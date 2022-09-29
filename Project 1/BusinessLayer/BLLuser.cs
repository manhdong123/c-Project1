using FrmMain.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain.BusinessLayer
{
    public class BLLuser
    {
        //Hàm tạo 
        UserDao userDao;

        public BLLuser(string path)
        {
            userDao = new UserDao(path);
        }
        //Lấy data 
        public bool Kiemtradangnhap(string taiKhoan, string matKhau)
        {
            return userDao.KiemTraDangNhap(taiKhoan, matKhau);

        }

        public List<User> GetUsers()
        {
            return userDao.GetUsers();
        }
        public bool Capnhatdulieu(List<User> users)
        {
            return userDao.Capnhatdulieu(users);
        }
    }
}
