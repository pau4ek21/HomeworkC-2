//Homework seminar 2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("input number: ");
int inpNumber = Convert.ToInt32(Console.ReadLine());
string strin = Convert.ToString(inpNumber);
Console.WriteLine("number 2: " + strin[1]);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("input number: ");
int inpNumber = Convert.ToInt32(Console.ReadLine());
string strin = Convert.ToString(inpNumber);

if (strin.Length > 2) 
{
    Console.WriteLine("number three " + strin[2]);
}
else {
    Console.WriteLine("number three out");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void weekday(int days)
{
    Console.Write("inpunt week day number: ");
    int inpNumber = Convert.ToInt32(Console.ReadLine());

    if (inpNumber == 6 || inpNumber == 7)
    {
        Console.WriteLine($"Yes! {inpNumber} day off");
    }
    else if (inpNumber < 1 || inpNumber > 7)
    {
        Console.WriteLine($"It is number {inpNumber} not week day");
    }
    else
    {
        Console.WriteLine($"No! {inpNumber} not day off");
    }
}

int start = 1;  //Прошу дать комментарий по данной схеме на void. У меня программа работает но я так и не разобрался зачем я присвоил числовое значение "start = 1" а ниже weekday(start);
weekday(start); //можно ли вообще записать это по другому? Я все думал и баловался, так получилось.
                //и если я просто писал int start; то он писал следующее
                //Использование локальной переменной "start", которой не присвоено значение. и не давал запустить программу а после присвоения все заработало.