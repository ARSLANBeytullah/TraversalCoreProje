using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService : IGenericService<About> //IGenericService'de tanımlanan 5 adet method dışında herhangi bir method'a ihtiyaç duyulursa bu method'lar buraya yazılacaktır.
    {

    }
}
