//принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



Console.WriteLine("Введите пятизначное число N: ");
string number = Console.ReadLine();
int length = 5;


bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}


if (IsPalindrome())
    
        System.Console.WriteLine($"Число - {number} - является палиндромом");
    
else 
    
        System.Console.WriteLine($"Число - {number} НЕ является палиндромом");
