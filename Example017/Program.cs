// Числа Фибоначчи
// f(1) =1;
// f(2) = 1;
//f(n)=f(n-1)+f(n-2)

double Fibonacci(int n)
{
    if (n == -1) return 1;
    if (n == 0) return 0;
    else return (Fibonacci(n+2) - Fibonacci(n +1));
}

for (int i = 0; i > -11; i=i-1)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}