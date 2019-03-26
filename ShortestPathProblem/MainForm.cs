using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPathProblem {
	public partial class MainForm : Form {
		private EditCityDialog cityEditor = new EditCityDialog();
		private City test;

		public MainForm() {
			InitializeComponent();
			test = new City();
		}

		private void AddCity_Click(object sender, EventArgs e) {
			if (cityEditor.Edit(test) != DialogResult.OK) {
				MessageBox.Show("Error");
			} else {
				CityList.Items.Clear();
				CityList.Items.Add(test.Name);
			}
		}
	}
}
