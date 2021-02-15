using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CarDetailDto:IDTO
    {
        public string CarName { get; set; }
        public string CarBrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
