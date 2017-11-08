using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> list = new List<Country>();
            list.Insert(0, new Country("Sverige", "Stockholm", 10.07, 450295));
            list.Insert(0, new Country("Norge", "Oslo", 5.27, 323802));


           /*         
           Island, Reykyavik, 0.33, 102775
           Danmark, Köpenhamn, 5.75, 42931
           Finland, Helsinki, 5.51, 338424
           Belgien, Bryssel, 11.30, 30528
           Tyskland, Berlin, 82.18, 357168
           Frankrike, Paris, 66.99, 640679
           Storbritannien, London, 60.80, 209331
           Niue, Alofi, 0.0016, 261
           Mongoliet, Kuala Lumpur, 3.08, 1566000
           Polen, Warsawa, 38.63, 312679
           Spanien, Madrid, 46.5, 505990
           Portugal, Lissabon, 10.31, 92212
           Italien, Rom, 60.59, 301338
           Grekland, Aten, 11.18, 131957
           Luxemburg, Luxemburg, 0.58, 2586
           Liechtenstein, Vaduz, 0.038, 160
           */



        }
    }

    class Country
    {
        public string Name { get; set; } = "Empty";
        public string City { get; set; } = "Empty";
        public double Residents { get; set; } = 0;
        public int Area { get; set; } = 0;

        public Country(string n = "None", string c = "None", double r = 0, int a = 0)
        {
            Name = n;
            City = c;
            Residents = r;
            Area = a;
        }
    }
}
