namespace HiraganaKatakana2.Data
{
    public static class ArrayExtension
    {
        private static readonly Random rng = new();

        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
        }
    }
}
