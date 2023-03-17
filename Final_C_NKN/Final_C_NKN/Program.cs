namespace Final_C_NKN
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentFunction stf = new StudentFunction();

            while (true)
            {
                Console.WriteLine(" 1.Input information(input details for a student).");
                Console.WriteLine(" 2.Display all the student list using method Print in Interface.");
                Console.WriteLine(" 3.Calculator average mark.");
                Console.WriteLine(" 4. Searching.");
                Console.WriteLine(" 5.Exit program.");
                Console.Write("Enter your choice: ");

                int c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("1. Enter information a student");
                        stf.InsertNewStudent();

                        break;

                    case 2:
                        Console.WriteLine("2. Display all the student list using method Print in Interface.");
                        stf.PrintAll();
                        break;

                    case 3:
                        Console.WriteLine("3.Calculator average mark.");
                        stf.CalculateAverageMark();
                        break;

                    case 4:
                        stf.Display();
                        break;
                    default:
                        break;

                }
            }
        }



    }
    

}