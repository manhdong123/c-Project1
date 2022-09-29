using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain.DataLayer
{
    public class UserDao
    {
        //Hàm tạo
        Database database;

        public UserDao(string path)
        {
            database = new Database(path);
        }
        //get data 

        public bool KiemTraDangNhap(string taiKhoan,string matKhau)
        {
            bool result = false;
            List<User> users = database.ReadUserFromFileINI();
            foreach (User item in users)
            {
                if(item.TaiKhoan.Equals(taiKhoan) && item.MatKhau.Equals(matKhau))
                {
                    result = true;
                    break;
                }

            }
            return result;
        }
        public List<User> GetUsers()
        {
            return database.ReadUserFromFileINI();
        }
        //add data 
        public bool Capnhatdulieu(List<User> users)
        {
            return database.WriterUserToFileINI(users);
        }
        //Update data 
        //Xóa
    }
   
}
