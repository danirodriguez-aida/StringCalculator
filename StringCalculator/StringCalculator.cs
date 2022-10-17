namespace StringCalculatorProject;

public static class StringCalculator
{
    public static float Sum(string values)
    {
        if (string.IsNullOrWhiteSpace(values)) return 0;
        return Convert.ToSingle(values);
    }
}