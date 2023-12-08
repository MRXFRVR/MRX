namespace c_sharp3
{
    internal class Program
    {
        class IsHappy
        {
            public int Input { get; set; }
            public bool IsHappy_Number()
            {
                var numbers = new HashSet<int>();
                while (Input > 1 && numbers.Add(Input))
                {
                    var sum = 0;
                    while (Input > 0)
                    {
                        sum += (Input % 10) * (Input % 10);
                        Input /= 10;
                    }
                    Input = sum;
                }
                return Input == 1;
            }
        }
        class Solution : IsHappy
        {
            public bool IsPalindrome()
            {
                string num = Input.ToString();
                int len = num.Length;
                for (int i = 0, j = len - 1; i < len; i++, j--)
                {
                    if (num[i] == num[j]) continue;
                    else return false;
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            IsHappy isHappy = new IsHappy();
            isHappy.Input = 19;
            isHappy.IsHappy_Number();
            Solution solution = new Solution();
            solution.Input = 8;
            solution.IsPalindrome();
        }
    }
}