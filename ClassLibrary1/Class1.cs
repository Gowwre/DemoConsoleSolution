namespace ClassLibrary1;
using static System.Console;
public class Class1
{
    private static int[] numbers = { 1, 2, 3, 4, 5 };

    static ref int FindNumber(int target)
    {
        bool flag = true;
        ref int value = ref numbers[0];
        for (int i = 0; i < numbers.Length && flag == true; i++)
        {
            if (numbers[i] == target)
            {
                value = ref numbers[i];
                flag = false;
            }
        }

        return ref value;
    }
    public static void Main()
    {
        Console.WriteLine("Original Sequence:");
        Console.WriteLine(string.Join(" ",numbers));
        ref int value = ref FindNumber(3);
        value += 4;
        Console.WriteLine("New Sequence:");
        Console.WriteLine(String.Join(" ", numbers));
        

        /*short age;
        double salary = 455_888_888;
        var helloWorld = "Lol";
        WriteLine($@"{helloWorld}, this is my {salary}");
        WriteLine("{0}, this is my {1}",helloWorld,salary);
        
        int num1 = 1;
        int num2 = 2;
        Swap(ref num1, ref num2);
        WriteLine($"Num1 is {num1}, Num2 is :{num2}");

        int sum;
        Sum(out sum,1,5,8,6,4,8,9);
        WriteLine($"The sum of n integers is {sum}");
        var (myString, myNum) = ("Hello", 44);
        Console.WriteLine(myNum);
        Console.WriteLine(myString);*/
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public static int Add(int num1, int num2,int num3)
    {
        return Add(Add(num1, num2), num3);
    }

    public static void Swap(ref int num1, ref int num2)
    {
        (num1, num2) = (num2, num1);
    }

    public static void Sum(out int sum, params int[] nums)
    {
        var total = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            total += nums[i];
        }

        sum = total;
    }
}