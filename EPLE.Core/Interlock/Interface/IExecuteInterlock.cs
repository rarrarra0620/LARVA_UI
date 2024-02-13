using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.Core.Interlock.Interface
{
    public interface IExecuteInterlock
    {
        bool Execute(object setValue);
    }
}
