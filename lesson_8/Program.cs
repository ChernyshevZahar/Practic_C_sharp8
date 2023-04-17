// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int [,] array = RandomArrayDoudle(4,4);
// PrintDoudleArray(array);
// SortDoubleArray(array);
// PrintDoudleArray(array);


// int[,]SortDoubleArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int d = 0; d < array.GetLength(1); d++)
//             {
//                 if(array[i,j]>array[i,d]){
//                 int tmp = array[i,j];
//                 array[i,j] = array[i,d];
//                 array[i,d] = tmp;
//             }
//             }
//         }
//     }
//     return array;
// }


int[,] RandomArrayDoudle(int coll, int stro){
    Random random = new Random();
    int[,] arr = new int[stro,coll];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
            arr[i,j]= random.Next(1,10);
       }   
    }
    return arr;
}


void PrintDoudleArray( int [,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}   ");
                }
    }
    Console.WriteLine();
}

void PrintArray( int [] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if(i+1<arr.Length){
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ");
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array2 = RandomArrayDoudle(4,4);
// PrintDoudleArray(array2);
// Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMiniSumToStr(array2)} строка");

// int FindMiniSumToStr(int[,] array){
//     int MinSumToStr=0;
//     int[] arr= new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int d = 0; d < array.GetLength(1); d++)
//         {
//             arr[i] += array[i,d];
//         }
//     }
//     PrintArray(arr); // вывожу суммы для удобства проверки
//     int num = arr[0];
//     for (int g = 0; g < arr.GetLength(0); g++)
//     {
//         if(arr[g]<num){
//             num = arr[g];
//             MinSumToStr = g;
//         }
//     }
//     return MinSumToStr+1; // прибавил 1 для убодства чтения
// }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//явно заданые значения
// int[,] matric1 = new int[,]{{2,4},{3,2}};
// int[,] matric2 = new int[,]{{3,4},{3,3}};

// рандомные значения
// int[,] matric1 = RandomArrayDoudle(2,2);
// int[,] matric2 = RandomArrayDoudle(2,2);
// PrintDoubleMatric(matric1,matric2);
// PrintDoudleArray(ProductOfTwoMatrices(matric1,matric2));

// int[,] ProductOfTwoMatrices(int[,] mt1,int[,] mt2){
//     int[,] arr = new int [mt1.GetLength(0),mt1.GetLength(1)];
//     if(mt1.GetLength(0)==mt2.GetLength(0)){
//         for (int i = 0; i < mt1.GetLength(0); i++)
//         {
//             if(mt1.GetLength(1)==mt2.GetLength(1)){
//                 for (int g = 0; g < mt1.GetLength(1); g++)
//                 {
//                     for (int b = 0; b < mt1.GetLength(0); b++)
//                     {
//                         arr[i,g] +=(mt1[i,b] * mt2[b,g]);
//                     }
//                 }
//             }
            
//         }
//     }
//     return arr;
    
// }

// void PrintDoubleMatric(int[,] mt1,int[,] mt2){
//     if(mt1.GetLength(0)==mt2.GetLength(0)){
//         for (int i = 0; i < mt1.GetLength(0); i++)
//         {
//             if(mt1.GetLength(1)==mt2.GetLength(1)){
//                 for (int g = 0; g < mt1.GetLength(1); g++)
//                     {
//                         Console.Write($"{mt1[i,g]} ");
//                     }
//                 Console.Write($"| ");
//                 for (int f = 0; f < mt2.GetLength(1); f++)
//                     {
//                         Console.Write($"{mt2[i,f]} ");
//                     }
//             }
//             Console.WriteLine();
//         }
//     }
    
// }
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] arr = new int[2,2,2];
// Print3DArreyOrId(Fillin3DArray(arr));


// int[,,] Fillin3DArray(int[,,] array){
    
//     Dictionary<int, int> dic = new Dictionary<int,int>();
//     for (int d = 0; d < array.GetLength(0); d++)
//     {
//         for (int v = 0; v < array.GetLength(1); v++)
//         {
//             for (int b = 0; b < array.GetLength(2); b++)
//             { 
//                 array[d,v,b] = unicrandom3d(dic);
//             }
//         }
//     }


//     return array;
// }


// void Print3DArreyOrId(int[,,] array3d){
//     for (int d = 0; d < array3d.GetLength(0); d++)
//     {
//         for (int v = 0; v < array3d.GetLength(1); v++)
//         {
//             for (int b = 0; b < array3d.GetLength(2); b++)
//             { 
//                 Console.WriteLine($"{array3d[d,v,b]}({d},{v},{b})");
//             }
//         }
//     }
// }

// int unicrandom3d(Dictionary<int, int> dic){
//         Random random = new Random();
//         int num = random.Next(10,100);
//         if(!dic.TryAdd(num,1)){
//             return unicrandom3d(dic);    
//         }else{
//             return num;   
//         }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] array3 = new int[6,6];

// PrintDoudleArraySper(SpiralDoubleArray(array3));


// int[,] SpiralDoubleArray(int[,] arr){
//     int swch = 1;

    //первое решение

    // for (int b = 0; b < arr.GetLength(0); b++)
    // {
    //     for (int d = 0; d < arr.GetLength(1); d++)
    //     {
            
    //         if(swch<arr.GetLength(0)){
    //             arr[b,d] = swch+1;
    //             swch++;
    //         }
    //         if(swch>3&&swch<8){
    //             arr[d+b,arr.GetLength(0)-1] = swch;
    //             swch++;
    //         }
    //         if(swch>7&&swch<10){
    //             arr[arr.GetLength(0)-1,arr.GetLength(1)-d] = swch;
    //             swch++;
    //         }
    //         if(swch>9&&swch<12){
    //             arr[arr.GetLength(0)-b,0] = swch;
    //             swch++;
    //         }
    //         if(swch>11&&swch<14){
                
    //             arr[arr.GetLength(0)-b-1,d] = swch;;
    //             swch++;
    //         }
    //         if(swch>13&&swch<16){
    //             Console.WriteLine(swch);
    //             arr[d-1+b-1,arr.GetLength(0)-2] = swch;
    //             swch++;
    //         }
    //         if(swch>15){
    //             arr[arr.GetLength(0)-2,arr.GetLength(1)-3] = swch;
    //             break;
    //         }
     
    //     }} 

    //второе решение для любых размеров квадратных массивов
     
    // int startc = 0;
    // int endc = arr.GetLength(0)-1;
    // int startr = 0;
    // int endr = arr.GetLength(1)-1;
    // while (startc<=endc&&startr<=endc)
    // {
    //     for (int i = startc; i <= endc; i++)
    //     {
    //         arr[startr,i] = swch;
    //         swch++;
    //     }
    //     startr++;
    //     for (int g = startr; g <= endr; g++)
    //     {
    //         arr[g,endc] = swch;
    //         swch++;
    //     }
    //     endc--;
    //     for (int b = endc; b >= startc; b--)
    //     {
    //         arr[endr,b] = swch;
    //         swch++;
            
    //     }
    //     endr--;
    //     for (int v = endr; v >= startr; v--)
    //     {
    //         arr[v,startc] = swch;
    //         swch++;
            
    //     }
    //     startc++;
    // }

    


//     return arr;
// }

// void PrintDoudleArraySper( int [,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < arr.GetLength(1); j++)
//                 {
//                     if(arr[i,j]>9){
//                         Console.Write($"{arr[i,j]} ");
//                     }else{
//                         Console.Write($"0{arr[i,j]} ");
//                     }
                    
//                 }
//     }
//     Console.WriteLine();
// }