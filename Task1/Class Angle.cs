using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Class_Angle
    {
        public int gradus;
        public int minutes;
        public int second;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value > -360 || value > 360)
                {
                    Console.WriteLine("Значение не корректное");
                }
                else
                {
                    gradus = value;
                }
            }
        }
         public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Значение не корректное");
                }
                else
                {
                    minutes = value;
                }
            }
         }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Значение не корректное");
                }
                else
                {
                    second = value;
                }
            }
        }
            public Class_Angle(int gradus, int minutes, int second)
            {
            this.Gradus = gradus;
            this.Minutes = minutes;
            this.Second = second;
            }

        public Class_Angle()
        {
        }

        public double ConvertToRadians(double angle)
            {
            return (Math.PI / 180) * angle;
            }
    }
}