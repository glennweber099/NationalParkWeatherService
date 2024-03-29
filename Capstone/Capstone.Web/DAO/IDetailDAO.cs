﻿using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAO
{
    public interface IDetailDAO
    {
        IList<ParkModel> GetParksIndex();
        ParkModel GetPark(string parkCode);
        IList<Weather> GetWeather(string parkCode);
    }
}
