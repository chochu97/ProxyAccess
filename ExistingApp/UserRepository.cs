using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingApp
{
    public class UserRepository : IRepository
    {
        IList<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
        }
        public IList<User> GetAll()
        {
            return _users;
        }

        public void Save(User user)
        {
            _users.Add(user);
        }
    }
}
