namespace WebApplication.Algorithm
{
    public sealed class RotorOne : Rotor
    {
        protected override string RotorMap => "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        public override char SpinNextRotorCharForward => 'R';

        public RotorOne(char startingChar) : base(startingChar)
        {
        }
    }
}