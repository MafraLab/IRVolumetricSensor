namespace Volumetry
{
	partial class Wizard
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
			this.components = new System.ComponentModel.Container();
			this.pnlCamera = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioTClean = new System.Windows.Forms.RadioButton();
			this.radioContour = new System.Windows.Forms.RadioButton();
			this.radioResult = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioClean = new System.Windows.Forms.RadioButton();
			this.radioMask = new System.Windows.Forms.RadioButton();
			this.radioCanny = new System.Windows.Forms.RadioButton();
			this.btCameraNext = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.grpMask = new System.Windows.Forms.GroupBox();
			this.btSave = new System.Windows.Forms.Button();
			this.grpLineGeneration = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.grpCanny = new System.Windows.Forms.GroupBox();
			this.tbLineThresh = new System.Windows.Forms.TrackBar();
			this.tbThreshold = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grpFOV = new System.Windows.Forms.GroupBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbScaleStopbits = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.cbScaleDatabits = new System.Windows.Forms.ComboBox();
			this.cbScaleParity = new System.Windows.Forms.ComboBox();
			this.cbScaleBaud = new System.Windows.Forms.ComboBox();
			this.cbScalePort = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.grpSensor = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.cbStopbits = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.cbDatabits = new System.Windows.Forms.ComboBox();
			this.cbParity = new System.Windows.Forms.ComboBox();
			this.cbBaud = new System.Windows.Forms.ComboBox();
			this.cbCOM = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.label21 = new System.Windows.Forms.Label();
			this.SerialSensor = new System.IO.Ports.SerialPort(this.components);
			this.SerialScale = new System.IO.Ports.SerialPort(this.components);
			this.pnlCamera.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.grpMask.SuspendLayout();
			this.grpLineGeneration.SuspendLayout();
			this.grpCanny.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbLineThresh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
			this.grpFOV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.grpSensor.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCamera
			// 
			this.pnlCamera.Controls.Add(this.groupBox1);
			this.pnlCamera.Controls.Add(this.btCameraNext);
			this.pnlCamera.Controls.Add(this.button1);
			this.pnlCamera.Controls.Add(this.grpMask);
			this.pnlCamera.Controls.Add(this.grpLineGeneration);
			this.pnlCamera.Controls.Add(this.grpCanny);
			this.pnlCamera.Controls.Add(this.grpFOV);
			this.pnlCamera.Controls.Add(this.pictureBox1);
			this.pnlCamera.Location = new System.Drawing.Point(6, 6);
			this.pnlCamera.Name = "pnlCamera";
			this.pnlCamera.Size = new System.Drawing.Size(981, 576);
			this.pnlCamera.TabIndex = 0;
			this.pnlCamera.VisibleChanged += new System.EventHandler(this.pnlCamera_VisibleChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(772, 433);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 111);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mask";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioTClean);
			this.groupBox3.Controls.Add(this.radioContour);
			this.groupBox3.Controls.Add(this.radioResult);
			this.groupBox3.Location = new System.Drawing.Point(105, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(85, 87);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tool";
			// 
			// radioTClean
			// 
			this.radioTClean.AutoSize = true;
			this.radioTClean.Location = new System.Drawing.Point(6, 18);
			this.radioTClean.Name = "radioTClean";
			this.radioTClean.Size = new System.Drawing.Size(52, 17);
			this.radioTClean.TabIndex = 5;
			this.radioTClean.TabStop = true;
			this.radioTClean.Text = "Clean";
			this.radioTClean.UseVisualStyleBackColor = true;
			// 
			// radioContour
			// 
			this.radioContour.AutoSize = true;
			this.radioContour.Location = new System.Drawing.Point(6, 41);
			this.radioContour.Name = "radioContour";
			this.radioContour.Size = new System.Drawing.Size(62, 17);
			this.radioContour.TabIndex = 3;
			this.radioContour.TabStop = true;
			this.radioContour.Text = "Contour";
			this.radioContour.UseVisualStyleBackColor = true;
			// 
			// radioResult
			// 
			this.radioResult.AutoSize = true;
			this.radioResult.Location = new System.Drawing.Point(6, 64);
			this.radioResult.Name = "radioResult";
			this.radioResult.Size = new System.Drawing.Size(55, 17);
			this.radioResult.TabIndex = 4;
			this.radioResult.TabStop = true;
			this.radioResult.Text = "Result";
			this.radioResult.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioClean);
			this.groupBox2.Controls.Add(this.radioMask);
			this.groupBox2.Controls.Add(this.radioCanny);
			this.groupBox2.Location = new System.Drawing.Point(8, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(91, 87);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "View";
			// 
			// radioClean
			// 
			this.radioClean.AutoSize = true;
			this.radioClean.Location = new System.Drawing.Point(6, 18);
			this.radioClean.Name = "radioClean";
			this.radioClean.Size = new System.Drawing.Size(78, 17);
			this.radioClean.TabIndex = 0;
			this.radioClean.TabStop = true;
			this.radioClean.Text = "Clean View";
			this.radioClean.UseVisualStyleBackColor = true;
			// 
			// radioMask
			// 
			this.radioMask.AutoSize = true;
			this.radioMask.Location = new System.Drawing.Point(6, 41);
			this.radioMask.Name = "radioMask";
			this.radioMask.Size = new System.Drawing.Size(77, 17);
			this.radioMask.TabIndex = 1;
			this.radioMask.TabStop = true;
			this.radioMask.Text = "Mask View";
			this.radioMask.UseVisualStyleBackColor = true;
			// 
			// radioCanny
			// 
			this.radioCanny.AutoSize = true;
			this.radioCanny.Location = new System.Drawing.Point(6, 64);
			this.radioCanny.Name = "radioCanny";
			this.radioCanny.Size = new System.Drawing.Size(81, 17);
			this.radioCanny.TabIndex = 2;
			this.radioCanny.TabStop = true;
			this.radioCanny.Text = "Canny View";
			this.radioCanny.UseVisualStyleBackColor = true;
			// 
			// btCameraNext
			// 
			this.btCameraNext.Location = new System.Drawing.Point(822, 550);
			this.btCameraNext.Name = "btCameraNext";
			this.btCameraNext.Size = new System.Drawing.Size(75, 23);
			this.btCameraNext.TabIndex = 6;
			this.btCameraNext.Text = "Next";
			this.btCameraNext.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(903, 550);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// grpMask
			// 
			this.grpMask.Controls.Add(this.btSave);
			this.grpMask.Location = new System.Drawing.Point(772, 4);
			this.grpMask.Name = "grpMask";
			this.grpMask.Size = new System.Drawing.Size(200, 55);
			this.grpMask.TabIndex = 4;
			this.grpMask.TabStop = false;
			this.grpMask.Text = "Mask";
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(6, 19);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(184, 23);
			this.btSave.TabIndex = 0;
			this.btSave.Text = "Save Mask";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// grpLineGeneration
			// 
			this.grpLineGeneration.Controls.Add(this.textBox6);
			this.grpLineGeneration.Controls.Add(this.label8);
			this.grpLineGeneration.Controls.Add(this.textBox5);
			this.grpLineGeneration.Controls.Add(this.textBox4);
			this.grpLineGeneration.Controls.Add(this.textBox3);
			this.grpLineGeneration.Controls.Add(this.textBox2);
			this.grpLineGeneration.Controls.Add(this.label7);
			this.grpLineGeneration.Controls.Add(this.label6);
			this.grpLineGeneration.Controls.Add(this.label5);
			this.grpLineGeneration.Controls.Add(this.label4);
			this.grpLineGeneration.Location = new System.Drawing.Point(772, 299);
			this.grpLineGeneration.Name = "grpLineGeneration";
			this.grpLineGeneration.Size = new System.Drawing.Size(200, 128);
			this.grpLineGeneration.TabIndex = 3;
			this.grpLineGeneration.TabStop = false;
			this.grpLineGeneration.Text = "Line Generation";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(115, 102);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(44, 20);
			this.textBox6.TabIndex = 14;
			this.textBox6.Text = "1000";
			this.textBox6.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 105);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Minimun Square Size";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(115, 79);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(44, 20);
			this.textBox5.TabIndex = 12;
			this.textBox5.Text = "500";
			this.textBox5.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(115, 57);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(44, 20);
			this.textBox4.TabIndex = 11;
			this.textBox4.Text = "30";
			this.textBox4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(115, 35);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(44, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "15";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(115, 13);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(44, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "1";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Gap Between Lines";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Min. Line Width";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(55, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Threshold";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Pixel Resolution";
			// 
			// grpCanny
			// 
			this.grpCanny.Controls.Add(this.tbLineThresh);
			this.grpCanny.Controls.Add(this.tbThreshold);
			this.grpCanny.Controls.Add(this.label3);
			this.grpCanny.Controls.Add(this.label2);
			this.grpCanny.Location = new System.Drawing.Point(772, 150);
			this.grpCanny.Name = "grpCanny";
			this.grpCanny.Size = new System.Drawing.Size(200, 143);
			this.grpCanny.TabIndex = 2;
			this.grpCanny.TabStop = false;
			this.grpCanny.Text = "Canny Definitions";
			// 
			// tbLineThresh
			// 
			this.tbLineThresh.Location = new System.Drawing.Point(6, 92);
			this.tbLineThresh.Maximum = 255;
			this.tbLineThresh.Name = "tbLineThresh";
			this.tbLineThresh.Size = new System.Drawing.Size(184, 42);
			this.tbLineThresh.TabIndex = 5;
			this.tbLineThresh.TickFrequency = 10;
			this.tbLineThresh.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// tbThreshold
			// 
			this.tbThreshold.Location = new System.Drawing.Point(6, 34);
			this.tbThreshold.Maximum = 255;
			this.tbThreshold.Name = "tbThreshold";
			this.tbThreshold.Size = new System.Drawing.Size(184, 42);
			this.tbThreshold.TabIndex = 4;
			this.tbThreshold.TickFrequency = 10;
			this.tbThreshold.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Link Threshold:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Threshold:";
			// 
			// grpFOV
			// 
			this.grpFOV.Controls.Add(this.textBox8);
			this.grpFOV.Controls.Add(this.label22);
			this.grpFOV.Controls.Add(this.textBox1);
			this.grpFOV.Controls.Add(this.label1);
			this.grpFOV.Location = new System.Drawing.Point(772, 65);
			this.grpFOV.Name = "grpFOV";
			this.grpFOV.Size = new System.Drawing.Size(200, 79);
			this.grpFOV.TabIndex = 1;
			this.grpFOV.TabStop = false;
			this.grpFOV.Text = "Field Of View";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(97, 50);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(44, 20);
			this.textBox8.TabIndex = 3;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(8, 53);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(91, 13);
			this.label22.TabIndex = 2;
			this.label22.Text = "Capture Timeout: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(44, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(44, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "FOV:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(4, 4);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(762, 569);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(762, 569);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1000, 614);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pnlCamera);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(992, 588);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Camera Config";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.grpSensor);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(992, 588);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Sensor Config";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbScaleStopbits);
			this.groupBox4.Controls.Add(this.button3);
			this.groupBox4.Controls.Add(this.cbScaleDatabits);
			this.groupBox4.Controls.Add(this.cbScaleParity);
			this.groupBox4.Controls.Add(this.cbScaleBaud);
			this.groupBox4.Controls.Add(this.cbScalePort);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Location = new System.Drawing.Point(228, 184);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(219, 184);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Scale Sensor";
			// 
			// cbScaleStopbits
			// 
			this.cbScaleStopbits.FormattingEnabled = true;
			this.cbScaleStopbits.Location = new System.Drawing.Point(73, 104);
			this.cbScaleStopbits.Name = "cbScaleStopbits";
			this.cbScaleStopbits.Size = new System.Drawing.Size(121, 21);
			this.cbScaleStopbits.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(22, 147);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(172, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Test Communication";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cbScaleDatabits
			// 
			this.cbScaleDatabits.FormattingEnabled = true;
			this.cbScaleDatabits.Location = new System.Drawing.Point(73, 83);
			this.cbScaleDatabits.Name = "cbScaleDatabits";
			this.cbScaleDatabits.Size = new System.Drawing.Size(121, 21);
			this.cbScaleDatabits.TabIndex = 7;
			// 
			// cbScaleParity
			// 
			this.cbScaleParity.FormattingEnabled = true;
			this.cbScaleParity.Location = new System.Drawing.Point(73, 62);
			this.cbScaleParity.Name = "cbScaleParity";
			this.cbScaleParity.Size = new System.Drawing.Size(121, 21);
			this.cbScaleParity.TabIndex = 6;
			// 
			// cbScaleBaud
			// 
			this.cbScaleBaud.FormattingEnabled = true;
			this.cbScaleBaud.Location = new System.Drawing.Point(73, 41);
			this.cbScaleBaud.Name = "cbScaleBaud";
			this.cbScaleBaud.Size = new System.Drawing.Size(121, 21);
			this.cbScaleBaud.TabIndex = 5;
			// 
			// cbScalePort
			// 
			this.cbScalePort.FormattingEnabled = true;
			this.cbScalePort.Location = new System.Drawing.Point(73, 20);
			this.cbScalePort.Name = "cbScalePort";
			this.cbScalePort.Size = new System.Drawing.Size(121, 21);
			this.cbScalePort.TabIndex = 2;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(22, 107);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Stopbits";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(21, 86);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(46, 13);
			this.label15.TabIndex = 3;
			this.label15.Text = "Databits";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(34, 65);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(33, 13);
			this.label16.TabIndex = 2;
			this.label16.Text = "Parity";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(14, 44);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(58, 13);
			this.label17.TabIndex = 1;
			this.label17.Text = "Baud Rate";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(19, 23);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(53, 13);
			this.label18.TabIndex = 0;
			this.label18.Text = "COM Port";
			// 
			// grpSensor
			// 
			this.grpSensor.Controls.Add(this.label20);
			this.grpSensor.Controls.Add(this.textBox7);
			this.grpSensor.Controls.Add(this.label19);
			this.grpSensor.Controls.Add(this.cbStopbits);
			this.grpSensor.Controls.Add(this.button2);
			this.grpSensor.Controls.Add(this.cbDatabits);
			this.grpSensor.Controls.Add(this.cbParity);
			this.grpSensor.Controls.Add(this.cbBaud);
			this.grpSensor.Controls.Add(this.cbCOM);
			this.grpSensor.Controls.Add(this.label13);
			this.grpSensor.Controls.Add(this.label12);
			this.grpSensor.Controls.Add(this.label11);
			this.grpSensor.Controls.Add(this.label10);
			this.grpSensor.Controls.Add(this.label9);
			this.grpSensor.Location = new System.Drawing.Point(497, 158);
			this.grpSensor.Name = "grpSensor";
			this.grpSensor.Size = new System.Drawing.Size(219, 235);
			this.grpSensor.TabIndex = 1;
			this.grpSensor.TabStop = false;
			this.grpSensor.Text = "Distance Sensor";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(159, 157);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(21, 13);
			this.label20.TabIndex = 11;
			this.label20.Text = "cm";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(73, 154);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(80, 20);
			this.textBox7.TabIndex = 10;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(22, 157);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(49, 13);
			this.label19.TabIndex = 9;
			this.label19.Text = "Distance";
			// 
			// cbStopbits
			// 
			this.cbStopbits.FormattingEnabled = true;
			this.cbStopbits.Location = new System.Drawing.Point(73, 104);
			this.cbStopbits.Name = "cbStopbits";
			this.cbStopbits.Size = new System.Drawing.Size(121, 21);
			this.cbStopbits.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 206);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(172, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Test Communication";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cbDatabits
			// 
			this.cbDatabits.FormattingEnabled = true;
			this.cbDatabits.Location = new System.Drawing.Point(73, 83);
			this.cbDatabits.Name = "cbDatabits";
			this.cbDatabits.Size = new System.Drawing.Size(121, 21);
			this.cbDatabits.TabIndex = 7;
			// 
			// cbParity
			// 
			this.cbParity.FormattingEnabled = true;
			this.cbParity.Location = new System.Drawing.Point(73, 62);
			this.cbParity.Name = "cbParity";
			this.cbParity.Size = new System.Drawing.Size(121, 21);
			this.cbParity.TabIndex = 6;
			// 
			// cbBaud
			// 
			this.cbBaud.FormattingEnabled = true;
			this.cbBaud.Location = new System.Drawing.Point(73, 41);
			this.cbBaud.Name = "cbBaud";
			this.cbBaud.Size = new System.Drawing.Size(121, 21);
			this.cbBaud.TabIndex = 5;
			// 
			// cbCOM
			// 
			this.cbCOM.FormattingEnabled = true;
			this.cbCOM.Location = new System.Drawing.Point(73, 20);
			this.cbCOM.Name = "cbCOM";
			this.cbCOM.Size = new System.Drawing.Size(121, 21);
			this.cbCOM.TabIndex = 2;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(22, 107);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 13);
			this.label13.TabIndex = 4;
			this.label13.Text = "Stopbits";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(21, 86);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(46, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Databits";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(34, 65);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 2;
			this.label11.Text = "Parity";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(14, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Baud Rate";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 23);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "COM Port";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button4);
			this.tabPage3.Controls.Add(this.label21);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(992, 588);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Save";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(402, 169);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(343, 153);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(184, 13);
			this.label21.TabIndex = 0;
			this.label21.Text = "Press save to store the configurations";
			// 
			// Wizard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 614);
			this.Controls.Add(this.tabControl1);
			this.Name = "Wizard";
			this.Text = "Wizard";
			this.pnlCamera.ResumeLayout(false);
			this.pnlCamera.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.grpMask.ResumeLayout(false);
			this.grpLineGeneration.ResumeLayout(false);
			this.grpLineGeneration.PerformLayout();
			this.grpCanny.ResumeLayout(false);
			this.grpCanny.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbLineThresh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
			this.grpFOV.ResumeLayout(false);
			this.grpFOV.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.grpSensor.ResumeLayout(false);
			this.grpSensor.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCamera;
		private System.Windows.Forms.GroupBox grpMask;
		private System.Windows.Forms.GroupBox grpLineGeneration;
		private System.Windows.Forms.GroupBox grpCanny;
		private System.Windows.Forms.GroupBox grpFOV;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar tbThreshold;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar tbLineThresh;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btCameraNext;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioMask;
		private System.Windows.Forms.RadioButton radioClean;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioContour;
		private System.Windows.Forms.RadioButton radioResult;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioCanny;
		private System.Windows.Forms.RadioButton radioTClean;
		private System.Windows.Forms.GroupBox grpSensor;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label13;
		private System.IO.Ports.SerialPort SerialSensor;
		private System.Windows.Forms.ComboBox cbStopbits;
		private System.Windows.Forms.ComboBox cbDatabits;
		private System.Windows.Forms.ComboBox cbParity;
		private System.Windows.Forms.ComboBox cbBaud;
		private System.Windows.Forms.ComboBox cbCOM;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox cbScaleStopbits;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cbScaleDatabits;
		private System.Windows.Forms.ComboBox cbScaleParity;
		private System.Windows.Forms.ComboBox cbScaleBaud;
		private System.Windows.Forms.ComboBox cbScalePort;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.IO.Ports.SerialPort SerialScale;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label22;
	}
}