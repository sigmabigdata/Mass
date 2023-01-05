int[] array = {22, 66, 65, 54, 58, 44, 26, 87, 65, 888};

int n = array.Length;
int find = 65;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
    index = index + 1;
}