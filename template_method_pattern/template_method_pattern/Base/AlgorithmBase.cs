using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method_pattern.Base
{
    public abstract class AlgorithmBase
    {
        public void TemplateMethod()
        {
            OperationA();
            OperationB();
            OperationC();
        }
        public abstract bool OperationA();
        public abstract bool OperationB();
        public abstract bool OperationC();
    }
}
