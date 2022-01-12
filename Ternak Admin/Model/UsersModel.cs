using System.Data;

namespace Ternak_Admin.Model
{
    public class UsersModel
    {
        private ModelTemplate _template;

        public string nama { get; set; }
        public string password { get; set; }

        public static string UserName;
        public static string Password;

        public UsersModel()
        {
            _template = new ModelTemplate();
        }

        public bool CheckLogin()
        {
            bool result;
            DataSet ds;
            ds = _template.Select("users", "name = '" + nama + "' AND password = '" + password + "'");

            if (ds.Tables[0].Rows.Count > 0)
            {
                UserName = ds.Tables[0].Rows[0][1].ToString();
                Password = ds.Tables[0].Rows[0][2].ToString();
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool AddUsers()
        {
            var data = "'" + nama + "','" + password + "'";
            return _template.Insert("users", data);
        }
    }
}