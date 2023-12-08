using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        interface IFilter
        {
            string Execute(string textLine);
        }
        class DigitFilter : IFilter
        {
            public string Execute(string textLine)
            {
                List<char> textLine_copy = new List<char>();
                char[] numbers = {'А', 'Б', 'В', 'Г', 'Д',
                                    'Е', 'Ё', 'Ж', 'З', 'И',
                                    'Й', 'К', 'Л', 'М', 'Н',
                                    'О', 'П', 'Р', 'С', 'Т',
                                    'У', 'Ф', 'Х', 'Ц', 'Ч',
                                    'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                                    'Э', 'Ю', 'Я','а', 'б', 'в', 'г', 'д',
                                    'е', 'ё', 'ж', 'з', 'и',
                                    'й', 'к', 'л', 'м', 'н',
                                    'о', 'п', 'р', 'с', 'т',
                                    'у', 'ф', 'х', 'ц', 'ч',
                                    'ш', 'щ', 'ъ', 'ы', 'ь',
                                    'э', 'ю', 'я'};
                for (int i = 0; i < textLine.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (textLine[i] == numbers[j])
                        {

                            textLine_copy.Add(numbers[j]);
                        }
                    }
                }
                textLine_copy.ForEach(Console.Write);
                Console.WriteLine();
                return textLine_copy.ToString();
            }
        }

        class LetterFilter : IFilter
        {
            public string Execute(string textLine)
            {
                List<char> textLine_copy = new List<char>();
                char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                for (int i = 0; i < textLine.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (textLine[i] == numbers[j])
                        {
                            textLine_copy.Add(numbers[j]);
                        }
                    }
                }
                textLine_copy.ForEach(Console.Write);
                Console.WriteLine();
                return textLine_copy.ToString();
            }
        }
        static void Main(string[] args)
        {
            DigitFilter filter = new DigitFilter();
            filter.Execute("П22222222");
            LetterFilter letterFilter = new LetterFilter();
            letterFilter.Execute("П2222");
        }
    }
}