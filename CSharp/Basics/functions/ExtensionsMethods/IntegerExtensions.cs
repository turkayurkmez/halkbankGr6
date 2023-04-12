namespace ExtensionsMethods
{
    public static class IntegerExtensions
    {
        public static int GetSquare(this int value)
        {
            return (int)Math.Pow(value, 2);
        }

        public static char NextChar(this Random random, bool isLower = true)
        {
            return isLower ? (char)random.Next(97, 123) : (char)random.Next(65, 91);
        }
        public static string NextString(this Random random, List<string> wordList)
        {

            return wordList[random.Next(wordList.Count)];
        }

        public static string NextString(this Random random, int length)
        {
            string generated = string.Empty;
            for (int i = 0; i < length; i++)
            {
                generated += random.NextChar();
            }

            return generated;
        }
    }


}
