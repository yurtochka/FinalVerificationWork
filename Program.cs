// Search in the array all value equal to three symbol or less
using static System.Console;
Clear();


WriteLine("Enter count value in the array: ");
int x = Convert.ToInt32(ReadLine());

string[] arr = FormArray(x);
PrintArray(arr);

string[] FormArray(int a) 
{
    string[] array = new string[a];
    string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        string str = "";
        int StrArrSize = random.Next(1, 5);
        for (int j = 0; j < StrArrSize; j++)
        {
            int variable = random.Next(ABC.Length);
            str = str + ABC[variable];
        }
        array[i] = str;
    }
    return array;
}



void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}