using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Common.Interfaces;

namespace MVC.Common.Classes
{
    public class DBRepo : IMVCDBRepo
    {
        public SomeDTO GetSomeData()
        {
            return new SomeDTO {Name = "Colin"};
        }
    }
}
