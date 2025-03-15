double height;
double weight;

//Nhap va kiem tra gia tri user nhap vao da hop ly chua
Console.WriteLine("Enter Height as meters :");
while (true)
    if (double.TryParse(Console.ReadLine(), out height))
    {
        if (height > 0)
        {
            break;
        }
        else Console.WriteLine("Enter Height as a positive number which greater than 0");
    }
    else Console.WriteLine("Enter Height as a positive number which greater than 0");
Console.WriteLine("Enter Weight as kilograms :");
while (true)
    if (double.TryParse(Console.ReadLine(), out weight))
    {
        if (weight > 0)
        {
            break ;
        }
        else Console.WriteLine("Enter Weight as a positive number which greater than 0");
    }
    else Console.WriteLine("Enter Weight as a positive number which greater than 0");
double BMI = weight / Math.Pow(height, 2);
BMI = Math.Round(BMI,1);
Console.WriteLine("BMI :" + BMI);

//Kiem tra, danh gia va xuat ket qua dua tren BMI da tinh
if (BMI >= 30 )
{
    Console.WriteLine("Obese");
}
else
{
    if (BMI >= 25 )
    {
        Console.WriteLine("Overweight");
    }
    else
    {
        if (BMI >= 18.5)
        {
            Console.WriteLine("Normal");
        }
        else
        {
            Console.WriteLine("Underwerght");
        }
    }
}