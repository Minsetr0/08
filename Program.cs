﻿const string password = "12345";
int tryCount = 3;

for (int i = 0; i < tryCount; i++)
{
    Console.WriteLine("Введите пароль.");
    string userInput = Console.ReadLine();

    if (password == userInput)
    {
        Console.WriteLine("Вы вошли в систему");
    }
    else
    {
        Console.WriteLine("Неверно. У вас осталось " + (tryCount - i - 1) + " попыток.");
    }
}
