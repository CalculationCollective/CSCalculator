Console.Write("Enter the first number: ");
var num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Choose between:\n1) Addition\n2) Subtraction\n3) Multiplication\n4) Division");
var calculationType = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
var num2 = double.Parse(Console.ReadLine());

switch (calculationType)
{
    case 1:
        Console.Write(num1 + num2);
        break;
    case 2:
        Console.Write(num1 - num2);
        break;
    case 3:
        Console.Write(num1 * num2);
        break;
    case 4:
        Console.Write(num1 / num2);
        break;
    default:
        Console.Write($"{calculationType} is not a valid function");
        break;
}