using System;
using System.Data;

namespace ежедневник
{
    internal class Program
    {
        public static void Main()
        {
            Arrows(1,1);
        }
        public static void Arrows(int position, int daypos)
        {

            position = 1;

            ConsoleKeyInfo key = Console.ReadKey();

            DateTime date = DateTime.Now;

            while (key.Key != ConsoleKey.Escape)
            {

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    daypos--;
                    date = date.AddDays(-1);

                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    daypos++;
                    date = date.AddDays(1);

                }
                Console.Clear();

                switch (daypos)
                {
                    case 0:
                        {
                            date = DateTime.Now;
                            Console.WriteLine("Выбрана дата: " + date);
                            Menu();
                            if (key.Key == ConsoleKey.Enter)
                            {

                                if (position == 1)
                                {
                                    Console.Clear();
                                    subMenu("  Прийти на пары", "  Послушать Владлена Ивановича", 0);

                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    subMenu("  Пойти в столовку с друзьями", "  Скушать сэндвич и попить чая", 0);

                                }
                            }
                        }
                        break;
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата: " + date);
                            Menu3();

                            if (key.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                if (position == 1)
                                {
                                    subMenu("  Код будущего", "  Сделать презентацию", +1);

                                }
                                else if (position == 2)
                                {
                                    subMenu("  Выспаться", "  Прийти домой, заварить чай и выучить все лекции", +1);
                                }
                            }
                        }
                        break;
                    case -1:
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата: " + date);
                            Menu2();
                            if (key.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                if (position == 1)
                                {
                                    subMenu("  Сходить к врачу", "  Взять с собой паспорт, рецепт и подойти к 245 кабинету в 13:00", -1);

                                }

                            }
                        }
                        break;
                    default:
                        { Console.WriteLine("Выбрана дата: " + date); }
                        break;

                }

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }

        }

        public static void Menu()
        {
            Class1 note = new Class1();

            note.Title = "  Прийти на пары";
            note.Description = "  Послушать Владлена Ивановича";

            Class1 note2 = new Class1();

            note2.Title = "  Пойти в столовку с друзьями";
            note2.Description = "  Скушать сэндвич и попить чая";
            List<Class1> dateTimes = new List<Class1>()
            {
                note,note2
            };

            foreach (var date in dateTimes)
            {
                Console.WriteLine(date.Title);
            }
        }
        public static void Menu2()
        {
            Class1 note3 = new Class1();

            note3.Title = "  Сходить к врачу";
            note3.Description = "  Взять с собой паспорт, рецепт и подойти к 245 кабинету в 13:00";
            List<Class1> dateTimes = new List<Class1>() { note3 };

            foreach (var date in dateTimes)
            {
                Console.WriteLine(date.Title);
            }

        }
        public static void Menu3()
        {
            Class1 note4 = new Class1();

            note4.Title = "  Код будущего";
            note4.Description = "  Сделать презентацию";

            Class1 note5 = new Class1();

            note5.Title = "  Выспаться";
            note5.Description = "  Прийти домой, заварить чай и выучить все лекции";
            List<Class1> dateTimes = new List<Class1>()
            {
                note4,note5
            };

            foreach (var date in dateTimes)
            {
                Console.WriteLine(date.Title);
            }

        }
        public static void subMenu(string name, string description, int trt)
        {

            Class1 note1 = new Class1();
            DateTime DayMonthYear = DateTime.Now;
            note1.Title = name;

            note1.Description = description;
            List<Class1> lazy = new List<Class1>()
            {
                note1
            };

            foreach (var Date in lazy)
            {
                Console.WriteLine(Date.Title);
                Console.WriteLine("------------------");
                Console.WriteLine(Date.Description);
                Console.WriteLine(DayMonthYear.AddDays(trt));

            }
        }
    }
}