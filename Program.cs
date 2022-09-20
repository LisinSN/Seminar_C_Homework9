// Урок 9. Рекурсия. Домашняя работа. 

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine();
Console.WriteLine("*** Давайте напишем все числа от M до N ***");
Console.WriteLine();

// Метод. Принятия числа. 
int ReadNum(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1"); // int.Parse - парсин строки
    return num;
}

// Метод рекурсивного определения чисел. 
string RecursMToN(int numM, int numN)
{
    if (numM >= numN) return numN.ToString(); // numN.ToString() - преобразование числа
    else return numM + ", " + RecursMToN(numM + 1, numN);

}
// Метод рекурсивного подсчёта суммы. 
int RecursSum(int numM, int numN)
{
    if (numM >= numN) return numN; // numN.ToString() - преобразование числа
    else return numM + RecursSum(numM + 1, numN);

}
// Метод вывода
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

// Ввод данных

// Ввод данных
int numM = ReadNum("* Введите число M: ");
int numN = ReadNum("* Введите число N: ");
string result = (numM < numN) ? (RecursMToN(numM, numN)) : (RecursMToN(numN, numM));
// Выше  string result = (x < y) ? ():() - условие, при котором программа выбирает правильный ответ из двух 
// разделенных знаком вопроса. И выполняет одно из двух условий разграниченных двоиточием.
PrintData($"* Числа от {numM} до {numN}: ", result.ToString());

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine();
Console.WriteLine("*** Давайте надём сумму всех чисел от M до N ***");
Console.WriteLine();

int sumMN;
if (numM < numN) sumMN = RecursSum(numM, numN);
else sumMN = RecursSum(numN, numM);
Console.WriteLine($"* Сумма чисел от {numM} до {numN}: " + sumMN); // не работает метод PrintData, ошибка int и string 

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine("*** Давайте вычислим функцию Акермана для M до N ***");
Console.WriteLine();

// Метод решения функции Акермана 
int AkermanFun(int numM, int numN)
{
    if (numM == 0) // первое условие
    {
        return numN + 1;
    }
    else if ((numM > 0) && (numN == 0)) // второе условие
    {
        return AkermanFun(numM - 1, 1);
    }
    else if ((numM > 0) && (numN > 0)) // третье условие
    {
        return AkermanFun(numM - 1, AkermanFun(numM, numN - 1));
    }
    else return 0;
}

int resFun = AkermanFun(numM, numN);
if (resFun == 0) Console.WriteLine("* Некорректный воод отрицательного числа*");
else PrintData($"* Числа от {numM} до {numN}: ", resFun.ToString());