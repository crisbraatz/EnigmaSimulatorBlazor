namespace WebApplication.Algorithm
{
    public abstract class Rotor
    {
        public char CurrentChar { get; private set; }
        protected abstract string RotorMap { get; }
        public abstract char SpinNextRotorCharForward { get; }
        public char SpinNextRotorCharBackward => (char) (SpinNextRotorCharForward - 1);

        protected Rotor(char startingChar)
        {
            CurrentChar = startingChar;
        }

        public char Convert(char value, bool isGoing)
        {
            int index;
            char result;

            if (isGoing)
            {
                index = Alphabet.GetIndexBy(value, CurrentChar - 65);
                result = RotorMap[index];
                index = Alphabet.GetIndexBy(result);
                result = Alphabet.GetCharBy(index, CurrentChar - 65);
            }
            else
            {
                index = Alphabet.GetIndexBy(value, CurrentChar - 65);
                result = Alphabet.GetCharBy(index);
                index = RotorMap.IndexOf(result);
                result = Alphabet.GetCharBy(index, CurrentChar - 65);
            }

            return result;
        }

        public void SpinForward() => CurrentChar = (char) (CurrentChar + 1 > 90 ? 65 : CurrentChar + 1);

        public void SpinBackward() => CurrentChar = (char) (CurrentChar - 1 < 65 ? 90 : CurrentChar - 1);
    }
}