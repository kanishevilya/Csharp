using System.Numerics;

using classWork_9_10;
namespace classwork_9_10
{
    public class Program
    {
        //private static string str = "Hello";
        //private static int number_1 = 1, number_2 = 2;
        //private static bool value = false;

        public static void Main(string[] args)
        {
            Director director = new Director("John", "Smith", new DateTime(1990, 06, 13), "Director", 10000);
            IWorker seller = new Seller("Nick", "Grid", new DateTime(1995, 04, 15), "Seller", 4444);
            IWorker cashier = new Cashier("Jotaro", "Kujo", new DateTime(1992, 03, 11), "Cashier", 6444);
            IWorker storeKeeper = new StoreKeeper("Jorno", "Jovanna", new DateTime(1998, 03, 21), "StoreKeeper", 7444);
            director.Workers.Add(seller);
            director.Workers.Add(cashier);
            director.Workers.Add(storeKeeper);

            foreach(var worker in director.Workers)
            {
                if (worker.IsWorkin)
                {
                    Console.WriteLine(worker.Work());
                }
            }
            Console.WriteLine();

            //foreach (var item in director.Workers)
            //{
            //    if(item is Cashier)
            //    {
            //        (item as Cashier).goToHome();
            //    }
            //    Employee employee = item as Employee;
            //    employee.goToHome();
            //    employee.goToHome(true);
            //}
            Console.WriteLine((seller as Employee).Compare(seller, cashier));

        }
    }
    
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x=0, int y=0)
        {
            X = x;
            Y = y;
        }

        public static Point operator ++(Point ptr)
        {
            ptr.X++;
            ptr.Y++;
            return ptr;
        }
        public static Point operator --(Point ptr)
        {
            ptr.X--;
            ptr.Y--;
            return ptr;
        }

        public static Point operator -(Point ptr)
        {
            return new Point(-ptr.X, -ptr.Y);
        }
        public static Point operator +(Point v1, Point v2)
        {
            return new Point(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Point operator *(Point v1, Point v2)
        {
            return new Point(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static bool operator==(Point point_1, Point point_2)
        {
            return point_1.X == point_1.X && point_1.Y == point_1.Y;
        }
        public static bool operator !=(Point point_1, Point point_2)
        {
            return !(point_1==point_2);
        }
        public static bool operator !(Point point_1)
        {
            if (point_1)
            {
                return false;
            }
            return true;
        }
        public static bool operator >(Point point_1, Point point_2)
        {
            return (point_1.X > point_2.X) && (point_1.Y > point_2.Y); 
        }
        public static bool operator <(Point point_1, Point point_2)
        {
            return (point_1.X < point_2.X) && (point_1.Y < point_2.Y);
        }
        public static bool operator true(Point point)
        {
            return point.X!=0 && point.Y!=0;
        }
        public static bool operator false(Point point)
        {
            return point.X == 0 || point.Y == 0;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Point)
            {
            Point checkPoint = obj as Point;
            return X==checkPoint.X && Y==checkPoint.Y;
            }
            return false; 
        }
        public override string ToString()
        {
            return $"x = {X} | y = {Y}";
        }
    }
}