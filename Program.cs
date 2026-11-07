// Task1
// int[] arr = {1,2,3,4,2,1,3,0};
// int max = int.MinValue;
// 
// for (int i = 0; i < arr.Length; i++)
// {
// if (max < arr[i])
// {
// max = arr[i];
// }
// }
// Console.WriteLine("Max: " + max);


// Task2
// double sum = 0;
// 
// int a = 2;
// int b = 2;
// 
// for (int i=0; i <=b; i++)
// {
// sum+=Math.Pow(a,i);
// }
// Console.WriteLine("Sum: "+sum);


//Task3
// int[] arr = {1,2,0,3,4,0,5,0,0};
// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
// {
// if (arr.Length > 0)
// {
// sum+=arr[i];
// }
// }
// System.Console.WriteLine("Sum: "+sum);


//task4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// if(arr[arr.Length - 1] > 0 && arr[arr.Length - 2] > 0 ||
//    arr[arr.Length - 1] < 0 && arr[arr.Length - 2] < 0)
// {
//     System.Console.WriteLine("YES");
// }
// else
// {
//     System.Console.WriteLine("NO");
// }


// Task 5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = i + 1; j < n; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//             Console.Write(arr[j] + " ");
//             break;
//         }
//     }
// }

// Task 6
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int min = arr[0];

// for(int i = 0; i < n; i++)
// {
//     if(min > arr[i])
//     {
//         min = arr[i];
//     }
// }

// System.Console.WriteLine(min);


// Task 7
// int n;
// int sum = 0;
// int cnt = 0;

// while (true)
// {
//     Console.Write("Give a number: ");
//     n = Convert.ToInt32(Console.ReadLine());

//     if (n == 0)
//     {
//         break;
//     }

//     sum += n;
//     cnt++;
// }

// Console.WriteLine("Sum of numbers: " + sum);
// Console.WriteLine("cnt of numbers: " + cnt);


// Task 8
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int zarb = 1;

// for (; n > 0; n /= 10)
// {
//     int digit = n % 10;

//     sum += digit;
//     zarb *= digit;
// }

// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Zarb: " + zarb);


// Task 9
// int n = Convert.ToInt32(Console.ReadLine());

// for (; n > 0; n /= 10)
// {
//     int a = n % 10;
//     Console.Write(a);
// }


// Hometask 2
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int zarb = 1;

// for(int i = 0; i < n; i++)
// {
//     zarb *= arr[i];
// }

// for(int i = 0; i < n; i++)
// {
//     Console.Write(arr[i]);

//     if(i < n - 1)
//     {
//         Console.Write("*");
//     }
// }

// Console.WriteLine(" = " + zarb);


//hometask3
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i=0;i<n;i++);
// System.Console.WriteLine(n-1);



// hometask 4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < n; i++)
// {
//     int cnt = 0;

//     for(int j = 0; j < n; j++)
//     {
//         if(arr[i] == arr[j])
//         {
//             cnt++;
//         }
//     }

//     if(cnt == 1)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


//hometask5



// hometask 8
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < n; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(i + " ");
//     }
// }


// hometask 9
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// for(int i = a; i <= b; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


// hometask 10
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for(int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < n; i++)
{
    if(arr[i] % 2 != 0)
    {
        Console.Write(arr[i] * arr[i] + " ");
    }
}