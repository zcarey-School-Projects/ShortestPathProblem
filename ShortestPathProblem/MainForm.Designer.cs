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
			this.Btn_AddCity = new System.Windows.Forms.Button();
			this.Btn_EditCity = new System.Windows.Forms.Button();
			this.Btn_RemoveCity = new System.Windows.Forms.Button();
			this.CityList2 = new System.Windows.Forms.ListBox();
			this.CityList3 = new System.Windows.Forms.ListBox();
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
			// Btn_AddCity
			// 
			this.Btn_AddCity.Location = new System.Drawing.Point(135, 12);
			this.Btn_AddCity.Name = "Btn_AddCity";
			this.Btn_AddCity.Size = new System.Drawing.Size(75, 23);
			this.Btn_AddCity.TabIndex = 1;
			this.Btn_AddCity.Text = "Add";
			this.Btn_AddCity.UseVisualStyleBackColor = true;
			this.Btn_AddCity.Click += new System.EventHandler(this.Btn_AddCity_Click);
			// 
			// Btn_EditCity
			// 
			this.Btn_EditCity.Location = new System.Drawing.Point(135, 41);
			this.Btn_EditCity.Name = "Btn_EditCity";
			this.Btn_EditCity.Size = new System.Drawing.Size(75, 23);
			this.Btn_EditCity.TabIndex = 2;
			this.Btn_EditCity.Text = "Edit";
			this.Btn_EditCity.UseVisualStyleBackColor = true;
			this.Btn_EditCity.Click += new System.EventHandler(this.Btn_EditCity_Click);
			// 
			// Btn_RemoveCity
			// 
			this.Btn_RemoveCity.Location = new System.Drawing.Point(135, 70);
			this.Btn_RemoveCity.Name = "Btn_RemoveCity";
			this.Btn_RemoveCity.Size = new System.Drawing.Size(75, 23);
			this.Btn_RemoveCity.TabIndex = 3;
			this.Btn_RemoveCity.Text = "Delete";
			this.Btn_RemoveCity.UseVisualStyleBackColor = true;
			this.Btn_RemoveCity.Click += new System.EventHandler(this.Btn_RemoveCity_Click);
			// 
			// CityList2
			// 
			this.CityList2.FormattingEnabled = true;
			this.CityList2.ItemHeight = 16;
			this.CityList2.Location = new System.Drawing.Point(309, 12);
			this.CityList2.Name = "CityList2";
			this.CityList2.Size = new System.Drawing.Size(117, 276);
			this.CityList2.TabIndex = 4;
			this.CityList2.SelectedIndexChanged += new System.EventHandler(this.CityList2_SelectedIndexChanged);
			// 
			// CityList3
			// 
			this.CityList3.FormattingEnabled = true;
			this.CityList3.ItemHeight = 16;
			this.CityList3.Location = new System.Drawing.Point(432, 12);
			this.CityList3.Name = "CityList3";
			this.CityList3.Size = new System.Drawing.Size(117, 276);
			this.CityList3.TabIndex = 5;
			this.CityList3.SelectedIndexChanged += new System.EventHandler(this.CityList3_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CityList3);
			this.Controls.Add(this.CityList2);
			this.Controls.Add(this.Btn_RemoveCity);
			this.Controls.Add(this.Btn_EditCity);
			this.Controls.Add(this.Btn_AddCity);
			this.Controls.Add(this.CityList);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox CityList;
		private System.Windows.Forms.Button Btn_AddCity;
		private System.Windows.Forms.Button Btn_EditCity;
		private System.Windows.Forms.Button Btn_RemoveCity;
		private System.Windows.Forms.ListBox CityList2;
		private System.Windows.Forms.ListBox CityList3;
	}
}

