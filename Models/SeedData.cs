
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheNaturalTouch.Data;
using System;
using System.Linq;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Drawing;

namespace TheNaturalTouch.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TheNaturalTouchContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TheNaturalTouchContext>>()))
        {
            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
            new Product
            {
                   Category = "Bath",
                Price = 10,
                Size = "200x200 cm",
                Color = "white",
                Material = "Cotton Blend",
                FabricType = "100 % Cotton",
                Pattern = "Solid",
                Style = "Classic",
                Theme = "No Theme",
                Shape = "Square",
                Feature = "Skin Friendly",
                Rating = "5"

                },
                
                new Product
                {
                    Category = "Face",
                    Price = 15,
                    Size = "100x100 cm",
                    Color = "Light Blue",
                    Material = "Cotton",
                    FabricType = "100 % Cotton",
                    Pattern = "Print",
                    Style = "Modern",
                    Theme = "Love",
                    Shape = "Square",
                    Feature = "Super Soft",
                    Rating = "5"
                },
                new Product
                {
                    Category = "Gym",
                    Price = 12,
                    Size = "100x200 cm",
                    Color = "Green",
                    Material = "Cotton Blend",
                    FabricType = "100 % Cotton",
                    Pattern = "Checkered",
                    Style = "Classic",
                    Theme = "No Theme",
                    Shape = "Rectangle",
                    Feature = "Skin Friendly",
                    Rating = "5"

                },
                 new Product
                 {
                     Category = "Baby",
                     Price = 10,
                     Size = "50x50 cm",
                     Color = "Blue",
                     Material = "Cotton",
                     FabricType = "100 % Cotton",
                     Pattern = "Solid",
                     Style = "Classic",
                     Theme = "No Theme",
                     Shape = "Square",
                     Feature = "LightWeight",
                     Rating = "5"

                 },
                  new Product
                  {
                      Category = "Hand",
                      Price = 10,
                      Size = "200x200 cm",
                      Color = "white",
                      Material = "Cotton Blend",
                      FabricType = "100 % Cotton",
                      Pattern = "Solid",
                      Style = "Classic",
                      Theme = "No Theme",
                      Shape = "Square",
                      Feature = "Skin Friendly",
                      Rating = "5"

                  },
                   new Product
                   {
                       Category = "Face",
                       Price = 10,
                       Size = "200x200 cm",
                       Color = "white",
                       Material = "Cotton Blend",
                       FabricType = "100 % Cotton",
                       Pattern = "Solid",
                       Style = "Classic",
                       Theme = "No Theme",
                       Shape = "Square",
                       Feature = "Skin Friendly",
                       Rating = "5"

                   },
                    new Product
                    {
                        Category = "Gym",
                        Price = 8,
                        Size = "150x200 cm",
                        Color = "Blue",
                        Material = "Cotton Blend",
                        FabricType = "100 % Cotton",
                        Pattern = "Solid",
                        Style = "Classic",
                        Theme = "Coastal",
                        Shape = "Square",
                        Feature = "Skin Friendly",
                        Rating = "5"

                    },
                     new Product
                     {
                         Category = "Face",
                         Price = 10,
                         Size = "250x200 cm",
                         Color = "white",
                         Material = "Cotton Blend",
                         FabricType = "100 % Cotton",
                         Pattern = "Solid",
                         Style = "Classic",
                         Theme = "No Theme",
                         Shape = "Square",
                         Feature = "Skin Friendly",
                         Rating = "5"

                     },
                      new Product
                      {
                          Category = "Bath",
                          Price = 10,
                          Size = "200x200 cm",
                          Color = "white",
                          Material = "Cotton Blend",
                          FabricType = "100 % Cotton",
                          Pattern = "Solid",
                          Style = "Classic",
                          Theme = "No Theme",
                          Shape = "Square",
                          Feature = "Quick Dry",
                          Rating = "5"

                      },
                       new Product
                       {
                           Category = "Baby",
                           Price = 10,
                           Size = "30x30 cm",
                           Color = "Light Pink",
                           Material = "Cotton",
                           FabricType = "100 % Cotton",
                           Pattern = "Print",
                           Style = "Classic",
                           Theme = "No Theme",
                           Shape = "Square",
                           Feature = "Skin Friendly",
                           Rating = "5"

                       }
            );
            context.SaveChanges();
        }
    }
}