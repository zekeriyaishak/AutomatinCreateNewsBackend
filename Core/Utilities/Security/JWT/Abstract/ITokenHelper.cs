using Core.Entities.Concrete;
using Core.Utilities.Security.JWT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT.Abstract
{
    public interface ITokenHelper
    {//userin bilgileri doğruysa çalışcak jwt oluşturcak
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
