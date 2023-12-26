/зборник задач/тема 10/подтема 10/средний уровень/вариант 24
try
{
    Console.WriteLine("Введите три вещесвтенных числа:");
    Console.Write("x: ");
    double x = double.Parse(Console.ReadLine()!);
    Console.Write("y: ");
    double y = double.Parse(Console.ReadLine()!);
    Console.Write("z: ");
    double z = double.Parse(Console.ReadLine()!);
    TrioXYZ numXYZ = new TrioXYZ(x, y, z);
    Console.WriteLine();
    Console.WriteLine("Введите три вещесвтенных числа:");
    Console.Write("a: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("b: ");
    double b = double.Parse(Console.ReadLine()!);
    Console.Write("c: ");
    double c = double.Parse(Console.ReadLine()!);
    TrioXYZABC numXYZABC = new TrioXYZABC(x, y, z, a, b, c);
    Console.WriteLine();
    Console.Write("Класс родитель: ");
    numXYZ.PrintClass();
    Console.Write("Класс потомок: ");
    numXYZABC.PrintClass();
    Console.WriteLine("Скалярное произведение 2-ух наборов чисел: ");
    numXYZABC.Print();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
class TrioXYZ
{
    private double x; 
    private double y; 
    private double z;
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { x = value; }
    }
    public double Z
    {
        get { return z; }
        set { z = value; }
    }
    public TrioXYZ(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public virtual void PrintClass()
    {
        Console.WriteLine($"x: {x}, y: {y}, z: {z}");
}
}
class TrioXYZABC : TrioXYZ
{
    private double a;
    private double b;
    private double c;

    public TrioXYZABC(double x, double y, double z, double a, double b, double c) : base(x, y, z)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override void PrintClass()
    {
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
    public void Print()
    {
        Console.WriteLine(X * a + Y * b + Z * c);
    }
}
