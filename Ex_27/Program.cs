/*Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetUserValue(string message){
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetMultipleResult(int number){
int res = 0;
while(number > 0){
    res = res + number % 10;
    number = number / 10;
}
return res;
}

void ShowResult(string msg, int result){
    Console.Write(msg);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(result);
    Console.ResetColor();
}

int number = GetUserValue("Введите число");
int result = GetMultipleResult(number);
ShowResult($"Сумма цифр числа {number} равна : ", result);
//Console.WriteLine(result);
