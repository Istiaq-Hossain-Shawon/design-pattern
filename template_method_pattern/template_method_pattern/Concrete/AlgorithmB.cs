using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_method_pattern.Base;

namespace template_method_pattern.Concrete
{
   public sealed class AlgorithmB : AlgorithmBase
     {
         public override bool OperationA()
         {
             Console.WriteLine("Inside OperationA() of AlgorithmB");
             return true;
         }
         public override bool OperationB()
         {
             Console.WriteLine("Inside OperationB() of AlgorithmB");
             return true;
         }
         public override bool OperationC()
         {
             Console.WriteLine("Inside OperationC() of AlgorithmB");
             return true;
         }
     }
}
