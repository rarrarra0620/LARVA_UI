using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.Core.Function.Interface
{
    public interface IFunction
    {
        bool CanExecute();     

        string Execute(object[] args = null);

        void PostExecute();

        void ExecuteWhenSimulate();
    }
}
