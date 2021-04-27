namespace WebApplication.Algorithm
{
    public sealed class RotorTwo : Rotor
    {
        protected override string RotorMap => "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        public override char SpinNextRotorCharForward => 'F';

        public RotorTwo(char startingChar) : base(startingChar)
        {
        }
    }
}