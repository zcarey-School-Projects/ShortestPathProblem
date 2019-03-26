namespace ShortestPathProblem {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.CityList = new System.Windows.Forms.ListBox();
			this.AddCity = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CityList
			// 
			this.CityList.FormattingEnabled = true;
			this.CityList.ItemHeight = 16;
			this.CityList.Location = new System.Drawing.Point(12, 12);
			this.CityList.Name = "CityList";
			this.CityList.Size = new System.Drawing.Size(117, 276);
			this.CityList.TabIndex = 0;
			// 
			// AddCity
			// 
			this.AddCity.Location = new System.Drawing.Point(135, 12);
			this.AddCity.Name = "AddCity";
			this.AddCity.Size = new System.Drawing.Size(75, 23);
			this.AddCity.TabIndex = 1;
			this.AddCity.Text = "Add City";
			this.AddCity.UseVisualStyleBackColor = true;
			this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AddCity);
			this.Controls.Add(this.CityList);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox CityList;
		private System.Windows.Forms.Button AddCity;
	}
}

