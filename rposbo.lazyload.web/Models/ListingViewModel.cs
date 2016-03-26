using System.Collections.Generic;

namespace rposbo.lazyload.web.Models
{
    public class ListingViewModel
    {
        public List<ListingItem> Above { get; set; }
        public List<ListingItem> Below { get; set; }
        public List<ListingItem> All { get; set; }
        public string FlatLink { get; set; }
        public string Title { get; set; }
    }
}