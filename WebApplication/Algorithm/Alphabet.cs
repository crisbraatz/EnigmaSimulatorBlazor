using System.Collections.Generic;

namespace WebApplication.Algorithm
{
    public static class Alphabet
    {
        private static readonly IDictionary<int, string> Maps = new Dictionary<int, string>
        {
            {0, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"},
            {1, "ZABCDEFGHIJKLMNOPQRSTUVWXY"},
            {2, "YZABCDEFGHIJKLMNOPQRSTUVWX"},
            {3, "XYZABCDEFGHIJKLMNOPQRSTUVW"},
            {4, "WXYZABCDEFGHIJKLMNOPQRSTUV"},
            {5, "VWXYZABCDEFGHIJKLMNOPQRSTU"},
            {6, "UVWXYZABCDEFGHIJKLMNOPQRST"},
            {7, "TUVWXYZABCDEFGHIJKLMNOPQRS"},
            {8, "STUVWXYZABCDEFGHIJKLMNOPQR"},
            {9, "RSTUVWXYZABCDEFGHIJKLMNOPQ"},
            {10, "QRSTUVWXYZABCDEFGHIJKLMNOP"},
            {11, "PQRSTUVWXYZABCDEFGHIJKLMNO"},
            {12, "OPQRSTUVWXYZABCDEFGHIJKLMN"},
            {13, "NOPQRSTUVWXYZABCDEFGHIJKLM"},
            {14, "MNOPQRSTUVWXYZABCDEFGHIJKL"},
            {15, "LMNOPQRSTUVWXYZABCDEFGHIJK"},
            {16, "KLMNOPQRSTUVWXYZABCDEFGHIJ"},
            {17, "JKLMNOPQRSTUVWXYZABCDEFGHI"},
            {18, "IJKLMNOPQRSTUVWXYZABCDEFGH"},
            {19, "HIJKLMNOPQRSTUVWXYZABCDEFG"},
            {20, "GHIJKLMNOPQRSTUVWXYZABCDEF"},
            {21, "FGHIJKLMNOPQRSTUVWXYZABCDE"},
            {22, "EFGHIJKLMNOPQRSTUVWXYZABCD"},
            {23, "DEFGHIJKLMNOPQRSTUVWXYZABC"},
            {24, "CDEFGHIJKLMNOPQRSTUVWXYZAB"},
            {25, "BCDEFGHIJKLMNOPQRSTUVWXYZA"}
        };

        public static char GetCharBy(int index, int key = 0) => Maps[key][index];

        public static int GetIndexBy(char value, int key = 0) => Maps[key].IndexOf(value);
    }
}