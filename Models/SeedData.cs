
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
                Image = "/Images/Image1.jpg",
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
                    Image = "/Images/Image2.jpg",
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
                    Image = "/Images/Image3.jpg",
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
                     Image = "/Images/Image4.jpg",
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
                      Size = "250x200 cm",
                      Color = "white",
                      Image = "/Images/Image5.jpg",
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
                       Size = "250x200 cm",
                       Color = "white",
                       Image = "/Images/Image6.jpg",
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
                        Price = 11,
                        Size = "150x200 cm",
                        Color = "Blue",
                        Image = "/Images/Image7.jpg",
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
                         Image = "/Images/Image8.jpg",
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
                          Size = "200x150 cm",
                          Color = "white",
                          Image = "/Images/Image9.jpg",
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
                           Price = 15,
                           Size = "30x30 cm",
                           Color = "Light Pink",
                           Image = "/Images/Image10.jpg",
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