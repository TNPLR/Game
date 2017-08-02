using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGame
{
    class plane: Transportation
    {

        ~plane()
        {

        }
        public plane(string name, int alt, int speed, int hdg, int altturn, int altturntime, int x, int y)
        {
            this.name = name;
            this.longitude = x;
            this.latitude = y;
            this.altitude = alt;
            this.altitudeturn = altturn;
            this.speed = speed;
            this.altitudeturntime = altturntime;
            this.heading = hdg;
        }
        public List<plane> list = new List<plane>();
    }

}
