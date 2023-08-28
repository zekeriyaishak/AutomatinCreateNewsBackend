using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class News: IEntity
    {
        public int Id { get; set; }
        public int CategoriesId { get; set; }
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Labels { get; set;}
    }
}
