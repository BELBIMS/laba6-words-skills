// Базовый абстрактный класс Transport представляет транспортное средство
public abstract class Transport
{
    // Абстрактные свойства для скорости, грузоподъемности и дальности
    public abstract double Speed { get; }
    public abstract double Load_capacity { get; }
    public abstract double Range { get; }

    // Абстрактный метод для вывода информации о транспорте
    public abstract void GetInfo();
}

// Абстрактный класс Car наследуется от Transport и представляет автомобиль
public abstract class Car : Transport
{
    // Реализация метода GetInfo для вывода информации о машине
    public override void GetInfo()
    {
        Console.WriteLine($"Машина с грузоподъемностью {Load_capacity} может проехать {Range} км.");
    }
}

// Абстрактный класс Aircraft наследуется от Transport и представляет самолет
public abstract class Aircraft : Transport
{
    // Реализация метода GetInfo для вывода информации о самолете
    public override void GetInfo()
    {
        Console.WriteLine($"Самолет с грузоподъемностью {Load_capacity} может пролететь {Range} км.");
    }
}

// Абстрактный класс Ship наследуется от Transport и представляет корабль
public abstract class Ship : Transport
{
    // Реализация метода GetInfo для вывода информации о корабле
    public override void GetInfo()
    {
        Console.WriteLine($"Корабль с грузоподъемностью {Load_capacity} может проплыть {Range} км.");
    }
}

// Класс Mazda представляет машину и наследуется от Car
public class Mazda : Car
{
    public override double Speed => 180;
    public override double Load_capacity => 475;
    public override double Range => 550;

    // Переопределенный метод GetInfo для вывода информации о Mazda
    public override void GetInfo()
    {
        Console.WriteLine($"Mazda с грузоподъемностью {Load_capacity} может проехать {Range} км.");
    }
}

// Класс Mig представляет самолет и наследуется от Aircraft
public class Mig : Aircraft
{
    public override double Speed => 3000;
    public override double Load_capacity => 21820;
    public override double Range => 2500;

    // Переопределенный метод GetInfo для вывода информации о Mig
    public override void GetInfo()
    {
        Console.WriteLine($"Mig с грузоподъемностью {Load_capacity} может пролететь {Range} км.");
    }
}

// Класс Aurora представляет корабль и наследуется от Ship
public class Aurora : Ship
{
    public override double Speed => 38;
    public override double Load_capacity => 7600000;
    public override double Range => 7200;

    // Переопределенный метод GetInfo для вывода информации о Aurora
    public override void GetInfo()
    {
        Console.WriteLine($"Aurora с грузоподъемностью {Load_capacity} может проплыть {Range} км.");
    }

}

class Program
{
    static void Main()
    {
        // Создание объектов Mazda, Mig и Aurora
        Mazda mazda = new Mazda();
        mazda.GetInfo();

        Mig mig = new Mig();
        mig.GetInfo();

        Aurora aurora = new Aurora();
        aurora.GetInfo();

    }
}
