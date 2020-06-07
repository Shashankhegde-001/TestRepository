using EFNgApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFNgApp.Interfaces
{
    public interface ICity
    {
        List<TblCities> GetCities();
    }
}
