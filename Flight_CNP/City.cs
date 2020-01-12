/**
 * This object represents the city class from Java to C#.
 * @author Rob Kelley
 * @author cporter
 * @version 1/12/2020
 * CS-311 Programming Project 1
 * Spring 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_CNP
{
    class City
    {
        private readonly String name;
        private readonly double latitude;
        private readonly double longitude;

        /**
	     * Empty-argument constructor to put 
	     * object into a consistent state.
	     */
        private City()
        {
            name = "";
            latitude = 0.0;
            longitude = 0.0;
        }//end constructor

        /**
	     * Constructor to instantiate the object.
	     */
        public City(String name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }//end constructor

        /**
         * Getter for name.
         */
        public String GetName()
        {
            return name;
        }//end getName

        /**
         * Getter for latitude.
         */
        public double GetLatitude()
        {
            return latitude;
        }//end GetLatitude

        /**
         * Getter for longitude.
         */
        public double GetLongitude()
        {
            return longitude;
        }//end GetLongitude

        override
        public String ToString()
        {
            return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
        }//end toString
    }//end class
}//end namespace
