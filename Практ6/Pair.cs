using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Практ6
{
    internal class Pair
    {
        private int para1;
        private int para2;
        /// <summary>
        /// Класс для создания пары чисел и операции умножения над ними
        /// </summary>
        public int Para1
        {
            get
            {
                return para1;
            }
            set
            {
                if (value!=0 && value % 2 == 0)
                {
                    para1 = value;
                }
                else
                {
                    MessageBox.Show("Первое число в паре не четное");
                }

            }
        }
        public int Para2
        {
            get
            {
                return para2;
            }
            set
            {
                if (value!=0 && value % 2 == 0)
                {
                    para2 = value;
                }
                else
                {
                    MessageBox.Show("Второе число в паре не четное");
                }
            }
        }
        /// <summary>
        /// Умножение эллементов пары (a,b)=(a*b)
        /// </summary>
        /// <param name="value1">Объект пары 1</param>
        /// <returns>result Возвращаемое значение операции произведения одной пары</returns>
        public Pair multiplication(Pair value1)
        {
            Pair result = new Pair();
            result.para1 = value1.Para1 * value1.Para2;
            return result;

        }
        /// <summary>
        /// Операция произведения значений двух пар (a,b) * (c,d) = (a*c);(b*d)
        /// </summary>
        /// <param name="value1">Объект пары 1</param>
        /// <param name="value2">Объект пары 2</param>
        /// <returns>Возвращаемое значение result результат операции произведения двух пар</returns>
        public Pair multiplication(Pair value1, Pair value2)
        {
            Pair result = new Pair();
            result.para1 = value1.Para1 * value2.Para1;
            result.para2 = value1.Para2 * value2.Para2;
            return result;
        }
        /// <summary>
        /// Операция инкремента (a,b;b)=(a+b,b+b)
        /// </summary>
        /// <param name="value1">Объект пары 1</param>
        /// <param name="value2">Объект пары 2</param>
        /// <returns>Возвращаемое значение itog результат операции инкремента</returns>
        public static Pair operator ++(Pair value1)
        {
            Pair itog = new Pair();
            itog.para1 = value1.Para1 + value1.Para2;
            itog.para2 = value1.Para2;
            return itog;
        }
        public static Pair operator *(Pair value1, Pair value2)
        {
            Pair itog = new Pair();
            itog.para1 = value1.Para1 * value2.Para1;
            itog.para2 = value1.Para2 * value2.Para2;
            return itog;
        }
    }
}
