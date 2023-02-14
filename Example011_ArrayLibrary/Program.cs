// set random array and finds an index of element equal to preset 'find' using method
void FillArray(int[] collection)
{
    int lng = collection.Length;
    int index = 0;
    while(index < lng)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int lng = col.Length;
    int index = 0;
    while(index < lng)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}

int IndexOf(int[] collection, int find)
{
    int sz = collection.Length;
    int index = 0;
    int position = -1; //-1 to signal if no preset values are found in the array

    while(index < sz)
    {
        if(collection[index] == find)
        {
            position = index + 1;
            break;
        }
        index++;
    }

    return position;
}

int find = 4;
int[] array = new int[10]; //0 array of a size 10


FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine(IndexOf(array, find));
            
