using System;
public abstract class Parent
{
    protected double pole1; 
    protected double pole2; 
    protected double pole3;
    public Parent(double speed, double altitude)
    {
        pole1 = speed;
        pole2 = altitude;
    }
    public abstract string Info();
    public abstract void Metod();
}
public class Child1 : Parent
{
    public Child1(double speed, double altitude) : base(speed, altitude)
    {
    }
    public override string Info()
    {
        return $"Пасажирський лiтак: Швидкiсть = {pole1}, Висота = {pole2}, Вартiсть = {pole3}";
    }
    public override void Metod()
    {
        pole3 = pole1 * 1000 + pole2 * 100;
    }
}
public class Child2 : Parent
{
    public Child2(double speed, double altitude) : base(speed, altitude)
    {
    }
    public override string Info()
    {
        return $"Винищувач: Швидкiсть = {pole1}, Висота = {pole2}, Вартiсть = {pole3}";
    }
    public override void Metod()
    {
        pole3 = pole1 * 3000 + pole2 * 200;
    }
}
public class Child3 : Parent
{
    private double pole4; 
    public Child3(double speed, double altitude, double bombCount) : base(speed, altitude)
    {
        pole4 = bombCount;
    }
    public override string Info()
    {
        return $"Бомбардувальник: Швидкiсть = {pole1}, Висота = {pole2}, Кiлькiсть бомб = {pole4}, Вартiсть = {pole3}";
    }
    public override void Metod()
    {
        pole3 = pole1 * 1500 + pole2 * 150 + pole4 * 50;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Parent[] aircraft = new Parent[5];

        for (int i = 0; i < 5; i++)
        {
            int aircraftType = random.Next(1, 4);
            double speed = random.Next(500, 1000);
            double altitude = random.Next(10000, 30000);
            double bombCount = random.Next(1, 10);

            if (aircraftType == 1)
                aircraft[i] = new Child1(speed, altitude);
            else if (aircraftType == 2)
                aircraft[i] = new Child2(speed, altitude);
            else
                aircraft[i] = new Child3(speed, altitude, bombCount);

            aircraft[i].Metod();
            Console.WriteLine(aircraft[i].Info());
        }
    }
}