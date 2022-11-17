﻿using System.Collections.Generic;

namespace Eterna.Models
{
    public static class Data
    {
        public static List<Service> Services = new List<Service>()
            {
                new Service{Id = 1,Title = "Service 11",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 1",Icon="bx bxl-dribbble"},
                new Service{Id = 2,Title = "Service 2",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 2", Icon="<i class=\"bx bx-file\"></i>"},
                new Service{Id = 3,Title = "Service 3",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 3"},
                new Service{Id = 4,Title = "Service 4",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 4"},
                new Service{Id = 5,Title = "Service 5",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 5"},
            };

        public static List<Feature> Features = new List<Feature>()
            {
                new Feature{Id = 1,Title = "Service 11",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 1",Icon="bx bxl-dribbble"},
                new Feature{Id = 2,Title = "Service 2",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 2", Icon="<i class=\"bx bx-file\"></i>"},
                new Feature{Id = 3,Title = "Service 3",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 3"},
                new Feature{Id = 4,Title = "Service 4",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 4"},
                new Feature{Id = 5,Title = "Service 5",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi 5"},
            };


        public static List<Slider> Sliders = new List<Slider>()
            {
                new Slider{Id = 1,Title = "Slide 1",Image ="slide-1.jpg"},
                new Slider{Id = 2,Title = "Slide 2",Image="slide-2.jpg" },
                new Slider{Id = 3,Title = "Slide 3",Image="slide-3.jpg"},
        };

        public static List<Team> Team = new List<Team>()
        {
            new Team{Id =1,Title = "Team 1",Image="team-1.jpg",Icon ="<i class=\"bi bi-twitter\"></i>",Desc ="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"},
            new Team{Id =2,Title = "Team 2",Image="team-2.jpg",Icon ="<i class=\"bi bi-twitter\"></i>",Desc ="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"},
            new Team{Id =3,Title = "Team 3",Image="team-3.jpg",Icon ="<i class=\"bi bi-twitter\"></i>",Desc ="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"}
        };
    }
}
