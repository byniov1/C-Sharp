namespace _10_Struct
{

    /*Struct
    public struct Point
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //public int X;
        //public int Y;

        // It’s a common practice to make structs immutable
        // by declaring all fields as readonly and providing only
        // get accessors for properties.
        // Dla tego zakomentowałem poprzednie propy i pola
        //public int Id { get;}
        //public int X { get; }
        //public int Y { get; }


        //Ale do zademonstrowanie różnic między klasą a struct damy możliwośc ustawiania, i wywale prop ID
        public int X { get; set; }
        public int Y { get; set; }

        //public Point(int id, int x, int y)
        public Point(int x, int y)
        {
            //Id = id;
            X = x;
            Y = y;
        }

        public void Display()
        {
            //Console.WriteLine($"Point {Id}: ({X}, {Y})");
            Console.WriteLine($"Point: ({X}, {Y})");
        }

        public double DistanceTo(Point other)
        { 
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }


        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }*/

    
    /*Enum
    enum DaysOfWeek { Sunday,Monday,Tuesday,Wednesday,Thursday,Friday, Saturday }

    enum MonthsOfYear
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July = 20,
        August,
        September,
        October,
        November,
        December
    }*/


    public class DateTimeCustom
    {
        public DateTime GetTommorow()
        {
            DateTime today = DateTime.Today;
            return today.AddDays(1);
        }

        public DateTime GetFirstDayOfYear(int year) 
        {
            return new DateTime(year, 1, 1);
        }
    }

    internal class Program
    {
        /*Struct
        //static void Main(string[] args)
        //{
        //     Point p0 = new Point();
        //       Point p1 = new Point(10, 20);

        //       p0.Display();
        //       p1.Display();


        //       Point p2;
        //       p2.X = 30;
        //       p2.Y = 40;
        //       p2.Display();


        //       Point p3 = p1;
        //       p3.X = 50;
        //       p3.Y = 60;
        //       p1.Display();
        //       p3.Display();
        //    

        //               Point p0 = new Point();
        //                Point p1 = new Point(1, 10, 20);
        //                Point p2 = new Point(2, 30, 40);
        //                p0.Display();
        //                p1.Display();
        //                p2.Display();


        //                Point p3 = p1;
        //                p1.Display();
        //                Console.Write("This is P3: ");
        //                p3.Display();

        //                double distance = p1.DistanceTo(p2);
        //                Console.WriteLine($"Distance between point: {distance:F10}");
*/


        /*Differences between structs and classes
        =============== =============== =============== =============== =============== ===============
        //    Point p1 = new Point(10, 20);
        //    p1.Display();

        //    Point p2 = p1; // p2 is a copy of p1
        //    p2.Display();
        //    p2.X = 25; // Changes p2, p1 remains unchanged
        //    Console.WriteLine("After changing p2.X to 25");
        //    p1.Display();
        //    p2.Display();

        //    Console.WriteLine("NOW COME THE CLASS OBJECTS");
        //    PointClass pC1 = new PointClass(1, 2);
        //    PointClass pC2 = pC1; // pC2 is a reference to the same object as pC1
        //    pC1.Display();
        //    pC2.Display();


        //    pC2.X = 3; // Changes p1.X as well, since p1 and p2 reference the same object
        //    Console.WriteLine("After changing pC2.X to 3");
        //    pC1.Display();
        //    pC2.Display();

        //    bool isEqual = pC1.Equals(pC2);
        //    Console.WriteLine("is it equal?" + isEqual);
        //    Console.ReadKey();
        //}*/


        /* Enums 
        //static void Main(string[] args)
        //{
        //    DaysOfWeek fr = DaysOfWeek.Friday;
        //    DaysOfWeek su = DaysOfWeek.Sunday;

        //    DaysOfWeek a = DaysOfWeek.Friday;

        //    Console.WriteLine($"Is a fr == a {fr == a}");
        //    Console.WriteLine($"DaysOfWeek.Monday: {DaysOfWeek.Monday}");
        //    Console.WriteLine($"(int)DaysOfWeek.Monday: {(int)DaysOfWeek.Monday}");


        //    Console.WriteLine($"(int)MonthsOfYear.August: {(int)MonthsOfYear.August}");
        //}
        */

        static void Main(string[] args)
        {
            /*DateTime*/
            //DateTime dateTime0 = new DateTime();
            //Console.WriteLine($"0 {dateTime0}");

            DateTime dateTime = new DateTime(1997, 12, 8);
            Console.WriteLine($"My brthday is {dateTime}");

            //Write today on screnn
            Console.WriteLine(DateTime.Today);

            //Write current time on screnn
            Console.WriteLine(DateTime.Now);

            DateTimeCustom dateTimeCustom = new DateTimeCustom();
            Console.WriteLine("Tommor will be " + dateTimeCustom.GetTommorow());

            Console.WriteLine("Todays is the " + DateTime.Today.DayOfWeek);
            Console.WriteLine("First Day of year" + dateTimeCustom.GetFirstDayOfYear(1999));
            Console.WriteLine("First Day of year" + dateTimeCustom.GetFirstDayOfYear(1999).DayOfWeek);

            int days = DateTime.DaysInMonth(2023, 2);
            Console.WriteLine($"Days in month: {days}");

            DateTime dateTime1 = DateTime.Now;
            Console.WriteLine(dateTime1.Minute);

            DateTime dateTime2 = DateTime.Now;
            Console.WriteLine(dateTime2.Hour + dateTime2.Minute + dateTime2.Second);


            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out DateTime dateTime3))
            {
                Console.WriteLine(dateTime3);
                TimeSpan daysPassed = DateTime.Now.Subtract(dateTime3);
                Console.WriteLine("Days passed singe " + daysPassed.Days);
            }
            else
            { 
                Console.WriteLine("Wrong input");
            }
        }

    }
}
