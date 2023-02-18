//Task: "Search in the array all value equal to three symbol or less"
using static System.Console;
Clear();


WriteLine("Enter count value in the array: ");
int x = Convert.ToInt32(ReadLine());
WriteLine();

string[] arr = FormArray(x);

//Search for a value equal to three symbol or less
string[] ArrRes = new string[x];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4)
        ArrRes[i] = arr[i];
}

PrintArray(arr); //output the all generated array
Write(" --> ");
PrintArray(ArrRes); //printing a sorted array


// Forming a string array 
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


// Print formed array 
void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            if (array[i] != null) Write($" '{array[i]}']"); else Write($"]");
        }
        else
        {
            if (array[i] != null)
                Write($" '{array[i]}'");
            else
                Write($"");
        }
    }
    WriteLine();
}