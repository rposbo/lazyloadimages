using rposbo.lazyload.web.Models;
using System.Collections.Generic;

namespace rposbo.lazyload.web.Data
{
    public class ListingData
    {
        public List<ListingItem> Load()
        {
            return new List<ListingItem>{
                new ListingItem {
                    Title = "Dark Claw",
                    ImageUrl = @"\Content\img\dark-claw.jpg"
                },
                new ListingItem {
                    Title = "Super Soldier",
                    ImageUrl = @"\Content\img\super-soldier.jpg"
                },
                new ListingItem {
                    Title = "Iron Lantern",
                    ImageUrl = @"\Content\img\iron-lantern.jpg"
                },
                new ListingItem {
                    Title = "Spider Boy",
                    ImageUrl = @"\Content\img\spider-boy.jpg"
                },
                new ListingItem {
                    Title = "Amazon",
                    ImageUrl = @"\Content\img\amazon.jpg"
                },
                new ListingItem {
                    Title = "Bizarnage",
                    ImageUrl = @"\Content\img\bizarnage.jpg"
                },
                new ListingItem {
                    Title = "Catsai",
                    ImageUrl = @"\Content\img\catsai.jpg"
                },
                new ListingItem {
                    Title = "Moonwing",
                    ImageUrl = @"\Content\img\moonwing.jpg"
                },
                new ListingItem {
                    Title = "Hawkeye",
                    ImageUrl = @"\Content\img\hawkeye.jpg"
                },
                new ListingItem {
                    Title = "Mercury",
                    ImageUrl = @"\Content\img\mercury.jpg"
                },
                new ListingItem {
                    Title = "Dr Strangefate",
                    ImageUrl = @"\Content\img\dr-strangefate.jpg"
                }
            };
        }
    }
}