using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using EPLE.Core.Manager.Model;
using Microsoft.VisualBasic.ApplicationServices;

namespace EPLE.Core.Manager
{
    public class ShelfInfoManager
    {
        private string _dbPath;
        public List<SHELF_INFO> Shelfs { get; set; }

        private ShelfInfoManager()
        {
        }

        public static ShelfInfoManager Instance = new ShelfInfoManager();

        public void Initialize(string dbPath)
        {
            _dbPath = Path.GetFullPath(dbPath);

            Shelfs = GetShelfInfoAsList();
        }

        private List<SHELF_INFO> GetShelfInfoAsList()
        {

            string queryCommand = @"SELECT * FROM sys_box_info";

            List<SHELF_INFO> shelfinfolist = new List<SHELF_INFO>();

            DataTable dt = DbHandler.Instance.ExecuteQuery(_dbPath, queryCommand);

            foreach (DataRow dr in dt.Rows)
            {
                SHELF_INFO shelfinfo = new SHELF_INFO();

                shelfinfo.Id = Convert.ToInt32(dr["Id"]);
                shelfinfo.BoxName = dr["BoxName"] as string;

                string boxlevel = dr["BoxLevel"] as string;
                if (boxlevel != null) { shelfinfo.Boxlevel = (eLARVALEVEL)Convert.ToInt32(boxlevel); }
                shelfinfo.Description = dr["Description"] as string;

                shelfinfolist.Add(shelfinfo);
            }
            return shelfinfolist;
        }

        public int UpdateShelfInfo(SHELF_INFO shelfinfo, int boxlevel)
        {

            int rowCount = 0;

            string sql = string.Format(@"UPDATE sys_box_info SET sys_box_info.BoxLevel = '{0}' WHERE sys_box_info.BoxName = '{1}'", Convert.ToString(boxlevel), shelfinfo.BoxName);

            rowCount = DbHandler.Instance.ExecuteNonQuery(_dbPath, sql);

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
