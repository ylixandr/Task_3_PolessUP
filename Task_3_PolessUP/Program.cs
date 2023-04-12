//Учитывая отсортированный массив различных целых чисел и целевое значение, вернуть индекс, если цель найдена. Если нет, верните индекс туда, где он был бы, если бы он был вставлен по порядку. 
//Ввод: числа = [1, 3, 5, 6], цель = 5
//Вывод: 2
using System.Formats.Asn1;

int[] array = { 1, 3, 5, 6 };
int target = 2;
bool res = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == target)
    {
        res = true;
        Console.WriteLine(i);
    }
    
    
}

if (res == false)
{
    for (int i = 0;i < array.Length; i++)
    {
        if (target > array[i] && target< array[i+1] && i+1<array.Length)
        {
            Console.WriteLine(i+1);
        }
    }
}