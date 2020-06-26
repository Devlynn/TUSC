namespace TUSC
{
	partial class Form1
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
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.footCircLabel = new System.Windows.Forms.Label();
			this.sockCircLabel = new System.Windows.Forms.Label();
			this.footCircTextbox = new System.Windows.Forms.TextBox();
			this.footLenLabel = new System.Windows.Forms.Label();
			this.footLenTextbox = new System.Windows.Forms.TextBox();
			this.sockLenLabel = new System.Windows.Forms.Label();
			this.gaugeLabel = new System.Windows.Forms.Label();
			this.wrkStsLabel = new System.Windows.Forms.Label();
			this.gaugeTextbox = new System.Windows.Forms.TextBox();
			this.keyNumberTextbox = new System.Windows.Forms.TextBox();
			this.shortRowsStsLabel = new System.Windows.Forms.Label();
			this.endShortRowsStsLabel = new System.Windows.Forms.Label();
			this.generatePatternButton = new System.Windows.Forms.Button();
			this.adjustNoteLabel = new System.Windows.Forms.Label();
			this.workingStitchesLabel = new System.Windows.Forms.Label();
			this.keyNumberLabel = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.savePatternToLabel = new System.Windows.Forms.Label();
			this.savePatternButton = new System.Windows.Forms.Button();
			this.saveFileAsLabel = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// footCircLabel
			// 
			this.footCircLabel.AutoSize = true;
			this.footCircLabel.Location = new System.Drawing.Point(112, 84);
			this.footCircLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.footCircLabel.Name = "footCircLabel";
			this.footCircLabel.Size = new System.Drawing.Size(164, 19);
			this.footCircLabel.TabIndex = 0;
			this.footCircLabel.Text = "Foot Circumfrence (in):";
			// 
			// sockCircLabel
			// 
			this.sockCircLabel.AutoSize = true;
			this.sockCircLabel.Location = new System.Drawing.Point(106, 243);
			this.sockCircLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.sockCircLabel.Name = "sockCircLabel";
			this.sockCircLabel.Size = new System.Drawing.Size(167, 19);
			this.sockCircLabel.TabIndex = 1;
			this.sockCircLabel.Text = "Sock Circumfrence (in):";
			// 
			// footCircTextbox
			// 
			this.footCircTextbox.Location = new System.Drawing.Point(291, 80);
			this.footCircTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.footCircTextbox.Name = "footCircTextbox";
			this.footCircTextbox.Size = new System.Drawing.Size(148, 26);
			this.footCircTextbox.TabIndex = 2;
			// 
			// footLenLabel
			// 
			this.footLenLabel.AutoSize = true;
			this.footLenLabel.Location = new System.Drawing.Point(142, 121);
			this.footLenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.footLenLabel.Name = "footLenLabel";
			this.footLenLabel.Size = new System.Drawing.Size(134, 19);
			this.footLenLabel.TabIndex = 4;
			this.footLenLabel.Text = "Length of foot (in):";
			// 
			// footLenTextbox
			// 
			this.footLenTextbox.Location = new System.Drawing.Point(291, 117);
			this.footLenTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.footLenTextbox.Name = "footLenTextbox";
			this.footLenTextbox.Size = new System.Drawing.Size(148, 26);
			this.footLenTextbox.TabIndex = 3;
			// 
			// sockLenLabel
			// 
			this.sockLenLabel.AutoSize = true;
			this.sockLenLabel.Location = new System.Drawing.Point(150, 280);
			this.sockLenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.sockLenLabel.Name = "sockLenLabel";
			this.sockLenLabel.Size = new System.Drawing.Size(124, 19);
			this.sockLenLabel.TabIndex = 6;
			this.sockLenLabel.Text = "Sock Length (in):";
			// 
			// gaugeLabel
			// 
			this.gaugeLabel.AutoSize = true;
			this.gaugeLabel.Location = new System.Drawing.Point(166, 157);
			this.gaugeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gaugeLabel.Name = "gaugeLabel";
			this.gaugeLabel.Size = new System.Drawing.Size(107, 19);
			this.gaugeLabel.TabIndex = 8;
			this.gaugeLabel.Text = "Gauge (sts/in):";
			// 
			// wrkStsLabel
			// 
			this.wrkStsLabel.AutoSize = true;
			this.wrkStsLabel.Location = new System.Drawing.Point(112, 320);
			this.wrkStsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.wrkStsLabel.Name = "wrkStsLabel";
			this.wrkStsLabel.Size = new System.Drawing.Size(161, 19);
			this.wrkStsLabel.TabIndex = 9;
			this.wrkStsLabel.Text = "Working Stitches (sts):";
			// 
			// gaugeTextbox
			// 
			this.gaugeTextbox.Location = new System.Drawing.Point(291, 153);
			this.gaugeTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.gaugeTextbox.Name = "gaugeTextbox";
			this.gaugeTextbox.Size = new System.Drawing.Size(148, 26);
			this.gaugeTextbox.TabIndex = 4;
			// 
			// keyNumberTextbox
			// 
			this.keyNumberTextbox.Location = new System.Drawing.Point(291, 392);
			this.keyNumberTextbox.Margin = new System.Windows.Forms.Padding(4);
			this.keyNumberTextbox.Name = "keyNumberTextbox";
			this.keyNumberTextbox.Size = new System.Drawing.Size(148, 26);
			this.keyNumberTextbox.TabIndex = 5;
			this.keyNumberTextbox.Leave += new System.EventHandler(this.keyNumberTextbox_Leave);
			// 
			// shortRowsStsLabel
			// 
			this.shortRowsStsLabel.AutoSize = true;
			this.shortRowsStsLabel.Location = new System.Drawing.Point(66, 434);
			this.shortRowsStsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.shortRowsStsLabel.Name = "shortRowsStsLabel";
			this.shortRowsStsLabel.Size = new System.Drawing.Size(209, 19);
			this.shortRowsStsLabel.TabIndex = 12;
			this.shortRowsStsLabel.Text = "Stitches For Toe && Heel (sts):";
			// 
			// endShortRowsStsLabel
			// 
			this.endShortRowsStsLabel.AutoSize = true;
			this.endShortRowsStsLabel.Location = new System.Drawing.Point(18, 476);
			this.endShortRowsStsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.endShortRowsStsLabel.Name = "endShortRowsStsLabel";
			this.endShortRowsStsLabel.Size = new System.Drawing.Size(252, 19);
			this.endShortRowsStsLabel.TabIndex = 14;
			this.endShortRowsStsLabel.Text = "Stitches @ End Of Toe && Heel (sts):";
			// 
			// generatePatternButton
			// 
			this.generatePatternButton.Location = new System.Drawing.Point(22, 514);
			this.generatePatternButton.Margin = new System.Windows.Forms.Padding(4);
			this.generatePatternButton.Name = "generatePatternButton";
			this.generatePatternButton.Size = new System.Drawing.Size(418, 34);
			this.generatePatternButton.TabIndex = 6;
			this.generatePatternButton.Text = "Generate Pattern";
			this.generatePatternButton.UseVisualStyleBackColor = true;
			this.generatePatternButton.Click += new System.EventHandler(this.GeneratePattern_Click);
			// 
			// adjustNoteLabel
			// 
			this.adjustNoteLabel.AutoSize = true;
			this.adjustNoteLabel.Location = new System.Drawing.Point(18, 358);
			this.adjustNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.adjustNoteLabel.Name = "adjustNoteLabel";
			this.adjustNoteLabel.Size = new System.Drawing.Size(416, 19);
			this.adjustNoteLabel.TabIndex = 17;
			this.adjustNoteLabel.Text = "Adjust this number to a multiple of the choosen stitch pattern.";
			// 
			// workingStitchesLabel
			// 
			this.workingStitchesLabel.AutoSize = true;
			this.workingStitchesLabel.Location = new System.Drawing.Point(240, 358);
			this.workingStitchesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.workingStitchesLabel.Name = "workingStitchesLabel";
			this.workingStitchesLabel.Size = new System.Drawing.Size(0, 19);
			this.workingStitchesLabel.TabIndex = 18;
			// 
			// keyNumberLabel
			// 
			this.keyNumberLabel.AutoSize = true;
			this.keyNumberLabel.Location = new System.Drawing.Point(180, 396);
			this.keyNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.keyNumberLabel.Name = "keyNumberLabel";
			this.keyNumberLabel.Size = new System.Drawing.Size(100, 19);
			this.keyNumberLabel.TabIndex = 19;
			this.keyNumberLabel.Text = "Key Number:";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "Pattern";
			// 
			// savePatternToLabel
			// 
			this.savePatternToLabel.AutoSize = true;
			this.savePatternToLabel.Location = new System.Drawing.Point(158, 14);
			this.savePatternToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.savePatternToLabel.Name = "savePatternToLabel";
			this.savePatternToLabel.Size = new System.Drawing.Size(116, 19);
			this.savePatternToLabel.TabIndex = 20;
			this.savePatternToLabel.Text = "Save pattern to:";
			// 
			// savePatternButton
			// 
			this.savePatternButton.Location = new System.Drawing.Point(291, 5);
			this.savePatternButton.Margin = new System.Windows.Forms.Padding(4);
			this.savePatternButton.Name = "savePatternButton";
			this.savePatternButton.Size = new System.Drawing.Size(150, 34);
			this.savePatternButton.TabIndex = 1;
			this.savePatternButton.Text = "Browse";
			this.savePatternButton.UseVisualStyleBackColor = true;
			this.savePatternButton.Click += new System.EventHandler(this.savePatternButton_Click);
			// 
			// saveFileAsLabel
			// 
			this.saveFileAsLabel.AutoSize = true;
			this.saveFileAsLabel.Location = new System.Drawing.Point(180, 50);
			this.saveFileAsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.saveFileAsLabel.Name = "saveFileAsLabel";
			this.saveFileAsLabel.Size = new System.Drawing.Size(95, 19);
			this.saveFileAsLabel.TabIndex = 22;
			this.saveFileAsLabel.Text = "Save file as: ";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(22, 191);
			this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(418, 34);
			this.calculateButton.TabIndex = 23;
			this.calculateButton.Text = "Calculate my numbers!!";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(466, 567);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.saveFileAsLabel);
			this.Controls.Add(this.savePatternButton);
			this.Controls.Add(this.savePatternToLabel);
			this.Controls.Add(this.keyNumberLabel);
			this.Controls.Add(this.workingStitchesLabel);
			this.Controls.Add(this.adjustNoteLabel);
			this.Controls.Add(this.generatePatternButton);
			this.Controls.Add(this.endShortRowsStsLabel);
			this.Controls.Add(this.shortRowsStsLabel);
			this.Controls.Add(this.keyNumberTextbox);
			this.Controls.Add(this.gaugeTextbox);
			this.Controls.Add(this.wrkStsLabel);
			this.Controls.Add(this.gaugeLabel);
			this.Controls.Add(this.sockLenLabel);
			this.Controls.Add(this.footLenTextbox);
			this.Controls.Add(this.footLenLabel);
			this.Controls.Add(this.footCircTextbox);
			this.Controls.Add(this.sockCircLabel);
			this.Controls.Add(this.footCircLabel);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Toe Up Sock Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label footCircLabel;
		private System.Windows.Forms.Label sockCircLabel;
		private System.Windows.Forms.TextBox footCircTextbox;
		private System.Windows.Forms.Label footLenLabel;
		private System.Windows.Forms.TextBox footLenTextbox;
		private System.Windows.Forms.Label sockLenLabel;
		private System.Windows.Forms.Label gaugeLabel;
		private System.Windows.Forms.Label wrkStsLabel;
		private System.Windows.Forms.TextBox gaugeTextbox;
		private System.Windows.Forms.TextBox keyNumberTextbox;
		private System.Windows.Forms.Label shortRowsStsLabel;
		private System.Windows.Forms.Label endShortRowsStsLabel;
		private System.Windows.Forms.Button generatePatternButton;
		private System.Windows.Forms.Label adjustNoteLabel;
		private System.Windows.Forms.Label workingStitchesLabel;
		private System.Windows.Forms.Label keyNumberLabel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label savePatternToLabel;
		private System.Windows.Forms.Button savePatternButton;
		private System.Windows.Forms.Label saveFileAsLabel;
		private System.Windows.Forms.Button calculateButton;
	}
}