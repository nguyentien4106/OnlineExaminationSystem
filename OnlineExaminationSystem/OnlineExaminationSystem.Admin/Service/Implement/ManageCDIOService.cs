using OnlineExaminationSystem.Common.Data;
using OnlineExaminationSystem.Common.Data.Model;

namespace OnlineExaminationSystem.Admin.Service.Implement
{
    public class ManageCDIOService : IManageCDIOService
    {
        private readonly ApplicationDbContext _context;

        public ManageCDIOService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void AddCDIO(CDIO cdio)
        {
            _context.CDIO.Add(cdio);
            _context.SaveChanges();
        }

        public List<CDIO> GetAll()
        {
            return _context.CDIO.ToList();
        }
    }
}
