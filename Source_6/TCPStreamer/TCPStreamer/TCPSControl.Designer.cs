namespace TCPStreamer
{
    partial class TCPSControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.ComboboxInputSoundDeviceNameClient = new System.Windows.Forms.ComboBox();
            this.GroupBoxServerStart = new System.Windows.Forms.GroupBox();
            this.ButtonServerListen = new System.Windows.Forms.Button();
            this.ButtonServerSpeak = new System.Windows.Forms.Button();
            this.ComboboxInputSoundDeviceNameServer = new System.Windows.Forms.ComboBox();
            this.LabelInputSoundDeviceNameServer = new System.Windows.Forms.Label();
            this.LabelOutputSoundDeviceNameServer = new System.Windows.Forms.Label();
            this.ComboboxOutputSoundDeviceNameServer = new System.Windows.Forms.ComboBox();
            this.LabelIPAddressClient = new System.Windows.Forms.Label();
            this.FlowLayoutPanelServerClients = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanelServerProgressBars = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanelServerSpeak = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxServerClients = new System.Windows.Forms.GroupBox();
            this.FlowLayoutPanelServerListen = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBoxServerAddress = new System.Windows.Forms.TextBox();
            this.LabelServerPort = new System.Windows.Forms.Label();
            this.TextBoxServerPort = new System.Windows.Forms.TextBox();
            this.ButtonServer = new System.Windows.Forms.Button();
            this.ComboboxSamplesPerSecondServer = new System.Windows.Forms.ComboBox();
            this.LabelJitterBufferServer = new System.Windows.Forms.Label();
            this.LabelSamplesPerSecondServer = new System.Windows.Forms.Label();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageServer = new System.Windows.Forms.TabPage();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.GroupBoxServer = new System.Windows.Forms.GroupBox();
            this.NumericUpDownJitterBufferServer = new System.Windows.Forms.NumericUpDown();
            this.LabelServer = new System.Windows.Forms.Label();
            this.TabPageClient = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.GroupBoxSound = new System.Windows.Forms.GroupBox();
            this.ProgressBarPlayingClient = new System.Windows.Forms.ProgressBar();
            this.ButtonClientSpeak = new System.Windows.Forms.Button();
            this.ButtonClientListen = new System.Windows.Forms.Button();
            this.ComboboxOutputSoundDeviceNameClient = new System.Windows.Forms.ComboBox();
            this.LabelOutputSoundDeviceNameClient = new System.Windows.Forms.Label();
            this.GroupBoxClient = new System.Windows.Forms.GroupBox();
            this.LabelIPAddressServer = new System.Windows.Forms.Label();
            this.TextBoxClientAddress = new System.Windows.Forms.TextBox();
            this.NumericUpDownJitterBufferClient = new System.Windows.Forms.NumericUpDown();
            this.ButtonClient = new System.Windows.Forms.Button();
            this.LabelJitterBufferClient = new System.Windows.Forms.Label();
            this.TextBoxClientPort = new System.Windows.Forms.TextBox();
            this.LabelPortServer = new System.Windows.Forms.Label();
            this.LabelClient = new System.Windows.Forms.Label();
            this.GroupBoxServerStart.SuspendLayout();
            this.GroupBoxServerClients.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            this.TabPageServer.SuspendLayout();
            this.GroupBoxServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownJitterBufferServer)).BeginInit();
            this.TabPageClient.SuspendLayout();
            this.GroupBoxSound.SuspendLayout();
            this.GroupBoxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownJitterBufferClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Speak";
            // 
            // OpenFileDialogMain
            // 
            this.OpenFileDialogMain.FileName = "MyRecord.wav";
            this.OpenFileDialogMain.Filter = "Wave Dateien (*.wav)|*.wav|Alle Dateien (*.*)|*.*";
            // 
            // ComboboxInputSoundDeviceNameClient
            // 
            this.ComboboxInputSoundDeviceNameClient.BackColor = System.Drawing.Color.White;
            this.ComboboxInputSoundDeviceNameClient.DropDownHeight = 800;
            this.ComboboxInputSoundDeviceNameClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxInputSoundDeviceNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxInputSoundDeviceNameClient.ForeColor = System.Drawing.Color.Black;
            this.ComboboxInputSoundDeviceNameClient.FormattingEnabled = true;
            this.ComboboxInputSoundDeviceNameClient.IntegralHeight = false;
            this.ComboboxInputSoundDeviceNameClient.Location = new System.Drawing.Point(112, 22);
            this.ComboboxInputSoundDeviceNameClient.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxInputSoundDeviceNameClient.Name = "ComboboxInputSoundDeviceNameClient";
            this.ComboboxInputSoundDeviceNameClient.Size = new System.Drawing.Size(265, 24);
            this.ComboboxInputSoundDeviceNameClient.TabIndex = 35;
            // 
            // GroupBoxServerStart
            // 
            this.GroupBoxServerStart.Controls.Add(this.ButtonServerListen);
            this.GroupBoxServerStart.Controls.Add(this.ButtonServerSpeak);
            this.GroupBoxServerStart.Controls.Add(this.ComboboxInputSoundDeviceNameServer);
            this.GroupBoxServerStart.Controls.Add(this.LabelInputSoundDeviceNameServer);
            this.GroupBoxServerStart.Controls.Add(this.LabelOutputSoundDeviceNameServer);
            this.GroupBoxServerStart.Controls.Add(this.ComboboxOutputSoundDeviceNameServer);
            this.GroupBoxServerStart.Location = new System.Drawing.Point(8, 167);
            this.GroupBoxServerStart.Name = "GroupBoxServerStart";
            this.GroupBoxServerStart.Size = new System.Drawing.Size(376, 92);
            this.GroupBoxServerStart.TabIndex = 35;
            this.GroupBoxServerStart.TabStop = false;
            // 
            // ButtonServerListen
            // 
            this.ButtonServerListen.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonServerListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonServerListen.Image = global::TCPStreamer.Properties.Resources.Listen_On;
            this.ButtonServerListen.Location = new System.Drawing.Point(68, 52);
            this.ButtonServerListen.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonServerListen.Name = "ButtonServerListen";
            this.ButtonServerListen.Size = new System.Drawing.Size(32, 32);
            this.ButtonServerListen.TabIndex = 44;
            this.ButtonServerListen.UseVisualStyleBackColor = false;
            this.ButtonServerListen.Click += new System.EventHandler(this.ButtonServerListen_Click);
            // 
            // ButtonServerSpeak
            // 
            this.ButtonServerSpeak.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonServerSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonServerSpeak.Image = global::TCPStreamer.Properties.Resources.Speak_On;
            this.ButtonServerSpeak.Location = new System.Drawing.Point(68, 16);
            this.ButtonServerSpeak.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonServerSpeak.Name = "ButtonServerSpeak";
            this.ButtonServerSpeak.Size = new System.Drawing.Size(32, 32);
            this.ButtonServerSpeak.TabIndex = 43;
            this.ButtonServerSpeak.UseVisualStyleBackColor = false;
            this.ButtonServerSpeak.Click += new System.EventHandler(this.ButtonServerSpeak_Click);
            // 
            // ComboboxInputSoundDeviceNameServer
            // 
            this.ComboboxInputSoundDeviceNameServer.BackColor = System.Drawing.Color.White;
            this.ComboboxInputSoundDeviceNameServer.DropDownHeight = 800;
            this.ComboboxInputSoundDeviceNameServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxInputSoundDeviceNameServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxInputSoundDeviceNameServer.ForeColor = System.Drawing.Color.Black;
            this.ComboboxInputSoundDeviceNameServer.FormattingEnabled = true;
            this.ComboboxInputSoundDeviceNameServer.IntegralHeight = false;
            this.ComboboxInputSoundDeviceNameServer.Location = new System.Drawing.Point(117, 19);
            this.ComboboxInputSoundDeviceNameServer.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxInputSoundDeviceNameServer.Name = "ComboboxInputSoundDeviceNameServer";
            this.ComboboxInputSoundDeviceNameServer.Size = new System.Drawing.Size(251, 24);
            this.ComboboxInputSoundDeviceNameServer.TabIndex = 42;
            // 
            // LabelInputSoundDeviceNameServer
            // 
            this.LabelInputSoundDeviceNameServer.AutoSize = true;
            this.LabelInputSoundDeviceNameServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInputSoundDeviceNameServer.Location = new System.Drawing.Point(5, 24);
            this.LabelInputSoundDeviceNameServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInputSoundDeviceNameServer.Name = "LabelInputSoundDeviceNameServer";
            this.LabelInputSoundDeviceNameServer.Size = new System.Drawing.Size(48, 17);
            this.LabelInputSoundDeviceNameServer.TabIndex = 41;
            this.LabelInputSoundDeviceNameServer.Text = "Speak";
            // 
            // LabelOutputSoundDeviceNameServer
            // 
            this.LabelOutputSoundDeviceNameServer.AutoSize = true;
            this.LabelOutputSoundDeviceNameServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutputSoundDeviceNameServer.Location = new System.Drawing.Point(6, 61);
            this.LabelOutputSoundDeviceNameServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOutputSoundDeviceNameServer.Name = "LabelOutputSoundDeviceNameServer";
            this.LabelOutputSoundDeviceNameServer.Size = new System.Drawing.Size(46, 17);
            this.LabelOutputSoundDeviceNameServer.TabIndex = 11;
            this.LabelOutputSoundDeviceNameServer.Text = "Listen";
            // 
            // ComboboxOutputSoundDeviceNameServer
            // 
            this.ComboboxOutputSoundDeviceNameServer.BackColor = System.Drawing.Color.White;
            this.ComboboxOutputSoundDeviceNameServer.DropDownHeight = 800;
            this.ComboboxOutputSoundDeviceNameServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxOutputSoundDeviceNameServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxOutputSoundDeviceNameServer.ForeColor = System.Drawing.Color.Black;
            this.ComboboxOutputSoundDeviceNameServer.FormattingEnabled = true;
            this.ComboboxOutputSoundDeviceNameServer.IntegralHeight = false;
            this.ComboboxOutputSoundDeviceNameServer.Location = new System.Drawing.Point(117, 58);
            this.ComboboxOutputSoundDeviceNameServer.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxOutputSoundDeviceNameServer.Name = "ComboboxOutputSoundDeviceNameServer";
            this.ComboboxOutputSoundDeviceNameServer.Size = new System.Drawing.Size(251, 24);
            this.ComboboxOutputSoundDeviceNameServer.TabIndex = 12;
            // 
            // LabelIPAddressClient
            // 
            this.LabelIPAddressClient.AutoSize = true;
            this.LabelIPAddressClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIPAddressClient.Location = new System.Drawing.Point(5, 25);
            this.LabelIPAddressClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelIPAddressClient.Name = "LabelIPAddressClient";
            this.LabelIPAddressClient.Size = new System.Drawing.Size(58, 13);
            this.LabelIPAddressClient.TabIndex = 19;
            this.LabelIPAddressClient.Text = "IP Address";
            // 
            // FlowLayoutPanelServerClients
            // 
            this.FlowLayoutPanelServerClients.BackColor = System.Drawing.Color.DimGray;
            this.FlowLayoutPanelServerClients.Location = new System.Drawing.Point(8, 21);
            this.FlowLayoutPanelServerClients.Name = "FlowLayoutPanelServerClients";
            this.FlowLayoutPanelServerClients.Size = new System.Drawing.Size(151, 206);
            this.FlowLayoutPanelServerClients.TabIndex = 36;
            // 
            // FlowLayoutPanelServerProgressBars
            // 
            this.FlowLayoutPanelServerProgressBars.BackColor = System.Drawing.Color.DimGray;
            this.FlowLayoutPanelServerProgressBars.Location = new System.Drawing.Point(158, 21);
            this.FlowLayoutPanelServerProgressBars.Name = "FlowLayoutPanelServerProgressBars";
            this.FlowLayoutPanelServerProgressBars.Size = new System.Drawing.Size(210, 206);
            this.FlowLayoutPanelServerProgressBars.TabIndex = 37;
            // 
            // FlowLayoutPanelServerSpeak
            // 
            this.FlowLayoutPanelServerSpeak.BackColor = System.Drawing.Color.DimGray;
            this.FlowLayoutPanelServerSpeak.Location = new System.Drawing.Point(363, 22);
            this.FlowLayoutPanelServerSpeak.Name = "FlowLayoutPanelServerSpeak";
            this.FlowLayoutPanelServerSpeak.Size = new System.Drawing.Size(36, 206);
            this.FlowLayoutPanelServerSpeak.TabIndex = 39;
            // 
            // GroupBoxServerClients
            // 
            this.GroupBoxServerClients.Controls.Add(this.FlowLayoutPanelServerSpeak);
            this.GroupBoxServerClients.Controls.Add(this.FlowLayoutPanelServerListen);
            this.GroupBoxServerClients.Controls.Add(this.FlowLayoutPanelServerClients);
            this.GroupBoxServerClients.Controls.Add(this.FlowLayoutPanelServerProgressBars);
            this.GroupBoxServerClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxServerClients.Location = new System.Drawing.Point(8, 265);
            this.GroupBoxServerClients.Name = "GroupBoxServerClients";
            this.GroupBoxServerClients.Size = new System.Drawing.Size(376, 233);
            this.GroupBoxServerClients.TabIndex = 38;
            this.GroupBoxServerClients.TabStop = false;
            this.GroupBoxServerClients.Text = "Clients";
            // 
            // FlowLayoutPanelServerListen
            // 
            this.FlowLayoutPanelServerListen.BackColor = System.Drawing.Color.DimGray;
            this.FlowLayoutPanelServerListen.Location = new System.Drawing.Point(396, 21);
            this.FlowLayoutPanelServerListen.Name = "FlowLayoutPanelServerListen";
            this.FlowLayoutPanelServerListen.Size = new System.Drawing.Size(30, 206);
            this.FlowLayoutPanelServerListen.TabIndex = 38;
            // 
            // TextBoxServerAddress
            // 
            this.TextBoxServerAddress.BackColor = System.Drawing.Color.White;
            this.TextBoxServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxServerAddress.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxServerAddress.Location = new System.Drawing.Point(68, 22);
            this.TextBoxServerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxServerAddress.Name = "TextBoxServerAddress";
            this.TextBoxServerAddress.Size = new System.Drawing.Size(117, 20);
            this.TextBoxServerAddress.TabIndex = 13;
            this.TextBoxServerAddress.Text = "192.168.0.101";
            this.TextBoxServerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelServerPort
            // 
            this.LabelServerPort.AutoSize = true;
            this.LabelServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelServerPort.Location = new System.Drawing.Point(196, 25);
            this.LabelServerPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelServerPort.Name = "LabelServerPort";
            this.LabelServerPort.Size = new System.Drawing.Size(26, 13);
            this.LabelServerPort.TabIndex = 15;
            this.LabelServerPort.Text = "Port";
            // 
            // TextBoxServerPort
            // 
            this.TextBoxServerPort.BackColor = System.Drawing.Color.White;
            this.TextBoxServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxServerPort.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxServerPort.Location = new System.Drawing.Point(226, 22);
            this.TextBoxServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxServerPort.Name = "TextBoxServerPort";
            this.TextBoxServerPort.Size = new System.Drawing.Size(59, 20);
            this.TextBoxServerPort.TabIndex = 14;
            this.TextBoxServerPort.Text = "7000";
            this.TextBoxServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonServer
            // 
            this.ButtonServer.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonServer.Location = new System.Drawing.Point(293, 18);
            this.ButtonServer.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonServer.Name = "ButtonServer";
            this.ButtonServer.Size = new System.Drawing.Size(75, 27);
            this.ButtonServer.TabIndex = 0;
            this.ButtonServer.Text = "Start";
            this.ButtonServer.UseVisualStyleBackColor = false;
            this.ButtonServer.Click += new System.EventHandler(this.ButtonServer_Click);
            // 
            // ComboboxSamplesPerSecondServer
            // 
            this.ComboboxSamplesPerSecondServer.BackColor = System.Drawing.Color.White;
            this.ComboboxSamplesPerSecondServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxSamplesPerSecondServer.FormattingEnabled = true;
            this.ComboboxSamplesPerSecondServer.Items.AddRange(new object[] {
            "5000",
            "8000",
            "22050",
            "44100"});
            this.ComboboxSamplesPerSecondServer.Location = new System.Drawing.Point(114, 56);
            this.ComboboxSamplesPerSecondServer.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxSamplesPerSecondServer.Name = "ComboboxSamplesPerSecondServer";
            this.ComboboxSamplesPerSecondServer.Size = new System.Drawing.Size(71, 21);
            this.ComboboxSamplesPerSecondServer.TabIndex = 40;
            // 
            // LabelJitterBufferServer
            // 
            this.LabelJitterBufferServer.AutoSize = true;
            this.LabelJitterBufferServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJitterBufferServer.Location = new System.Drawing.Point(243, 61);
            this.LabelJitterBufferServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelJitterBufferServer.Name = "LabelJitterBufferServer";
            this.LabelJitterBufferServer.Size = new System.Drawing.Size(45, 17);
            this.LabelJitterBufferServer.TabIndex = 34;
            this.LabelJitterBufferServer.Text = "Jitter";
            // 
            // LabelSamplesPerSecondServer
            // 
            this.LabelSamplesPerSecondServer.AutoSize = true;
            this.LabelSamplesPerSecondServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSamplesPerSecondServer.Location = new System.Drawing.Point(5, 59);
            this.LabelSamplesPerSecondServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSamplesPerSecondServer.Name = "LabelSamplesPerSecondServer";
            this.LabelSamplesPerSecondServer.Size = new System.Drawing.Size(105, 13);
            this.LabelSamplesPerSecondServer.TabIndex = 37;
            this.LabelSamplesPerSecondServer.Text = "Samples per Second";
            // 
            // TabControlMain
            // 
            this.TabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMain.Controls.Add(this.TabPageServer);
            this.TabControlMain.Controls.Add(this.TabPageClient);
            this.TabControlMain.Location = new System.Drawing.Point(3, 3);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(407, 576);
            this.TabControlMain.TabIndex = 41;
            this.TabControlMain.Visible = false;
            // 
            // TabPageServer
            // 
            this.TabPageServer.Controls.Add(this.btnClose2);
            this.TabPageServer.Controls.Add(this.GroupBoxServerClients);
            this.TabPageServer.Controls.Add(this.GroupBoxServer);
            this.TabPageServer.Controls.Add(this.GroupBoxServerStart);
            this.TabPageServer.Location = new System.Drawing.Point(4, 22);
            this.TabPageServer.Name = "TabPageServer";
            this.TabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageServer.Size = new System.Drawing.Size(399, 550);
            this.TabPageServer.TabIndex = 1;
            this.TabPageServer.Text = "Server";
            this.TabPageServer.UseVisualStyleBackColor = true;
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(108, 504);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(172, 34);
            this.btnClose2.TabIndex = 39;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // GroupBoxServer
            // 
            this.GroupBoxServer.Controls.Add(this.LabelIPAddressClient);
            this.GroupBoxServer.Controls.Add(this.TextBoxServerAddress);
            this.GroupBoxServer.Controls.Add(this.ButtonServer);
            this.GroupBoxServer.Controls.Add(this.LabelServerPort);
            this.GroupBoxServer.Controls.Add(this.ComboboxSamplesPerSecondServer);
            this.GroupBoxServer.Controls.Add(this.LabelJitterBufferServer);
            this.GroupBoxServer.Controls.Add(this.LabelSamplesPerSecondServer);
            this.GroupBoxServer.Controls.Add(this.TextBoxServerPort);
            this.GroupBoxServer.Controls.Add(this.NumericUpDownJitterBufferServer);
            this.GroupBoxServer.Controls.Add(this.LabelServer);
            this.GroupBoxServer.Location = new System.Drawing.Point(8, 4);
            this.GroupBoxServer.Name = "GroupBoxServer";
            this.GroupBoxServer.Size = new System.Drawing.Size(376, 157);
            this.GroupBoxServer.TabIndex = 27;
            this.GroupBoxServer.TabStop = false;
            this.GroupBoxServer.Text = "Server";
            // 
            // NumericUpDownJitterBufferServer
            // 
            this.NumericUpDownJitterBufferServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownJitterBufferServer.Location = new System.Drawing.Point(293, 59);
            this.NumericUpDownJitterBufferServer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownJitterBufferServer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownJitterBufferServer.Name = "NumericUpDownJitterBufferServer";
            this.NumericUpDownJitterBufferServer.Size = new System.Drawing.Size(75, 21);
            this.NumericUpDownJitterBufferServer.TabIndex = 33;
            this.NumericUpDownJitterBufferServer.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUpDownJitterBufferServer.ValueChanged += new System.EventHandler(this.NumericUpDownJitterBufferServer_ValueChanged);
            // 
            // LabelServer
            // 
            this.LabelServer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LabelServer.Location = new System.Drawing.Point(9, 85);
            this.LabelServer.Name = "LabelServer";
            this.LabelServer.Size = new System.Drawing.Size(359, 59);
            this.LabelServer.TabIndex = 28;
            // 
            // TabPageClient
            // 
            this.TabPageClient.Controls.Add(this.btnClose);
            this.TabPageClient.Controls.Add(this.GroupBoxSound);
            this.TabPageClient.Controls.Add(this.GroupBoxClient);
            this.TabPageClient.Location = new System.Drawing.Point(4, 22);
            this.TabPageClient.Name = "TabPageClient";
            this.TabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageClient.Size = new System.Drawing.Size(399, 550);
            this.TabPageClient.TabIndex = 0;
            this.TabPageClient.Text = "Client";
            this.TabPageClient.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(123, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 34);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // GroupBoxSound
            // 
            this.GroupBoxSound.Controls.Add(this.ProgressBarPlayingClient);
            this.GroupBoxSound.Controls.Add(this.ButtonClientSpeak);
            this.GroupBoxSound.Controls.Add(this.ComboboxInputSoundDeviceNameClient);
            this.GroupBoxSound.Controls.Add(this.ButtonClientListen);
            this.GroupBoxSound.Controls.Add(this.label1);
            this.GroupBoxSound.Controls.Add(this.ComboboxOutputSoundDeviceNameClient);
            this.GroupBoxSound.Controls.Add(this.LabelOutputSoundDeviceNameClient);
            this.GroupBoxSound.Location = new System.Drawing.Point(11, 388);
            this.GroupBoxSound.Name = "GroupBoxSound";
            this.GroupBoxSound.Size = new System.Drawing.Size(377, 108);
            this.GroupBoxSound.TabIndex = 30;
            this.GroupBoxSound.TabStop = false;
            // 
            // ProgressBarPlayingClient
            // 
            this.ProgressBarPlayingClient.Location = new System.Drawing.Point(112, 61);
            this.ProgressBarPlayingClient.Name = "ProgressBarPlayingClient";
            this.ProgressBarPlayingClient.Size = new System.Drawing.Size(254, 24);
            this.ProgressBarPlayingClient.TabIndex = 37;
            this.ProgressBarPlayingClient.Visible = false;
            // 
            // ButtonClientSpeak
            // 
            this.ButtonClientSpeak.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonClientSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClientSpeak.Image = global::TCPStreamer.Properties.Resources.Speak_On;
            this.ButtonClientSpeak.Location = new System.Drawing.Point(59, 17);
            this.ButtonClientSpeak.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClientSpeak.Name = "ButtonClientSpeak";
            this.ButtonClientSpeak.Size = new System.Drawing.Size(32, 32);
            this.ButtonClientSpeak.TabIndex = 44;
            this.ButtonClientSpeak.UseVisualStyleBackColor = false;
            this.ButtonClientSpeak.Click += new System.EventHandler(this.ButtonClientSpeak_Click);
            // 
            // ButtonClientListen
            // 
            this.ButtonClientListen.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonClientListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClientListen.Image = global::TCPStreamer.Properties.Resources.Listen_On;
            this.ButtonClientListen.Location = new System.Drawing.Point(58, 56);
            this.ButtonClientListen.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClientListen.Name = "ButtonClientListen";
            this.ButtonClientListen.Size = new System.Drawing.Size(32, 32);
            this.ButtonClientListen.TabIndex = 45;
            this.ButtonClientListen.UseVisualStyleBackColor = false;
            this.ButtonClientListen.Click += new System.EventHandler(this.ButtonClientListen_Click);
            // 
            // ComboboxOutputSoundDeviceNameClient
            // 
            this.ComboboxOutputSoundDeviceNameClient.BackColor = System.Drawing.Color.White;
            this.ComboboxOutputSoundDeviceNameClient.DropDownHeight = 800;
            this.ComboboxOutputSoundDeviceNameClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxOutputSoundDeviceNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxOutputSoundDeviceNameClient.ForeColor = System.Drawing.Color.Black;
            this.ComboboxOutputSoundDeviceNameClient.FormattingEnabled = true;
            this.ComboboxOutputSoundDeviceNameClient.IntegralHeight = false;
            this.ComboboxOutputSoundDeviceNameClient.Location = new System.Drawing.Point(112, 61);
            this.ComboboxOutputSoundDeviceNameClient.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxOutputSoundDeviceNameClient.Name = "ComboboxOutputSoundDeviceNameClient";
            this.ComboboxOutputSoundDeviceNameClient.Size = new System.Drawing.Size(265, 24);
            this.ComboboxOutputSoundDeviceNameClient.TabIndex = 12;
            // 
            // LabelOutputSoundDeviceNameClient
            // 
            this.LabelOutputSoundDeviceNameClient.AutoSize = true;
            this.LabelOutputSoundDeviceNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutputSoundDeviceNameClient.Location = new System.Drawing.Point(8, 64);
            this.LabelOutputSoundDeviceNameClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOutputSoundDeviceNameClient.Name = "LabelOutputSoundDeviceNameClient";
            this.LabelOutputSoundDeviceNameClient.Size = new System.Drawing.Size(46, 17);
            this.LabelOutputSoundDeviceNameClient.TabIndex = 11;
            this.LabelOutputSoundDeviceNameClient.Text = "Listen";
            // 
            // GroupBoxClient
            // 
            this.GroupBoxClient.Controls.Add(this.LabelIPAddressServer);
            this.GroupBoxClient.Controls.Add(this.TextBoxClientAddress);
            this.GroupBoxClient.Controls.Add(this.NumericUpDownJitterBufferClient);
            this.GroupBoxClient.Controls.Add(this.ButtonClient);
            this.GroupBoxClient.Controls.Add(this.LabelJitterBufferClient);
            this.GroupBoxClient.Controls.Add(this.TextBoxClientPort);
            this.GroupBoxClient.Controls.Add(this.LabelPortServer);
            this.GroupBoxClient.Controls.Add(this.LabelClient);
            this.GroupBoxClient.Location = new System.Drawing.Point(8, 4);
            this.GroupBoxClient.Name = "GroupBoxClient";
            this.GroupBoxClient.Size = new System.Drawing.Size(432, 378);
            this.GroupBoxClient.TabIndex = 22;
            this.GroupBoxClient.TabStop = false;
            this.GroupBoxClient.Text = "Client";
            // 
            // LabelIPAddressServer
            // 
            this.LabelIPAddressServer.AutoSize = true;
            this.LabelIPAddressServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIPAddressServer.Location = new System.Drawing.Point(5, 25);
            this.LabelIPAddressServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelIPAddressServer.Name = "LabelIPAddressServer";
            this.LabelIPAddressServer.Size = new System.Drawing.Size(58, 13);
            this.LabelIPAddressServer.TabIndex = 19;
            this.LabelIPAddressServer.Text = "IP Address";
            // 
            // TextBoxClientAddress
            // 
            this.TextBoxClientAddress.BackColor = System.Drawing.Color.White;
            this.TextBoxClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClientAddress.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxClientAddress.Location = new System.Drawing.Point(63, 22);
            this.TextBoxClientAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxClientAddress.Name = "TextBoxClientAddress";
            this.TextBoxClientAddress.Size = new System.Drawing.Size(95, 20);
            this.TextBoxClientAddress.TabIndex = 13;
            this.TextBoxClientAddress.Text = "192.168.0.101";
            this.TextBoxClientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumericUpDownJitterBufferClient
            // 
            this.NumericUpDownJitterBufferClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownJitterBufferClient.Location = new System.Drawing.Point(331, 22);
            this.NumericUpDownJitterBufferClient.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownJitterBufferClient.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownJitterBufferClient.Name = "NumericUpDownJitterBufferClient";
            this.NumericUpDownJitterBufferClient.Size = new System.Drawing.Size(38, 21);
            this.NumericUpDownJitterBufferClient.TabIndex = 35;
            this.NumericUpDownJitterBufferClient.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUpDownJitterBufferClient.ValueChanged += new System.EventHandler(this.NumericUpDownJitterBufferClient_ValueChanged);
            // 
            // ButtonClient
            // 
            this.ButtonClient.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClient.ForeColor = System.Drawing.Color.Black;
            this.ButtonClient.Location = new System.Drawing.Point(8, 49);
            this.ButtonClient.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClient.Name = "ButtonClient";
            this.ButtonClient.Size = new System.Drawing.Size(373, 45);
            this.ButtonClient.TabIndex = 0;
            this.ButtonClient.Text = "Connect";
            this.ButtonClient.UseVisualStyleBackColor = false;
            this.ButtonClient.Click += new System.EventHandler(this.ButtonClient_Click);
            // 
            // LabelJitterBufferClient
            // 
            this.LabelJitterBufferClient.AutoSize = true;
            this.LabelJitterBufferClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJitterBufferClient.Location = new System.Drawing.Point(278, 23);
            this.LabelJitterBufferClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelJitterBufferClient.Name = "LabelJitterBufferClient";
            this.LabelJitterBufferClient.Size = new System.Drawing.Size(45, 17);
            this.LabelJitterBufferClient.TabIndex = 36;
            this.LabelJitterBufferClient.Text = "Jitter";
            // 
            // TextBoxClientPort
            // 
            this.TextBoxClientPort.BackColor = System.Drawing.Color.White;
            this.TextBoxClientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxClientPort.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxClientPort.Location = new System.Drawing.Point(192, 21);
            this.TextBoxClientPort.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxClientPort.Name = "TextBoxClientPort";
            this.TextBoxClientPort.Size = new System.Drawing.Size(41, 20);
            this.TextBoxClientPort.TabIndex = 14;
            this.TextBoxClientPort.Text = "7000";
            this.TextBoxClientPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelPortServer
            // 
            this.LabelPortServer.AutoSize = true;
            this.LabelPortServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPortServer.Location = new System.Drawing.Point(162, 25);
            this.LabelPortServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPortServer.Name = "LabelPortServer";
            this.LabelPortServer.Size = new System.Drawing.Size(26, 13);
            this.LabelPortServer.TabIndex = 15;
            this.LabelPortServer.Text = "Port";
            // 
            // LabelClient
            // 
            this.LabelClient.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LabelClient.Location = new System.Drawing.Point(9, 106);
            this.LabelClient.Name = "LabelClient";
            this.LabelClient.Size = new System.Drawing.Size(371, 257);
            this.LabelClient.TabIndex = 26;
            // 
            // TCPSControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControlMain);
            this.Name = "TCPSControl";
            this.Size = new System.Drawing.Size(413, 582);
            this.GroupBoxServerStart.ResumeLayout(false);
            this.GroupBoxServerStart.PerformLayout();
            this.GroupBoxServerClients.ResumeLayout(false);
            this.TabControlMain.ResumeLayout(false);
            this.TabPageServer.ResumeLayout(false);
            this.GroupBoxServer.ResumeLayout(false);
            this.GroupBoxServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownJitterBufferServer)).EndInit();
            this.TabPageClient.ResumeLayout(false);
            this.GroupBoxSound.ResumeLayout(false);
            this.GroupBoxSound.PerformLayout();
            this.GroupBoxClient.ResumeLayout(false);
            this.GroupBoxClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownJitterBufferClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogMain;
        private System.Windows.Forms.GroupBox GroupBoxServerStart;
        private System.Windows.Forms.Button ButtonServerListen;
        private System.Windows.Forms.Button ButtonServerSpeak;
        private System.Windows.Forms.ComboBox ComboboxInputSoundDeviceNameServer;
        private System.Windows.Forms.Label LabelInputSoundDeviceNameServer;
        private System.Windows.Forms.Label LabelOutputSoundDeviceNameServer;
        private System.Windows.Forms.ComboBox ComboboxOutputSoundDeviceNameServer;
        private System.Windows.Forms.Label LabelIPAddressClient;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelServerClients;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelServerProgressBars;
        private System.Windows.Forms.GroupBox GroupBoxServerClients;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelServerSpeak;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelServerListen;
        private System.Windows.Forms.Label LabelServerPort;
        private System.Windows.Forms.Label LabelJitterBufferServer;
        private System.Windows.Forms.Label LabelSamplesPerSecondServer;
        private System.Windows.Forms.TabPage TabPageServer;
        private System.Windows.Forms.GroupBox GroupBoxServer;
        private System.Windows.Forms.Label LabelServer;
        private System.Windows.Forms.TabPage TabPageClient;
        private System.Windows.Forms.GroupBox GroupBoxSound;
        private System.Windows.Forms.ComboBox ComboboxOutputSoundDeviceNameClient;
        private System.Windows.Forms.Label LabelOutputSoundDeviceNameClient;
        private System.Windows.Forms.GroupBox GroupBoxClient;
        private System.Windows.Forms.Label LabelIPAddressServer;
        private System.Windows.Forms.Label LabelJitterBufferClient;
        private System.Windows.Forms.Label LabelPortServer;
        private System.Windows.Forms.Label LabelClient;
        public System.Windows.Forms.Button btnClose2;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button ButtonClientSpeak;
        public System.Windows.Forms.Button ButtonClientListen;
        public System.Windows.Forms.ComboBox ComboboxInputSoundDeviceNameClient;
        public System.Windows.Forms.TextBox TextBoxServerAddress;
        public System.Windows.Forms.TextBox TextBoxServerPort;
        public System.Windows.Forms.Button ButtonServer;
        public System.Windows.Forms.ComboBox ComboboxSamplesPerSecondServer;
        public System.Windows.Forms.TabControl TabControlMain;
        public System.Windows.Forms.NumericUpDown NumericUpDownJitterBufferServer;
        public System.Windows.Forms.ProgressBar ProgressBarPlayingClient;
        public System.Windows.Forms.TextBox TextBoxClientAddress;
        public System.Windows.Forms.NumericUpDown NumericUpDownJitterBufferClient;
        public System.Windows.Forms.Button ButtonClient;
        public System.Windows.Forms.TextBox TextBoxClientPort;
    }
}
