using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ThreeTierCourseCRUD
{
    public class CourseRepository
    {
        public static DataTable GetAllCourses()
        {
            DbLayer layer = new DbLayer();
            return layer.Select("Select Crs_Id as ID, Crs_Name as [Course Name], Crs_Duration as [Course Duration],Top_Name as [Topic Name] From Course c,Topic t where c.Top_Id = t.Top_Id;");
        }

        public static int InsertCourse(Dictionary<string, object> parameters)
        {
            DbLayer dbLayer = new DbLayer();
            return dbLayer.ExecuteDMLQueries("Insert into course (crs_id,crs_Name,crs_Duration,Top_Id) values (@Id,@Name,@Duration,(Select Top_Id from Topic where Top_Name =@TopicName))", parameters);
        }

        public static int UpdateCourse(Dictionary<string, object> parameters)
        {
            DbLayer dbLayer = new DbLayer();
            return dbLayer.ExecuteDMLQueries("update course set crs_Name=@Name, crs_Duration=@Duration, Top_Id=(Select Top_Id from Topic where Top_Name =@TopicName) where crs_id=@Id", parameters);
        }

        public static int DeleteCourse(Dictionary<string, object> parameters)
        {
            DbLayer dbLayer = new DbLayer();
            return dbLayer.ExecuteDMLQueries("delete from course where Crs_Id=@Id", parameters);

        }
    }
}
