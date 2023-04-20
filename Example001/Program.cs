int OneTask(int A,int B) // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
{
    int summ = Convert.ToInt32(Math.Pow(A, B));
    return summ;
}
// Console.WriteLine(OneTask(3,5));

int TwoTask(int A) // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
{
    // С этой задачей проблема. конвертированные значение отличаются от не конвертированных, из за этого алгоритм не правельно считает
    string AS = Convert.ToString(A);

    int summ = 0;
    for(int i=0;i < AS.Length;i++){
        summ += Convert.ToInt32(AS[i]);

        Console.WriteLine("конвертировоное " + Convert.ToInt32(AS[i]));
        Console.WriteLine("Не конвертировоное " + AS[i]);
    }

    return summ;
}

// Console.WriteLine(TwoTask(452));

string ThreeTask()// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
{
    int[] arr = new int[8] {1, 2, 5, 7, 19, 23, 5, 1};
    string arrS = string.Join(',',arr);

    return arrS;
}

// Console.WriteLine(ThreeTask());