//1
int[] array5 = { 1, 2, 3, 4, 5 };
foreach (int i in array5)
{
    Console.WriteLine(i);
}

//2
string[] arrayS = { "Leche", "Azúcar", "Huevos", "Agua", "Brocoli", "Carne" };
for (int i = 0; i < arrayS.Length; i += 2)
{
    Console.WriteLine(arrayS[i]);
}

//3
int[] arrayEnt = { 1, 2, 3, 4, 5, 10 };
Console.WriteLine(arrayEnt.Max()); //Método de array para conseguir el valor máximo dentro del array

//4
int[] arrayE = { 1, 2, 3, 4, 5 };
Console.WriteLine(arrayE.Sum()); //Método de array para sumar los elementos

//5
int[] arraySmall = { 1, 2, 3, 4, 5 };
Console.WriteLine(arraySmall.Min()); //Método de array para conseguir el valor mínimo

//6
int[] arrayMult = { 1, 2, 3, 4, 5 };
Console.WriteLine("Ingrese un número:");
string? num = Console.ReadLine();
int x = int.Parse(num);
for (int i = 0; i < arrayMult.Length; i++)
{
    Console.Write((arrayMult[i] * x) + ", ");
}
Console.WriteLine("");

//7
string[] things = { "hoja", "girasol", "tulipan", "escarabajo" };
Array.Reverse(things);
foreach (var i in things) 
{
    Console.WriteLine(i);
}

//8
string[] findIt = { "trueno", "nube", "lluvia", "sol" };
Console.WriteLine("Ingrese una palabra:");
string? given = Console.ReadLine();
Console.WriteLine(Array.IndexOf(findIt, given));

//9
string[] eliminate = { "trueno", "nube", "lluvia", "sol", "tormenta" };
Console.WriteLine("Ingrese una palabra para eliminar:");
string? elimination = Console.ReadLine();
int ind = Array.IndexOf(eliminate, elimination);
Array.Clear(eliminate, ind, 1);
foreach (var i in eliminate)
{
    Console.WriteLine(i);
}

//10
int[] adding = new int[5];
for  (int i = 0;i < adding.Length;i++)
{
    Console.WriteLine("Ingrese un número para agregar:");
    string? add = Console.ReadLine();
    int adder = int.Parse(add);
    adding[i] = adder;
}
Array.ForEach(adding, i => Console.Write(i + ", "));