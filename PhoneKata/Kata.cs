namespace PhoneKata;

public static class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        int countryCode = numbers[0];
        
        if (countryCode < 1 || countryCode > 9999)
        {
            return "Invalid phone number.";
        }

        for (int digitIndex = 1; digitIndex < numbers.Length; digitIndex++)
        {
            int digit = numbers[digitIndex];
            if (digit > 9)
                return "Invalid phone number.";
        }
        
        return string.Format("+{0} ({1}{2}{3}) {4}{5}{6}-{7}{8}{9}{10}",
            numbers[0], numbers[1], numbers[2], numbers[3], numbers[4],
            numbers[5], numbers[6], numbers[7], numbers[8], numbers[9], numbers[10]);
    }
}