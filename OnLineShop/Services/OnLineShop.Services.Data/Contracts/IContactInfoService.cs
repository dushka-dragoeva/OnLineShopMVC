using OnLineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShop.Services.Data.Contracts
{
    public interface IContactInfoService
    {
        ContactInfo GetById(int? id);
    }
}
