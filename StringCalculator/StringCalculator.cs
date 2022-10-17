namespace StringCalculatorProject;

public static class StringCalculator
{
    public static float Sum(string values) {
        if (string.IsNullOrWhiteSpace(values)) return 0;
        var numbers = values.Split(",");
        if (numbers.Length == 2)
        {
            return Convert.ToSingle(numbers[0]) + Convert.ToSingle(numbers[1]);
        }
        return Convert.ToSingle(values);
    }
}