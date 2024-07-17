namespace _13_Lambda_Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var array = new[] { 1, 2, 3, 4 };
            //var result = from i in array select i * 2;

            //var array = new[] { 1, 2, 3, 4 };
            //var result = array.Select(i => i * 2);

            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            //IEnumerable<int> result =
            //                        from v in values
            //                        where v < 37
            //                        orderby -v
            //                        select v;
            var result = values.Where(x => x < 37).OrderBy(x => -x);

            foreach (var i in result) Console.WriteLine(i);
        }
    }
}
