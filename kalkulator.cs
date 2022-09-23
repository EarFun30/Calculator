
using System;
namespace SkilvulLearning {

    class ProgramInput
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Enter the Action to be performed :");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subscription");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            int pilihan = int.Parse(Console.ReadLine());
            
            switch (pilihan) {
                case 1: 
                Console.WriteLine("Enter 1st input"); 
                int tambah1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd input"); 
                int tambah2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is : {0}", tambah1 += tambah2);
                break;

                case 2: 
                Console.WriteLine("Enter 1st input"); 
                int kurang1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd input"); 
                int kurang2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is : {0}", kurang1 -= kurang2);
                break;

                case 3: 
                Console.WriteLine("Enter 1st input"); 
                int kali1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd input"); 
                int kali2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is : {0}", kali1 *= kali2);
                break;

                case 4: 
                Console.WriteLine("Enter 1st input"); 
                int bagi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd input"); 
                int bagi2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is : {0}", bagi1 /= bagi2);
                break;

                default: 
                Console.WriteLine("Action cannot be performed"); 
                break;
            }

            Console.ReadKey();


            
        }
    
    }

}