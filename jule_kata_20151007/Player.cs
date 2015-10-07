using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jule_kata_20151007
{
    public class Player
    {
        MarkerStack markerStack = MarkerStack.PlayerMarkerStack();

        public int MarkerCount()
        {
            return markerStack.Count();
        }

        public void receiveMarkers(int additionalMarkers)
        {
            markerStack.addMarkers(additionalMarkers);
        }

        public void returnMarkers(int removedMarkers)
        {
            markerStack.removeMarkers(removedMarkers);
        }
    }
}
