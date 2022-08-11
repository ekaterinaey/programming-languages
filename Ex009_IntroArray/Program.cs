// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Нахождение максимума из 9 чисел с помощью массива

int Max(int arg1, int arg2, int arg3)  // Функция (или метод) Max
{
    int result = arg1;  // в переменную result кладется значение максимума
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}  


int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};  // обозначение массива
//array[0] = 12;  Запись нового значения в индекс 0


int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);