using System;

namespace StyleCop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger log = Logger.GetInstance();
            log.Print(TypeLog.Warning, "Something happen");
            log.Print(TypeLog.Info, "Something happened!!!");
            log.Print(TypeLog.Error, "Sg happen");
            log.Print(TypeLog.Warning, "Something happen");

            log.GetInfo();

            // Logger.Print();
        }
    }
}
