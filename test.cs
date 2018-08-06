using System;
using System.Text;

namespace Sharp6Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo.X);
            

            Point p = new Point();
            Console.WriteLine(p.ToString());

            Console.WriteLine(++Bob<int>.Count); // 1
            Console.WriteLine(++Bob<int>.Count); // 2
            Console.WriteLine(++Bob<string>.Count); // 1
            Console.WriteLine(++Bob<object>.Count); // 1

            Console.ReadLine();
        }
    }

    class Bob<T> { public static int Count; }

    class Foo
    {
        public static Foo Instance = new Foo();
        public static int X = 3;

        //static Foo()
        Foo()
        {
            Console.WriteLine(X);
        }
    }

    // 0
    // 3

    public struct Point
    {
        int x, y;
        public Point(int x, int y) { this.x = x; this.y = y; }
        public new string ToString() { return new StringBuilder($"Point x:{this.x}, y:{this.y}").ToString(); }
    }
}
