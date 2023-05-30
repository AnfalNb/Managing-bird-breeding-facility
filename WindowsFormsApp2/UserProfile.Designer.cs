namespace WindowsFormsApp2
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Species = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subspecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HatchDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CageNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MotherSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FatherSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton_search_bird = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton_page_search_cage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1_page_add_bird = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2_page_addcage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serial,
            this.Species,
            this.Subspecies,
            this.HatchDate,
            this.Gender,
            this.CageNumber,
            this.MotherSerial,
            this.FatherSerial});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 467);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1004, 226);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Serial
            // 
            this.Serial.Text = "Serial";
            this.Serial.Width = 85;
            // 
            // Species
            // 
            this.Species.Text = "Species";
            this.Species.Width = 90;
            // 
            // Subspecies
            // 
            this.Subspecies.Text = "Subspecies";
            this.Subspecies.Width = 95;
            // 
            // HatchDate
            // 
            this.HatchDate.Text = "HatchDate";
            this.HatchDate.Width = 100;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 80;
            // 
            // CageNumber
            // 
            this.CageNumber.Text = "CageNumber";
            this.CageNumber.Width = 100;
            // 
            // MotherSerial
            // 
            this.MotherSerial.Text = "MotherSerial";
            this.MotherSerial.Width = 100;
            // 
            // FatherSerial
            // 
            this.FatherSerial.Text = "FatherSerial";
            this.FatherSerial.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(-2, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Birds :";
            // 
            // kryptonButton_search_bird
            // 
            this.kryptonButton_search_bird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton_search_bird.Location = new System.Drawing.Point(802, 287);
            this.kryptonButton_search_bird.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonButton_search_bird.Name = "kryptonButton_search_bird";
            this.kryptonButton_search_bird.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton_search_bird.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton_search_bird.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_search_bird.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_search_bird.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton_search_bird.OverrideDefault.Border.Width = 1;
            this.kryptonButton_search_bird.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton_search_bird.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonButton_search_bird.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_search_bird.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_search_bird.OverrideFocus.Border.Rounding = 100;
            this.kryptonButton_search_bird.OverrideFocus.Border.Width = 1;
            this.kryptonButton_search_bird.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton_search_bird.Size = new System.Drawing.Size(205, 61);
            this.kryptonButton_search_bird.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton_search_bird.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton_search_bird.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_search_bird.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_search_bird.StateCommon.Border.Rounding = 20;
            this.kryptonButton_search_bird.StateCommon.Border.Width = 1;
            this.kryptonButton_search_bird.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton_search_bird.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton_search_bird.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_search_bird.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton_search_bird.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton_search_bird.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_search_bird.StatePressed.Border.Rounding = 20;
            this.kryptonButton_search_bird.StatePressed.Border.Width = 1;
            this.kryptonButton_search_bird.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton_search_bird.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_search_bird.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton_search_bird.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_search_bird.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_search_bird.StateTracking.Border.Rounding = 20;
            this.kryptonButton_search_bird.StateTracking.Border.Width = 1;
            this.kryptonButton_search_bird.TabIndex = 49;
            this.kryptonButton_search_bird.Values.Text = "Search Bird";
            this.kryptonButton_search_bird.Click += new System.EventHandler(this.kryptonButton_search_bird_Click);
            // 
            // kryptonButton_page_search_cage
            // 
            this.kryptonButton_page_search_cage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton_page_search_cage.Location = new System.Drawing.Point(550, 287);
            this.kryptonButton_page_search_cage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonButton_page_search_cage.Name = "kryptonButton_page_search_cage";
            this.kryptonButton_page_search_cage.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_page_search_cage.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_page_search_cage.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton_page_search_cage.OverrideDefault.Border.Width = 1;
            this.kryptonButton_page_search_cage.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_page_search_cage.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_page_search_cage.OverrideFocus.Border.Rounding = 100;
            this.kryptonButton_page_search_cage.OverrideFocus.Border.Width = 1;
            this.kryptonButton_page_search_cage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton_page_search_cage.Size = new System.Drawing.Size(205, 61);
            this.kryptonButton_page_search_cage.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_page_search_cage.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_page_search_cage.StateCommon.Border.Rounding = 20;
            this.kryptonButton_page_search_cage.StateCommon.Border.Width = 1;
            this.kryptonButton_page_search_cage.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton_page_search_cage.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton_page_search_cage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_page_search_cage.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton_page_search_cage.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton_page_search_cage.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_page_search_cage.StatePressed.Border.Rounding = 20;
            this.kryptonButton_page_search_cage.StatePressed.Border.Width = 1;
            this.kryptonButton_page_search_cage.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton_page_search_cage.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton_page_search_cage.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton_page_search_cage.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton_page_search_cage.StateTracking.Border.Rounding = 20;
            this.kryptonButton_page_search_cage.StateTracking.Border.Width = 1;
            this.kryptonButton_page_search_cage.TabIndex = 50;
            this.kryptonButton_page_search_cage.Values.Text = "Search Cage";
            this.kryptonButton_page_search_cage.Click += new System.EventHandler(this.kryptonButton_page_search_cage_Click);
            // 
            // kryptonButton1_page_add_bird
            // 
            this.kryptonButton1_page_add_bird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1_page_add_bird.Location = new System.Drawing.Point(12, 287);
            this.kryptonButton1_page_add_bird.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonButton1_page_add_bird.Name = "kryptonButton1_page_add_bird";
            this.kryptonButton1_page_add_bird.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton1_page_add_bird.OverrideDefault.Border.Width = 1;
            this.kryptonButton1_page_add_bird.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1_page_add_bird.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1_page_add_bird.OverrideFocus.Border.Rounding = 100;
            this.kryptonButton1_page_add_bird.OverrideFocus.Border.Width = 1;
            this.kryptonButton1_page_add_bird.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1_page_add_bird.Size = new System.Drawing.Size(205, 61);
            this.kryptonButton1_page_add_bird.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1_page_add_bird.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1_page_add_bird.StateCommon.Border.Rounding = 20;
            this.kryptonButton1_page_add_bird.StateCommon.Border.Width = 1;
            this.kryptonButton1_page_add_bird.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1_page_add_bird.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1_page_add_bird.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1_page_add_bird.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1_page_add_bird.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1_page_add_bird.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1_page_add_bird.StatePressed.Border.Rounding = 20;
            this.kryptonButton1_page_add_bird.StatePressed.Border.Width = 1;
            this.kryptonButton1_page_add_bird.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton1_page_add_bird.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton1_page_add_bird.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1_page_add_bird.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1_page_add_bird.StateTracking.Border.Rounding = 20;
            this.kryptonButton1_page_add_bird.StateTracking.Border.Width = 1;
            this.kryptonButton1_page_add_bird.TabIndex = 51;
            this.kryptonButton1_page_add_bird.Values.Text = "Add Bird";
            this.kryptonButton1_page_add_bird.Click += new System.EventHandler(this.kryptonButton1_page_add_bird_Click);
            // 
            // kryptonButton2_page_addcage
            // 
            this.kryptonButton2_page_addcage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton2_page_addcage.Location = new System.Drawing.Point(275, 287);
            this.kryptonButton2_page_addcage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kryptonButton2_page_addcage.Name = "kryptonButton2_page_addcage";
            this.kryptonButton2_page_addcage.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2_page_addcage.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2_page_addcage.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton2_page_addcage.OverrideDefault.Border.Width = 1;
            this.kryptonButton2_page_addcage.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.OverrideFocus.Border.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2_page_addcage.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2_page_addcage.OverrideFocus.Border.Rounding = 100;
            this.kryptonButton2_page_addcage.OverrideFocus.Border.Width = 1;
            this.kryptonButton2_page_addcage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2_page_addcage.Size = new System.Drawing.Size(205, 61);
            this.kryptonButton2_page_addcage.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2_page_addcage.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2_page_addcage.StateCommon.Border.Rounding = 20;
            this.kryptonButton2_page_addcage.StateCommon.Border.Width = 1;
            this.kryptonButton2_page_addcage.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2_page_addcage.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2_page_addcage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2_page_addcage.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton2_page_addcage.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton2_page_addcage.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2_page_addcage.StatePressed.Border.Rounding = 20;
            this.kryptonButton2_page_addcage.StatePressed.Border.Width = 1;
            this.kryptonButton2_page_addcage.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.kryptonButton2_page_addcage.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton2_page_addcage.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2_page_addcage.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2_page_addcage.StateTracking.Border.Rounding = 20;
            this.kryptonButton2_page_addcage.StateTracking.Border.Width = 1;
            this.kryptonButton2_page_addcage.TabIndex = 52;
            this.kryptonButton2_page_addcage.Values.Text = "Add Cage";
            this.kryptonButton2_page_addcage.Click += new System.EventHandler(this.kryptonButton2_page_addcage_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1011, 705);
            this.Controls.Add(this.kryptonButton2_page_addcage);
            this.Controls.Add(this.kryptonButton1_page_add_bird);
            this.Controls.Add(this.kryptonButton_page_search_cage);
            this.Controls.Add(this.kryptonButton_search_bird);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfile";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Serial;
        private System.Windows.Forms.ColumnHeader Species;
        private System.Windows.Forms.ColumnHeader Subspecies;
        private System.Windows.Forms.ColumnHeader HatchDate;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader CageNumber;
        private System.Windows.Forms.ColumnHeader MotherSerial;
        private System.Windows.Forms.ColumnHeader FatherSerial;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_search_bird;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_page_search_cage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1_page_add_bird;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2_page_addcage;
    }
}