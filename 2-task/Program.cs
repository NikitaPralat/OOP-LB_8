using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Напишите дату откуда начнется отчет");

                Console.WriteLine("Напишите месяц от 1 до 12");
                int month = Convert.ToInt32(Console.ReadLine());
                while (month < 1 || month > 12)
                {
                    Console.WriteLine("Напишите месяц от 1 до 12");
                    month = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Напишите день с 1 до 30");
                int day = Convert.ToInt32(Console.ReadLine());
                while (day < 1 || day > 30)
                {
                    Console.WriteLine("Напишите день с 1 до 30");
                    day = Convert.ToInt32(Console.ReadLine());
                }

                string date = $"{nToString(day)}.{nToString(month)}";

                DateWork dateWork = new DateWork(day, month, date);

                Console.WriteLine($"Напишите день каторый будет добавлен к дате {date}");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dateWork[index]);
            }
            catch
            {
                Console.WriteLine("Значение должно быть числом");
            }
        }
        static string nToString(int n)
        {
            if (n < 10)
                return $"0{n}";
            else
                return $"{n}";
        }
    }
    
    class DateWork
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public string DateFrom { get; set; }
        public DateWork(int day, int month, string date)
        {
            DateFrom = date;
            Day = day;
            Month = month;
        }
        public string this[int index]
        {
            get
            {
                
                int newMonth = (Day + index) / 30 + Month;
                int newDay = 0;
                int f = Day + index;
                if (f - 30 > 0)
                {
                    do
                    {
                        f -= 30;
                    }
                    while (f > 30);
                    newDay = f;
                }
                else
                {
                    newDay = Day + index;
                }
                
                return $"{nToString(newDay)}.{nToString(newMonth)}";
            }
        }

        private string nToString(int n)
        {
            if (n < 10)
                return $"0{n}";
            else
                return $"{n}";
        }
    }
}
