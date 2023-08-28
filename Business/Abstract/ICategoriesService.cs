using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoriesService
    {
        IResult AddCategories(Categories categories);
        IDataResult<List<Categories>> GetAll();
        IResult UpdateCategories(Categories categories);
        IResult DeleteCategories(Categories categories);
    }
}
