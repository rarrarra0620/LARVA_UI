using EPLE.Core.Manager.Model;
using EPLE.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Annotations;

namespace EPLE.Core.Manager
{
    public class LocationManager
    {
        private string _dbPath;

        private List<LOCATION_INFO> _locationList;
        private LocationManager() 
        {
            
        }

        public string DatabaseFilePath { set { _dbPath = value; } }
        public static readonly LocationManager Instance = new LocationManager();


        public void Initialize(string dbPath)
        {
            _dbPath = Path.GetFullPath(dbPath);

            UpdateLocationList();
        }

        public void UpdateLocationList()
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"SELECT * FROM sys_location_info";

            _locationList = new List<LOCATION_INFO>();

            DataTable dt = DbHandler.Instance.ExecuteQuery(dbFilePath, queryCommand);

            foreach (DataRow dr in dt.Rows)
            {
                LOCATION_INFO loc = new LOCATION_INFO();

                loc.LOCATION_ID = Convert.ToInt64(dr["LOCATION_ID"]);
                loc.LOCATION_NAME = Convert.ToString(dr["LOCATION_NAME"]?? "UNKONWN");
                loc.X_POS = Convert.ToDouble(dr["X_POS"] ?? 0.0);
                loc.Y_IN_POS = Convert.ToDouble(dr["Y_IN_POS"] ?? 0.0);
                loc.Y_OUT_POS = Convert.ToDouble(dr["Y_OUT_POS"] ?? 0.0);
                loc.Z_UP_POS = Convert.ToDouble(dr["Z_UP_POS"]?? 0.0);
                loc.Z_DOWN_POS = Convert.ToDouble(dr["Z_DOWN_POS"]?? 0.0);
                loc.TRANSFER_HAND = Convert.ToString(dr["TRANSFER_HAND"]?? "LEFT");
                loc.LOCATION_TYPE = Convert.ToString(dr["LOCATION_TYPE"]?? "STOCKER");
                loc.LEVEL = Convert.ToString(dr["LARVA_LEVEL"]);
                loc.FLOOR = Convert.ToString(dr["FLOOR"] ?? "0");
                loc.COL = Convert.ToString(dr["COL"] ?? "0");
                loc.ORDER = Convert.ToString(dr["ORDER"] ?? "FRONT");
                _locationList.Add(loc);
            }
        }

        public int UpdateXPosition(long locationId, double xPosition)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET X_POS = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@X_POS"] = xPosition;
            parameters["@LOCATION_ID"] = locationId;
            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret; 
        }

        public int UpdateYInPosition(long locationId, double yPosition)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET Y_IN_POS = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@Y_IN_POS"] = yPosition;
            parameters["@LOCATION_ID"] = locationId;

            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret;
        }

        public int UpdateYOutPosition(long locationId, double yPosition)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET Y_OUT_POS = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@Y_OUT_POS"] = yPosition;
            parameters["@LOCATION_ID"] = locationId;

            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret;
        }

        public int UpdateZUpPosition(long locationId, double zPosition)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET Z_UP_POS = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@Z_UP_POS"] = zPosition;
            parameters["@LOCATION_ID"] = locationId;

            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret;
        }

        public int UpdateZDownPosition(long locationId, double zPosition)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET Z_DOWN_POS = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@Z_DOWN_POS"] = zPosition;
            parameters["@LOCATION_ID"] = locationId;

            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret;
        }

        public int UpdateTransferHand(long locationId, string transferHand)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET TRANSFER_HAND = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@TRANSFER_HAND"] = transferHand;
            parameters["@LOCATION_ID"] = locationId;

            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret;
        }


        public int UpdateLocationType(long locationId, string locationType)
        {
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET LOCATION_TYPE = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@LOCATION_TYPE"] = locationType;
            parameters["@LOCATION_ID"] = locationId;

            int ret = DbHandler.Instance.ExecuteNonQuery(dbFilePath, queryCommand, parameters);

            if (ret > 0)
            {
                UpdateLocationList();
            }

            return ret;
        }
        /// <summary>
        /// Location Key는 "LOCATION_ID : LOCATION_NAME" 으로 이루어진다.
        /// </summary>
        /// <returns></returns>
        public List<string> GetLocationKeys()
        {
            List<string> keys = new List<string>();

            foreach(LOCATION_INFO loc in _locationList)
            {
                string key = loc.LOCATION_ID.ToString() + ":" + loc.LOCATION_NAME;

                keys.Add(key);
            }

            return keys;
        }

        public List<LOCATION_INFO> GetLocationList()
        {
            //UpdateLocationList();
            return _locationList;
        }

        public int UpdateLocationLevel(long locationId, string level)
        {

            int rowCount = 0;
            string dbFilePath = _dbPath;
            string queryCommand = @"UPDATE sys_location_info SET LARVA_LEVEL = ? WHERE LOCATION_ID = ?";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters["@LARVA_LEVEL"] = level;
            parameters["@LOCATION_ID"] = locationId;

            rowCount = DbHandler.Instance.ExecuteNonQuery(_dbPath, queryCommand, parameters);

            //        // 파라미터화된 SQL 쿼리
            //        string sql = "UPDATE sys_box_info SET BoxLevel = @boxLevel WHERE BoxName = @boxName";

            //        // 파라미터를 담을 Dictionary 생성
            //        Dictionary<string, object> parameters = new Dictionary<string, object>
            //{
            //    {"@boxLevel", boxlevel},
            //    {"@boxName", shelfinfo.BoxName}
            //};

            //        // ExecuteNonQuery 메서드를 사용하여 쿼리 실행
            //        rowCount = DbHandler.Instance.ExecuteNonQuery(_dbPath, sql, parameters);

            return rowCount;
        }
    }
}
