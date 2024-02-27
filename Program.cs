string[] array = { "213", "ouhwr", "8iejfsa", "h5h", "nuoe1", "hey" };
string[] newArray = new string[array.Length];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[i] = array[i];
        index++;
    }    
    Console.Write($"{newArray[i]} ");
}
