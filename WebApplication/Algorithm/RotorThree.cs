namespace WebApplication.Algorithm
{
    public sealed class RotorThree : Rotor
    {
        protected override string RotorMap => "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        public override char SpinNextRotorCharForward => 'W';

        public RotorThree(char startingChar) : base(startingChar)
        {
        }
    }
}