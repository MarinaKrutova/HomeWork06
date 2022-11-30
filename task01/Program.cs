/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int getNumberFromUser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int count=0;
int m = getNumberFromUser("Сколько чисел будете вводить?: ");
for (int i = 1; i <=m; i++)
{
    int number=getNumberFromUser($"Введите число {i}: ");
    if (number >0)
    {
        count+=1;
    }
}
Console.WriteLine($"Количество чисел больше 0: {count}");