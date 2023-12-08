using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class Human
        {
            public Human(string name, int age, string gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }
            public string Name { get; }
            public int Age { get; }
            public string Gender { get; }
        }
        class Worker : Human
        {
            public string Post { get; }

            public Worker(string name, int age, string gender, string post) : base(name, age, gender)
            {
                Post = post;
            }

        }

        static void Main(string[] args)
        {
            Human human = new Human("Valera Zaharov", 23, "M");
            Worker worker = new Worker("Valera Zaharov", 23, "M", "manager");
        }
    }
}