int [] array = { 11, 12, 34, 4, 18, 55, 67, 27, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index = index + 1;
}
