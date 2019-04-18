using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathProblem {
	public class Distance {

		private DistanceUnit unit = DistanceUnit.Kilometers;
		public DistanceUnit Unit {
			get => unit;
			set {
				if (value == null) unit = DistanceUnit.Kilometers;
				else unit = value;
			}
		}

		private double distanceKM = 0; //The distance in KM. The format the data is stored in.
		public double Value {
			get => distanceKM * unit.ConversionFactor;
			set => distanceKM = value / unit.ConversionFactor;
		}

		public Distance() {

		}

		public static bool operator <(Distance dist1, Distance dist2) {
			if ((object)dist1 == null || (object)dist2 == null) return false;
			return dist1.distanceKM < dist2.distanceKM;
		}

		public static bool operator <=(Distance dist1, Distance dist2) {
			return dist1 < dist2 || dist1 == dist2;
		}

		public static bool operator >(Distance dist1, Distance dist2) {
			if ((object)dist1 == null || (object)dist2 == null) return false;
			return dist1.distanceKM > dist2.distanceKM;
		}

		public static bool operator >=(Distance dist1, Distance dist2) {
			return dist1 > dist2 || dist1 == dist2;
		}

		public static bool operator ==(Distance dist1, Distance dist2) {
			if ((object)dist1 == null && (object)dist2 == null) return true;
			else if ((object)dist1 == null ^ (object)dist2 == null) return false;
			else return dist1.distanceKM == dist2.distanceKM;
		}

		public static bool operator !=(Distance dist1, Distance dist2) {
			if ((object)dist1 == null && (object)dist2 == null) return false;
			else if ((object)dist1 == null ^ (object)dist2 == null) return true;
			else return dist1.distanceKM != dist2.distanceKM;
		}

	}

	public class DistanceUnit {

		public static DistanceUnit Kilometers = new DistanceUnit("Kilometers", "KM", 1d);
		public static DistanceUnit Miles = new DistanceUnit("Miles", "Mi", 0.621504039776258545680546923555d);

		public readonly string Name;
		public readonly string Abbreviation;
		public readonly double ConversionFactor; //Number KM is multiplied by to get this unit

		public DistanceUnit(string name, string abbv, double conv) {
			Name = name;
			Abbreviation = abbv;
			ConversionFactor = conv;
		}

	}
}
