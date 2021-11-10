using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleCop
{
    public class Actions
    {
        private Logger _log;

        public Actions()
        {
            _log = Logger.GetInstance();
        }

        public Result FirstMethod()
        {
            Result.Message = $"Start method: FirstMethod()";
            Result.Status = true;
            _log.Print(TypeLog.Info, Result.Message);
            return new Result();
        }

        public Result SecondMethod()
        {
            Result.Message = $"Scipped logic in method: SecondMethod()";
            Result.Status = true;
            _log.Print(TypeLog.Warning, Result.Message);
            return new Result();
        }

        public Result ThirdMethod()
        {
            Result.Message = $"I broke a logic";
            Result.Status = false;
            return new Result();
        }
    }
}
