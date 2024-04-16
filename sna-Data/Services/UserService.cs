
using sna_Data.Context.MSSQLContext;
using sna_Data.Entities;

namespace sna_Data.Services
{
    public class UserService : BaseService<User>
    {
        private ApplicationDbContext _context;
        public UserService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
