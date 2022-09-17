int M = new Random().Next(1, 10);
int count = 0;
Console.WriteLine("Input numbers: ");
for (int i = 1; i <= M; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++; 
}
Console.WriteLine($"Numbers > 0: {count}");