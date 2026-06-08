class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter = 'X';

    public Question()
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        questionText = null;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter=Question.defaultCorrectAnswerLetter;
        


    }

    public Question(string questionText)
    {
        //TO DO: Initialize questionText. Also, initialize optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        this.questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText. Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;
        this.correctAnswerLetter= correctAnswerLetter;
    }
    

    public bool AreOptionsValid()
    {
        //TO DO: Return true, if at least two options are not null
        if((optionA==null && optionB==null && optionC==null&&optionD==null)||(optionA==null&&optionB==null&&optionC==null&&optionD!=null) || (optionA == null && optionB == null && optionC != null&&optionD==null) || (optionA == null && optionB != null && optionC == null&&optionD==null) || (optionA != null && optionB == null && optionC != null&&optionD==null))
        {
            return false;
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        //TO DO: Create an object of Question class and pass no arguments to the constructor
        Question q1 = new Question();
        //TO DO: Create an object of Question class and pass value for questionText only to the constructor.
        Question q2 = new Question("What is the Capital of India?");
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        Question q3 = new Question("What is the Capital of Telangana?","Haryana","Himayath Nagar","Hyderabad","Hampi",'C');
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
        Question q4 = new Question() { questionText="What is the Capital of Andhra Pradesh?", optionA="Kadapa", optionB="Kurnool", optionC="Nellore",optionD= "Amaravathi" };

        System.Console.ReadLine();
    }
}