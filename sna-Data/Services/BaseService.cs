
using sna_Data.Context.MSSQLContext;
using sna_Data.Entities;

namespace sna_Data.Services
{
    public class BaseService<T> where T : BaseEntity
    {
        public readonly ApplicationDbContext _context;
        public BaseService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public List<T> GetAll()
        {
            try
            {
                return _context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
