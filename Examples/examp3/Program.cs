/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*алгоритм, задать массив, провести его по циклу, начать отсчет где мин и макс будут изначально равны нулю.
Вычленить из массива минимальное и максимальное значение, вычленить из них разницу.
*/

Console.WriteLine("Задан массив вещественных чисел");
string ? input = Console.ReadLine();
var result = input.Split(','); 
List<int> int_result = new();

for(int i = 0; i < result.Length; i++)
{
   int_result.Add(Convert.ToInt32(result[i]));
}
int min = 100;
int max = 0;
for(int i = 0; i < result.Length; i++)
{
    if(int_result[i] > max) max = int_result[i];
    if(int_result[i]< min) min = int_result[i];
}
Console.WriteLine("max: " + max);
Console.WriteLine("min: " + min);
Console.WriteLine(max - min);
