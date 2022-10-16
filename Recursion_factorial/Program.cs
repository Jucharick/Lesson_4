double Factorial(int n) // метод, принимающий целое число и возвращающий целое число.
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;             // return мы должны указать явно, что метод должен вернуть значение
    else return n * Factorial(n-1);  // return мы должны указать явно, что метод должен вернуть значение
}
Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6
Console.WriteLine(Factorial(5));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // при 17! происходит переполнение типа данных int. Для решения переполнения данных можем изметить тип данных на double,  который принимает метод Factorial
}