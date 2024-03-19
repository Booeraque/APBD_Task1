// Task 2

// Console.WriteLine("Hello, World!");

// Task 3

class Program
{
    private static void Main(string[] args)
    {
        int[] arr = [ 1, 2, 3, 4, 5, 666, 7, 8, 288 ];
        var arrAvg = CalculateAvg(arr);
        Console.WriteLine("The average for the array: [" + string.Join(", ", arr) + "]\nIs a number: " + arrAvg);
    }

    private static int CalculateAvg(int[] myArr)
    {
        var maxValue = myArr[0];
        foreach (var num in myArr)
        {
            if (maxValue <= num) maxValue = num;
        }

        return maxValue;
    }
}