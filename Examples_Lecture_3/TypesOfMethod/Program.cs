// Метод Вид 1 - ничего не принимает. ничего не возвращает.

// void Method1()
// {
//    Console.WriteLine("Автор я...");
// }
// Method1();





// Метод Вид 2 - что-то принимает. ничего не возвращает.

//void Method2(string msg)
//{
//    Console.WriteLine("msg");
//}
//Method2(msg:"Текст сообщения");

// или

//void Method2_1(string msg, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
//}
//Method2_1(msg: "Текст", count: 4);





// Метод Вид 3 - ничего не принимает. что-то возвращает.

//int Method3()
//{
//    return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);



// Метод Вид 4 - что-то принимает. что-то возвращает.

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // помещаем переменную result в пустую строкуб можно заменить на = "";

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "море");
Console.WriteLine(res);