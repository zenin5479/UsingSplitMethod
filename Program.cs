using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingSplitMethod
{
    internal class Program
    {
        static void Main()
        {
            // Использование метода Split()
            // Метод Split() является одним из наиболее распространенных способов преобразования строки в список.
            // Он позволяет разделить строку на отдельные элементы с заданным разделителем.
            const string str = "В-эту-ночь-Анжелика-никак-не-могла-уснуть";
            List<string> angelica = str.Split('-').ToList();
            foreach (string variable in angelica)
            {
                Console.WriteLine(variable);
            }

            const string str2 = "— Что с вами, моя дорогая? Вы просто голову потеряли! Вы не ответили уже на три приглашения короля!";
            char[] delimiterChars = { '!', '?', '—', ',' };
            List<string> angelica2 = new List<string>(str2.Split(delimiterChars));
            foreach (string variable in angelica2)
            {
                Console.WriteLine(variable);
            }
        }
    }
}