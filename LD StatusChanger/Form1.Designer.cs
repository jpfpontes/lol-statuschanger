namespace LD_StatusChanger
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ApplyMissionBtn = new System.Windows.Forms.Button();
            this.MissionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusAtual = new System.Windows.Forms.Label();
            this.statusBtn = new System.Windows.Forms.Button();
            this.iconBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.icon1 = new System.Windows.Forms.RadioButton();
            this.icon3 = new System.Windows.Forms.RadioButton();
            this.icon16 = new System.Windows.Forms.RadioButton();
            this.icon19 = new System.Windows.Forms.RadioButton();
            this.icon9 = new System.Windows.Forms.RadioButton();
            this.icon23 = new System.Windows.Forms.RadioButton();
            this.icon2 = new System.Windows.Forms.RadioButton();
            this.icon14 = new System.Windows.Forms.RadioButton();
            this.icon4 = new System.Windows.Forms.RadioButton();
            this.icon5 = new System.Windows.Forms.RadioButton();
            this.icon6 = new System.Windows.Forms.RadioButton();
            this.icon7 = new System.Windows.Forms.RadioButton();
            this.icon11 = new System.Windows.Forms.RadioButton();
            this.icon12 = new System.Windows.Forms.RadioButton();
            this.icon13 = new System.Windows.Forms.RadioButton();
            this.icon8 = new System.Windows.Forms.RadioButton();
            this.icon15 = new System.Windows.Forms.RadioButton();
            this.icon17 = new System.Windows.Forms.RadioButton();
            this.icon18 = new System.Windows.Forms.RadioButton();
            this.icon20 = new System.Windows.Forms.RadioButton();
            this.icon21 = new System.Windows.Forms.RadioButton();
            this.icon22 = new System.Windows.Forms.RadioButton();
            this.icon10 = new System.Windows.Forms.RadioButton();
            this.icon24 = new System.Windows.Forms.RadioButton();
            this.icon25 = new System.Windows.Forms.RadioButton();
            this.icon26 = new System.Windows.Forms.RadioButton();
            this.icon27 = new System.Windows.Forms.RadioButton();
            this.icon28 = new System.Windows.Forms.RadioButton();
            this.icon29 = new System.Windows.Forms.RadioButton();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.ApplyIconButton = new System.Windows.Forms.Button();
            this.statusAtual2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshUpdate = new System.Windows.Forms.Timer(this.components);
            this.avisoLol = new System.Windows.Forms.Label();
            this.statusPanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyMissionBtn
            // 
            this.ApplyMissionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyMissionBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ApplyMissionBtn.Location = new System.Drawing.Point(239, 333);
            this.ApplyMissionBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ApplyMissionBtn.Name = "ApplyMissionBtn";
            this.ApplyMissionBtn.Size = new System.Drawing.Size(62, 27);
            this.ApplyMissionBtn.TabIndex = 0;
            this.ApplyMissionBtn.Text = "Aplicar";
            this.ApplyMissionBtn.UseVisualStyleBackColor = true;
            this.ApplyMissionBtn.Click += new System.EventHandler(this.ApplyMissionBtn_Click);
            // 
            // MissionTextBox
            // 
            this.MissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionTextBox.Location = new System.Drawing.Point(5, 50);
            this.MissionTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MissionTextBox.Multiline = true;
            this.MissionTextBox.Name = "MissionTextBox";
            this.MissionTextBox.Size = new System.Drawing.Size(296, 271);
            this.MissionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o status que você deseja abaixo";
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.MissionTextBox);
            this.statusPanel.Controls.Add(this.ApplyMissionBtn);
            this.statusPanel.Controls.Add(this.statusAtual);
            this.statusPanel.Controls.Add(this.label1);
            this.statusPanel.Location = new System.Drawing.Point(12, 42);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(316, 374);
            this.statusPanel.TabIndex = 6;
            // 
            // statusAtual
            // 
            this.statusAtual.AutoSize = true;
            this.statusAtual.ForeColor = System.Drawing.Color.White;
            this.statusAtual.Location = new System.Drawing.Point(5, 336);
            this.statusAtual.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statusAtual.Name = "statusAtual";
            this.statusAtual.Size = new System.Drawing.Size(85, 24);
            this.statusAtual.TabIndex = 1;
            this.statusAtual.Text = "Alterado!";
            this.statusAtual.Visible = false;
            // 
            // statusBtn
            // 
            this.statusBtn.Location = new System.Drawing.Point(73, -1);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(90, 37);
            this.statusBtn.TabIndex = 8;
            this.statusBtn.Text = "Status";
            this.statusBtn.UseVisualStyleBackColor = true;
            this.statusBtn.Click += new System.EventHandler(this.StatusBtn_Click);
            // 
            // iconBtn
            // 
            this.iconBtn.Location = new System.Drawing.Point(161, -1);
            this.iconBtn.Name = "iconBtn";
            this.iconBtn.Size = new System.Drawing.Size(90, 37);
            this.iconBtn.TabIndex = 9;
            this.iconBtn.Text = "Ícone";
            this.iconBtn.UseVisualStyleBackColor = true;
            this.iconBtn.Click += new System.EventHandler(this.IconBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecione o ícone abaixo";
            // 
            // icon1
            // 
            this.icon1.AutoSize = true;
            this.icon1.Location = new System.Drawing.Point(54, 54);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(14, 13);
            this.icon1.TabIndex = 1;
            this.icon1.TabStop = true;
            this.icon1.UseVisualStyleBackColor = true;
            // 
            // icon3
            // 
            this.icon3.AutoSize = true;
            this.icon3.Location = new System.Drawing.Point(54, 134);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(14, 13);
            this.icon3.TabIndex = 3;
            this.icon3.TabStop = true;
            this.icon3.UseVisualStyleBackColor = true;
            // 
            // icon16
            // 
            this.icon16.AutoSize = true;
            this.icon16.Location = new System.Drawing.Point(207, 54);
            this.icon16.Name = "icon16";
            this.icon16.Size = new System.Drawing.Size(14, 13);
            this.icon16.TabIndex = 16;
            this.icon16.TabStop = true;
            this.icon16.UseVisualStyleBackColor = true;
            // 
            // icon19
            // 
            this.icon19.AutoSize = true;
            this.icon19.Location = new System.Drawing.Point(207, 174);
            this.icon19.Name = "icon19";
            this.icon19.Size = new System.Drawing.Size(14, 13);
            this.icon19.TabIndex = 19;
            this.icon19.TabStop = true;
            this.icon19.UseVisualStyleBackColor = true;
            // 
            // icon9
            // 
            this.icon9.AutoSize = true;
            this.icon9.Location = new System.Drawing.Point(131, 54);
            this.icon9.Name = "icon9";
            this.icon9.Size = new System.Drawing.Size(14, 13);
            this.icon9.TabIndex = 9;
            this.icon9.TabStop = true;
            this.icon9.UseVisualStyleBackColor = true;
            // 
            // icon23
            // 
            this.icon23.AutoSize = true;
            this.icon23.Location = new System.Drawing.Point(285, 54);
            this.icon23.Name = "icon23";
            this.icon23.Size = new System.Drawing.Size(14, 13);
            this.icon23.TabIndex = 23;
            this.icon23.TabStop = true;
            this.icon23.UseVisualStyleBackColor = true;
            // 
            // icon2
            // 
            this.icon2.AutoSize = true;
            this.icon2.Location = new System.Drawing.Point(54, 94);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(14, 13);
            this.icon2.TabIndex = 2;
            this.icon2.TabStop = true;
            this.icon2.UseVisualStyleBackColor = true;
            // 
            // icon14
            // 
            this.icon14.AutoSize = true;
            this.icon14.Location = new System.Drawing.Point(131, 254);
            this.icon14.Name = "icon14";
            this.icon14.Size = new System.Drawing.Size(14, 13);
            this.icon14.TabIndex = 14;
            this.icon14.TabStop = true;
            this.icon14.UseVisualStyleBackColor = true;
            // 
            // icon4
            // 
            this.icon4.AutoSize = true;
            this.icon4.Location = new System.Drawing.Point(54, 174);
            this.icon4.Name = "icon4";
            this.icon4.Size = new System.Drawing.Size(14, 13);
            this.icon4.TabIndex = 4;
            this.icon4.TabStop = true;
            this.icon4.UseVisualStyleBackColor = true;
            // 
            // icon5
            // 
            this.icon5.AutoSize = true;
            this.icon5.Location = new System.Drawing.Point(54, 214);
            this.icon5.Name = "icon5";
            this.icon5.Size = new System.Drawing.Size(14, 13);
            this.icon5.TabIndex = 5;
            this.icon5.TabStop = true;
            this.icon5.UseVisualStyleBackColor = true;
            // 
            // icon6
            // 
            this.icon6.AutoSize = true;
            this.icon6.Location = new System.Drawing.Point(54, 254);
            this.icon6.Name = "icon6";
            this.icon6.Size = new System.Drawing.Size(14, 13);
            this.icon6.TabIndex = 6;
            this.icon6.TabStop = true;
            this.icon6.UseVisualStyleBackColor = true;
            // 
            // icon7
            // 
            this.icon7.AutoSize = true;
            this.icon7.Location = new System.Drawing.Point(54, 294);
            this.icon7.Name = "icon7";
            this.icon7.Size = new System.Drawing.Size(14, 13);
            this.icon7.TabIndex = 7;
            this.icon7.TabStop = true;
            this.icon7.UseVisualStyleBackColor = true;
            // 
            // icon11
            // 
            this.icon11.AutoSize = true;
            this.icon11.Location = new System.Drawing.Point(131, 134);
            this.icon11.Name = "icon11";
            this.icon11.Size = new System.Drawing.Size(14, 13);
            this.icon11.TabIndex = 11;
            this.icon11.TabStop = true;
            this.icon11.UseVisualStyleBackColor = true;
            // 
            // icon12
            // 
            this.icon12.AutoSize = true;
            this.icon12.Location = new System.Drawing.Point(131, 174);
            this.icon12.Name = "icon12";
            this.icon12.Size = new System.Drawing.Size(14, 13);
            this.icon12.TabIndex = 12;
            this.icon12.TabStop = true;
            this.icon12.UseVisualStyleBackColor = true;
            // 
            // icon13
            // 
            this.icon13.AutoSize = true;
            this.icon13.Location = new System.Drawing.Point(131, 214);
            this.icon13.Name = "icon13";
            this.icon13.Size = new System.Drawing.Size(14, 13);
            this.icon13.TabIndex = 13;
            this.icon13.TabStop = true;
            this.icon13.UseVisualStyleBackColor = true;
            // 
            // icon8
            // 
            this.icon8.AutoSize = true;
            this.icon8.Location = new System.Drawing.Point(53, 334);
            this.icon8.Name = "icon8";
            this.icon8.Size = new System.Drawing.Size(14, 13);
            this.icon8.TabIndex = 8;
            this.icon8.TabStop = true;
            this.icon8.UseVisualStyleBackColor = true;
            // 
            // icon15
            // 
            this.icon15.AutoSize = true;
            this.icon15.Location = new System.Drawing.Point(131, 295);
            this.icon15.Name = "icon15";
            this.icon15.Size = new System.Drawing.Size(14, 13);
            this.icon15.TabIndex = 15;
            this.icon15.TabStop = true;
            this.icon15.UseVisualStyleBackColor = true;
            // 
            // icon17
            // 
            this.icon17.AutoSize = true;
            this.icon17.Location = new System.Drawing.Point(207, 94);
            this.icon17.Name = "icon17";
            this.icon17.Size = new System.Drawing.Size(14, 13);
            this.icon17.TabIndex = 17;
            this.icon17.TabStop = true;
            this.icon17.UseVisualStyleBackColor = true;
            // 
            // icon18
            // 
            this.icon18.AutoSize = true;
            this.icon18.Location = new System.Drawing.Point(207, 134);
            this.icon18.Name = "icon18";
            this.icon18.Size = new System.Drawing.Size(14, 13);
            this.icon18.TabIndex = 18;
            this.icon18.TabStop = true;
            this.icon18.UseVisualStyleBackColor = true;
            // 
            // icon20
            // 
            this.icon20.AutoSize = true;
            this.icon20.Location = new System.Drawing.Point(207, 214);
            this.icon20.Name = "icon20";
            this.icon20.Size = new System.Drawing.Size(14, 13);
            this.icon20.TabIndex = 20;
            this.icon20.TabStop = true;
            this.icon20.UseVisualStyleBackColor = true;
            // 
            // icon21
            // 
            this.icon21.AutoSize = true;
            this.icon21.Location = new System.Drawing.Point(207, 254);
            this.icon21.Name = "icon21";
            this.icon21.Size = new System.Drawing.Size(14, 13);
            this.icon21.TabIndex = 21;
            this.icon21.TabStop = true;
            this.icon21.UseVisualStyleBackColor = true;
            // 
            // icon22
            // 
            this.icon22.AutoSize = true;
            this.icon22.Location = new System.Drawing.Point(207, 295);
            this.icon22.Name = "icon22";
            this.icon22.Size = new System.Drawing.Size(14, 13);
            this.icon22.TabIndex = 22;
            this.icon22.TabStop = true;
            this.icon22.UseVisualStyleBackColor = true;
            // 
            // icon10
            // 
            this.icon10.AutoSize = true;
            this.icon10.Location = new System.Drawing.Point(131, 94);
            this.icon10.Name = "icon10";
            this.icon10.Size = new System.Drawing.Size(14, 13);
            this.icon10.TabIndex = 10;
            this.icon10.TabStop = true;
            this.icon10.UseVisualStyleBackColor = true;
            // 
            // icon24
            // 
            this.icon24.AutoSize = true;
            this.icon24.Location = new System.Drawing.Point(285, 94);
            this.icon24.Name = "icon24";
            this.icon24.Size = new System.Drawing.Size(14, 13);
            this.icon24.TabIndex = 24;
            this.icon24.TabStop = true;
            this.icon24.UseVisualStyleBackColor = true;
            // 
            // icon25
            // 
            this.icon25.AutoSize = true;
            this.icon25.Location = new System.Drawing.Point(285, 134);
            this.icon25.Name = "icon25";
            this.icon25.Size = new System.Drawing.Size(14, 13);
            this.icon25.TabIndex = 25;
            this.icon25.TabStop = true;
            this.icon25.UseVisualStyleBackColor = true;
            // 
            // icon26
            // 
            this.icon26.AutoSize = true;
            this.icon26.Location = new System.Drawing.Point(285, 174);
            this.icon26.Name = "icon26";
            this.icon26.Size = new System.Drawing.Size(14, 13);
            this.icon26.TabIndex = 26;
            this.icon26.TabStop = true;
            this.icon26.UseVisualStyleBackColor = true;
            // 
            // icon27
            // 
            this.icon27.AutoSize = true;
            this.icon27.Location = new System.Drawing.Point(285, 214);
            this.icon27.Name = "icon27";
            this.icon27.Size = new System.Drawing.Size(14, 13);
            this.icon27.TabIndex = 27;
            this.icon27.TabStop = true;
            this.icon27.UseVisualStyleBackColor = true;
            // 
            // icon28
            // 
            this.icon28.AutoSize = true;
            this.icon28.Location = new System.Drawing.Point(285, 254);
            this.icon28.Name = "icon28";
            this.icon28.Size = new System.Drawing.Size(14, 13);
            this.icon28.TabIndex = 28;
            this.icon28.TabStop = true;
            this.icon28.UseVisualStyleBackColor = true;
            // 
            // icon29
            // 
            this.icon29.AutoSize = true;
            this.icon29.Location = new System.Drawing.Point(285, 295);
            this.icon29.Name = "icon29";
            this.icon29.Size = new System.Drawing.Size(14, 13);
            this.icon29.TabIndex = 0;
            this.icon29.TabStop = true;
            this.icon29.UseVisualStyleBackColor = true;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.ApplyIconButton);
            this.iconPanel.Controls.Add(this.statusAtual2);
            this.iconPanel.Controls.Add(this.icon29);
            this.iconPanel.Controls.Add(this.icon28);
            this.iconPanel.Controls.Add(this.icon27);
            this.iconPanel.Controls.Add(this.icon26);
            this.iconPanel.Controls.Add(this.icon25);
            this.iconPanel.Controls.Add(this.icon24);
            this.iconPanel.Controls.Add(this.icon10);
            this.iconPanel.Controls.Add(this.icon22);
            this.iconPanel.Controls.Add(this.icon21);
            this.iconPanel.Controls.Add(this.icon20);
            this.iconPanel.Controls.Add(this.icon18);
            this.iconPanel.Controls.Add(this.icon17);
            this.iconPanel.Controls.Add(this.icon15);
            this.iconPanel.Controls.Add(this.icon8);
            this.iconPanel.Controls.Add(this.icon13);
            this.iconPanel.Controls.Add(this.icon12);
            this.iconPanel.Controls.Add(this.icon11);
            this.iconPanel.Controls.Add(this.icon7);
            this.iconPanel.Controls.Add(this.icon6);
            this.iconPanel.Controls.Add(this.icon5);
            this.iconPanel.Controls.Add(this.icon4);
            this.iconPanel.Controls.Add(this.icon14);
            this.iconPanel.Controls.Add(this.icon2);
            this.iconPanel.Controls.Add(this.icon23);
            this.iconPanel.Controls.Add(this.icon9);
            this.iconPanel.Controls.Add(this.icon19);
            this.iconPanel.Controls.Add(this.icon16);
            this.iconPanel.Controls.Add(this.icon3);
            this.iconPanel.Controls.Add(this.icon1);
            this.iconPanel.Controls.Add(this.pictureBox1);
            this.iconPanel.Controls.Add(this.label3);
            this.iconPanel.Location = new System.Drawing.Point(12, 42);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(320, 376);
            this.iconPanel.TabIndex = 7;
            this.iconPanel.Visible = false;
            // 
            // ApplyIconButton
            // 
            this.ApplyIconButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyIconButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ApplyIconButton.Location = new System.Drawing.Point(239, 333);
            this.ApplyIconButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ApplyIconButton.Name = "ApplyIconButton";
            this.ApplyIconButton.Size = new System.Drawing.Size(62, 27);
            this.ApplyIconButton.TabIndex = 4;
            this.ApplyIconButton.Text = "Aplicar";
            this.ApplyIconButton.UseVisualStyleBackColor = true;
            this.ApplyIconButton.Click += new System.EventHandler(this.ApplyIconButton_Click);
            // 
            // statusAtual2
            // 
            this.statusAtual2.AutoSize = true;
            this.statusAtual2.ForeColor = System.Drawing.Color.White;
            this.statusAtual2.Location = new System.Drawing.Point(85, 331);
            this.statusAtual2.Name = "statusAtual2";
            this.statusAtual2.Size = new System.Drawing.Size(85, 24);
            this.statusAtual2.TabIndex = 33;
            this.statusAtual2.Text = "Alterado!";
            this.statusAtual2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LD_StatusChanger.Properties.Resources.imagem;
            this.pictureBox1.Location = new System.Drawing.Point(3, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "jpfpontes © 2020.";
            // 
            // refreshUpdate
            // 
            this.refreshUpdate.Enabled = true;
            this.refreshUpdate.Interval = 300;
            this.refreshUpdate.Tick += new System.EventHandler(this.RefreshUpdate_Tick);
            // 
            // avisoLol
            // 
            this.avisoLol.AutoSize = true;
            this.avisoLol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoLol.ForeColor = System.Drawing.Color.Red;
            this.avisoLol.Location = new System.Drawing.Point(9, 9);
            this.avisoLol.Name = "avisoLol";
            this.avisoLol.Size = new System.Drawing.Size(317, 31);
            this.avisoLol.TabIndex = 11;
            this.avisoLol.Text = "Seu LoL não está aberto!";
            this.avisoLol.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(333, 459);
            this.Controls.Add(this.avisoLol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBtn);
            this.Controls.Add(this.iconPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.statusBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lol StatusChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyMissionBtn;
        private System.Windows.Forms.TextBox MissionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label statusAtual;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.Button iconBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton icon1;
        private System.Windows.Forms.RadioButton icon3;
        private System.Windows.Forms.RadioButton icon16;
        private System.Windows.Forms.RadioButton icon19;
        private System.Windows.Forms.RadioButton icon9;
        private System.Windows.Forms.RadioButton icon23;
        private System.Windows.Forms.RadioButton icon2;
        private System.Windows.Forms.RadioButton icon14;
        private System.Windows.Forms.RadioButton icon4;
        private System.Windows.Forms.RadioButton icon5;
        private System.Windows.Forms.RadioButton icon6;
        private System.Windows.Forms.RadioButton icon7;
        private System.Windows.Forms.RadioButton icon11;
        private System.Windows.Forms.RadioButton icon12;
        private System.Windows.Forms.RadioButton icon13;
        private System.Windows.Forms.RadioButton icon8;
        private System.Windows.Forms.RadioButton icon15;
        private System.Windows.Forms.RadioButton icon17;
        private System.Windows.Forms.RadioButton icon18;
        private System.Windows.Forms.RadioButton icon20;
        private System.Windows.Forms.RadioButton icon21;
        private System.Windows.Forms.RadioButton icon22;
        private System.Windows.Forms.RadioButton icon10;
        private System.Windows.Forms.RadioButton icon24;
        private System.Windows.Forms.RadioButton icon25;
        private System.Windows.Forms.RadioButton icon26;
        private System.Windows.Forms.RadioButton icon27;
        private System.Windows.Forms.RadioButton icon28;
        private System.Windows.Forms.RadioButton icon29;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statusAtual2;
        private System.Windows.Forms.Button ApplyIconButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer refreshUpdate;
        private System.Windows.Forms.Label avisoLol;
    }
}

