﻿//Вариант 1
/* void Method1()
{
    Console.WriteLine("Автор...");
} 

Method1(); */

//Вариант 2
/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Автор...");
 */
/* void Method21(string msg, int count)
{
    int i = 0;
    while (i <count)
    {
       Console.WriteLine(msg);
       i++; 
    }
}
Method21(count: 4, msg: "Автор..."); */

//Вариант 3. В случае возвращения результата из метода необходимо указывать тип возвращаемых данных

/* int Method3()
{
    return DateTime.Now.Year;
}
int  year = Method3();
Console.WriteLine(year); */

//Вариант 4

/* string Method(int count, string text)
{
    //int i = 0;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    /* while (i < count)
    {
        result = result + text;
        i++;
    } */
    //return result;
//}

/* string res = Method (10, "asdf");
Console.WriteLine(res);
 */
string Method(int count, string text)
{
    //int i = 0;
    string result = string.Empty;
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j < 10; j++)
        {
            Console.WriteLine($"{i}*{j} = {i*j}");
        }
        Console.WriteLine();
    }
    return result;
}

string res = Method (10, "asdf");
Console.WriteLine(res);


