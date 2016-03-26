using rposbo.lazyload.web.Data;
using rposbo.lazyload.web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace rposbo.lazyload.web.Controllers
{
    public class ListingController : Controller
    {
        private List<ListingItem> _allItems;
        private ListingData _db;

        public ListingController()
        {
            _db = new ListingData();
            _allItems = _db.Load();
        }

        public ActionResult Index()
        {
            var aboveTheFoldCount = 6;

            var aboveTheFold = _allItems.Take(aboveTheFoldCount);
            var belowTheFold = _allItems.Skip(aboveTheFoldCount);

            return View(
                    new ListingViewModel
                    {
                        Above = aboveTheFold.ToList(),
                        Below = belowTheFold.ToList(),
                        FlatLink = "Index",
                        Title = "Amalgam Characters"
                    }
                );
        }

        public ActionResult Flat()
        {
            return View(
                    new ListingViewModel
                    {
                        All = _allItems.ToList(),
                        Title = "Amalgam Characters"
                    }
                );
        }

    }
}