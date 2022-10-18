namespace StringCalculatorProject;

public static class StringCalculator
{
    public static int Add(string values) {
        if (string.IsNullOrWhiteSpace(values)) return 0;
        var numbers = values.Split(",");
        return numbers.Sum(Convert.ToInt32);
    }
}