using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace CduetzalDestok
{
    internal class APIService
    {
        private string URLBASE = "https://cdserver-r54a.vercel.app/";
        private static readonly HttpClient client = new HttpClient();

        public APIService() {}
        public int GetData()
        {
            return 1;        
        }
        public int GetCount()
        {
            return 1;
        }
    }
}
