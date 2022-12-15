/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Задан массив с трехзначными числами");
string ? input = Console.ReadLine();
var result = input.Split(','); 
List<int> int_result = new();

for(int i = 0; i < result.Length; i++)
{
   int_result.Add(Convert.ToInt32(result[i]));
}
int num = 0;
for(int i = 0; i < int_result.Count; i++)
{
    if (int_result[i] % 2 == 0)
    {
        num++;
    }
}
Console.WriteLine(num);
