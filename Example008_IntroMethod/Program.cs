// Intro of the methods (functions)
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

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
Console.WriteLine(Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)));