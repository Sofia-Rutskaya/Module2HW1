using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StyleCop
{
    public class Starter
    {
        private Random _rand;
        private Actions _actions;
        private Logger _log;

        public Starter()
        {
            _actions = new Actions();
            _log = Logger.GetInstance();
            _rand = new System.Random();
        }

        public void Run()
        {
           for (int i = 0; i < 100; i++)
            {
                var a = _rand.Next(4);
                if (a == 0)
                {
                    _actions.FirstMethod();
                }
                else if (a == 1)
                {
                    _actions.SecondMethod();
                }
                else if (a == 3)
                {
                    _actions.ThirdMethod();
                }

                if (Result.Status == false)
                {
                    _log.Print(TypeLog.Error, "Action failed by a reason:" + Result.Message);
                }
           }

           File.WriteAllText("log.txt", _log.GetInfo());
        }
    }
}
