using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPathProblem {
	public partial class MainForm : Form {
		private EditCityDialog cityEditor = new EditCityDialog();
		private List<City> cities = new List<City>();
		const string SAVE_FILE_NAME = "SavedCities.dat";

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			cities = LoadCitiesFromFile(SAVE_FILE_NAME);
			refreshList();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			SaveCitiesToFile(SAVE_FILE_NAME, cities);
		}

		private void refreshList() {
			cities.Sort((x, y) => x.Name.CompareTo(y.Name));
			CityList.Items.Clear();
			foreach (City city in cities) {
				CityList.Items.Add(city.Name);
			}
		}

		private void Btn_AddCity_Click(object sender, EventArgs e) {
			City newCity = new City();
			if(cityEditor.Edit(newCity) == DialogResult.OK) {
				cities.Add(newCity);
				refreshList();
			}
		}

		private void Btn_EditCity_Click(object sender, EventArgs e) {
			int index = CityList.SelectedIndex;
			if ((index < 0) || (index >= cities.Count)) return;
			City selection = cities[index];
			if (cityEditor.Edit(selection) == DialogResult.OK) {
				refreshList();
			} else {
				MessageBox.Show("Error loading city.");
			}
		}

		private void Btn_RemoveCity_Click(object sender, EventArgs e) {
			int index = CityList.SelectedIndex;
			if ((index < 0) || (index >= cities.Count)) return;
			cities.RemoveAt(index);
			CityList.Items.RemoveAt(index);
		}

		private List<City> LoadCitiesFromFile(string filename) {
			List<City> cities = new List<City>();
			if (!File.Exists(filename)) return cities;
			string[] lines = File.ReadAllLines(filename);
			foreach(string str in lines) {
				City city = new City();
				string[] args = str.Split(',');
				if(args.Length != 3) {
					Console.WriteLine("Unexpected number of arguments: Expected 3, got " + args.Length + ".");
					continue;
				}
				if(args[0] == null || args[1] == null || args[2] == null) {
					Console.WriteLine("There was a null argument.");
					continue;
				}
				if(args[0].Length == 0 || args[1].Length == 0 || args[2].Length == 0) {
					Console.WriteLine("There was an empty argument.");
					continue;
				}

				city.Name = args[0];

				decimal temp;
				if(!decimal.TryParse(args[1], out temp)) {
					Console.WriteLine("Could not read latitude.");
					continue;
				}
				city.Latitude = temp;

				if(!decimal.TryParse(args[2], out temp)) {
					Console.WriteLine("Could not read longitude.");
					continue;
				}
				city.Longitude = temp;

				cities.Add(city);
			}
			
			return cities;
		}

		private void SaveCitiesToFile(string filename, List<City> cities) {
			List<string> lines = new List<string>();
			foreach (City city in cities) {
				string str = city.Name;
				str += "," + city.Latitude.ToString();
				str += "," + city.Longitude.ToString();
				lines.Add(str);
			}
			File.WriteAllLines(filename, lines.ToArray());
		}

		private void CityList2_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void CityList3_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private City getSelectedCity()

	}
}
