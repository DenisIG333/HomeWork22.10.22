/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет

12821 -> да

23432 -> да
*/




int Get(string message)
{
    
    while(true)
    {
        Console.WriteLine(message);
        

        if(int.TryParse(Console.ReadLine(), out int number))
        {
            if(number >= 9999 && number <= 99999)
            {
                string numStr = number.ToString();
                char[] obrtext = numStr.ToCharArray();
                Array.Reverse(obrtext);
                string finaltext = new string(obrtext);

                int finaltextInt = int.Parse(finaltext);

                if(finaltextInt == number)
                {
                    Console.WriteLine($"число {number} является палиндромом");
                }
                else
                {
                    Console.WriteLine($"число {number} не является палиндромом");
                }

                return number;
            }
            else
            {
                Console.WriteLine("Вы ввели не пятизначное число. Повторите ввод \n");
            }
            
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод \n");
        }
        
        
    }
    
}

int number = Get("Введите пятизначное число");

