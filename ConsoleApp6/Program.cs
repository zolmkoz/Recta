using System;

namespace Rectangle
{
    class Rectangle
    {
        private int _len;
        private int _width;

        public float Len
        {
            get
            {
                return _len;
            }
            set
            {
                if (value > 0)
                    _len = value;
                else
                    Console.WriteLine("Length must be greater than 0");
            }
        }

        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                    _width = value;
                else
                    Console.WriteLine("Width must be greater than 0");
            }
        }
        public Rectangle(float len, float width)
        {
            Len = 1;
            Width = 1;
        }
        public  Rectangle(float len, float width)
        {
            Len = len;
            Width = width;
        }
        public float Perimetter(float len, float width)
        {
            return (len + width) * 2;
        }
        public float Area(float len, float width)
        {
            return (len * width);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();

            Console.WriteLine("Area of rectanle is {0}",R.Area(R.Len, R.Width));
            Console.WriteLine("Perimetter of retangle is {0}", R.Perimetter(R.Len, R.Width));

            Console.WriteLine("Enter length, please:");
            float len = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter width, please:");
            float width = float.Parse(Console.ReadLine());

            Rectangle R1 = new Rectangle(len, width);

            Console.WriteLine("Area of rectangle is {0}", R1.Area(R1.Len, R1.Width));
            Console.WriteLine("Peritmetter of rectangle is {0}", R1.Perimetter(R1.Len, R1.Width));

            Console.ReadLine();
        }
    }
}
