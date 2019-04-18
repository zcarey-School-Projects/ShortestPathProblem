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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sub1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sub2");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sub3");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sub1");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Sub2");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sub1");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode8});
			this.CityList = new System.Windows.Forms.ListBox();
			this.Btn_AddCity = new System.Windows.Forms.Button();
			this.Btn_EditCity = new System.Windows.Forms.Button();
			this.Btn_RemoveCity = new System.Windows.Forms.Button();
			this.DistanceList = new System.Windows.Forms.TreeView();
			this.Btn_Units_Miles = new System.Windows.Forms.RadioButton();
			this.Btn_Units_KM = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// CityList
			// 
			this.CityList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.CityList.FormattingEnabled = true;
			this.CityList.ItemHeight = 16;
			this.CityList.Location = new System.Drawing.Point(12, 12);
			this.CityList.Name = "CityList";
			this.CityList.Size = new System.Drawing.Size(117, 276);
			this.CityList.TabIndex = 0;
			this.CityList.SelectedIndexChanged += new System.EventHandler(this.CityList_SelectedIndexChanged);
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
			// DistanceList
			// 
			this.DistanceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DistanceList.Location = new System.Drawing.Point(216, 12);
			this.DistanceList.Name = "DistanceList";
			treeNode1.Name = "Node3";
			treeNode1.Text = "Sub1";
			treeNode2.Name = "Node4";
			treeNode2.Text = "Sub2";
			treeNode3.Name = "Node5";
			treeNode3.Text = "Sub3";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Node0";
			treeNode5.Name = "Node6";
			treeNode5.Text = "Sub1";
			treeNode6.Name = "Node7";
			treeNode6.Text = "Sub2";
			treeNode7.Name = "Node1";
			treeNode7.Text = "Node1";
			treeNode8.Name = "Node8";
			treeNode8.Text = "Sub1";
			treeNode9.Name = "Node2";
			treeNode9.Text = "Node2";
			this.DistanceList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode9});
			this.DistanceList.ShowPlusMinus = false;
			this.DistanceList.ShowRootLines = false;
			this.DistanceList.Size = new System.Drawing.Size(168, 276);
			this.DistanceList.TabIndex = 8;
			// 
			// Btn_Units_Miles
			// 
			this.Btn_Units_Miles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Btn_Units_Miles.AutoSize = true;
			this.Btn_Units_Miles.Checked = true;
			this.Btn_Units_Miles.Location = new System.Drawing.Point(135, 240);
			this.Btn_Units_Miles.Name = "Btn_Units_Miles";
			this.Btn_Units_Miles.Size = new System.Drawing.Size(61, 21);
			this.Btn_Units_Miles.TabIndex = 9;
			this.Btn_Units_Miles.TabStop = true;
			this.Btn_Units_Miles.Text = "Miles";
			this.Btn_Units_Miles.UseVisualStyleBackColor = true;
			this.Btn_Units_Miles.CheckedChanged += new System.EventHandler(this.Btn_Units_Miles_CheckedChanged);
			// 
			// Btn_Units_KM
			// 
			this.Btn_Units_KM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Btn_Units_KM.AutoSize = true;
			this.Btn_Units_KM.Location = new System.Drawing.Point(135, 267);
			this.Btn_Units_KM.Name = "Btn_Units_KM";
			this.Btn_Units_KM.Size = new System.Drawing.Size(49, 21);
			this.Btn_Units_KM.TabIndex = 10;
			this.Btn_Units_KM.Text = "KM";
			this.Btn_Units_KM.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 313);
			this.Controls.Add(this.Btn_Units_KM);
			this.Controls.Add(this.Btn_Units_Miles);
			this.Controls.Add(this.DistanceList);
			this.Controls.Add(this.Btn_RemoveCity);
			this.Controls.Add(this.Btn_EditCity);
			this.Controls.Add(this.Btn_AddCity);
			this.Controls.Add(this.CityList);
			this.Name = "MainForm";
			this.Text = "Shortest Distance";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox CityList;
		private System.Windows.Forms.Button Btn_AddCity;
		private System.Windows.Forms.Button Btn_EditCity;
		private System.Windows.Forms.Button Btn_RemoveCity;
		private System.Windows.Forms.TreeView DistanceList;
		private System.Windows.Forms.RadioButton Btn_Units_Miles;
		private System.Windows.Forms.RadioButton Btn_Units_KM;
	}
}

