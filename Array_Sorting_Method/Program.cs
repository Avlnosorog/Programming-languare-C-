﻿// int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// //PrintArray(array);


// void SelectionSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for(int j=i+1; j<array.Length; j++)
//         {
//             if(array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temparray = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temparray;
//     }
// }
// PrintArray(array);
// Console.WriteLine();
// SelectionSort(array);
// PrintArray(array);