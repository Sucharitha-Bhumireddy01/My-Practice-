class Convert
{
    static void Main()
    {
        int feet = 5, inches = 7;
        //1 inch = 2.54 cm
        // 1 feet = 12 inches
        //converting feet to inches
        inches += feet * 12;
        double centimeters=0;
        centimeters += inches * 2.54;//converting inches to cm
        System.Console.WriteLine("Centemeters:"+centimeters);
        System.Console.ReadKey();


    }
}
//Conveting height in feet and inches to centimeters
//1 feet=30.48cm
//1 inch=2.54cm
//Console.WriteLine("Please Enter the Height in the format shown below\nFeet\nInch");
//int heightInFeet=Convert.ToInt32(Console.ReadLine());
//int heightInInch = Convert.ToInt32(Console.ReadLine());
//double heightInCM = heightInFeet * 30.48+ heightInInch*2.54;
//Console.WriteLine("Height in Centimeters: " + heightInCM+"cm");
//Console.ReadKey();

