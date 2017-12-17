using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryV1
{
    public class UnitOfWork : IDisposable
    {
        private Context _context = new Context();
        public Repository<User> Users { get; }
        public Repository<Question> Questions { get; }
        public UnitOfWork()
        {
            Users = new Repository<User>(_context);
            Questions = new Repository<Question>(_context);
        } 
        
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
