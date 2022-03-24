using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiForTraining.Model;

namespace WebApiForTraining.Data
{
    public interface IContract
    {
        public IEnumerable<User> GetAllData();
        public User GetUserById(int Id);
        public void CreateUser(User user);
        public bool SaveChanges();
    }
}
