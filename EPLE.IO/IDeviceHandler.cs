using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.IO.Interface
{
    public interface IDeviceHandler
    {
        bool DeviceAttach(string arguments);
        bool DeviceDettach();
        bool DeviceInit();
        bool DeviceReset();

        eDevMode IsDevMode();

        void SET_INT_OUT(string id_1, string id_2, string id_3, string id_4, int value, ref bool result);

        int GET_INT_IN(string id_1, string id_2, string id_3, string id_4, ref bool result);

        void SET_DOUBLE_OUT(string id_1, string id_2, string id_3, string id_4, double value, ref bool result);


        double GET_DOUBLE_IN(string id_1, string id_2, string id_3, string id_4, ref bool result);

        void SET_STRING_OUT(string id_1, string id_2, string id_3, string id_4, string value, ref bool result);

        string GET_STRING_IN(string id_1, string id_2, string id_3, string id_4, ref bool result);

        object GET_DATA_IN(string id_1, string id_2, string id_3, string id_4, ref bool result);

        void SET_DATA_OUT(string id_1, string id_2, string id_3, string id_4, object value, ref bool result);
    }
}
