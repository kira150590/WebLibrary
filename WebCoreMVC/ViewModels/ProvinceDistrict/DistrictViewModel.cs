using System;
using System.Collections.Generic;
using System.Linq;
using WebCoreMVC.Models;

namespace WebCoreMVC.ViewModels
{
    public class DistrictViewModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int ProvinceId { get; set; }

        public static DistrictViewModel DistrictView(District districtView)
        {
            var a = new DistrictViewModel();
            a.Id = districtView.Id;
            a.Code = districtView.Code;
            a.Name = districtView.Name;
            a.ProvinceId = districtView.ProvinceId;
            return a;
        }

        public static IEnumerable<DistrictViewModel> DistrictViews(IEnumerable<District> districts)
        {
            List<DistrictViewModel> districtViews = new List<DistrictViewModel>();
            for (int i = 0; i < districts.Count(); i++)
            {
                districtViews.Add(DistrictViews(districts.ElementAtOrDefault(i)));
            }

            return districtViews;
        }

        public static DistrictViewModel DistrictViews(District district)
        {
            throw new NotImplementedException();
        }
    }
}
