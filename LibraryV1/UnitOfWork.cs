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
        public UnitOfWork()
        {
            Users = new Repository<User>(_context);            
        } 
        
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
