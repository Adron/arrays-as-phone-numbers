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

    public static int[] EncodePhone(string phoneNumber)
    {
        string cleanedNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

        if (cleanedNumber.Length < 11 || cleanedNumber.Length > 13)
        {
            throw new ArgumentException("Invalid phone number format.");
        }

        // Identify the country code length (1 to 3 digits)
        int countryCodeLength = cleanedNumber.Length - 10;

        // Create an array for the result
        int[] numbers = new int[11];

        // Parse the country code and store it as a single element
        numbers[0] = int.Parse(cleanedNumber.Substring(0, countryCodeLength));

        // Parse the remaining phone number digits
        for (int i = 0; i < 10; i++)
        {
            numbers[i + 1] = int.Parse(cleanedNumber[countryCodeLength + i].ToString());
        }

        return numbers;
    }
}