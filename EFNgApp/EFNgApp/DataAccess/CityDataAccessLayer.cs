using EFNgApp.Interfaces;
using EFNgApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFNgApp.DataAccess
{
    public class CityDataAccessLayer:ICity
    {
        private myTestDBContext db;

        public CityDataAccessLayer(myTestDBContext _db)
        {
            db = _db;
        }

        //To Get the list of Cities
        public List<TblCities> GetCities()
        {
            List<TblCities> lstCity = new List<TblCities>();
            lstCity = (from CityList in db.TblCities select CityList).ToList();

            return lstCity;
        }
    }
}
