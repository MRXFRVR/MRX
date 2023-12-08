using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        interface IShare
        {
            void Draw(int size);
        }
        class VerticalLine : IShare
        {
            public void Draw(int size)
            {
                Console.WriteLine("Вертикальная линия");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("*");
                }
            }
        }
        class HorizontalLine : IShare
        {
            public void Draw(int size)
            {
                Console.WriteLine("Горизонтальная линия");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("*");
                }
            }
        }
        class Sqare : IShare
        {
            public void Draw(int size)
            {

                Console.WriteLine("\nКвадрат");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
        }

        static void Main(string[] args)
        {
            VerticalLine verticalLine = new VerticalLine();
            verticalLine.Draw(5);
            HorizontalLine horizontalLine = new HorizontalLine();
            horizontalLine.Draw(5);
            Sqare sqare = new Sqare();
            sqare.Draw(10);
        }
    }
}