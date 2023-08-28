using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoriesManager : ICategoriesService
    {
        ICategoriesDal _categoriesDal;
        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }
        public IResult AddCategories(Categories categories)
        {
            _categoriesDal.Add(categories);
            return new SuccessResult(Messages.CategoriesAdded);
        }

        public IResult DeleteCategories(Categories categories)
        {
            _categoriesDal.Delete(categories);
            return new SuccessResult(Messages.CategoriesDeleted);
        }

        public IDataResult<List<Categories>> GetAll()
        {
            var getAllCategories = _categoriesDal.GetAll();
            return new SuccessDataResult<List<Categories>>(getAllCategories,Messages.CategoriesListed);
        }

        public IResult UpdateCategories(Categories categories)
        {
            _categoriesDal.Update(categories);
            return new SuccessResult(Messages.CategoriesUpdated);
        }
    }
}
