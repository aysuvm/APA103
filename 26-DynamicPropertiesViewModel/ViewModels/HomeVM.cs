using _26_DynamicPropertiesViewModel.Models;
using System.Collections.Generic;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
