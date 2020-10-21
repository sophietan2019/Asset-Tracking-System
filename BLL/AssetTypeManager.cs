using Data;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AssetTypeManager
    {
        public static List<AssetType> GetAll()
        {
            var context = new AssetContext();
            var assets = context.AssetTypes.OrderBy(a=>a.Name).ToList();
            return assets;
        }

        public static void Add(AssetType assetType)
        {
            var context = new AssetContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }


        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetContext();
            var assettypes = context.AssetTypes.Select(a => new
            {
                Key=a.Id,
                Value=a.Name
            }).ToList();
               
            return assettypes;
        }


 
       
    }
}
