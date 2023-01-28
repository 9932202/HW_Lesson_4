/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число 
A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

int GetUserValue(string message){
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetExponentiationResult(int A, int B){
    int res = A;
    for (int i = 2; i <= B; i++){
        res = res * A;
    }
    return res;
}

void ShowResult(string msg, int result){
    Console.Write(msg);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(result);
    Console.ResetColor();
}

int numberA = GetUserValue("Веедите число: ");
int numberB = GetUserValue("Введите в какую степень возвести это число:  ");
int result = GetExponentiationResult(numberA, numberB);
ShowResult("Результат возведения в степень = ", result);

//int result = GetExponentiationResult(2, 3);
// Console.WriteLine(result);
