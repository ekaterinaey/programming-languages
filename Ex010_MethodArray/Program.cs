﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;
int find = 18; //запрашиваемое пользователем число

int index = 0; // счетчик

while(index < n){
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }

    index++;
}
