using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class DataViewModel
    {
        public List<ChartModel> Data { get; set; }
        public DataViewModel() {
            Data = new List<ChartModel>()
            {
                new ChartModel { X = 02, Y = 408 },
                new ChartModel { X = 03, Y = 415  },
                new ChartModel { X = 04, Y = 350 },
                new ChartModel { X = 05, Y = 375 },
                new ChartModel{ X = 06, Y = 500 },
                new ChartModel{ X = 07, Y = 390 },
                new ChartModel{ X = 08, Y = 400 },
                new ChartModel{ X = 09, Y = 440 },
                new ChartModel{ X = 10, Y = 350 },
                new ChartModel{ X = 11, Y = 400 },
                new ChartModel{ X = 12, Y = 365 },
                new ChartModel{ X = 13, Y = 490 },
                new ChartModel{ X = 14, Y = 400 },
                new ChartModel{ X = 15, Y = 520 },
                new ChartModel{ X = 16, Y = 510 },
                new ChartModel{ X = 17, Y = 395 },
                new ChartModel{ X = 18, Y = 380 },
                new ChartModel{ X = 19, Y = 404 },
                new ChartModel{ X = 20, Y = 430 },
                new ChartModel{ X = 21, Y = 375 },
                new ChartModel{ X = 22, Y = 350 },
                new ChartModel{ X = 23, Y = 398 },
                new ChartModel{ X = 24, Y = 432 },
            };
        }
    }
}
