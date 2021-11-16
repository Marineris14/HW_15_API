using System;

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
