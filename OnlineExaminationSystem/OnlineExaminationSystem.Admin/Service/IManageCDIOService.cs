using OnlineExaminationSystem.Common.Data.Model;

namespace OnlineExaminationSystem.Admin.Service
{
    public interface IManageCDIOService
    {
        void AddCDIO(CDIO cdio);

        List<CDIO> GetAll();
    }
}