using DreamSale.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamSale.Core.DataSetting;

namespace ConsoleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineContext.Initialize(false);
            var settings = EngineContext.Current.Resolve<DataSettings>();
            if (settings != null && settings.IsValid())
            {
            }
        }
    }
}
