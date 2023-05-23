Console.Clear();
int Max(int arg1, int arg2, int arg3, int arg4)
{
    int result = arg1;
    if (arg1>result) result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    if (arg4>result) result = arg4;
    return result;
}
//             0 1 2 3
int[] array = {1,7,9,0};

int max = Max(
    Max(array[1], array[7], array[9], array[0]));
Console.WriteLine(max);
