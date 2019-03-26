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
			//string[] File.ReadAllLines(filename);
			//cities.Add(new City());
			return cities;
		}

		private void SaveCitiesToFile(string filename, List<City> cities) {
			//File.WriteAllLines(filename, lines.ToArray());
		}

	}
}
