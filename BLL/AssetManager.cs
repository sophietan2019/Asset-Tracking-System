using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AssetManager
    {
        public static List<Asset> GetAll()
        {
            var context = new AssetContext();
            var assets = context.Assets.Include(a => a.AssetType).ToList();
            return assets;
        }

        public static List<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetContext();
            var assets = context.Assets.Where(at => at.AssetTypeId == id).Include(a => a.AssetType).ToList();
            return assets;
        }

        public static void Add(Asset aAsset)
        {
            var context = new AssetContext();
            context.Assets.Add(aAsset);
            context.SaveChanges();

        }


    }
}
