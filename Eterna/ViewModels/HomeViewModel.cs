using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }



        public List<Feature> Features { get; set; }

        public List<Slider> Slider { get; set; }

        public List<Team> Team { get; set; }
    }
}
