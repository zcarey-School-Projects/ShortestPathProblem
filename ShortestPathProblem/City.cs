using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathProblem {
	public class City {

		private string name = "N/A";
		public string Name {
			get => name;
			set {
				if((value != null) && (value.Length > 0)) {
					name = value;
				}
			}
		}

		private decimal lat = 0M;
		public decimal Latitude {
			get => lat;
			set {
				lat = Math.Max(-90M, Math.Min(90M, value));
			}
		}

		private decimal lon = 0M;
		public decimal Longitude {
			get => lon;
			set {
				lon = Math.Max(-180M, Math.Min(180M, value));
			}
		}

		/// <summary>Returns the distance between two cities in KM</summary>
		/// <param name="city">The city to calculate the distance to.</param>
		/// <returns>A double value of the distance between the two cities in KM.</returns>
		public double DistanceTo(City city) {
			GeoCoordinate coord1 = new GeoCoordinate((double)city.Latitude, (double)city.Longitude);
			GeoCoordinate coord2 = new GeoCoordinate((double)Latitude, (double)Longitude);
			return coord1.GetDistanceTo(coord2) / 1000;
		}

		private static double ToRadians(double degs) {
			return degs * Math.PI / 180;
		}
	}
}
