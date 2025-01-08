//Declaration of variables
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirmentYear = 65;
int retirmentRemainingYears = 0;
Console.WriteLine("Please enter your firstname");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your lastname");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age =Convert.ToInt32( Console.ReadLine());
retirmentRemainingYears = retirmentYear - age;
Console.WriteLine($"your fullname is : {firstName} {lastName}");
Console.WriteLine($"you have {retirmentRemainingYears} to retire");




