class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsValidNumber(num))
        {
            if (IsPalindrome(num))
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
        else
        {
            Console.WriteLine("некорректный ввод");
        }
    }

    static bool IsPalindrome(int num) 
    {
        return (num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10);
    }

    static bool IsValidNumber(int num)
    {
        return (num >= 10000) && (num < 100000);
    }
}