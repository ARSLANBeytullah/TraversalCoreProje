using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal; //Servise katmanı data access katmanını kullanır. O yüzden de ilgili entity'nin manager sınıfı ilgili entity'nin data dccess katmanınında ki interfacei kullanır ve işlemlerini gerçekleştirir.

        public AboutManager(IAboutDal aboutDal) //Burada amacımız gelen entity'i karşılamaktır.Hangi entity geldiyse o entity'e ait repository'lere ulaşmak için dependency injection kullanıldı.         
        {
            _aboutDal = aboutDal;              //Dependency injection . Constructor sayesinde _aboutDal field'ı sayesin de about entity'sine ait methodlara erişebiliriz. Yani constructor sayesin de ilgili entity'nin interface'i sayesin de bizler ilgili methodlara rahatlıkla eişebilir ve kullanabiliriz.
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
