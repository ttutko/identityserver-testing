using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcidentity
{
    public class FavoriteColor
    {
        public string ColorName { get; set; }
        public string RGB { get; set; }

        public FavoriteColor()
        {

        }

        public FavoriteColor(string name, string rgb)
        {
            ColorName = name;
            RGB = rgb;
        }
    }
}
