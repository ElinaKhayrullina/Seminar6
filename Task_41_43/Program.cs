// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void CountOfNumber (int[]arr){
    int count =0;
    for (int i=0; i<arr.Length;i++){
        if(arr[i]>0){
            count++;
        }
    }
    Console.WriteLine($"You input {count} numbers more 0");
    }

int size=0;
int[] array=new int[100];

while(true){
    Console.WriteLine("Input number or input end to break: ");
    string input = Console.ReadLine();
    if (input=="end"){
        Console.WriteLine("You have finished input"); 
        break;
}
    else{
        int n=Convert.ToInt32(input);
        array[size]=n;
        size++;
        
        }
    }

CountOfNumber(array);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void Equation (double k1,double b1,double k2,double b2){
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    Console.WriteLine($"Point of intersection of two sraight lines is: ({x};{y})");
    }

Console.WriteLine("Two sraight lines are written by the equations:");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();
Console.WriteLine("Input number k1: ");
double k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b1: ");
double b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number k2: ");
double k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b2: ");
double b2=Convert.ToInt32(Console.ReadLine());


Equation(k1,b1,k2,b2);
*/