using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.Core.ExtentionMthods
{
    public static class GeneratCode
    {
        public static string GuidCode()
        {
            return Guid.NewGuid().ToString().Replace("-","");
        }
    }
}
