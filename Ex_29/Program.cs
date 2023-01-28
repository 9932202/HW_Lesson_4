/*Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int numberOfArray){
    int[] result = new int[numberOfArray];
    for (int i = 0; i < numberOfArray; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

string GetStringArray(int[] array){
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $"{array[i]},";
    }
}

int[] array = CreateArray(8);
string stringArray = GetStringArray(array);
Console.WriteLine(stringArray);
