using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LAB_3_Bulygina;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание на лабораторную работу №3
            //Разработать программу(отдельный проект в рамках решения включающего проекты ЛР1 и ЛР2), реализующую работу с коллекциями.
            //+ 1.Программа должна быть разработана в виде консольного приложения на языке C#.
            //+ 2.Объекты классов «Прямоугольник», «Квадрат», «Круг» использовать из проекта лабораторной работы №2.
            //+ 3.Для реализации возможности сортировки геометрических фигур для класса «Геометрическая фигура» добавить реализацию интерфейса IComparable. Сортировка производится по площади фигуры.
            //+ 4.Создать коллекцию класса ArrayList.Сохранить объекты(типы) Прямоугольник, Квадрат, Круг, в коллекцию. Вывести в цикле содержимое площади элементов коллекции.
            //+ 5.Создать коллекцию класса List<Figure>.Сохранить объекты в коллекцию. Отсортировать коллекцию. Вывести в цикле содержимое коллекции.
            //+ 6.Модифицировать класс разреженной матрицы(проект SparseMatrix) для работы с тремя измерениями – x,y,z.Вывод элементов в методе ToString() осуществлять в том виде, который Вы считаете наиболее удобным. Разработать пример использования разреженной матрицы для геометрических фигур.
            //+ 7.Реализовать класс «SimpleStack» на основе односвязного списка. Класс SimpleStack наследуется от класса SimpleList(проект SimpleListProject). Необходимо добавить в класс методы:
            //⦁    public void Push(T element) – добавление в стек;
            //⦁    public T Pop() – чтение с удалением из стека.
            //+ 8.    Пример работы класса SimpleStack реализовать на основе геометрических фигур.


            Console.WriteLine("Лабораторная работа №3");
            Console.Title = "Дубянский А. И., ИУ5Ц-51Б";


            // Объект класса Rectangle
            Rectangle rect = new Rectangle(2, 4);
            rect.Print();

            // Объект класса 
            Square square = new Square(5);
            square.Print();

            // Объект класса 
            Circle circle = new Circle(3);
            circle.Print();

            //коллекция класса ArrayList
            ArrayList figures = new ArrayList();
            figures.Add(circle);
            figures.Add(rect);
            figures.Add(square);
            Console.WriteLine("\nДо сортировки для ArrayList");
            foreach (var i in figures)
            {
                Console.WriteLine(i);
            }
            figures.Sort();
            Console.WriteLine("\nПосле сортировки для ArrayList");
            foreach (var i in figures)
            {
                Console.WriteLine(i);
            }

            //коллекция класса List<Figure>
            List<Figure> figures1 = new List<Figure>();
            figures1.Add(circle); //добавление в коллекцию
            figures1.Add(rect);
            figures1.Add(square);
            Console.WriteLine("\n\nДо сортировки для List<Figure>:");
            foreach (var i in figures1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nПосле сортировки для List<Figure>:");
            figures1.Sort();
            foreach (var i in figures1)
            {
                Console.WriteLine(i);
            }

            //создание разреженной матрицы
            Console.WriteLine("\n\nМатрица:");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0] = rect;
            matrix[1, 1] = square;
            matrix[2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            //использование коллекции SimpleList
            SimpleList<Figure> list = new SimpleList<Figure>();
            list.Add(circle);
            list.Add(rect);
            list.Add(square);
            Console.WriteLine("\n\nПеред сортировкой (SimpleList):");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            list.Sort();
            Console.WriteLine("\n\nПосле сортировки (SimpleList):");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

            //использование собственного стека
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(circle);
            stack.Push(rect);
            stack.Push(square);
            Console.WriteLine("\n\nИспользование стека:");
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}