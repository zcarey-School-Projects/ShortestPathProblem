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
	public partial class EditCityDialog : Form {
		private City selectedCity;

		public EditCityDialog() {
			InitializeComponent();
		}

		private void EditCityDialog_Load(object sender, EventArgs e) {
			TextBox_CityName.Text = selectedCity.Name;
		}

		public DialogResult Edit(City editCity) {
			DialogResult = DialogResult.No;
			if(editCity != null) {
				selectedCity = editCity;
				ShowDialog();
			}
			return DialogResult;
		}

		private void Btn_Save_Click(object sender, EventArgs e) {
			string newName = TextBox_CityName.Text;
			if ((newName != null) && (newName.Length > 0)) {
				selectedCity.Name = newName;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void EditCityDialog_FormClosing(object sender, FormClosingEventArgs e) {
			if(e.CloseReason == CloseReason.UserClosing) {
				//Treat as cancel
				DialogResult = DialogResult.Cancel;
			}
		}

		private void Btn_Cancel_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
