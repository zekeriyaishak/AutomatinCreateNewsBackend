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
    public class NewsManager : INewsService
    {
        INewsDal _newsDal;
        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }
        public IResult AddNews(News news)
        {
            _newsDal.Add(news);
            return new SuccessResult(Messages.NewsAdded);
        }

        public IResult DeleteNews(News news)
        {
            _newsDal.Delete(news);
            return new SuccessResult(Messages.NewsDeleted);
        }

        public IDataResult<List<News>> GetAll()
        {
            var getAll = _newsDal.GetAll();
            return new SuccessDataResult<List<News>>(getAll,Messages.NewsListed);
        }

        public IResult UpdateNews(News news)
        {
            _newsDal.Update(news);
            return new SuccessResult(Messages.NewsUpdated);
        }
    }
}
