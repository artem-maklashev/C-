int count = 0;
double time_ = 0;;
Console.Write("Введите дистанцию ");
string distance_string = Console.ReadLine(); 
double distance = Convert.ToDouble(distance_string);
int firstFrendSpeed = 1, secondFrendSpeed = 2, dogSpeed = 5, friend = 2;


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
Console.Write("Собака пробежит " + count + " раз!");
