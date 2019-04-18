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

		private LinkedList<Tuple<City, Distance>> sortedCityDistances = new LinkedList<Tuple<City, Distance>>();

		public City() {

		}

		public City(City city) {
			CopyValues(city);
		}

		public void CopyValues(City toCopy) {
			if (toCopy == null) return;
			this.name = toCopy.name;
			this.lat = toCopy.lat;
			this.lon = toCopy.lon;
		}

		public void addCity(City city) {
			Distance dist = DistanceTo(city);
			Tuple<City, Distance> tuple = new Tuple<City, Distance>(city, dist);
			//if (sortedCityDistances.Count == 0) sortedCityDistances.AddFirst(new Tuple<City, Distance>(city, dist));
			//else {
			LinkedListNode<Tuple<City, Distance>> currentNode = sortedCityDistances.First;
			while (currentNode != null) {
				if(dist < currentNode.Value.Item2) {
					sortedCityDistances.AddBefore(currentNode, tuple);
					return;
				}
				currentNode = currentNode.Next;
			}
			sortedCityDistances.AddLast(tuple);
			//}
			
		}

		public void removeCity(City city) {
			LinkedListNode<Tuple<City, Distance>> currentNode = sortedCityDistances.First;
			while(currentNode != null) {
				if(currentNode.Value.Item1 == city) {
					sortedCityDistances.Remove(currentNode);
					return;
				}
				currentNode = currentNode.Next;
			}
		}

		public Tuple<City, Distance> FindClosestCity(List<City> remainingCities) {
			foreach(Tuple<City, Distance> pair in sortedCityDistances) {
				if (remainingCities.Contains(pair.Item1)) {
					return pair;
				}
			}
			return null;
		}

		public Distance GetDistance(City city) {
			foreach(Tuple<City, Distance> tuple in sortedCityDistances) {
				if (tuple.Item1 == city) return tuple.Item2;
			}
			return null;
		}

		/// <summary>Returns the distance between two cities in KM</summary>
		/// <param name="city">The city to calculate the distance to.</param>
		/// <returns>A double value of the distance between the two cities in KM.</returns>
		private Distance DistanceTo(City city) {
			GeoCoordinate coord1 = new GeoCoordinate((double)city.Latitude, (double)city.Longitude);
			GeoCoordinate coord2 = new GeoCoordinate((double)Latitude, (double)Longitude);

			Distance dist = new Distance();
			dist.Unit = DistanceUnit.Kilometers;
			dist.Value = coord1.GetDistanceTo(coord2) / 1000;

			return dist;
		}

		private static double ToRadians(double degs) {
			return degs * Math.PI / 180;
		}
	}
}
