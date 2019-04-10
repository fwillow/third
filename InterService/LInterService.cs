using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fhl165033213.Enity;
using fhl165033213.InterService;
using fhl165033213.MySqlTask;

namespace fhl165033213.InterService
{
    public class LInterService
    {
        public string loginBookstore(User user)
        {
            DBTask dbTask = new DBTask();
            User regUser = dbTask.getRegUser(user);
            if (regUser != null)
            {
                if (user.Password == regUser.Password) return "信息正确";
                else return "密码错！登录失败";

            }
            else
                return "用户不存在！登录失败";
        }
    }
}