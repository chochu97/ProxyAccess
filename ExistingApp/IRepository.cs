using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingApp
{
    public interface IRepository
    {
        IList<User> GetAll();

        void Save(User user);
    }
}
