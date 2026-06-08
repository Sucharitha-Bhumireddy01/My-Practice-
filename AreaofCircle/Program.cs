class Circle
{
    static void Main()
    {
        System.Console.WriteLine("Plese Enter the Radius ");
        double Radius=System.Convert.ToDouble(System.Console.ReadLine());
        double Area = System.Math.PI*Radius* Radius;
        System.Console.WriteLine("Area of the Circle: "+Area);
        System.Console.ReadKey();
    }
}