using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    public class DateWriterRepository : IDateWriterRepository
    {
        private IOutputRepository _output;
        public DateWriterRepository(IOutputRepository output)
        {
            _output = output;
        }
        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
