using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public class UserManager:IUserManager
    {
        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " adlı kullanıcının kaydı silindi.");
        }

        private IUserCheck _userCheck;

        public UserManager(IUserCheck userCheck)
        {
            _userCheck = userCheck;
        }


        public void Save(User user)
        {
            if (_userCheck.CheckUserOfReal(user))
            {
                Console.WriteLine("Başarıyla kaydoldunuz.");
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine(user.Id + " numaralı kullanıcının bilgileri güncellendi");
        }
    }
}
