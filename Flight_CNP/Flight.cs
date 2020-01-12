/**
 * This object represents the flight class from Java to C#.
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
    class Flight
    {
        private String airLineName;
        private City originCity;
        private City destinationCity;
        private String flightNumber;

        /**
	     * Empty-argument constructor to put 
	     * the object into a consistent state.
	     */
        public Flight()
        {
            airLineName = null;
            originCity = null;
            destinationCity = null;
            flightNumber = null;
        }//end constructor

        /**
	     * Preferred constructor for this object.
	     */
        public Flight(String aln, String fn, City o, City d)
        {
            SetAirLineName(aln);
            SetFlightNumber(fn);
            SetOriginCity(o);
            SetDestinationCity(d);
        }//end constructor

        /**
	     * Method uses the haversine formulae
	     * to calculate the distance around the 
	     * globe from one city to another.
	     */
        public double CalcDistanceToFly()
        {
            double R = 6371000;
            double lat1 = originCity.GetLatitude();
            double lat2 = destinationCity.GetLatitude();
            double lon1 = originCity.GetLongitude();
            double lon2 = destinationCity.GetLongitude();

            double lat1Radians = (Math.PI / 180) * lat1;
            double lat2Radians = (Math.PI / 180) * lat2;
            double lon1Radians = (Math.PI / 180) * lon1;
            double lon2Radians = (Math.PI / 180) * lon2;

            double latDiff = lat2 - lat1;
            double lonDiff = lon2 - lon1;

            double deltaLat = (Math.PI / 180) * latDiff;
            double deltaLon = (Math.PI / 180) * lonDiff;

            double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos(lat1Radians) * Math.Cos(lat2Radians) * Math.Pow(Math.Sin(deltaLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = R * c;

            return distance * 0.000621371;

        }//end CalcDistanceToFly

        /**
	     * This method will return all of the flight
	     * details including the airline, flight number,
	     * and distance between two city objects.
	     */
        public String PrintFlightDetails()
        {
            return $"{airLineName} {flightNumber}\n{originCity.GetName()} to {destinationCity.GetName()}" +
                 $"\nDistance: {Math.Round(this.CalcDistanceToFly(), 3)} miles.\n";
        }//end PrintFlightDetails

        /**
         * Getter for airLineName
         */
        public String GetAirLineName()
        {
            return airLineName;
        }//end GetAirLineName

        /**
         * Setter for airLineName
         */
        public void SetAirLineName(String airLineName)
        {
            this.airLineName = airLineName;
        }//end SetAirLineName

        /**
         * Getter for flight number.
         */
        public String GetFlightNumber()
        {
            return flightNumber;
        }//end GetFlightNumber

        /**
         * Setter for flightNumber.
         */
        public void SetFlightNumber(String flightNumber)
        {
            this.flightNumber = flightNumber;
        }//end SetFlightNumber

        /**
         * Getter for originCity.
         */
        public City GetOriginCity()
        {
            return originCity;
        }//end GetOriginCity

        /**
         * Setter for originCity.
         */
        public void SetOriginCity(City originCity)
        {
            this.originCity = originCity;
        }//end SetOriginCity

        /*
         * Getter for destinationCity.
         */
        public City GetDestinationCity()
        {
            return destinationCity;
        }//end GetDestinationCity

        /**
         * Setter for destinationCity.
         */
        public void SetDestinationCity(City destinationCity)
        {
            this.destinationCity = destinationCity;
        }//end SetDestinationCity

        override
        public String ToString()
        {
            return "Flight [airLineName = " + airLineName + ", originCity = " + originCity + ", destinationCity = "
                + destinationCity + ", flightNumber = " + flightNumber + "]";
        }//end toString
    }//end class
}//end namespace
