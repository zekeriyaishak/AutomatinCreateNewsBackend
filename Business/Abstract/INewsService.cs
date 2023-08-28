using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsService
    {
        IResult AddNews(News news);
        IDataResult<List<News>> GetAll();
        IResult UpdateNews(News news);
        IResult DeleteNews(News news);
    }
}
