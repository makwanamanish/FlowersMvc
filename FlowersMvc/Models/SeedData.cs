using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FlowersMvc.Data;
using System;
using System.Linq;
using System.Drawing;

namespace FlowersMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Flowers.Any())
                {
                    return;
                }

                context.Flowers.AddRange(
                    new Flowers
                    {
                        ScientificName = "Rosa",
                        Color = "Red",
                        BloomingSeason = "Spring",
                        Size = "Small",
                        Fragrance = "Strong",
                        GrowingConditions = "Full sun",
                        Rating = "5"
                    },
                    new Flowers
                    {
                        ScientificName = "Viola odorata ",
                        Color = "Yellow",
                        BloomingSeason = "Summer",
                        Size = "Medium",
                        Fragrance = "Light ",
                        GrowingConditions = "Partial sun",
                        Rating = "4"
                    },
                    new Flowers
                    {
                        ScientificName = "Dianthus caryophyllus ",
                        Color = "Pink",
                        BloomingSeason = "Fall",
                        Size = "Large",
                        Fragrance = "No scent  ",
                        GrowingConditions = "Shade",
                        Rating = "5"
                    },
                     new Flowers
                     {
                         ScientificName = "Tulipa gesneriana  ",
                         Color = "Orange",
                         BloomingSeason = "Winter",
                         Size = "Extra-large ",
                         Fragrance = "Sweet  ",
                         GrowingConditions = "Moist soil",
                         Rating = "3"
                     },
                      new Flowers
                      {
                          ScientificName = "Lavandula angustifolia   ",
                          Color = "White",
                          BloomingSeason = "Year-round",
                          Size = "Varying ",
                          Fragrance = "Spicy   ",
                          GrowingConditions = "Well-drained soil",
                          Rating = "1"
                      },
                      new Flowers
                      {
                          ScientificName = "Gerbera jamesonii    ",
                          Color = "Purple",
                          BloomingSeason = "Peak bloom",
                          Size = "Medium  ",
                          Fragrance = "Sweet  ",
                          GrowingConditions = "Well-drained soil",
                          Rating = "4"
                      },
                      new Flowers
                      {
                          ScientificName = "Lilium sp.    ",
                          Color = "Blue",
                          BloomingSeason = "Fall ",
                          Size = "large  ",
                          Fragrance = "Light  ",
                          GrowingConditions = "Acidic soil",
                          Rating = "2"
                      },
                      new Flowers
                      {
                          ScientificName = "Camellia japonica.    ",
                          Color = "Yellow",
                          BloomingSeason = "Fall ",
                          Size = "Small  ",
                          Fragrance = "Sweet   ",
                          GrowingConditions = "Alkaline soil",
                          Rating = "3"
                      },

                       new Flowers
                       {
                           ScientificName = "Salvia splendens    ",
                           Color = "red",
                           BloomingSeason = "spring ",
                           Size = "large  ",
                           Fragrance = "Light   ",
                           GrowingConditions = "Low humidity",
                           Rating = "5"
                       },
                       new Flowers
                       {
                           ScientificName = "Narcissus pseudonarcissus    ",
                           Color = "yellow",
                           BloomingSeason = "spring ",
                           Size = "medium  ",
                           Fragrance = "Light   ",
                           GrowingConditions = "Sandy soil",
                           Rating = "4"
                       }
                );
                context.SaveChanges();
            }
        }
    }
}