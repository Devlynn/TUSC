using System;
using System.IO;
using System.Windows.Forms;

namespace TUSC
{
	public partial class Form1 : Form
	{
		public string endShortRowsStsText = "Stitches @ End Of Toe && Heel (sts):     ";
		public int endShortRowStitches;
		public double footCircumfrence;
		public double gauge;
		public int keyNumber;
		public double lengthOfFoot;
		public double lengthOfSock;
		public string patternSavePath;
		public string shortRowsStsText = "Stitches For Toe && Heel (sts):     ";
		public int shortRowStitches;
		public double sockCircumfrence;
		public int workingStitches;
		public string workingStitchesText = "Working Stitches (sts):     ";

		public Form1()
		{
			InitializeComponent();
			footCircTextbox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
			footLenTextbox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
			gaugeTextbox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
			keyNumberTextbox.KeyPress += new KeyPressEventHandler(C_KeyPress);
		}

		private void C_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar);
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(patternSavePath) && footCircumfrence == 0 && lengthOfFoot == 0 && gauge == 0 && keyNumber == 0)
			{
				MessageBox.Show("Please enter a place to save the pattern, the foot circumfrence, the foot length, and the gauge.", "Something's broken :(", MessageBoxButtons.OK);
			}
			else
			{
				footCircumfrence = Convert.ToDouble(footCircTextbox.Text);
				sockCircumfrence = footCircumfrence * .9;
				sockCircLabel.Text = sockCircLabel.Text + @"     " + sockCircumfrence.ToString();

				lengthOfFoot = Convert.ToDouble(footLenTextbox.Text);
				lengthOfSock = lengthOfFoot - 1.5;
				sockLenLabel.Text = sockLenLabel.Text + @"     " + lengthOfSock.ToString();

				gauge = Convert.ToDouble(gaugeTextbox.Text);
				workingStitches = (int)Math.Floor(sockCircumfrence * gauge);
				keyNumber = workingStitches;
				shortRowStitches = keyNumber / 2;
				endShortRowStitches = (int)Math.Round(shortRowStitches * .4);
				wrkStsLabel.Text = workingStitchesText + workingStitches.ToString();
				keyNumberTextbox.Text = workingStitches.ToString();
				shortRowsStsLabel.Text = shortRowsStsText + shortRowStitches.ToString();
				endShortRowsStsLabel.Text = endShortRowsStsText + endShortRowStitches.ToString();
			}
		}

		private void GeneratePattern_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(patternSavePath) && footCircumfrence == 0 && lengthOfFoot == 0 && gauge == 0 && keyNumber == 0)
			{
				MessageBox.Show("Please enter a place to save the pattern, the foot circumfrence, the foot length, and the gauge.", "Something's broken :(", MessageBoxButtons.OK);
			}
			else
			{
				string pattern = @"Using Judy's Magic Cast On, CO " + shortRowStitches + @" sts.

	Row 1 [WS]: Kfb, k to last st, kfb.
	Repeat row 1 until " + keyNumber + @" are on the needles.

	Work in stockinette st or chosen stitch pattern, until work measures " + lengthOfSock + @" inches from end of toe.

	Next Round: Decide which side of your sock you wish to be the top of the foot, and which side will form the sole. Work to the end of the stitches which form the top of the foot; the heel will be worked back and forth over the stitches which form the sole.

	Wrap & Turn [W&T] - The directions that follow are written for short rows worked in stockinette stitch.
		RS row - knit to point specified in pattern, bring yarn to front of work between needles, slip next stitch to working needle, bring yarn around this stitch to back of work, slip stitch back to other needle, turn work to begin purling back in the other direction.
		WS row - purl to point specified in pattern, bring yarn to back of work between needles, slip next stitch to working needle, bring yarn around this stitch to front of work, slip stitch back to other needle, turn work to begin knitting back in the other direction.
	Working Wraps Together with Wrapped Stitches:
		RS row - Knit to wrapped stitch. Slip next stitch from left needle to right needle, use tip of left needle to pick up 'wrap' and place it on right needle, insert left needle into both wrap and stitch, and knit them together.
		WS row - Purl to wrapped stitch. Slip next stitch from left needle to right needle, use tip of left needle to pick up 'wrap' and place it on right needle, slip both wrap and stitch back to left needle, purl together through back loops.

	Row 1 [RS]: K to last st, W&T.
	Row 2 [WS]: P to last st, W&T.
	Row 3 [RS]: K to st before last wrapped st, W&T.
	Row 4 [WS]: P to st before last wrapped st, W&T.

	Repeat Rows 3 and 4 until " + endShortRowStitches + @" sts remain unwrapped between wrapped sts on either side of work. You will be ready to start a RS row.

	Resume working in the round over all sts until work measures length desired. BO all sts loosely in pattern.";

				using (StreamWriter writer = new StreamWriter(patternSavePath, false))
				{
					writer.WriteLine(pattern);
				}
				MessageBox.Show("DONE!!", "Mission Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Close();
			}
		}

		private void keyNumberTextbox_Leave(object sender, EventArgs e)
		{
			workingStitches = Convert.ToInt16(keyNumberTextbox.Text);
			keyNumber = workingStitches;
			shortRowStitches = keyNumber / 2;
			endShortRowStitches = (int)Math.Round(shortRowStitches * .4);
			wrkStsLabel.Text = workingStitchesText + workingStitches.ToString();
			keyNumberTextbox.Text = workingStitches.ToString();
			shortRowsStsLabel.Text = shortRowsStsText + shortRowStitches.ToString();
			endShortRowsStsLabel.Text = endShortRowsStsText + endShortRowStitches.ToString();
		}

		private void savePatternButton_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			patternSavePath = saveFileDialog1.FileName.ToString();
			saveFileAsLabel.Text = saveFileAsLabel.Text + patternSavePath;
		}

		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}
	}
}