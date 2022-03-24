using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiForTraining.Model;

namespace WebApiForTraining.Data
{
    public class Operations : IContract
    {
        private readonly DataContext _context;
        public Operations(DataContext context )
        {
            _context = context;

        }
        public void CreateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException();
            _context.USERDB1.Add(user);
        }

        public IEnumerable<User> GetAllData()
        {
            return _context.USERDB1.ToList();
        }

        public User GetUserById(int Id)
        {
            return _context.USERDB1.FirstOrDefault(id => id.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }
    }
}
