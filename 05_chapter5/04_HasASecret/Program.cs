using System.Reflection;

namespace _04_HasASecret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HasASecret keeper = new HasASecret();
            // При снятии комментария с команды Console.WriteLine происходит ошибка компиляции:
            // поле 'HasASecret.secret' недоступно из-за его уровня защиты.
            // Console.WriteLine(keeper.secret);
            // Но для получения значения поля secret все еще можно воспользоваться отражением
            FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            // Этот цикл foreach выводит на консоль строку "xyzzy"
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(keeper));
            }
        }
    }
    class HasASecret
    {
        // Класс содержит поле secret. Обеспечит ли ключевое слово private его защиту?
        private string secret = "xyzzy";
    }
}
