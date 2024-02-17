/*
 * Scrieti un program care va calcula media aritmetica 
 * a trei numere citite de la tastatura
*/

Console.WriteLine("Introduceti valoarea pentru primului numar");
int numarA = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru al doilea numar");
int numarB = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru al treilea numar");
int numarC = int.Parse(Console.ReadLine());

int mediaAritmetica = (numarA + numarB + numarC) / 3;

Console.WriteLine("Media aritmetica a celor trei numere introduse este:" + mediaAritmetica);