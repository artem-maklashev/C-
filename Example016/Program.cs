//Factorial

double Factorial(int n)
{
    if (n==0) return 1; 
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}