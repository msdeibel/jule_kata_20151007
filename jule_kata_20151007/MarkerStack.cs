using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jule_kata_20151007
{
    public class MarkerStack
    {
        private const int MINIMUM_MARKER_COUNT = 0;
        private const int MAXIMUM_MARKER_COUNT = 13;

        int markerCount = MINIMUM_MARKER_COUNT;

        public int Count()
        {
            return markerCount;
        }

        private MarkerStack(int initialMarkerCount) 
        {
            markerCount = initialMarkerCount;
        }

        /// <summary>
        /// Creates a MarkerStack with 0 markers on it
        /// </summary>
        /// <returns></returns>
        public static MarkerStack PlayerMarkerStack()
        {
            return new MarkerStack(MINIMUM_MARKER_COUNT);
        }

        /// <summary>
        /// Creates a MarkerStack with 13 markers on it
        /// </summary>
        /// <returns></returns>
        public static MarkerStack GameMarkerStack()
        {
            return new MarkerStack(MAXIMUM_MARKER_COUNT);
        }

        public void addMarkers(int additionalMarkers)
        {
            if (MAXIMUM_MARKER_COUNT >= markerCount + additionalMarkers)
            {
                markerCount += additionalMarkers;    
            }
            else
            {
                throw new ArgumentOutOfRangeException("Can't add more than 13 markers");
            }
        }

        public void removeMarkers(int removedMarkers)
        {
            if (MINIMUM_MARKER_COUNT <= markerCount - removedMarkers)
            {
                markerCount -= removedMarkers;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Can't remove more than 13 markers");
            }
        }
    }
}
