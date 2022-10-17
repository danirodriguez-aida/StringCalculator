namespace StringCalculatorProject;

public static class StringCalculator
{
    public static int Add(string values) {
        if (string.IsNullOrWhiteSpace(values)) return 0;
        var numbers = values.Split(",");
        if (numbers.Length == 2)
        {
            return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
        }
        return Convert.ToInt32(values);
    }
}