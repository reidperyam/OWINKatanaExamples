using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyOwinTutorial
{
    public interface ICarRepository
    {
        Car GetById(int id);
        IList<Car> GetListOf(BrowseCarQuery carQuery);
    }
}
