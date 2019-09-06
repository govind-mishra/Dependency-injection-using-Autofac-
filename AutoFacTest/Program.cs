using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    class Program
    {

        private static IContainer Container { get; set; }
       

        static void Main(string[] args)
        {
            Container = CreateBuilderBaseClass.createBuilderforDependecy();
            WriteDate();
            Console.ReadKey();
        }

        public static void WriteDate()
        {
            
                var writer = Container.Resolve<IDateWriterRepository>();
                writer.WriteDate();
            
        }

    }

    
}
