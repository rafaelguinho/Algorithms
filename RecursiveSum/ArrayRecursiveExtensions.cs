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

        public static T Max<T>(this T[] values) where T : struct
        {
            dynamic subMax = values[0];

            if (values.Length == 2)
            {
                return (dynamic)values[0] > values[1] ? values[0] : values[1];
            }

            subMax = Max(values[1..]);

            return (dynamic)values[0] > subMax ? values[0] : subMax;
        }
    }
}
