// Task 2

// Console.WriteLine("Hello, World!");

// Task 3

class Program
{
    private static void Main(string[] args)
    {
        int[] arr = [ 1, 2, 3, 4, 5, 6, 7, 8, 288 ];
        var arrAvg = CalculateAvg(arr);
        Console.WriteLine("The average for the array: [" + string.Join(", ", arr) + "]\nIs a number: " + arrAvg);
    }

    private static int CalculateAvg(int[] arr)
    {
        var tCount = 0;
        var totalSum = 0;
        foreach (var num in arr)
        {
            totalSum += num;
            tCount++;
        }
        return totalSum / tCount;
    }
}