using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    /// Класс Круг
    class Circle : Figure, Interface1
    {
        /// Радиус
        //protected double Radius;
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { this._Radius = value; }
        }

        /// Конструктор
        public Circle(double radius)
        {
            this.Radius = radius;
            this.Type = "Круг";
        }

        /// Площадь Круга
        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        ///// Переопределенный метод преобразования в строку
        //public override string ToString()
        //{
        //    return "Круг: радиус = " + this.Radius + "; площадь = " + this.Area();
        //}

        /// Метод вывода на консоль
        public void Print()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("Радиус круга: " + this.Radius);
            Console.WriteLine(this.ToString());
        }

    }
}