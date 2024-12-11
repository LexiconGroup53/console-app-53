namespace console_app.Test;
using console_app;

public class UnitTest1
{
    // 45°F, 45°C
    // case of 45°F
    // case 45°34
    // case jjfkf
    // case null
    // case ""
    // case 7985399457937589°F
    // case -3000°C
    
    [Theory]
    [InlineData("45°Y", false)]
    [InlineData("45°C", true)]
    [InlineData("23°C", true)]
    [InlineData("23°F", true)]
    [InlineData("jjfkf", false)]
    public void Test1(string text, bool expected)
    {
       bool actual = Temperature.Intitialize(text,  out Temperature temperature);
       
       Assert.Equal(expected, actual);
    }
}