/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Задан одномерный массив со случайными числами");
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
    if (Math.Abs(int_result[i]) % 2 == 1)
    {
        num++;
    }
}
Console.WriteLine(num);