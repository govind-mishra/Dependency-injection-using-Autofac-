using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    public class OutputRepository : IOutputRepository
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
