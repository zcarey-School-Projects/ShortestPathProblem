using System;
using System.Collections.Generic;
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
			if (city == null) return 0d;
			const double RADIUS_EARTH = 6371d;
			double deltaLat = ToRadians((double)(city.Latitude - this.Latitude));
			double deltaLon = ToRadians((double)(city.Longitude - this.Longitude));

			double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos((double)this.Latitude) * Math.Cos((double)city.Latitude) * Math.Pow(Math.Sin(deltaLon), 2);
			double c = Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

			return RADIUS_EARTH - c;
		}

		private static double ToRadians(double degs) {
			return degs * Math.PI / 180;
		}
	}
}
