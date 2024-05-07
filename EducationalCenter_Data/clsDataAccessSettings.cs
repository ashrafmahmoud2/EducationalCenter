using System.Configuration;

namespace EducationalCenterDataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString =
            "Server=.;Database=EducationalCenter;User Id=sa;Password=sa123456;";
       // ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}