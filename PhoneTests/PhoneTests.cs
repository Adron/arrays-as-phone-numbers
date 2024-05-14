using PhoneKata;

namespace PhoneTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    [TestCase(new int[]{1,1,2,3,4,5,6,7,8,9,0}, ExpectedResult="+1 (123) 456-7890")]
    [TestCase(new int[]{1,1,1,1,1,1,1,1,1,1,1}, ExpectedResult="+1 (111) 111-1111")]
    [TestCase(new int[]{30,1,2,3,4,5,6,7,8,9,0}, ExpectedResult="+30 (123) 456-7890")] // Greece
    [TestCase(new int[]{31,1,2,3,4,5,6,7,8,9,0}, ExpectedResult="+31 (123) 456-7890")] // Netherlands
    [TestCase(new int[]{380,1,1,1,1,1,1,1,1,1,1}, ExpectedResult="+380 (111) 111-1111")] // Ukraine
    [TestCase(new int[]{45,15,2,3,4,93,6,7,8,9,0}, ExpectedResult="Invalid phone number.")] // Denmark
    [TestCase(new int[]{46,1,2,3,63,9,6,7,8,9,0}, ExpectedResult="Invalid phone number.")] // Sweden
    [TestCase(new int[]{47,1,55,3,4,9,6,7,8,9,0}, ExpectedResult="Invalid phone number.")] // Norway
    public static string FixedTest(int[] numbers)
    {
        return Kata.CreatePhoneNumber(numbers);
    }
    
}