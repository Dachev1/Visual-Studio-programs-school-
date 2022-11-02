// Sorting;
class Program
{
    static void Input(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("a[" + i + "]= ");
            a[i] = double.Parse(Console.ReadLine());
        }
    }
    static void SortMethod(double[] a)
    {
        Array.Sort(a);
    }
    static void Output(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
            Console.WriteLine("a[" + i + "]= " + a[i]);
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter number of array elements: ");
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n];
        Input(a);
        SortMethod(a);
        Output(a);
    }
}

