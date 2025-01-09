// See https://aka.ms/new-console-template for more information
string op;
int result=0;
Console.WriteLine("Welcome To Calculator App");
Console.WriteLine("Enter Your FirstNumber");
int firstNum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your SecondNumber");
int SecondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your operator:+/-/*//");
op = Console.ReadLine();
switch (op)
{
    case "+":
        result = firstNum + SecondNum;
        break;
    case "-":
        result = firstNum - SecondNum;
        break;
    case "*":
        result = firstNum * SecondNum;
        break;
    case "/":
        result = firstNum / SecondNum;
        break;
    default:
        Console.WriteLine("Enter valid Operator");
        break;

}
Console.WriteLine($"The Result is {result}");



