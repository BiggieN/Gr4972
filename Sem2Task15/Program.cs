﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// * Сделать вариант с использованием конструкции Dictionary
Console.WriteLine("Введите цифру от 1 до 7");
int dayNumber = int.Parse(Console.ReadLine());

//Создаем словарь
var weekDays = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"}
};

//Выводим значение
Console.Write("Ваш день недели " + weekDays[dayNumber]);