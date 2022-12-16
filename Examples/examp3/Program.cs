/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.WriteLine("Задан массив вещественных чисел");
string ? input = Console.ReadLine();
var result = input.Split(','); 
if (result.Length == 1)
{
    Console.WriteLine( "Массив не валидный");
    Environment.Exit(1);
}
List<int> int_result = new();

for(int i = 0; i < result.Length; i++)
{
   int_result.Add(Convert.ToInt32(result[i]));
}
int min = int_result[0];
int max = int_result[0];
for(int i = 1; i < result.Length; i++)
{
    if(int_result[i] > max) 
    {
        max = int_result[i];
    }
    else if(int_result[i]< min)
    {
        min = int_result[i];
    }
}
Console.WriteLine("max: " + max);
Console.WriteLine("min: " + min);
Console.WriteLine(max - min);

