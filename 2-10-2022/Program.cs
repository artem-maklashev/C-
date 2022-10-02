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



Console.WriteLine("=> Jagged multidimensional array.");
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








