using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGame
{
    class missile: Transportation
    {
        
        public missile(int alt, int speed, int hdg, int altturn, int altturntime, int x, int y)
        {
            isflying = false;
            this.name = "missile";
            this.longitude = x;
            this.latitude = y;
            this.altitude = alt;
            this.altitudeturn = altturn;
            this.speed = speed;
            this.altitudeturntime = altturntime;
            this.heading = hdg;
        }
        public void fly()
        {
            double near = 360;
            double nearestangle = 0;
            /*
            for(int a = 0; a <= 15; a++)
            {
                double tmp = Math.Abs(heading - a * 22.5);
                if ( tmp <= near)
                {
                    nearestangle = a;
                }
            }
            */
            int n = (int)(heading / 22.5);
            if (isflying)
            {
                switch (n)
                {
                    case 0:
                        latitude -= 2;
                        break;
                    case 1:
                        latitude -= 2;
                        break;
                    case 2:
                        latitude -= 2;
                        break;
                    case 3:
                        latitude -= 2;
                        break;
                    case 4:
                        longitude += 2;
                        break;
                    case 5:
                        latitude -= 2;
                        break;
                    case 6:
                        latitude -= 2;
                        break;
                    case 7:
                        latitude -= 2;
                        break;
                    case 8:
                        latitude += 2;
                        break;
                    case 9:
                        latitude -= 2;
                        break;
                    case 10:
                        latitude -= 2;
                        break;
                    case 11:
                        latitude -= 2;
                        break;
                    case 12:
                        longitude -= 2;
                        break;
                    case 13:
                        latitude -= 2;
                        break;
                    case 14:
                        latitude -= 2;
                        break;
                    case 15:
                        latitude -= 2;
                        break;
                }
            }
        }
        public List<missile> list = new List<missile>();
    }
}
