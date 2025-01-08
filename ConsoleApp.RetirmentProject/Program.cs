//Declaration of variables
string name = string.Empty;
int age = 0;
int retirmentYear = 65;
int retirmentRemainingYears = 0;
Console.WriteLine("Please enter your name");
name = Console.ReadLine();
Console.WriteLine("Please enter your age");
age =Convert.ToInt32( Console.ReadLine());
retirmentRemainingYears = retirmentYear - age;
Console.WriteLine($"your name is {name}");
Console.WriteLine($"you have {retirmentRemainingYears} to retire");




