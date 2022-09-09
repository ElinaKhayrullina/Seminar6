// Напишите программу, которая будет преобразовывать десятичное число в двоичное
/*
void Dec (int [] array){
    int temp=0;
    int j=1;

    for (int i=0;i<array.Length;i++){
        int[] number=new int [5];
            for (int z=0;z<number.Length;z++) {
                number[z]=2;
                Console.Write(number[z]+" ");

 }
 
        temp=array[i]%2;
       int n=array[i]/2;
        number[i]=temp;
            while (n!=0){
                temp=n%2;
                n=n/2;
                number[i+j]=temp;
                j++;

            }
             for (int k=number.Length;k>0;k--){
                if(number[k]!=2){
                    Console.Write(number[k]);
                }
             }
        }
        Console.WriteLine("--------------------");
    }


int [] arr={1,2,3,4,10};
Dec(arr);
*/
// Напишите программу, котора принимает на вход три числа и проверяет может ли существовать 
//треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
/*

void Tringle (int a,int b,int c){
    int sumA=b+c;
    int sumB=a+c;
    int sumC=a+b;
    if (a<sumA&&b<sumB&&c<sumC){
        Console.WriteLine("It is ok");

    }
    else{
        Console.WriteLine("You can't create triangle with this length of sides");
    }



}


Console.WriteLine("Input length of first side of tringle: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length of second side of tringle: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length of third side of tringle: ");
int c=Convert.ToInt32(Console.ReadLine());

Tringle(a,b,c);
*/
//Не используя рекурсию выведите n чисел Фибонначи
//Первые два числа Фибоначчи
/*
void Fibonacci (int n){
    int [] array=new int[n];
    array[0]=0;
    array[1]=1;

    for (int i=2; i<array.Length;i++){
        array[i]=array[i-1]+array[i-2];
    }
     for (int i=0; i<array.Length;i++){
        Console.Write(array[i]+" ");
     }
}
Console.WriteLine("Input number: ");
int n=Convert.ToInt32(Console.ReadLine());
Fibonacci(n);
*/