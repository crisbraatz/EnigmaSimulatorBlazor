namespace WebApplication.Algorithm
{
    public class Plugboard
    {
        private static string MapA => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string MapB { get; }

        public Plugboard(string mapB)
        {
            MapB = mapB;
        }

        public char Convert(char value, bool isGoing) => isGoing
            ? MapB[MapA.IndexOf(value)]
            : MapA[MapB.IndexOf(value)];
    }
}