using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetTracking.Models;
using BLL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AssetTracking.Controllers
{
    public class AssetController : Controller
    {
        public IActionResult Index()
        {
            var assets = AssetManager.GetAll();
            var viewmodels = assets.Select(a => new AssetViewModel
            {
                Id = a.Id,
                TagNumber = a.TagNumber,
                AssetType = a.AssetType.Name,
                Manufacturer = a.Manufacturer,
                Model = a.Model,
                Description = a.Description,
                SerialNumber = a.SerialNumber
            }).ToList();
            return View(viewmodels);
        }

        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType",id);
        }

        public IActionResult Search()
        {
            ViewBag.AssetTypes = GetAssetTypes();
            return View();
        }

        public IActionResult Assets(int id)
        {
            var filteredAssets = AssetManager.GetAllByAssetType(id);
            var result = $"Asset Count: {filteredAssets.Count}";

            return Content(result);
        }
        public IActionResult Create()
        {
       
            ViewBag.AssetTypeId = GetAssetTypes();

            return View();
          
        }

        [HttpPost]

        public IActionResult Create(Asset aAsset)
        {
            try
            {
                AssetManager.Add(aAsset);
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }

        protected IEnumerable GetAssetTypes()
        {
            var assettypes = AssetTypeManager.GetAsKeyValuePairs();

            //create a collection of SelectListItems

            var types= new SelectList(assettypes, "Key", "Value");

            var list = types.ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "All Types",
                Value = "0"
            });

            return list;

        }


    }
}
