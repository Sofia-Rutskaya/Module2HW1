using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace StyleCop
{
    public class Logger
    {
        private static Logger instance;
        private DateTime _date1;
        private StringBuilder _information;

        private Logger()
        {
            _information = new StringBuilder("\n");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Print(TypeLog lof, string message)
        {
            _date1 = DateTime.Now;
            Console.WriteLine($"{_date1}: {lof}: {message}");
            SaveInfo(_date1, lof, message);
        }

        public void SaveInfo(DateTime date, TypeLog lof, string message)
        {
           _information.Append($"{_date1}: {lof}: {message}\n");
        }

        public void GetInfo()
        {
            Console.WriteLine(_information);
        }
    }
}
