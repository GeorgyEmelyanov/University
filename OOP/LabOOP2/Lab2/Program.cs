using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ComplexNumber
    {
        private double _RealPart, _ImaginaryPart;
        public ComplexNumber (double RealPart, double ImgPart)
        {
            _RealPart = RealPart;
            _ImaginaryPart = ImgPart;
        }

        public static ComplexNumber operator +(ComplexNumber v1, ComplexNumber v2)
        {
            return new ComplexNumber(v1._RealPart + v2._RealPart, v1._ImaginaryPart + v2._ImaginaryPart);
        }

        public static ComplexNumber operator +(ComplexNumber v1, double v2)
        {
            return new ComplexNumber(v1._RealPart + v2, v1._ImaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber v1, ComplexNumber v2)
        {
            return new ComplexNumber(v1._RealPart - v2._RealPart, v1._ImaginaryPart - v2._ImaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber v1, double v2)
        {
            return new ComplexNumber(v1._RealPart - v2, v1._ImaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber v1, double v2)
        {
            return new ComplexNumber(v1._RealPart * v2, v1._ImaginaryPart * v2);
        }

        public override string ToString()
        {
            return $"{_RealPart} + ({_ImaginaryPart})i";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все действия будут реализовываться c первым комплексным числом!\n");

            Console.WriteLine("Введите действительную часть первого комплексного числа");
            double RealV1 = 0;
            string str = "";
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = double.TryParse(str, out RealV1);
                if (check)
                    break;
                else
                    str = "";
                Console.WriteLine("Введите число!");
            }

            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            double ImgV1 = 0;
            str = "";
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = double.TryParse(str, out ImgV1);
                if (check)
                    break;
                else
                    str = "";
                Console.WriteLine("Введите число!");
            }


            Console.WriteLine("Введите действительную часть второго комплексного числа");
            double RealV2 = 0;
            str = "";
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = double.TryParse(str, out RealV2);
                if (check)
                    break;
                else
                    str = "";
                Console.WriteLine("Введите число!");
            }

            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            double ImgV2 = 0;
            str = "";
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = double.TryParse(str, out ImgV2);
                if (check)
                    break;
                else
                    str = "";
                Console.WriteLine("Введите число!");
            }

            Console.WriteLine("Введите вещественное число");
            double V3 = 0;
            str = "";
            while (str == "")
            {
                str = Console.ReadLine();
                bool check = double.TryParse(str, out V3);
                if (check)
                    break;
                else
                    str = "";
                Console.WriteLine("Введите число!");
            }

            var V1 = new ComplexNumber(RealV1, ImgV1);
            var V2 = new ComplexNumber(RealV2, ImgV2);


            int action = -1;
            while (action!=0)
            {
                Console.WriteLine("Выберите действие:\n 0. Выход из программы \n 1. Сложение \n 2. Вычитание \n 3. Умножение на вещественное число");
                str = "";
                while (str == "")
                {
                    str = Console.ReadLine();
                    bool check = Int32.TryParse(str, out action);
                    if ((check)&&(action>=0)&&(action<=3))
                        break;
                    else
                        str = "";
                    Console.WriteLine("Введите число от 0 до 3!");
                }

                switch (action)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            Console.WriteLine("Выберите с каким числом складывать: \n 1. Комплексное \n 2. Вещественное");
                            int ch = 0;
                            str = "";
                            while (str == "")
                            {
                                str = Console.ReadLine();
                                bool check = Int32.TryParse(str, out ch);
                                if ((check) && (ch >= 1) && (ch <= 2))
                                    break;
                                else
                                    str = "";
                                Console.WriteLine("Введите число от 1 до 2!");
                            }
                            if (ch == 1)
                                Console.WriteLine(V1 + V2);
                            else
                                Console.WriteLine(V1 + V3);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Выберите какое число будете вычитать: \n 1. Комплексное \n 2. Вещественное");
                            int ch = 0;
                            str = "";
                            while (str == "")
                            {
                                str = Console.ReadLine();
                                bool check = Int32.TryParse(str, out ch);
                                if ((check) && (ch >= 1) && (ch <= 2))
                                    break;
                                else
                                    str = "";
                                Console.WriteLine("Введите число от 1 до 2!");
                            }
                            if (ch == 1)
                                Console.WriteLine(V1 - V2);
                            else
                                Console.WriteLine(V1 - V3);
                        }
                        break;
                    case 3:
                        Console.WriteLine(V1 * V3);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
