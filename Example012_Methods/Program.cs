﻿// Виды методов:
// * Для проверки работы того или иного метода, предыдущие вызовы методов я отключал *

// Вид 1: ( Методы, которые ничего не принимают и не возвращают.)
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();


// Вид 2 ( Методы, которые ничего не возвращают, но могут принимать какие-то аргументы.)
  // void - это ключевое слово.
  // Method2 - идентификатор, 
  // и какое-то кол-во аргументов например (string msg).
  //  (string msg) - это именованный аргумент, чтоб мы могли указать какому-то определённому аргументу
  // определённое значение. Это нужно когда методы принимают какое-то кол-во аргументов(отличное от одного).
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения"); 

void Method21(string msg, int count)
{
    int i = 0;                      // исп-ем значение перем-й , чтоб показывать на экране - 
                                    // - опред-ное кол-во сообщений mgg, которые буут предав-ся в наш метод)
    while( i < count)                
    {
        Console.WriteLine(msg);
        i++;                       // (i++) == (i = i +1) увеличение счётчика на 1 называют - инкрементом ) 
    }                              // если случилось зацикливание программы, то испровить это можно при помощи (ctr + c )
}
//Method21("Text", 4); 
//Method21(msg: "Text", count: 4);   // Мы можем явно указывать, какому аргументу, какое значение мы хотим присвоить
                                   // Если мы исп-ем именованные аргументы, то порядок не обязателен.

// Вид 3
// Методы кот-е что-то возвращают, но ничего не принимают
// Если методы что-то возвращают, то мы обязательно должны указать тип данных, значения которых мы ожидаем.(например int)

int Method3()
{
     return DateTime.Now.Year;             // Обязательное использование оператора return
}
int year = Method3();      // в левой части(int year) мы используем индетификатор переменной -
                        // - и через оператор присваивания(=) положили нужное значение

//Console.WriteLine(year);   // вдальнейшем исп-ем эту переменной и то значение кот-е нам вернул метод.

// Вид 4
// Методы которые что-то принимают и что-то возвращают

// string Method4(int count, string text)
//{
//   int i = 0;                // Берём цикл
//   string result = String.Empty; // переменная куда мы кладём конечный результат
                                   // читаем  result = String.Empty; т.е. изначально result будет пустой строкой
//    while( i < count)
//    {   
//        result = result + text;
//        i++; 
//    }
//    return result; 
//}
//string res = Method4(10, "asdf"); // чтоб вызвать наш метод, нужно создать нужную нам переменную
//Console.WriteLine(res);


string Method4(int count, string text)
{                
   string result = String.Empty;         
   for (int i = 0; i < count; i++)
   {   
       result = result + text;
   }
    return result; 
}
string res = Method4(10, "x"); 
Console.WriteLine(res);

for(int = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
       Console.WriteLine($"{i} * {j} = {i * j}");
    }
}

