﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    partial class Matrix<T>
    {
        ///<summary>
        /// Словарь для хранения значений
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        ///<summary>
        ///Макс. количество столбцов
        /// </summary>
        int MaxX;

        ///<summary>
        ///Макс.количество строк
        ///</summary>
        int MaxY;

        ///<summary>
        ///Реализация интерфейса для проверки пустого элемента
        ///</summary>
        IMatrixCheckEmpty<T> checkEmpty;

        ///<summary>
        ///Конструктор
        /// </summary>
        public Matrix(int x, int y, IMatrixCheckEmpty<T> param)
        {
            this.MaxX = x;
            this.MaxY = y;
            this.checkEmpty = param;
        }

        ///<summary>
        ///Индексатор для доступа к данным
        /// </summary>
        public T this[int x, int y]
        {
            set
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                this._matrix.Add(key, value);
            }
            get
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.checkEmpty.getEmptyElement();
                }
            }
        }

        ///<summary>
        ///Проверка границ
        ///</summary>
        void CheckBounds(int x, int y)
        {
            if (x < 0 || x > this.MaxX)
            {
                throw new ArgumentOutOfRangeException("x", "x =" + x + " выходит за границы");
            }
            if (y < 0 || y > this.MaxY)
            {
                throw new ArgumentOutOfRangeException("y", "y = " + y + "выходит за границы");
            }
        }

        ///<summary>
        ///Формирование ключа
        /// </summary>
        string DictKey(int x, int y)
        {
            return x.ToString() + " " + y.ToString();
        }

        ///<summary>
        ///Преобразование ToString() по строке
        /// </summary>
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            for (int j = 0; j < this.MaxY; j++)
            {
                b.Append("[");
                for (int i = 0; i < this.MaxX; i++)
                {
                    if (i > 0)
                    {
                        b.Append("\t");
                    }
                    //если элемент не пустой
                    if (!this.checkEmpty.CheckEmptyElement(this[i, j]))
                    {
                        //добавить этот элемент, преобразованный в строку
                        b.Append(this[i, j].ToString());
                    }
                    //иначе добавить "пусто"
                    else
                    {

                        b.Append(" - ");
                    }
                }
                b.Append("]\n");
            }
            return b.ToString();
        }

    }
}