Console.Write("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());


void SumOfDigits(int num)
{
     int i = 1;
     int remainder=0;
     int sum = 0;
     while (num>0)
     {
      remainder = num % 10;
      num = num/10;
      sum = sum + remainder;
       i++;
     }
     Console.WriteLine($"{sum}");
}
SumOfDigits(numA);
