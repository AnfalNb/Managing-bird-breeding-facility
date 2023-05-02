using System.Resources;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    partial class AddBirds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBirds));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonComboBox_species = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox_sup_species = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonDateTimePicker_hatch_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.kryptonComboBox_gender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kryptonTextBox_cage_number = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.hjk = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kryptonTextBox_mother_serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox_father_serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.kryptonButton_ADD_BIRD = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_species)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_sup_species)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(442, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Bird";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label3.Location = new System.Drawing.Point(394, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Serial :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textbox_serial
            // 
            this.textbox_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_serial.Location = new System.Drawing.Point(499, 119);
            this.textbox_serial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_serial.Name = "textbox_serial";
            this.textbox_serial.Size = new System.Drawing.Size(199, 44);
            this.textbox_serial.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textbox_serial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textbox_serial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textbox_serial.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textbox_serial.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textbox_serial.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.textbox_serial.StateCommon.Border.Rounding = 20;
            this.textbox_serial.StateCommon.Border.Width = 1;
            this.textbox_serial.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textbox_serial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_serial.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.textbox_serial.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(363, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Species  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label4.Location = new System.Drawing.Point(329, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Subspecies :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // kryptonComboBox_species
            // 
            this.kryptonComboBox_species.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox_species.DropDownWidth = 199;
            this.kryptonComboBox_species.Items.AddRange(new object[] {
            "European Gouldian",
            "American Gouldian",
            "Australian Gouldian"});
            this.kryptonComboBox_species.Location = new System.Drawing.Point(499, 182);
            this.kryptonComboBox_species.Name = "kryptonComboBox_species";
            this.kryptonComboBox_species.Size = new System.Drawing.Size(199, 29);
            this.kryptonComboBox_species.TabIndex = 30;
            this.kryptonComboBox_species.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox_species_SelectedIndexChanged);
            // 
            // kryptonComboBox_sup_species
            // 
            this.kryptonComboBox_sup_species.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox_sup_species.DropDownWidth = 199;
            this.kryptonComboBox_sup_species.Items.AddRange(new object[] {
            "North America",
            "Central America",
            "South America",
            "East Europe",
            "Western Europe",
            "Central Europe",
            "Central Australia",
            "Coastal Cities"});
            this.kryptonComboBox_sup_species.Location = new System.Drawing.Point(499, 226);
            this.kryptonComboBox_sup_species.Name = "kryptonComboBox_sup_species";
            this.kryptonComboBox_sup_species.Size = new System.Drawing.Size(199, 29);
            this.kryptonComboBox_sup_species.TabIndex = 31;
            this.kryptonComboBox_sup_species.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox_sup_species_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label5.Location = new System.Drawing.Point(334, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "hatch date :";
            // 
            // kryptonDateTimePicker_hatch_date
            // 
            this.kryptonDateTimePicker_hatch_date.CalendarTodayDate = new System.DateTime(2023, 4, 30, 0, 0, 0, 0);
            this.kryptonDateTimePicker_hatch_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker_hatch_date.Location = new System.Drawing.Point(499, 275);
            this.kryptonDateTimePicker_hatch_date.Name = "kryptonDateTimePicker_hatch_date";
            this.kryptonDateTimePicker_hatch_date.Size = new System.Drawing.Size(199, 30);
            this.kryptonDateTimePicker_hatch_date.TabIndex = 33;
            this.kryptonDateTimePicker_hatch_date.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker_hatch_date_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label6.Location = new System.Drawing.Point(374, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "gender :";
            // 
            // kryptonComboBox_gender
            // 
            this.kryptonComboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox_gender.DropDownWidth = 199;
            this.kryptonComboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.kryptonComboBox_gender.Location = new System.Drawing.Point(499, 327);
            this.kryptonComboBox_gender.Name = "kryptonComboBox_gender";
            this.kryptonComboBox_gender.Size = new System.Drawing.Size(199, 29);
            this.kryptonComboBox_gender.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(576, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label7.Location = new System.Drawing.Point(305, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "cage number :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kryptonTextBox_cage_number
            // 
            this.kryptonTextBox_cage_number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTextBox_cage_number.Location = new System.Drawing.Point(499, 371);
            this.kryptonTextBox_cage_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonTextBox_cage_number.Name = "kryptonTextBox_cage_number";
            this.kryptonTextBox_cage_number.Size = new System.Drawing.Size(199, 44);
            this.kryptonTextBox_cage_number.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox_cage_number.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox_cage_number.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox_cage_number.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox_cage_number.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox_cage_number.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.kryptonTextBox_cage_number.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox_cage_number.StateCommon.Border.Width = 1;
            this.kryptonTextBox_cage_number.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox_cage_number.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox_cage_number.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.kryptonTextBox_cage_number.TabIndex = 39;
            // 
            // hjk
            // 
            this.hjk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hjk.AutoSize = true;
            this.hjk.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hjk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.hjk.Location = new System.Drawing.Point(288, 445);
            this.hjk.Name = "hjk";
            this.hjk.Size = new System.Drawing.Size(195, 32);
            this.hjk.TabIndex = 40;
            this.hjk.Text = "Mother\'s serial :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.label9.Location = new System.Drawing.Point(300, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 32);
            this.label9.TabIndex = 41;
            this.label9.Text = "Father\'s serial :";
            // 
            // kryptonTextBox_mother_serial
            // 
            this.kryptonTextBox_mother_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTextBox_mother_serial.Location = new System.Drawing.Point(499, 433);
            this.kryptonTextBox_mother_serial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonTextBox_mother_serial.Name = "kryptonTextBox_mother_serial";
            this.kryptonTextBox_mother_serial.Size = new System.Drawing.Size(199, 44);
            this.kryptonTextBox_mother_serial.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox_mother_serial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox_mother_serial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox_mother_serial.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox_mother_serial.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox_mother_serial.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.kryptonTextBox_mother_serial.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox_mother_serial.StateCommon.Border.Width = 1;
            this.kryptonTextBox_mother_serial.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox_mother_serial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox_mother_serial.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.kryptonTextBox_mother_serial.TabIndex = 42;
            // 
            // kryptonTextBox_father_serial
            // 
            this.kryptonTextBox_father_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTextBox_father_serial.Location = new System.Drawing.Point(499, 495);
            this.kryptonTextBox_father_serial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonTextBox_father_serial.Name = "kryptonTextBox_father_serial";
            this.kryptonTextBox_father_serial.Size = new System.Drawing.Size(199, 44);
            this.kryptonTextBox_father_serial.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox_father_serial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox_father_serial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox_father_serial.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox_father_serial.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox_father_serial.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.kryptonTextBox_father_serial.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox_father_serial.StateCommon.Border.Width = 1;
            this.kryptonTextBox_father_serial.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.kryptonTextBox_father_serial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox_father_serial.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.kryptonTextBox_father_serial.TabIndex = 43;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(576, 609);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(442, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-2, 609);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(463, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // kryptonButton_ADD_BIRD
            // 
            this.kryptonButton_ADD_BIRD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton_ADD_BIRD.Location = new System.Drawing.Point(449, 609);
            this.kryptonButton_ADD_BIRD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonButton_ADD_BIRD.Name = "kryptonButton_ADD_BIRD";
            this.kryptonButton_ADD_BIRD.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton_ADD_BIRD.OverrideDefault.Border.Width = 1;
            this.kryptonButton_ADD_BIRD.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_ADD_BIRD.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_ADD_BIRD.OverrideFocus.Border.Rounding = 100;
            this.kryptonButton_ADD_BIRD.OverrideFocus.Border.Width = 1;
            this.kryptonButton_ADD_BIRD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton_ADD_BIRD.Size = new System.Drawing.Size(147, 70);
            this.kryptonButton_ADD_BIRD.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_ADD_BIRD.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_ADD_BIRD.StateCommon.Border.Rounding = 20;
            this.kryptonButton_ADD_BIRD.StateCommon.Border.Width = 1;
            this.kryptonButton_ADD_BIRD.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton_ADD_BIRD.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton_ADD_BIRD.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_ADD_BIRD.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton_ADD_BIRD.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton_ADD_BIRD.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_ADD_BIRD.StatePressed.Border.Rounding = 20;
            this.kryptonButton_ADD_BIRD.StatePressed.Border.Width = 1;
            this.kryptonButton_ADD_BIRD.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_ADD_BIRD.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton_ADD_BIRD.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_ADD_BIRD.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_ADD_BIRD.StateTracking.Border.Rounding = 20;
            this.kryptonButton_ADD_BIRD.StateTracking.Border.Width = 1;
            this.kryptonButton_ADD_BIRD.TabIndex = 48;
            this.kryptonButton_ADD_BIRD.Values.Text = "Add";
            this.kryptonButton_ADD_BIRD.Click += new System.EventHandler(this.kryptonButton_ADD_BIRD_Click);
            // 
            // AddBirds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1011, 705);
            this.Controls.Add(this.kryptonButton_ADD_BIRD);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.kryptonTextBox_father_serial);
            this.Controls.Add(this.kryptonTextBox_mother_serial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hjk);
            this.Controls.Add(this.kryptonTextBox_cage_number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonComboBox_gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kryptonDateTimePicker_hatch_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kryptonComboBox_sup_species);
            this.Controls.Add(this.kryptonComboBox_species);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_serial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1029, 750);
            this.Name = "AddBirds";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBirds";
            this.Load += new System.EventHandler(this.AddBirds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_species)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_sup_species)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox_gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textbox_serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox_species;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox_sup_species;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker_hatch_date;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox_gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox_cage_number;
        private System.Windows.Forms.Label hjk;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox_mother_serial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox_father_serial;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_ADD_BIRD;
    }
}