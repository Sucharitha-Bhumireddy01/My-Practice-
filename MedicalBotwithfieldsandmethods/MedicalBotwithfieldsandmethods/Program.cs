using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Hi!! I am " + MedicalBot.BotName + " I am here to assist you:)");

        Console.WriteLine("\n******* Please enter the patient details ******** ");

        Patient patient = new Patient();
      
        Console.Write("\nEnter the Name: ");
        while (!patient.SetName(Console.ReadLine(), out string errorMessage))
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter the Name: ");
        }
       
        Console.Write("\nEnter the age: ");
        while(!patient.SetAge(Convert.ToInt32(Console.ReadLine()), out string errorMessages))
        {
            Console.WriteLine(errorMessages);
            Console.Write("Enter the age: ");
        }



        Console.Write("\nEnter the Gender: ");
        while(!patient.SetGender(Console.ReadLine().ToUpper(), out string errorrMessages))
        {
            Console.WriteLine(errorrMessages);
            Console.Write("Enter the Gender: ");
        }

        Console.Write("\n**Medical History should be like Eg: Diabetes. Press Enter for None** ");
        Console.Write("\nEnter MedicalHistory: ");
        patient.SetMedicalHistory(Console.ReadLine().ToUpper());


        Console.WriteLine($"\nWelcome," + patient.GetName() + ":) Age: " + patient.GetAge() + ", " + patient.GetGender() + ".");

        string patientChoice="";
        do
        {
            Console.WriteLine("\n which of the following symptom do you have: \n S1. Headache \n S2. Skin rashes \n S3. Dizziness");
            Console.Write("Enter the symptom code from above list ( S1,S2 or S3): ");
            patient.SetSymptomCode(Console.ReadLine().ToUpper(), out string errorMessagess);

            MedicalBot medicalBot = new MedicalBot();
            medicalBot.PrescribeMedication(patient);
            
            Console.WriteLine("Do you have anyother Symptom? Yes/No");
            patientChoice = Console.ReadLine().ToUpper();

            if (patientChoice == "NO")
            {
                Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:");
                Console.WriteLine(patient.GetPrescription());
                Console.WriteLine("Thanks for Visiting!!");
            }

        } while (patientChoice=="YES");
        //displaying patient details

        //Console.WriteLine($"\nAge:" + patient.GetAge());
        //Console.WriteLine($"\nGender: " + patient.GetGender());
        // Console.WriteLine($"\nMedicalHistory: " + patient.GetMedicalHistory());

        Console.Read();


    }

    class MedicalBot
    {

        public const string BotName = "BOT";

        public static string GetBotName()
        {
            return BotName;
        }


        public void PrescribeMedication(Patient patient)
        {
            switch (patient.GetSymptomCode())
            {
                case "Headache":
                    patient.SetPrescription("ibuprofen  " + GetDosage("ibuprofen"));
                    break;
                case "Skin rashes":
                    patient.SetPrescription("diphenhydramine  " + GetDosage("diphenhydramine"));
                    break;
                case "Dizziness":
                    string medicalHistorys = patient.GetMedicalHistory();
                    if (medicalHistorys == "DIABETES")
                    {
                        patient.SetPrescription("metformin  " + GetDosage("metformin"));
                    }
                    else
                    {
                        patient.SetPrescription("dimenhydrinate  " + GetDosage("dimenhydrinate"));
                    }
                    break;

                default: Console.Write("unknown"); break;

            }


            string GetDosage(string medicineName)

            {
                if (medicineName == "ibuprofen")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "400mg";

                    }
                    else
                    {
                        return "800mg";
                    }
                }

                else if (medicineName == "diphenhydramine")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "50mg";

                    }
                    else
                    {
                        return "300mg";
                    }
                }

                else if (medicineName == "dimenhydrinate")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "50mg";

                    }
                    else
                    {
                        return "400mg";
                    }

                }

                else if (medicineName == "metformin")
                {
                    return "500mg";
                }
                return "unknown";


            }
        }






    }



    class Patient
    {
        // fields
        private string name;
        private int age;
        private string gender;
        private string medicalHistory;
        private string symptomCode;
        private string prescription;

        public string GetName()
        {
            return name;
        }
        public bool SetName(string name, out string errorMessage)
        {
            bool isValid;

            if (name == null || name.Length < 2)
            {
                isValid = false;
                errorMessage = "Patient name cant be blank \n it should contain atleast 2 or more characters";

                return isValid;
            }

            isValid = true;
            errorMessage = " ";

            this.name = name;
            return isValid;
        }


        public int GetAge()
        {
            return age;
        }
        public bool SetAge(int age, out string errorMessage)
        {
            bool isValid;

            if (age < 0 || age > 100)
            {
                isValid = false;
                errorMessage = "Patient age can't be negative \n Patinet age can't be more than 100";

                return isValid;
            }

            isValid = true;
            errorMessage = " ";

            this.age = age;
            return isValid;
        }



        public string GetGender()
        {
            return gender;
        }
        public bool SetGender(string gender, out string errorMessage)
        {
            bool isValid;

            if (!(gender == "FEMALE" || gender == "MALE" || gender == "OTHERS"))
            {
                isValid = false;
                errorMessage = " Patient gender should be Female or Male or Others";

                return isValid;
            }

            isValid = true;
            errorMessage = " ";

            this.gender = gender;
            return isValid;
        }



        public string GetMedicalHistory()
        {
            return medicalHistory;
            ;
        }
        public void SetMedicalHistory(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }



        public string GetSymptomCode()
        {
            string symptom;

            switch (symptomCode)
            {
                case "S1":
                    symptom = "Headache"; break;
                case "S2":
                    symptom = "Skin rashes"; break;
                case "S3":
                    symptom = "Dizziness"; break;
                default:
                    symptom = "unknown"; break;

            }
            return symptom;

        }
        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            bool isValid;

            if (!(symptomCode == "S1" || symptomCode == "S2" || symptomCode == "S3"))
            {
                isValid = false;
                errorMessage = " Symptomcode should be S1 or S2 or S3";

                return isValid;
            }

            isValid = true;
            errorMessage = "";

            this.symptomCode = symptomCode;
            return isValid;
        }

        public string GetPrescription()
        {
            return prescription;
        }

        public void SetPrescription(string prescription)
        {
            this.prescription += "\n"+prescription;
        }

    }


}