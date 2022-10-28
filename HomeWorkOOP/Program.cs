using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            string path = "C://Users//apers//OneDrive//Рабочий стол//OOP.txt";
            StreamReader f = new StreamReader(path);
            
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                list.Add(s);
                
                
            }
            f.Close();
            string[] val1 = list[0].Split(' ');
            string[] val2= list[1].Split(' ');
            string[] val3 = list[2].Split(' ');
            string[] val4 = list[3].Split(' ');
            string[] val5 = list[4].Split(' ');
            String j = " "; j = String.Join(j, val2, 1, 2);
            String j1 = " "; j1 = String.Join(j1, val3, 1, 2);
            String j2 = " "; j2 = String.Join(j2, val4, 1, 2);
            
            Submarine fleet1 = new Submarine(val1[0], val1[1], int.Parse(val1[2]), int.Parse(val1[3]), val1[4]);
            Submarine fleet2 = new Submarine(val2[0], j, int.Parse(val2[3]), int.Parse(val2[4]), val2[5]);
            AircraftCarrier fleet3 = new AircraftCarrier(val3[0], j1, int.Parse(val3[3]), int.Parse(val3[4]), int.Parse(val3[5]), int.Parse(val3[6]));
            Ship fleet4 = new Ship(val4[0], j2, int.Parse(val4[3]), int.Parse(val4[4]));
            Ship fleet5 = new Ship(val5[0], val5[1], int.Parse(val5[2]), int.Parse(val5[3]));
            fleet1.Info();
            fleet2.Info();
            fleet3.Info();
            fleet4.Info();
            fleet5.Info();

            fleet1.Port();
            fleet2.Port();
            fleet3.Port();
            fleet4.Port();
            fleet5.Port();
            


            Console.ReadKey();

        }
    }
    public abstract class Fleet
    {
        public string location { get; set; }
        public string name { get; set; }
        public int crew { get; set; }
        public string type { get; set; }

        

    }
    public class Submarine : Fleet
    {
        public int diving { get; set; }
        public string energy { get; set; }

        public Submarine(string loc, string n, int c, int Diving, string ener)
        {
            type = "Подводный транспорт";
            name = n;
            location = loc;
            crew = c;
            diving = Diving;
            energy = ener;
        }
        

        public void Info()
        {
            Console.WriteLine($"Характеристики:\nНазвание подводной лодки: {name}\nЛокация: {location} океан\nЭкипаж: {crew} человек\nТип: {type}\nДвигатель: {energy}\nМаксимальна длина погружения: {diving} метров");
            Console.WriteLine();
        }
        int north = 0;
        int pacific = 0;
        int black = 0;
        public void Port(string a, string b)
        {
            
            for (int i = 0; i < 2; i++)
            {
                if (location == "Северный")
                {
                    north++;
                }
                else if (location == "Тихий")
                {
                    pacific++;
                }
                else if (location == "Черноморский")
                {
                    black++;    
                }
                
            }
            Console.WriteLine($"Количество подводных лодок:\nСеверный океан: {north}\nТихий океан: {pacific}\nЧерное море: {black}");
            Console.WriteLine();
        }
    }
    public class Ship : Fleet
    {
        
        public int speed { get; set; }
        
        public Ship(string loc1, string n1, int c1, int s)
        {
            type = "Надводный транспорт";
            name = n1;
            location = loc1;
            crew = c1;
            speed = s;
        }
        public void Info()
        {
            Console.WriteLine($"Характеристики:\nНазвание корабля: {name}\nЛокация: {location} океан\nЭкипаж: {crew} человек\nТип: {type}\nСкорость: {speed} узлов");
            Console.WriteLine();
        }
        int north = 0;
        int pacific = 0;
        int black = 0;
        public void Port()
        {
            
            for (int i = 0; i < 2; i++)
            {
                if (location == "Северный")
                {
                    north++;
                }
                else if (location == "Тихий")
                {
                    pacific++;
                }
                else if (location == "Черноморский")
                {
                    black++;
                }
                
            }
            Console.WriteLine($"Количество кораблей:\nСеверный океан: {north}\nТихий океан: {pacific}\nЧерное море: {black}");
            Console.WriteLine();
        }
    }

    public class AircraftCarrier : Fleet
    {
        public int aircraft { get; set; }
        public int airstrip { get; set; }

        public AircraftCarrier(string loc1, string n1, int c1, int s, int airc, int airst)
        {
            type = "Надводный транспорт";
            name = n1;
            location = loc1;
            crew = c1;
            aircraft = airc;
            airstrip = airst;
        }
        public void Info()
        {
            Console.WriteLine($"Характеристики:\nНазвание авианосца: {name}\nЛокация: {location} океан\nЭкипаж: {crew} человек\nТип: {type}\nКоличество самолетов и вертолетов: {aircraft} штук\nДлина взлетной полосы: {airstrip} метров");
            Console.WriteLine();
        }
        int north = 0;
        int pacific = 0;
        int black = 0;
        public void Port()
        {
            
            for (int i = 0; i < 1; i++)
            {
                if (location == "Северный")
                {
                    north++;
                }
                else if (location == "Тихий")
                {
                    pacific++;
                }
                else if (location == "Черноморский")
                {
                    black++;
                }
                
            }
            Console.WriteLine($"Количество авианосцев:\nСеверный океан: {north}\nТихий океан: {pacific}\nЧерное море: {black}");
            Console.WriteLine();
        }
    }
}
