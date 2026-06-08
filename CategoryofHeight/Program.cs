//Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
//Height categories:

//Height is less than 150 cm = "Dwarf"

//Height is between 150 cm and 165 cm = "Average height"

//Height is between 165 cm and 195 cm = "Tall"

//Height is above 195 cm = "Abnormal height"



//Note: 1 inch = 2.54 centimeter

//You need to convert the input value (inches) into centimeters.



//Eg:

//Input: 75

//Output: Tall

class HeightClass
{
    static void Main()
    {
        int heightinInches = 60;
        double heightinCM;
        //Note: 1 inch = 2.54 centimeter
        heightinCM = 2.54 * heightinInches;
        if(heightinCM<150)
        {
            System.Console.WriteLine("Dwarf");
        }
        else if(heightinCM>=150&&heightinCM<165)
        {
            System.Console.WriteLine("Average height");
        }
        else if(heightinCM>=165&&heightinCM<195)
        {
            System.Console.WriteLine("Tall");
        }
        else
        {
            System.Console.WriteLine("Abnormal height");
        }
        System.Console.ReadKey();

    }
}
