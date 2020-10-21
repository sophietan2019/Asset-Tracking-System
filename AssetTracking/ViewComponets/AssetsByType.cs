using AssetTracking.Models;
using BLL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetTracking.ViewComponets
{
    public class AssetsByTypeViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Asset> assets = null;
            if (id == 0)
            {
                assets = AssetManager.GetAll();
            }
            else
            {
                assets = AssetManager.GetAllByAssetType(id);
            }

            var assetsS = assets.Select(a => new AssetViewModel
            {
                Id = a.Id,
                TagNumber=a.TagNumber,
                AssetType=a.AssetType.Name,
                Manufacturer=a.Manufacturer,
                Model=a.Model,
                Description=a.Description,
                SerialNumber=a.SerialNumber
            }).ToList();

            return View(assetsS);
        }

    }
}
