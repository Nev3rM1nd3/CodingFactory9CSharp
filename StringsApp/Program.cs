namespace StringsApp
{
    /// <summary>
    /// String are immutable and are interned by the .NET runtime,
    /// meaning that identical string literals are stored only once in memory
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1 = "hello";
            string? str2 = "hello";
            string? str3 = new string("hello");

            Console.WriteLine(str1[0]);     //'h' - indexing

            //String equality
            Console.WriteLine(str1 == str2);        //True (value equality)
            Console.WriteLine(str1.Equals(str2));   //True (value equality)

            //Reference equality
            Console.WriteLine(object.ReferenceEquals(str1, str2));  //True (interned string)
            Console.WriteLine(object.ReferenceEquals(str1, str3));  //False (different objects)

            //Compare strings
            Console.WriteLine(string.Compare(str1, str3));  //0 (equal)
            Console.WriteLine(str1.CompareTo(str2));        //0 (equal)

            //concat
            string? result = str1 + " " + str2;                 //Concatenation
            string? result2 = string.Concat(str1, " ", str2);   //Concatenation using a method

            //toUpper, toLower
            string? upper = str1.ToUpper();     //"HELLO"
            string? lower = str2.ToLower();     //"hello"

            Console.WriteLine(str1.ToUpper() == str2.ToLower());    //Normalized comparison (case-

            //Substring
            string? sub = str1.Substring(0, 2); //"he" starIndex, length
            string? part = str1.Substring(2);   //"llo" starIndex to end of string

            //indexOf, lastIndeOf
            int index = str1.IndexOf('l');          //2
            int lastIndex = str1.LastIndexOf("he"); //0

            //trim
            string? padded = "        hello    ";
            string? trimmed = padded.Trim();        //"hello"
        }
    }
}
