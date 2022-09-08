

    public class HW3
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("INPUT Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("INPUT Number:");
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Owner Name:");
            string OW = Console.ReadLine();
            Console.WriteLine("INPUT Number:");
            int Value = int.Parse(Console.ReadLine());
            Console.WriteLine("---------Shop Information----------");
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Number:{0}", Num);
            Console.WriteLine("Owner Name:{0}", OW);
            Console.WriteLine("Registered Value:{0}", Value);
            Console.WriteLine("------------------------------------");
           Console.WriteLine("Please input money:");
        double input = double.Parse(Console.ReadLine());
        shop(input);

        }
        public static double[] shop(double input) 
        
    {
            double money;
            double percentage;
            double thousand;
            double fivehundred;
            double hundred;
            double fifty;
            double twenty;
            double ten;
            double five;
            double two;
            double one;
            double fiftysatang;
            double twentyfivesatang;


            thousand = input / 1000;
            money = input % 1000;

            fivehundred = money / 500;
            money = money %  500; 
            
            hundred = money / 100;
            money = money % 100; 

            fifty = money / 50;
            money = money % 50;

            twenty = money / 20;
            money = money % 20;

            ten = money / 10;
            money = money % 10;

            five = money / 5;
            money = money % 5;

            two = money / 2;
            money = money % 2;

            one = money / 1;

            fiftysatang = money /.50;
            money = money % .50;

            twentyfivesatang = money / .25;
            money = money % .25;





            
            Console.WriteLine(string.Format("1000:{0}", Math.Floor (thousand)));
            Console.WriteLine(string.Format("500:{0}", Math.Floor (fivehundred)));
            Console.WriteLine(string.Format("100:{0}", Math.Floor (hundred)));
            Console.WriteLine(string.Format("50:{0}", Math.Floor (fifty)));
            Console.WriteLine(string.Format("20:{0}", Math.Floor (twenty)));
            Console.WriteLine(string.Format("10:{0}", Math.Floor (ten)));
            Console.WriteLine(string.Format("5:{0}", Math.Floor (five)));
            Console.WriteLine(string.Format("2:{0}", Math.Floor (two)));
            Console.WriteLine(string.Format("1:{0}", Math.Floor (one)));
            Console.WriteLine(string.Format("0.5:{0}", Math.Floor (fiftysatang)));
            Console.WriteLine(string.Format("0.25:{0}", Math.Floor (twentyfivesatang)));
            double[] Answer={Math.Floor(thousand),Math.Floor(fivehundred),Math.Floor(hundred),Math.Floor(fifty),Math.Floor(twenty),
            Math.Floor(ten),Math.Floor(five),Math.Floor(two),Math.Floor(one),Math.Floor(fiftysatang),Math.Floor(twentyfivesatang)};
            return Answer;
        }
        }
    
    
