using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new() 
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }

            },

            new()
            {
                Name = "Pluto",
                Subtitle = "The Star of Dwarf Planets",
                HeroImage = "pluto.png",
                Description = "Pluto is by far the most famous dwarf planet. Discovered by Clyde Tombaugh in 1930, " +
                "Pluto was long considered our solar system's ninth planet. " +
                " But after other astronomers found similar intriguing worlds deeper in the distant Kuiper Belt " +
                "– the IAU reclassified Pluto as a dwarf planet in 2006. " +
                "Pluto's heart-shaped glacier is about the size of Texas and Oklahoma." +
                "Pluto has five moons and has been the subject of one mission",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Pluto-01_Stern_03_Pluto_Color_TXT.jpg/1024px-Pluto-01_Stern_03_Pluto_Color_TXT.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Pluto%27s_internal_structure2.jpg/1280px-Pluto%27s_internal_structure2.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Pluto%2C_Earth_%26_Moon_size_comparison.jpg/1280px-Pluto%2C_Earth_%26_Moon_size_comparison.jpg"
                }

            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The Dwarf of the inner solar system",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, " +
                "and it's the only dwarf planet located in the inner solar system. " +
                " It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801." +
                "When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to be explored by a spacecraft." +
                "Called an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006." +
                "Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive." +
                "Ceres is named for the Roman goddess of corn and harvests. The word cereal comes from the same name.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/07/Dawn_at_Ceres-PIA19064-800x600-1.jpg?w=640&format=webp",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/PIA20348_crop_-_Ceres%27_Ahuna_Mons_top_view.jpg/1024px-PIA20348_crop_-_Ceres%27_Ahuna_Mons_top_view.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/11/PIA22660-Ceres-DwarfPlanet-Inside-ArtistConcept-20180814.jpg"
                }

            },

            new()
            {
                Name = "Makemake",
                Subtitle = "The Easterbunny",
                HeroImage = "makemake.png",
                Description = "Makemake, along with fellow dwarf planets Pluto, Eris, and Haumea, is located in the Kuiper Belt, " +
                "a donut-shaped region of icy bodies beyond the orbit of Neptune. " +
                " Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest." +
                " It takes about 305 Earth years for this dwarf planet to make one trip around the Sun." +
                "Makemake holds an important place in the history of solar system studies because it was one of the objects – along with Eris – " +
                "whose discovery prompted the International Astronomical Union to reconsider the definition of a planet, and to create the new group of dwarf planets." +
                "Makemake was first observed in March 2005 by M.E. Brown, C.A. Trujillo, and D.L. Rabinowitz at the Palomar Observatory, California." +
                "Makemake was named after the Rapanui god of fertility. With a radius of approximately 444 miles (715 kilometers), Makemake is 1/9 the radius of Earth.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_and_its_moon.jpg"
                }

            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The Santa",
                HeroImage = "haumea.png",
                Description = "Originally designated 2003 EL61 (and nicknamed Santa by one discovery team), Haumea is located in the Kuiper Belt " +
                ", a doughnut-shaped region of icy bodies beyond the orbit of Neptune. " +
                " Haumea is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system." +
                " The fast spin distorts Haumea's shape, making this dwarf planet look like a football." +
                "Everything we know about Haumea is from observations with ground-based telescopes from around the world." +
                "Haumea is named after the Hawaiian goddess of fertility." +
                "With a radius of about 385 miles (620 kilometers), Haumea is about 1/14 the radius of Earth.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Haumea.svg/1024px-Haumea.svg.png",
                    "https://upload.wikimedia.org/wikipedia/commons/2/2b/Haumea_Hubble.png"
                }

            },

            new()
            {
                Name = "Eris",
                Subtitle = "The Xena",
                HeroImage = "eris.png",
                Description = "Eris is one of the largest known dwarf planets in our solar system. " +
                "It's about the same size as Pluto but is three times farther from the Sun." +
                " At first, Eris appeared to be larger than Pluto. This triggered a debate in the scientific community that led " +
                "to the International Astronomical Union's decision in 2006 to clarify the definition of a planet." +
                "Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, during a Palomar Observatory survey of the outer solar system by Mike Brown" +
                "Eris is named for the ancient Greek goddess of discord and strife." +
                "With a radius of about 722 miles (1,163 kilometers), Eris is about 1/5 the radius of Earth. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/5/5b/Eris_and_dysnomia2.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/03/Eris%2C_Earth_%26_Moon_size_comparison.png"
                }

            }



        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
