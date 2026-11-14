using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class UserRepository
    {
        private readonly LabDbContext _context;
        public UserRepository()
        {
            _context = new LabDbContext();
        }
        public bool CheckLogin(string username, string password)
        {
            return _context.Users.Any(u => u.Username == username && u.Password == password);
        }
    }
}
