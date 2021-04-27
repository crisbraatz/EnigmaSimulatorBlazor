namespace WebApplication.Algorithm
{
    public class Enigma
    {
        public Plugboard Plugboard { get; set; }
        public Rotor FirstRotor { get; set; }
        public Rotor SecondRotor { get; set; }
        public Rotor ThirdRotor { get; set; }
        public string EncryptedMessage { get; set; }
        public string OriginalMessage { get; set; }

        public void Encrypt(char character)
        {
            OriginalMessage += character;

            var currentChar = Plugboard.Convert(character, true);

            Spin();

            currentChar = ThirdRotor.Convert(currentChar, true);
            currentChar = SecondRotor.Convert(currentChar, true);
            currentChar = FirstRotor.Convert(currentChar, true);

            currentChar = Reflector.Convert(currentChar);

            currentChar = FirstRotor.Convert(currentChar, false);
            currentChar = SecondRotor.Convert(currentChar, false);
            currentChar = ThirdRotor.Convert(currentChar, false);

            currentChar = Plugboard.Convert(currentChar, false);

            EncryptedMessage += currentChar;
        }

        public void Undo()
        {
            if (OriginalMessage.Length <= 0)
                return;

            EncryptedMessage = EncryptedMessage[..^1];
            OriginalMessage = OriginalMessage[..^1];

            ThirdRotor.SpinBackward();

            if (ThirdRotor.CurrentChar == ThirdRotor.SpinNextRotorCharBackward)
                SecondRotor.SpinBackward();

            if (SecondRotor.CurrentChar == SecondRotor.SpinNextRotorCharBackward)
                FirstRotor.SpinBackward();
        }

        private void Spin()
        {
            ThirdRotor.SpinForward();

            if (ThirdRotor.CurrentChar == ThirdRotor.SpinNextRotorCharForward)
                SecondRotor.SpinForward();

            if (SecondRotor.CurrentChar == SecondRotor.SpinNextRotorCharForward)
                FirstRotor.SpinForward();
        }
    }
}