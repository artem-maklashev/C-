int count = 0;
double distance = 10000; 
int firstFrendSpeed = 1, secondFrendSpeed = 2, dogSpeed = 5, friend = 2;
double time_ = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time_ = distance / (firstFrendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time_ = distance / (secondFrendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFrendSpeed + secondFrendSpeed) * time_;
    count = count + 1;
}
Console.Write("Собака пробежит " + count +" раз!");
