// Intro of the methods (functions)
//              0  1  2  3  4  5  6  6  8
int[] array = {11,21,31,41,15,61,17,18,19};

 int Max (int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;

    return result;
 }   

// int Max1 = Max(a1, b1, c1);
// int Max2 = Max(a2, b2, c2);
// int Max3 = Max(a3, b3, c3);

//Console.WriteLine(Max(Max1, Max2, Max3));
Console.WriteLine(Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]))
    );