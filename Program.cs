namespace CSI120_Lecture6Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // CSI 120 - Computer Programming 1
            // Lecture 6 Notes
            

        }

        public static void WhileLoopExample()
        {
            int userCount = 0;
            while (userCount <= 10) // Loop print until 10
            {
                Console.WriteLine($"No.{userCount}");
                userCount++;
            }
            
        } // End of WLE

        public static void ValidateUserInput()
        {
            int userNum = 0;
            bool isValid = false;
            
            while (!isValid) // Checking input
            {
                Console.Write("Enter your number: ");
                string userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out userNum);
                if (isValid = int.TryParse(userInput, out userNum))
                {
                    Console.WriteLine($"You entered: {userNum}");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                
            }
        }// End of VUI

        public static void DoWhileExample()
        {
            int userCount = 11;
            do // Set looping action
            {
                Console.WriteLine($"No.{userCount}");
                
            }
            while (userCount <= 10); // Looping condition

            Console.WriteLine("After our loop");
        }// End of DWE

        public static void PasswordValidation()
        {
            string userPass = "HKGN";
            bool isValid = false;
            while (!isValid) // Set condition to ask for password
            {
                Console.Write("Enter password: ");
                string userInput = Console.ReadLine();
                if (userInput == userPass)// Checking input
                {
                    isValid = true;
                    Console.WriteLine("Correct!");

                }
                else
                {
                    Console.WriteLine("Wrong Password!");
                }
            }
        }// End of PV

        public static void ForLoopExample()
        {
            for (int i = 450; i > -25; i -= 5) // Loop while performing the following actions as long as condition is met
            {
                Console.WriteLine($"{i}");
            }
        } // End of FLE

        public static void SumAndAverageNumbers()
        {
            int userSum = 0;
            int userCount = 0;
            for (int i = 0; i < 300; i += 4) // Loop to find all numbers under condition
            {
                userSum += i; //Add each number find to total
                userCount++;
            }
            
            int userAverage = userSum / userCount;
            Console.WriteLine($"Sum = {userSum}; Count = {userCount}; Average = {userAverage}");
        }// End of SAAN

    }// Class End
}// Name End
