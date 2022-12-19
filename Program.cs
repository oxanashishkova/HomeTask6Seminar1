// №6 На вход принимаем число, на выходе выдаем, является ли число четным


Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number %2 ==0)
    Console.WriteLine("Even number");
else
    Console.WriteLine("Odd number");