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
			this.SuspendLayout();
			// 
			// TextBox_CityName
			// 
			this.TextBox_CityName.Location = new System.Drawing.Point(12, 12);
			this.TextBox_CityName.Name = "TextBox_CityName";
			this.TextBox_CityName.Size = new System.Drawing.Size(107, 22);
			this.TextBox_CityName.TabIndex = 0;
			// 
			// Btn_Save
			// 
			this.Btn_Save.Location = new System.Drawing.Point(12, 40);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(75, 23);
			this.Btn_Save.TabIndex = 1;
			this.Btn_Save.Text = "Save";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Btn_Cancel.Location = new System.Drawing.Point(211, 40);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 2;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// EditCityDialog
			// 
			this.AcceptButton = this.Btn_Save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Btn_Cancel;
			this.ClientSize = new System.Drawing.Size(463, 232);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_Save);
			this.Controls.Add(this.TextBox_CityName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditCityDialog";
			this.Text = "EditCityDialog";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCityDialog_FormClosing);
			this.Load += new System.EventHandler(this.EditCityDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBox_CityName;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Button Btn_Cancel;
	}
}