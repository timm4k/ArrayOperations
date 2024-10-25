class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array of nums(separated by spaces):");
        string input = Console.ReadLine();
        int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1.Find max element of array");
        Console.WriteLine("2.Calculate sum of elements before first positive element");

        int option;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out option) && (option == 1 || option == 2))
            {
                break;
            }
            Console.WriteLine("Select 1 or 2.");
        }

        switch (option)
        {
            case 1:
                int maxElement = FindMax(array);
                Console.WriteLine($"Max element of array is: {maxElement}");
                break;

            case 2:
                int sum = SumBeforePositive(array);
                Console.WriteLine($"Sum of elements before the first positive element is: {sum}");
                break;
        }
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static int SumBeforePositive(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            if (num > 0)
            {
                break;
            }
            sum += num;
        }
        return sum;
    }
}
