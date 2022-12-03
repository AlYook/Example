// найти индекс числа N

int[] array = {7, 8, 13, 54, 13, 5, 93, 16};

int n = array.Length;
int find = 13;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}