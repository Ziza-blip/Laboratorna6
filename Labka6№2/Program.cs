using System;

abstract class Parcel
{
    public double Weight { get; set; }
    public double Distance { get; set; }

    public Parcel(double weight, double distance)
    {
        Weight = weight;
        Distance = distance;
    }

    public abstract double CalculateCost();
    public abstract int CalculateDeliveryTime();
}

class Standard : Parcel
{
    public Standard(double weight, double distance) : base(weight, distance) { }

    public override double CalculateCost()
    {
        return Weight * 10 + Distance * 0.5;
    }

    public override int CalculateDeliveryTime()
    {
        return (int)(Distance / 500) + 3;
    }
}

class Express : Parcel
{
    public Express(double weight, double distance) : base(weight, distance) { }

    public override double CalculateCost()
    {
        return Weight * 20 + Distance * 1.0;
    }

    public override int CalculateDeliveryTime()
    {
        return (int)(Distance / 700) + 1;
    }
}

class International : Parcel
{
    public International(double weight, double distance) : base(weight, distance) { }

    public override double CalculateCost()
    {
        return Weight * 30 + Distance * 1.5 + 100;
    }

    public override int CalculateDeliveryTime()
    {
        return (int)(Distance / 1000) + 7;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть тип доставки:");
        Console.WriteLine("1 - Стандартна");
        Console.WriteLine("2 - Експрес");
        Console.WriteLine("3 - Міжнародна");
        Console.Write("Ваш вибір: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Введіть вагу посилки (кг): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Введіть відстань доставки (км): ");
        double distance = double.Parse(Console.ReadLine());

        Parcel parcel = null;

        switch (choice)
        {
            case 1:
                parcel = new Standard(weight, distance);
                break;
            case 2:
                parcel = new Express(weight, distance);
                break;
            case 3:
                parcel = new International(weight, distance);
                break;
            default:
                Console.WriteLine("Невірний вибір!");
                return;
        }

        Console.WriteLine("\nРезультат:");
        Console.WriteLine($"Вартість доставки: {parcel.CalculateCost()} грн");
        Console.WriteLine($"Термін доставки: {parcel.CalculateDeliveryTime()} днів");

        Console.ReadKey();
    }
}
