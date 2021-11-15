using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_API
{
    class Helper
    {
        public string GenerateEmail()
        {
            string data = DateTime.Now.ToString("yyyyMMddHHmmss");
            return data + "@test.com";
        }

        public string GenerateName()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + "Name";
        }
    }
}
