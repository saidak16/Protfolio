using Microsoft.AspNetCore.Http;
using System;

namespace Web.ViewModels
{
    public class ProtfolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectImage { get; set; }
        public IFormFile File { get; set; }
    }
}
