namespace _06_Null
{
    #nullable enable
    class Guy
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }
        public override string ToString() => $"a {Age}-year-old named {Name}";
        public Guy(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Guy guy;
            guy = new Guy(25, "Alex");
            Console.WriteLine("guy.Name is {0} letters long", guy.Name.Length);
        }
    }
}
