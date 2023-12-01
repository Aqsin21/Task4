namespace ConsoleAppMM
{
    internal class Program
    {
        class telebe
        {
            public string name;
            public string surname;
            public int age;
            public string speciality;
            public int groupNo;
        }
        static void Main(string[] args)
        {
             // Task 1

               Console.WriteLine("1 ci ededi daxil edin");
               string num1 = Console.ReadLine();
               Console.WriteLine("2 ci ededi daxil edin");
               string num2 = Console.ReadLine();
               int number1;
               int number2;
               while (!(int.TryParse(num1, out number1) && (int.TryParse(num2, out number2))))
               {
                   Console.WriteLine("Sehvdi yeniden daxil edin");
                   num1 = Console.ReadLine();
                   num2 = Console.ReadLine();
               }


               int.TryParse(num1, out number1);
               int.TryParse(num2, out number2);
               int result = number1 + number2;

               if (result % 2 == 0)
               {
                   Console.WriteLine("cem cut ededdir");
               }
               else
               {
                   Console.WriteLine("Cem tek ededdir");
               }


               // Task 2

               int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
               for (int i = 0; i < num.Length; i++)
               {
                   if (num[i] % 2 == 0)
                   {
                       Console.WriteLine(num[i]);
                   }
               } 

            // Task 3
            
            int sum = 0;
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    sum += number[i];


                }
            }
            Console.WriteLine(sum);

            // Task 4


            int a = 1234;

            int a1 = a % 10;
            int a2 = (a % 100 - a1) / 10;
            int a3 = (a % 1000 - ((a2 * 10) + a1)) / 100;
           int a4 = (a / 1000);
          int result4 = a1 + a2 + a3 + a4;

            Console.WriteLine(result4);
            // Task 5

            telebe telebe = new telebe();
            telebe.name = "Aqsin";
            telebe.surname = "Abbaszade";
            telebe.age = 18;
            telebe.speciality = "Computer enginering";
            telebe.groupNo = 651;


            Console.WriteLine($" AD: {telebe.name} Soyad: {telebe.surname} Yasi:{telebe.age} Ixtisasi:{telebe.speciality} GrupNomrsi:{telebe.groupNo}");


















































        }
    }
}
