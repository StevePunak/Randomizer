namespace Randomizer
{
	partial class Randomizer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnGrabIt = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.textCasino = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textMax = new System.Windows.Forms.TextBox();
			this.textMin = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnGrabIt);
			this.splitContainer1.Panel2.Controls.Add(this.btnGo);
			this.splitContainer1.Panel2.Controls.Add(this.textCasino);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.textMax);
			this.splitContainer1.Panel2.Controls.Add(this.textMin);
			this.splitContainer1.Size = new System.Drawing.Size(372, 669);
			this.splitContainer1.SplitterDistance = 196;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnGrabIt
			// 
			this.btnGrabIt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnGrabIt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGrabIt.Location = new System.Drawing.Point(3, 444);
			this.btnGrabIt.Name = "btnGrabIt";
			this.btnGrabIt.Size = new System.Drawing.Size(166, 54);
			this.btnGrabIt.TabIndex = 3;
			this.btnGrabIt.Text = "Grab &It";
			this.btnGrabIt.UseVisualStyleBackColor = true;
			this.btnGrabIt.Click += new System.EventHandler(this.OnGrabItClicked);
			// 
			// btnGo
			// 
			this.btnGo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.Location = new System.Drawing.Point(3, 132);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(166, 54);
			this.btnGo.TabIndex = 3;
			this.btnGo.Text = "&Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.OnGoClicked);
			// 
			// textCasino
			// 
			this.textCasino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.textCasino.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textCasino.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textCasino.ForeColor = System.Drawing.Color.Red;
			this.textCasino.Location = new System.Drawing.Point(0, 530);
			this.textCasino.Name = "textCasino";
			this.textCasino.Size = new System.Drawing.Size(172, 139);
			this.textCasino.TabIndex = 2;
			this.textCasino.Text = "label3";
			this.textCasino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Maximum";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Minimum";
			// 
			// textMax
			// 
			this.textMax.Location = new System.Drawing.Point(87, 51);
			this.textMax.Name = "textMax";
			this.textMax.Size = new System.Drawing.Size(60, 25);
			this.textMax.TabIndex = 0;
			this.textMax.TextChanged += new System.EventHandler(this.OnMaxMinTextChanged);
			// 
			// textMin
			// 
			this.textMin.Location = new System.Drawing.Point(87, 20);
			this.textMin.Name = "textMin";
			this.textMin.Size = new System.Drawing.Size(60, 25);
			this.textMin.TabIndex = 0;
			this.textMin.TextChanged += new System.EventHandler(this.OnMaxMinTextChanged);
			// 
			// Randomizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 669);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Randomizer";
			this.Text = "Casino Randomizer";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textMax;
		private System.Windows.Forms.TextBox textMin;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Label textCasino;
		private System.Windows.Forms.Button btnGrabIt;
	}
}

