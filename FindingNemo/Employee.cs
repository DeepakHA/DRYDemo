namespace FindingNemo
{
    public static class Employee
    {
        public static string GenerateEmployeeID(string firstName, string lastName)
        {
            return $@"{firstName.GetNameSubstring(4)}{lastName.GetNameSubstring(4)}{DateTime.Now.Millisecond}";
        }

        private static string GetNameSubstring(this string name, int numberOfChars)
        {
            string output = name;

            if(name.Length > numberOfChars)
            {
                output = name[..numberOfChars];
            }
            else
            {
                while(output.Length < numberOfChars)
                {
                    output += "X";
                }
            }

            return output;
        }
    }
}
