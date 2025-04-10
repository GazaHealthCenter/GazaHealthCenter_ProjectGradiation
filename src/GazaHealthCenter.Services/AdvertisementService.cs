using GazaHealthCenter.Data;
using GazaHealthCenter.Objects.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;

namespace GazaHealthCenter.Services
{
    public class AdvertisementService : AService
    {
        public AdvertisementService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        // Get all advertisements
        public List<AdvertisementModel> GetAllAdvertisements()
        {
            List<AdvertisementModel> advertisements = UnitOfWork.Select<AdvertisementModel>().ToList();
            return advertisements;
        }

        // Get advertisement by ID
        public AdvertisementModel? GetAdvertisementById(long id)
        {
            return UnitOfWork.Get<AdvertisementModel>(id);
        }

        // Add new advertisement
        public void AddAdvertisement(AdvertisementModel advertisement)
        {
            UnitOfWork.Insert(advertisement);
            UnitOfWork.Commit();
        }

        // Update existing advertisement
        public void UpdateAdvertisement(AdvertisementModel advertisement)
        {
            UnitOfWork.Update(advertisement);
            UnitOfWork.Commit();
        }

        // Delete advertisement
        public void DeleteAdvertisement(long id)
        {
            AdvertisementModel? advertisement = UnitOfWork.Get<AdvertisementModel>(id);
            if (advertisement != null)
            {
                UnitOfWork.Delete(advertisement);
                UnitOfWork.Commit();
            }
        }
    }
}
