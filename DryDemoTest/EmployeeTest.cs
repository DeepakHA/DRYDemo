using FindingNemo;

namespace DryDemoTest
{
    public class EmployeeTest
    {
        [Theory]
        [InlineData("Deepak", "Holmes", "DeepHolm")]
        [InlineData("Deep", "Holm", "DeepHolm")]
        [InlineData("De", "Holm", "DeXXHolm")]
        [InlineData("Dee", "Hol", "DeeXHolX")]
        [InlineData("", "", "XXXXXXXX")]
        public void Test_GenerateEmployeeID(string firstName, string lastName, string expectedOutput)
        {
            string actualOutput = Employee.GenerateEmployeeID(firstName, lastName)[..expectedOutput.Length];
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
