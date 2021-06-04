namespace RecursiveSum
{
    public static class ArrayRecursiveExtensions
    {
        public static T Sum<T>(this T[] values) where T : struct
        {
            if (values.Length == 0)
            {
                return (dynamic)0;
            }

            return ((dynamic)values[0]) + Sum(values[1..]);
        }
    }
}
