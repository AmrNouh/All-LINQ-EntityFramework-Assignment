using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThreeTierCourseCRUD
{
    public class TopicRepository
    {
        public static DataTable GetAllTopics()
        {
            DbLayer dbLayer = new DbLayer();
            return dbLayer.Select("Select * from Topic;");
        }
    }
}
