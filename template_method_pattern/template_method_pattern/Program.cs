using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_method_pattern.Base;
using template_method_pattern.Concrete;

namespace template_method_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorithmBase obj1 = new AlgorithmA();
            obj1.TemplateMethod();
            AlgorithmBase obj2 = new AlgorithmB();
            obj2.TemplateMethod();
            Console.Read();
        }
        
    }
}
