using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Categories:IEntity
    {
        public int Id { get; set; }
        public string CategorieName { get; set; }
    }
}
