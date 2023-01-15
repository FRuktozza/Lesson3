class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точек");

        int[] coords = new int[6];

        for (int i = 0; i < coords.Length; i++)
        {
            coords[i] = Convert.ToInt32(Console.ReadLine());
        }

        double result = Distance(coords);
        Console.WriteLine(Math.Round(result, 2));
    }

    static double Distance(int[] coords)
    {
        double res = 0.0;
        for (int i = 0; i < coords.Length / 2; i++)
        {
            res += Math.Pow((coords[i] - coords[i + 3]), 2);
        }

        return Math.Sqrt(res);
    }
}
