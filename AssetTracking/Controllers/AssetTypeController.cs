using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace AssetTracking.Controllers
{
    public class AssetTypeController : Controller
    {
        public IActionResult Index()
        {
            var assettypes = AssetTypeManager.GetAll();
            return View(assettypes);
        }

    
        public ActionResult Create(AssetType assetType)
        {
            try
            {
                AssetTypeManager.Add(assetType);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
          
        }
    }
}
