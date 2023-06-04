string[] array = new string[10] { "Austria", "AUT", "Bulgaria","BGR" , "Brazil", "BRA","Vietnam" , "VNM","Greenland" , "GRL" };

string [] FindShortStrings(string[] array)
{
    int counter = 0;
    for(int i = 0; i<array.Length;i++)
        if(array[i].Length<4)counter++;
    if(counter==0)
    return new string[1]{"в массиве нет строк из 3х символов и менее"};
    
    string[]resultArray = new string[counter];
    counter = 0;
    for(int i = 0; i<array.Length;i++)
        if(array[i].Length<4)
        {
            resultArray[counter]=array[i];
            counter++;
        }
    return resultArray;
}

void PrintArray(string[] array)
{
    for(int i = 0; i<array.Length;i++)
        Console.Write($"{array[i]}, ");
}

PrintArray(FindShortStrings(array));