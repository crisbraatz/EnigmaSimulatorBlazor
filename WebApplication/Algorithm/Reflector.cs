namespace WebApplication.Algorithm
{
    public static class Reflector
    {
        private static string MapA => "YRUHQSLPXNOZW";
        private static string MapB => "ABCDEFGIJKMTV";

        public static char Convert(char value) => MapA.Contains(value)
            ? MapB[MapA.IndexOf(value)]
            : MapA[MapB.IndexOf(value)];
    }
}