class ClassesAndObjects
{
    private List<string> _history = new List<string>();

    public double Add(double a, double b)
    {
        double result = a + b;
        _history.Add($"{a} + {b} = {result}");
        return result;
    }

    public void ShowHistory()
    {
        foreach (string item in _history)
        {
            Console.WriteLine(item);
        }
    }

    public static void Main(string[] args)
    {
        ClassesAndObjects calculator = new ClassesAndObjects();
        double result = calculator.Add(5, 3);
        Console.WriteLine($"Result: {result}");
        calculator.ShowHistory();
    }
}
