namespace ShortestPathProblem {
	partial class EditCityDialog {
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
			this.TextBox_CityName = new System.Windows.Forms.TextBox();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Numeric_Latitude = new System.Windows.Forms.NumericUpDown();
			this.Numeric_Longitude = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Numeric_Latitude)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Numeric_Longitude)).BeginInit();
			this.SuspendLayout();
			// 
			// TextBox_CityName
			// 
			this.TextBox_CityName.Location = new System.Drawing.Point(94, 12);
			this.TextBox_CityName.Name = "TextBox_CityName";
			this.TextBox_CityName.Size = new System.Drawing.Size(202, 22);
			this.TextBox_CityName.TabIndex = 1;
			// 
			// Btn_Save
			// 
			this.Btn_Save.Location = new System.Drawing.Point(12, 107);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(75, 23);
			this.Btn_Save.TabIndex = 4;
			this.Btn_Save.Text = "Save";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Btn_Cancel.Location = new System.Drawing.Point(221, 107);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 5;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "City Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Latitude:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Longitude:";
			// 
			// Numeric_Latitude
			// 
			this.Numeric_Latitude.DecimalPlaces = 6;
			this.Numeric_Latitude.Location = new System.Drawing.Point(94, 40);
			this.Numeric_Latitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.Numeric_Latitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
			this.Numeric_Latitude.Name = "Numeric_Latitude";
			this.Numeric_Latitude.Size = new System.Drawing.Size(202, 22);
			this.Numeric_Latitude.TabIndex = 2;
			// 
			// Numeric_Longitude
			// 
			this.Numeric_Longitude.DecimalPlaces = 6;
			this.Numeric_Longitude.Location = new System.Drawing.Point(94, 69);
			this.Numeric_Longitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.Numeric_Longitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
			this.Numeric_Longitude.Name = "Numeric_Longitude";
			this.Numeric_Longitude.Size = new System.Drawing.Size(202, 22);
			this.Numeric_Longitude.TabIndex = 3;
			// 
			// EditCityDialog
			// 
			this.AcceptButton = this.Btn_Save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Btn_Cancel;
			this.ClientSize = new System.Drawing.Size(308, 151);
			this.Controls.Add(this.Numeric_Longitude);
			this.Controls.Add(this.Numeric_Latitude);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_Save);
			this.Controls.Add(this.TextBox_CityName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditCityDialog";
			this.Text = "Edit City";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCityDialog_FormClosing);
			this.Load += new System.EventHandler(this.EditCityDialog_Load);
			((System.ComponentModel.ISupportInitialize)(this.Numeric_Latitude)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Numeric_Longitude)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBox_CityName;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown Numeric_Latitude;
		private System.Windows.Forms.NumericUpDown Numeric_Longitude;
	}
}