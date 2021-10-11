using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        class Angle                             // класс Angle
        {
            int gradus;                            // поле  gradus

            public int Sec { get; set; }        // открытое поле Sec
            public int Min { get; set; }        // открытое поле Min

            public int Gradus          // свойство для gradus
            {
                set
                {
                    if (value != 0)
                        gradus = value;
                    else
                        Console.WriteLine("Значение градусов не может быть нулевым");               // проба проверки
                }
                get
                { return gradus; }
            }

            public Angle(int gradus, int min, int sec) { Gradus = gradus; Min = min; Sec = sec; }  // 1 конструктор

            public Angle() { Gradus = 1; Min = 0; Sec = 0; }               // 2 конструктор

            public Angle(int gradus) { Gradus = gradus; Min = 0; Sec = 0; }     // 3 конструктор

            public void ToRadians()
            {
                double z_angle;
                if (gradus != 0)
                {
                    if (gradus > 0)
                        z_angle = gradus + (double)Sec / 3600 + (double)Min / 60;
                    else
                        z_angle = (double)-Sec / 3600 - (double)Min / 60 + gradus;
                    Console.WriteLine("Значение угла {0}°C {1}'{2}\" в радианах = {3,3:f5}", Gradus, Min, Sec,(z_angle * Math.PI) / 180);
                }
            }
            static void Main()
            {
                Console.WriteLine("1 способ");
                Angle my_angle1 = new Angle();      // создание экземпляра класса с помощью 2-го конструктора
                my_angle1.ToRadians();
                Console.WriteLine();
                
                Console.WriteLine("2 способ");
                Angle my_angle2 = new Angle(25);      // создание экземпляра класса с помощью 3-го конструктора
                my_angle2.ToRadians();
                Console.WriteLine();
                
                Console.WriteLine("3 способ");
                Angle my_angle3 = new Angle(10, 1, 1);      // создание экземпляра класса с помощью 1-го конструктора
                my_angle3.ToRadians();
                Console.WriteLine();

                Console.WriteLine("4 способ");
                Angle my_angle4 = new Angle();              // создание экземпляра класса с помощью 2-го конструктора
                my_angle4.Gradus = 90;
                my_angle4.Min = 10;
                my_angle4.Sec = 0;
                my_angle4.ToRadians();

                Console.WriteLine();
                Console.WriteLine("5 способ");
                Console.WriteLine("Введите значение градусов");
                int gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение минут");
                int seconds = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение секунд");
                int minutes = Convert.ToInt32(Console.ReadLine());
                Angle my_angle5 = new Angle(gradus,seconds,minutes);      // создание экземпляра класса с помощью 1-го конструктора, ввод данных
                my_angle5.ToRadians();

                Console.ReadKey();

            }



        }
    }
}






