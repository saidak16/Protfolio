using Core.Entities;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        public Ownier ownier { get; set; }
        public List<ProtfolioItem> protfolioItems { get; set; }
    }
}
