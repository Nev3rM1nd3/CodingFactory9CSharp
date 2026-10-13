Skip to content
a8anassis
CodingFactory9CSharp
Repository navigation
Code
Issues
Pull requests
Actions
Projects
Security
Insights
Files
Go to file
t
PalindromeStr content loaded
ArgsDemo
ArgsDemo.csproj
Program.cs
Program.exe
ArrayApp
ArrayApp.csproj
Program.cs
CitiesFor
DoWhileApp
ExpressionBodyMethods
ExtractCapitals
ExtractCapitals.csproj
Program.cs
FomratExceptionApp
HelloWorld
IfCases
KilometersApp
LinqArrays
MethodChallenges
MethodsApp
MoreMethods
NullableApp
NumberRead
PalindromeStr
PalindromeStr.csproj
Program.cs
PrintingApp
ProductsVat
RegExApp
Program.cs
RegExApp.csproj
StringBuilderApp
StringsApp
SwapApp
SwitchApp
Traveling
WhileApp
.gitattributes
.gitignore
CodingFactory9CSharp.slnx
README.md
CodingFactory9CSharp/PalindromeStr
/Program.cs
a8anassis
a8anassis
chore: add palindrome app for strings manipulation
bcd8801
 · 
yesterday

Code

Blame
22 lines (19 loc) · 467 Bytes

namespace PalindromeStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool IsPalindrome(string? str)
        {
            if (str == null) return false;

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j]) return false;
            }

            return true;
        }
    }
}
PalindromeStr content loaded