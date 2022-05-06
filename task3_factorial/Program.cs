// Вычисляем факториал с помощью рекурсии
Console.Clear();
/*double factorial(int n)
{
if (n == 1) return 1;
else return n * factorial(n - 1);
}
for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"{i}! = {factorial(i)}");
}*/
int Fibonacci(int n)
{
    if(n == 1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 42; i++)
{
    Console.WriteLine(Fibonacci(i));
} 