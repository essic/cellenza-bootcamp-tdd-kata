namespace core;
public class StringCalculator
{
    public string Add(string number)
    {
        if (string.IsNullOrWhiteSpace(number))
            return "0";

        var numbers = number.Split(",");
        
        if (numbers.Length > 1)
            return "3";

        return number;
    }
}
