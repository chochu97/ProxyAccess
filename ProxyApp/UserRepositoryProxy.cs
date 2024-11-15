using ExistingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyApp
{
    public class UserRepositoryProxy : IRepository
    {
        IRepository real;

        public IList<User> GetAll()
        {
            if(real == null) real = new UserRepository();

            if (Session.CanGetAll)
            {
                return real.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void Save(User user)
        {
            if (real == null) real = new UserRepository();

            if (Session.CanSave)
            {
                real.Save(user);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
