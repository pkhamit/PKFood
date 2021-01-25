using PKFood.Core;
using System.Collections.Generic;
using System.Text;

namespace PKFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
