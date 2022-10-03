Console.Write("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());

void Degree(int num, int agr)
{
     int i = 1;
     int numC=0;
     while (i<=agr)
     {
      numC=num*num;
       i++;
     }
     Console.WriteLine($"{numC}");
}
Degree(numA,numB);