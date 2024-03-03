using System;

class Search
{
    static void Main(string[] args)
    {
        int[] testIntArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("What number do you want to find in the list?: ");
        int num = int.Parse(Console.ReadLine());

        int beg = 0;
        int end = testIntArray.Length - 1;

        if (end >= 0)
        {
            while (beg <= end)
            {
                int mid = (beg + end) / 2;

                if (testIntArray[mid] == num)
                {
                    Console.WriteLine("Your number {0} was found at index {1}", num, mid);
                    return;
                }
                else if (testIntArray[mid] < num)
                {
                    beg = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            Console.WriteLine("Your number {0} was not found in the list", num);
        }
        else
        {
            Console.WriteLine("The list is empty");
        }
    }
}
