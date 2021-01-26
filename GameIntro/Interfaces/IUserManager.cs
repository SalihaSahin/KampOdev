using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    public interface IUserManager
    {
        void Save(User user);
        void Delete(User user);
        void Update(User user);
    }
}
