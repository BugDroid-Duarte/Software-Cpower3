namespace CPower_CSharp
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
            this.RadioBtnCom = new System.Windows.Forms.RadioButton();
            this.RadioBtnNetWork = new System.Windows.Forms.RadioButton();
            this.btnSplitWnd = new System.Windows.Forms.Button();
            this.btnSendText = new System.Windows.Forms.Button();
            this.btnSendPicture = new System.Windows.Forms.Button();
            this.btnSendStaticText = new System.Windows.Forms.Button();
            this.btnSendClock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_cmbPort = new System.Windows.Forms.ComboBox();
            this.m_cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.m_cmbID = new System.Windows.Forms.ComboBox();
            this.IPAddr = new System.Windows.Forms.TextBox();
            this.IPPort = new System.Windows.Forms.TextBox();
            this.IDCode = new System.Windows.Forms.TextBox();
            this.m_edtText = new System.Windows.Forms.TextBox();
            this.m_edtPicture = new System.Windows.Forms.TextBox();
            this.m_edtStaticText = new System.Windows.Forms.TextBox();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.m_edtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_edtHeight = new System.Windows.Forms.TextBox();
            this.btnPlayOneProgram = new System.Windows.Forms.Button();
            this.m_edtSelProgram = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.createPRG = new System.Windows.Forms.Button();
            this.AddPRGText = new System.Windows.Forms.Button();
            this.RunPRG = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.status1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioBtnCom
            // 
            this.RadioBtnCom.AutoSize = true;
            this.RadioBtnCom.Location = new System.Drawing.Point(14, 73);
            this.RadioBtnCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioBtnCom.Name = "RadioBtnCom";
            this.RadioBtnCom.Size = new System.Drawing.Size(100, 21);
            this.RadioBtnCom.TabIndex = 4;
            this.RadioBtnCom.Text = "RS232/485";
            this.RadioBtnCom.UseVisualStyleBackColor = true;
            this.RadioBtnCom.CheckedChanged += new System.EventHandler(this.RadioBtnCom_CheckedChanged);
            // 
            // RadioBtnNetWork
            // 
            this.RadioBtnNetWork.AutoSize = true;
            this.RadioBtnNetWork.Location = new System.Drawing.Point(29, 72);
            this.RadioBtnNetWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioBtnNetWork.Name = "RadioBtnNetWork";
            this.RadioBtnNetWork.Size = new System.Drawing.Size(84, 21);
            this.RadioBtnNetWork.TabIndex = 4;
            this.RadioBtnNetWork.Text = "NetWork";
            this.RadioBtnNetWork.UseVisualStyleBackColor = true;
            this.RadioBtnNetWork.CheckedChanged += new System.EventHandler(this.RadioBtnNetWork_CheckedChanged);
            // 
            // btnSplitWnd
            // 
            this.btnSplitWnd.Location = new System.Drawing.Point(22, 301);
            this.btnSplitWnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSplitWnd.Name = "btnSplitWnd";
            this.btnSplitWnd.Size = new System.Drawing.Size(149, 31);
            this.btnSplitWnd.TabIndex = 5;
            this.btnSplitWnd.Text = "Make one window";
            this.btnSplitWnd.UseVisualStyleBackColor = true;
            this.btnSplitWnd.Click += new System.EventHandler(this.btnSplitWnd_Click);
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(23, 29);
            this.btnSendText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(149, 31);
            this.btnSendText.TabIndex = 5;
            this.btnSendText.Text = "Send Text";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // btnSendPicture
            // 
            this.btnSendPicture.Location = new System.Drawing.Point(23, 82);
            this.btnSendPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendPicture.Name = "btnSendPicture";
            this.btnSendPicture.Size = new System.Drawing.Size(149, 31);
            this.btnSendPicture.TabIndex = 5;
            this.btnSendPicture.Text = "Send Picture";
            this.btnSendPicture.UseVisualStyleBackColor = true;
            this.btnSendPicture.Click += new System.EventHandler(this.btnSendPicture_Click);
            // 
            // btnSendStaticText
            // 
            this.btnSendStaticText.Location = new System.Drawing.Point(23, 135);
            this.btnSendStaticText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendStaticText.Name = "btnSendStaticText";
            this.btnSendStaticText.Size = new System.Drawing.Size(149, 31);
            this.btnSendStaticText.TabIndex = 5;
            this.btnSendStaticText.Text = "Send Static Text";
            this.btnSendStaticText.UseVisualStyleBackColor = true;
            this.btnSendStaticText.Click += new System.EventHandler(this.btnSendStaticText_Click);
            // 
            // btnSendClock
            // 
            this.btnSendClock.Location = new System.Drawing.Point(23, 189);
            this.btnSendClock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendClock.Name = "btnSendClock";
            this.btnSendClock.Size = new System.Drawing.Size(149, 31);
            this.btnSendClock.TabIndex = 5;
            this.btnSendClock.Text = "Send Clock";
            this.btnSendClock.UseVisualStyleBackColor = true;
            this.btnSendClock.Click += new System.EventHandler(this.btnSendClock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP Addr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Baud rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Controller ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Code";
            // 
            // m_cmbPort
            // 
            this.m_cmbPort.FormattingEnabled = true;
            this.m_cmbPort.Location = new System.Drawing.Point(14, 125);
            this.m_cmbPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cmbPort.Name = "m_cmbPort";
            this.m_cmbPort.Size = new System.Drawing.Size(127, 24);
            this.m_cmbPort.TabIndex = 7;
            this.m_cmbPort.SelectedIndexChanged += new System.EventHandler(this.m_cmbPort_SelectedIndexChanged);
            // 
            // m_cmbBaudrate
            // 
            this.m_cmbBaudrate.FormattingEnabled = true;
            this.m_cmbBaudrate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600",
            "4800"});
            this.m_cmbBaudrate.Location = new System.Drawing.Point(14, 174);
            this.m_cmbBaudrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cmbBaudrate.Name = "m_cmbBaudrate";
            this.m_cmbBaudrate.Size = new System.Drawing.Size(127, 24);
            this.m_cmbBaudrate.TabIndex = 7;
            this.m_cmbBaudrate.SelectedIndexChanged += new System.EventHandler(this.m_cmbBaudrate_SelectedIndexChanged);
            // 
            // m_cmbID
            // 
            this.m_cmbID.FormattingEnabled = true;
            this.m_cmbID.Location = new System.Drawing.Point(14, 226);
            this.m_cmbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cmbID.Name = "m_cmbID";
            this.m_cmbID.Size = new System.Drawing.Size(127, 24);
            this.m_cmbID.TabIndex = 7;
            this.m_cmbID.SelectedIndexChanged += new System.EventHandler(this.m_cmbID_SelectedIndexChanged);
            // 
            // IPAddr
            // 
            this.IPAddr.Location = new System.Drawing.Point(29, 126);
            this.IPAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPAddr.Name = "IPAddr";
            this.IPAddr.Size = new System.Drawing.Size(127, 22);
            this.IPAddr.TabIndex = 8;
            this.IPAddr.Text = "192.168.1.100";
            // 
            // IPPort
            // 
            this.IPPort.Location = new System.Drawing.Point(29, 175);
            this.IPPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPPort.Name = "IPPort";
            this.IPPort.Size = new System.Drawing.Size(127, 22);
            this.IPPort.TabIndex = 8;
            this.IPPort.Text = "5200";
            this.IPPort.TextChanged += new System.EventHandler(this.IPPort_TextChanged);
            // 
            // IDCode
            // 
            this.IDCode.Location = new System.Drawing.Point(29, 225);
            this.IDCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDCode.Name = "IDCode";
            this.IDCode.Size = new System.Drawing.Size(127, 22);
            this.IDCode.TabIndex = 8;
            this.IDCode.Text = "255.255.255.255";
            // 
            // m_edtText
            // 
            this.m_edtText.AcceptsReturn = true;
            this.m_edtText.Location = new System.Drawing.Point(201, 21);
            this.m_edtText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_edtText.Multiline = true;
            this.m_edtText.Name = "m_edtText";
            this.m_edtText.Size = new System.Drawing.Size(244, 52);
            this.m_edtText.TabIndex = 14;
            this.m_edtText.Text = "Hello";
            // 
            // m_edtPicture
            // 
            this.m_edtPicture.Location = new System.Drawing.Point(201, 85);
            this.m_edtPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_edtPicture.Name = "m_edtPicture";
            this.m_edtPicture.Size = new System.Drawing.Size(244, 22);
            this.m_edtPicture.TabIndex = 16;
            this.m_edtPicture.Text = "test.bmp";
            // 
            // m_edtStaticText
            // 
            this.m_edtStaticText.Location = new System.Drawing.Point(201, 138);
            this.m_edtStaticText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_edtStaticText.Name = "m_edtStaticText";
            this.m_edtStaticText.Size = new System.Drawing.Size(244, 22);
            this.m_edtStaticText.TabIndex = 15;
            this.m_edtStaticText.Text = "Welcome";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(201, 189);
            this.btnSetTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(149, 31);
            this.btnSetTime.TabIndex = 13;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // m_edtWidth
            // 
            this.m_edtWidth.Location = new System.Drawing.Point(100, 347);
            this.m_edtWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_edtWidth.Name = "m_edtWidth";
            this.m_edtWidth.Size = new System.Drawing.Size(63, 22);
            this.m_edtWidth.TabIndex = 21;
            this.m_edtWidth.Text = "64";
            this.m_edtWidth.ModifiedChanged += new System.EventHandler(this.m_edtWidth_ModifiedChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(28, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Width";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(28, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Height";
            // 
            // m_edtHeight
            // 
            this.m_edtHeight.Location = new System.Drawing.Point(100, 377);
            this.m_edtHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_edtHeight.Name = "m_edtHeight";
            this.m_edtHeight.Size = new System.Drawing.Size(63, 22);
            this.m_edtHeight.TabIndex = 22;
            this.m_edtHeight.Text = "32";
            this.m_edtHeight.ModifiedChanged += new System.EventHandler(this.m_edtHeight_ModifiedChanged);
            // 
            // btnPlayOneProgram
            // 
            this.btnPlayOneProgram.Location = new System.Drawing.Point(225, 301);
            this.btnPlayOneProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayOneProgram.Name = "btnPlayOneProgram";
            this.btnPlayOneProgram.Size = new System.Drawing.Size(149, 31);
            this.btnPlayOneProgram.TabIndex = 19;
            this.btnPlayOneProgram.Text = "Play One Program";
            this.btnPlayOneProgram.Click += new System.EventHandler(this.btnPlayOneProgram_Click);
            // 
            // m_edtSelProgram
            // 
            this.m_edtSelProgram.Location = new System.Drawing.Point(257, 347);
            this.m_edtSelProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_edtSelProgram.Name = "m_edtSelProgram";
            this.m_edtSelProgram.Size = new System.Drawing.Size(95, 22);
            this.m_edtSelProgram.TabIndex = 20;
            this.m_edtSelProgram.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.status1);
            this.groupBox1.Controls.Add(this.RadioBtnCom);
            this.groupBox1.Controls.Add(this.m_cmbPort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_cmbBaudrate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_cmbID);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 271);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.status2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.RadioBtnNetWork);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IPAddr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.IPPort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.IDCode);
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 271);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sem fios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSendText);
            this.groupBox3.Controls.Add(this.btnSendPicture);
            this.groupBox3.Controls.Add(this.btnSendStaticText);
            this.groupBox3.Controls.Add(this.btnSendClock);
            this.groupBox3.Controls.Add(this.btnSetTime);
            this.groupBox3.Controls.Add(this.m_edtStaticText);
            this.groupBox3.Controls.Add(this.m_edtPicture);
            this.groupBox3.Controls.Add(this.m_edtText);
            this.groupBox3.Location = new System.Drawing.Point(891, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 258);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controlos";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(412, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 386);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gerir Programa";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RunPRG);
            this.groupBox5.Controls.Add(this.AddPRGText);
            this.groupBox5.Controls.Add(this.createPRG);
            this.groupBox5.Location = new System.Drawing.Point(891, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(464, 122);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Programa";
            // 
            // createPRG
            // 
            this.createPRG.Location = new System.Drawing.Point(23, 23);
            this.createPRG.Name = "createPRG";
            this.createPRG.Size = new System.Drawing.Size(81, 45);
            this.createPRG.TabIndex = 27;
            this.createPRG.Text = "Criar Programa";
            this.createPRG.UseVisualStyleBackColor = true;
            this.createPRG.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPRGText
            // 
            this.AddPRGText.Location = new System.Drawing.Point(23, 77);
            this.AddPRGText.Name = "AddPRGText";
            this.AddPRGText.Size = new System.Drawing.Size(81, 34);
            this.AddPRGText.TabIndex = 28;
            this.AddPRGText.Text = "Add Text";
            this.AddPRGText.UseVisualStyleBackColor = true;
            this.AddPRGText.Click += new System.EventHandler(this.AddPRGText_Click);
            // 
            // RunPRG
            // 
            this.RunPRG.Location = new System.Drawing.Point(120, 23);
            this.RunPRG.Name = "RunPRG";
            this.RunPRG.Size = new System.Drawing.Size(84, 45);
            this.RunPRG.TabIndex = 29;
            this.RunPRG.Text = "Run Program";
            this.RunPRG.UseVisualStyleBackColor = true;
            this.RunPRG.Click += new System.EventHandler(this.RunPRG_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Estado:";
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.Location = new System.Drawing.Point(68, 34);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(92, 17);
            this.status1.TabIndex = 29;
            this.status1.Text = "disconectado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Estado:";
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.Location = new System.Drawing.Point(86, 34);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(92, 17);
            this.status2.TabIndex = 30;
            this.status2.Text = "disconectado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 410);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_edtWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_edtHeight);
            this.Controls.Add(this.btnPlayOneProgram);
            this.Controls.Add(this.m_edtSelProgram);
            this.Controls.Add(this.btnSplitWnd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "C-Power Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton RadioBtnCom;
        public System.Windows.Forms.RadioButton RadioBtnNetWork;
        private System.Windows.Forms.Button btnSplitWnd;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.Button btnSendPicture;
        private System.Windows.Forms.Button btnSendStaticText;
        private System.Windows.Forms.Button btnSendClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox m_cmbPort;
        private System.Windows.Forms.ComboBox m_cmbBaudrate;
        private System.Windows.Forms.ComboBox m_cmbID;
        private System.Windows.Forms.TextBox IPAddr;
        private System.Windows.Forms.TextBox IPPort;
        private System.Windows.Forms.TextBox IDCode;
        internal System.Windows.Forms.TextBox m_edtText;
        internal System.Windows.Forms.TextBox m_edtPicture;
        internal System.Windows.Forms.TextBox m_edtStaticText;
        internal System.Windows.Forms.Button btnSetTime;
        internal System.Windows.Forms.TextBox m_edtWidth;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox m_edtHeight;
        internal System.Windows.Forms.Button btnPlayOneProgram;
        internal System.Windows.Forms.TextBox m_edtSelProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button createPRG;
        private System.Windows.Forms.Button AddPRGText;
        private System.Windows.Forms.Button RunPRG;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label label10;
    }
}

