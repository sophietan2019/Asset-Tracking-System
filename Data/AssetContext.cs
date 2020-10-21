using System;
using Microsoft.EntityFrameworkCore;
using Domain;


namespace Data
{
    public class AssetContext : DbContext
    {
        public AssetContext() : base() { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=SAIT226258OOSD\SQLEXPRESS;
           Database=Assets;
           Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data to AssetType table
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType { Id = 1, Name = "Computer" },
                new AssetType { Id = 2, Name = "Monitor" },
                new AssetType { Id = 3, Name = "Phone" }
          );

            //seed data to Asset table
            modelBuilder.Entity<Asset>().HasData(

                new Asset
                {
                    Id = 10001,
                    TagNumber = "C101",
                    AssetTypeId = 1,
                    Manufacturer = "Dell",
                    Model = "Inspiration 5520",
                    Description = "17.3 Laptop",
                    SerialNumber = " i3793-5841BLK-PUS"
                },

                new Asset
                {
                    Id = 10002,
                    TagNumber = "M101",
                    AssetTypeId = 2,
                    Manufacturer = "Acer",
                    Model = "S191HQL",
                    Description = "Colour lcd monitor",
                    SerialNumber = "9999333iiie33"
                },

                 new Asset
                 {
                     Id = 10003,
                     TagNumber = "P101",
                     AssetTypeId = 3,
                     Manufacturer = "Cisco",
                     Description = "Telephone",
                     SerialNumber = "123456fffe3p3"
                 },


                 new Asset
                 {
                     Id = 10004,
                     TagNumber = "C102",
                     AssetTypeId = 1,
                     Manufacturer = "Dell",
                     Model = "Latitude 3400",
                     Description = "14 Notebook",
                     SerialNumber = "i3793-5e378-BLK-AOC"
                 },

                    new Asset
                    {
                        Id = 10005,
                        TagNumber = "P102",
                        AssetTypeId = 3,
                        Manufacturer = "Polycom",
                        Model = "VVX 150",
                        Description = "Business IP Phone",
                        SerialNumber = "iiik-999-0olk"
                    },

                       new Asset
                       {
                           Id = 10006,
                           TagNumber = "C102",
                           AssetTypeId = 1,
                           Manufacturer = " HP",
                           Model = "Pavilion 27",
                           Description = "All-in-One PC",
                           SerialNumber = "88POL-999345-00KMM"
                       },

                        new Asset
                        {
                            Id = 10007,
                            TagNumber = "P103",
                            AssetTypeId = 3,
                            Manufacturer = "Avaya",
                            Model = "T7316E",
                            Description = "Office Phone",
                            SerialNumber = "NT8B27"
                        }

           );


        }
    }
}

