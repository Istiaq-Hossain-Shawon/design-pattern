using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_method_pattern.Base;

namespace template_method_pattern.Concrete
{
    public sealed class AlgorithmA : AlgorithmBase
     {
         public override bool OperationA()
         {
             Console.WriteLine("Inside OperationA() of AlgorithmA");
             return true;
         }
         public override bool OperationB()
         {
             Console.WriteLine("Inside OperationB() of AlgorithmA"); 
             return true;
         }
         public override bool OperationC()
         {
             Console.WriteLine("Inside OperationC() of AlgorithmA");
             return true;
         }
    }
}
