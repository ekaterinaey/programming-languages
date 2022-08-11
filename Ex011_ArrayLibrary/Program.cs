// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//void метод - метод, который ничего не возвращает. в таком методе не иср=пользуется оператор return

void FillArray(int[] collection)  // метод заполнения массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while(index < length){
        collection[index] = new Random().Next(1, 10);
        index++;

    }
}

void PrintArray(int[] col){  //метод печати массива
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.WriteLine(col[position]);
        position++;
    }
} 

int IndexOff(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count){
        if(collection[index] == find){
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // контрукция создания нового массива из 10 чисел

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 444);
Console.WriteLine(pos);

