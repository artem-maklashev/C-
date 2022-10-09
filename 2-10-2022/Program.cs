/* Console.WriteLine(" => Data type parsing: ");
bool b = bool.Parse("True");
Console.WriteLine("Value of b: {0} ", b); // Вывод значения b
double d = double.Parse("99.884 ");
Console.Write("Value of d: {0} ", d) ; // Вывод значения d
System.Console.WriteLine(d.GetType());
int i = int.Parse("8");
Console.WriteLine("Value of i: {0}", i); // Вывод значения i
char c = Char.Parse("w");
Console.WriteLine("Value of c: {0} ", c); // Вывод значения с
Console.WriteLine(); */


/* Console.WriteLine("=> Use Digit Separators:");
Console.Write ("Integer: ");
Console.WriteLine(123_456);
Console.Write("Long:");
Console.WriteLine(123_456_789L);
Console.Write("Float:");
Console.WriteLine(123_456.1234F);
Console.Write("Double:");
Console.WriteLine(123_456.12);
Console.Write("Decimal:");
Console.WriteLine(123_456.12M);
Console.WriteLine("Sixteen: {0}" , 0b0001_0000);
Console.WriteLine("Thirty Two: {0}",0b0010_0000); */



/* Console.WriteLine("=> Jagged multidimensional array.");
// Зубчатый многомерный массив (т.е. массив массивов).
// Здесь мы имеем массив из 5 разных массивов,
int[][] myJagArray = new int [5][] ;
// Создать зубчатый массив.
for (int i = 0; i < myJagArray.Length; i++)
myJagArray[i] = new int[i + 7];
// Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < myJagArray[i].Length; j++)
        Console.Write(myJagArray[i][j] +" ");
    Console.WriteLine();
}
Console.WriteLine();
 */

/* static void DisplayFancyMessage(ConsoleColor textColor,
ConsoleColor backgroundColor, string message)
{
// Сохранить старые цвета для их восстановления после вывода сообщения.
ConsoleColor oldTextColor = Console.ForegroundColor;
ConsoleColor oldbackgroundColor = Console.BackgroundColor;
// Установить новые цвета и вывести сообщение.
Console.ForegroundColor = textColor;
Console.BackgroundColor = backgroundColor;
Console.WriteLine(message);
// Восстановить предыдущие цвета.
Console.ForegroundColor = oldTextColor;
Console.BackgroundColor = oldbackgroundColor;
}

Console.WriteLine ("***** Fun with Methods *****");
DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
textColor: ConsoleColor.DarkRed,
backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
message: "Testing...",
textColor: ConsoleColor.DarkBlue);
Console.ReadLine(); */

//Кортежи
Console.WriteLine("=> Inferred Tuple Names1");
var foo = new {Propl = "first", Prop2 = "second"};
var bar = (foo.Propl, foo.Prop2);
Console.WriteLine($"{bar.Propl};{bar.Prop2}");

static (string first, string middle, string last) SplitNames(string fullName)
{
// Действия, необходимые для расщепления полного имени,
string[] arr =fullName.Split(" ");
/* do while (arr.Length == 3)
{
    Console.Write("Введены некоректные данные. Введите ФИО полностью: ");
    string? fullname= Console.ReadLine();  
   // string[] arr =fullName.Split(" ");
} */

    string first = arr[0];
    string middle = arr[1];
    string last =arr[2];
return (first, middle, last);

}

Console.Write("Введите имя: ");
string? fname= Console.ReadLine();
var (first, _, last) = SplitNames(fname);
Console.WriteLine(first);
Console.Write(last);