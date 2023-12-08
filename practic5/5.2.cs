using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        interface IHello
        {
            void SayHello();
        }
        class Russian : IHello
        {
            public void SayHello()
            {
                Console.WriteLine("Привет");
            }
        }
        class English : IHello
        {
            public void SayHello()
            {
                Console.WriteLine("Hello");
            }
        }
        class German : IHello
        {
            public void SayHello()
            {
                Console.WriteLine("Hallo");
            }
        }
        class Serbian : IHello
        {
            public void SayHello()
            {
                Console.WriteLine("Здраво");
            }
        }
        static void Main(string[] args)
        {
            List<IHello> mylang = new List<IHello>();

            mylang.Add(new Russian());
            mylang.Add(new English());
            mylang.Add(new German());
            mylang.Add(new Serbian());

            foreach (IHello hello in mylang)
            {
                hello.SayHello();
            }

            Console.ReadKey(true);
        }
    }
}