namespace VRP
{
    partial class Vuokratut
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
            System.Windows.Forms.Button buttonPoistu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vuokratut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelVari2 = new System.Windows.Forms.Panel();
            this.buttonLisaaTyokalu = new System.Windows.Forms.Button();
            this.panelVari = new System.Windows.Forms.Panel();
            this.buttonYliVK = new System.Windows.Forms.Button();
            this.buttonVuokratut = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLisaaTyovaline = new System.Windows.Forms.Panel();
            this.dataGridViewTyovalineet = new System.Windows.Forms.DataGridView();
            this.tyovalinenimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyovalineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuokrauspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuokrausfirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbltyovalineetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tyovalineetDataSet = new VRP.tyovalineetDataSet();
            this.buttonLisaa = new System.Windows.Forms.Button();
            this.textBoxTyovaline = new System.Windows.Forms.TextBox();
            this.textBoxTyovalNumero = new System.Windows.Forms.TextBox();
            this.textBoxVuokrauspvm = new System.Windows.Forms.TextBox();
            this.textBoxFirma = new System.Windows.Forms.TextBox();
            this.labelFirma = new System.Windows.Forms.Label();
            this.labelPVM = new System.Windows.Forms.Label();
            this.labelValineID = new System.Windows.Forms.Label();
            this.labelTyovaline = new System.Windows.Forms.Label();
            this.tbl_tyovalineetTableAdapter = new VRP.tyovalineetDataSetTableAdapters.tbl_tyovalineetTableAdapter();
            buttonPoistu = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLisaaTyovaline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTyovalineet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltyovalineetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyovalineetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPoistu
            // 
            buttonPoistu.BackgroundImage = global::VRP.Properties.Resources.cancel;
            buttonPoistu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonPoistu.FlatAppearance.BorderSize = 0;
            buttonPoistu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPoistu.Location = new System.Drawing.Point(764, 0);
            buttonPoistu.Name = "buttonPoistu";
            buttonPoistu.Size = new System.Drawing.Size(47, 41);
            buttonPoistu.TabIndex = 1;
            buttonPoistu.UseVisualStyleBackColor = true;
            buttonPoistu.Click += new System.EventHandler(this.buttonPoistu_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.panelSideMenu.Controls.Add(this.panelVari2);
            this.panelSideMenu.Controls.Add(this.buttonLisaaTyokalu);
            this.panelSideMenu.Controls.Add(this.panelVari);
            this.panelSideMenu.Controls.Add(this.buttonYliVK);
            this.panelSideMenu.Controls.Add(this.buttonVuokratut);
            this.panelSideMenu.Controls.Add(this.pictureBoxLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 540);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelVari2
            // 
            this.panelVari2.BackColor = System.Drawing.Color.White;
            this.panelVari2.Location = new System.Drawing.Point(193, 294);
            this.panelVari2.Name = "panelVari2";
            this.panelVari2.Size = new System.Drawing.Size(7, 97);
            this.panelVari2.TabIndex = 5;
            // 
            // buttonLisaaTyokalu
            // 
            this.buttonLisaaTyokalu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLisaaTyokalu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLisaaTyokalu.FlatAppearance.BorderSize = 0;
            this.buttonLisaaTyokalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLisaaTyokalu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisaaTyokalu.Image = global::VRP.Properties.Resources.plus;
            this.buttonLisaaTyokalu.Location = new System.Drawing.Point(0, 294);
            this.buttonLisaaTyokalu.Name = "buttonLisaaTyokalu";
            this.buttonLisaaTyokalu.Size = new System.Drawing.Size(200, 97);
            this.buttonLisaaTyokalu.TabIndex = 3;
            this.buttonLisaaTyokalu.Text = "LISÄÄ VUOKRATTU VÄLINE";
            this.buttonLisaaTyokalu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLisaaTyokalu.UseVisualStyleBackColor = true;
            this.buttonLisaaTyokalu.Click += new System.EventHandler(this.buttonLisaaTyokalu_Click);
            // 
            // panelVari
            // 
            this.panelVari.BackColor = System.Drawing.Color.White;
            this.panelVari.Location = new System.Drawing.Point(193, 100);
            this.panelVari.Name = "panelVari";
            this.panelVari.Size = new System.Drawing.Size(7, 97);
            this.panelVari.TabIndex = 4;
            // 
            // buttonYliVK
            // 
            this.buttonYliVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYliVK.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonYliVK.FlatAppearance.BorderSize = 0;
            this.buttonYliVK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYliVK.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYliVK.Image = global::VRP.Properties.Resources.clock;
            this.buttonYliVK.Location = new System.Drawing.Point(0, 197);
            this.buttonYliVK.Name = "buttonYliVK";
            this.buttonYliVK.Size = new System.Drawing.Size(200, 97);
            this.buttonYliVK.TabIndex = 2;
            this.buttonYliVK.Text = "YLI VIIKON VANHAT VUOKRAUKSET";
            this.buttonYliVK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonYliVK.UseVisualStyleBackColor = true;
            this.buttonYliVK.Click += new System.EventHandler(this.buttonYliVK_Click);
            // 
            // buttonVuokratut
            // 
            this.buttonVuokratut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVuokratut.FlatAppearance.BorderSize = 0;
            this.buttonVuokratut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVuokratut.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVuokratut.Image = global::VRP.Properties.Resources.tools_cross_settings_symbol_for_interface__1_;
            this.buttonVuokratut.Location = new System.Drawing.Point(0, 100);
            this.buttonVuokratut.Name = "buttonVuokratut";
            this.buttonVuokratut.Size = new System.Drawing.Size(200, 97);
            this.buttonVuokratut.TabIndex = 1;
            this.buttonVuokratut.Text = "VUOKRATUT";
            this.buttonVuokratut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVuokratut.UseVisualStyleBackColor = true;
            this.buttonVuokratut.Click += new System.EventHandler(this.buttonVuokratut_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::VRP.Properties.Resources.VRP_hyvanrakentajanovittunyt;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelLisaaTyovaline
            // 
            this.panelLisaaTyovaline.Controls.Add(this.dataGridViewTyovalineet);
            this.panelLisaaTyovaline.Controls.Add(this.buttonLisaa);
            this.panelLisaaTyovaline.Controls.Add(this.textBoxTyovaline);
            this.panelLisaaTyovaline.Controls.Add(this.textBoxTyovalNumero);
            this.panelLisaaTyovaline.Controls.Add(this.textBoxVuokrauspvm);
            this.panelLisaaTyovaline.Controls.Add(this.textBoxFirma);
            this.panelLisaaTyovaline.Controls.Add(this.labelFirma);
            this.panelLisaaTyovaline.Controls.Add(this.labelPVM);
            this.panelLisaaTyovaline.Controls.Add(this.labelValineID);
            this.panelLisaaTyovaline.Controls.Add(this.labelTyovaline);
            this.panelLisaaTyovaline.Location = new System.Drawing.Point(206, 47);
            this.panelLisaaTyovaline.Name = "panelLisaaTyovaline";
            this.panelLisaaTyovaline.Size = new System.Drawing.Size(592, 481);
            this.panelLisaaTyovaline.TabIndex = 2;
            // 
            // dataGridViewTyovalineet
            // 
            this.dataGridViewTyovalineet.AccessibleDescription = "tyovalineet";
            this.dataGridViewTyovalineet.AccessibleName = "tyovalineet";
            this.dataGridViewTyovalineet.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTyovalineet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTyovalineet.AutoGenerateColumns = false;
            this.dataGridViewTyovalineet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTyovalineet.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewTyovalineet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTyovalineet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewTyovalineet.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewTyovalineet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTyovalineet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTyovalineet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTyovalineet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tyovalinenimiDataGridViewTextBoxColumn,
            this.tyovalineidDataGridViewTextBoxColumn,
            this.vuokrauspvmDataGridViewTextBoxColumn,
            this.vuokrausfirmaDataGridViewTextBoxColumn});
            this.dataGridViewTyovalineet.DataSource = this.tbltyovalineetBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTyovalineet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTyovalineet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTyovalineet.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewTyovalineet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTyovalineet.Name = "dataGridViewTyovalineet";
            this.dataGridViewTyovalineet.Size = new System.Drawing.Size(592, 481);
            this.dataGridViewTyovalineet.TabIndex = 3;
            this.dataGridViewTyovalineet.VirtualMode = true;
            // 
            // tyovalinenimiDataGridViewTextBoxColumn
            // 
            this.tyovalinenimiDataGridViewTextBoxColumn.DataPropertyName = "tyovaline_nimi";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tyovalinenimiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tyovalinenimiDataGridViewTextBoxColumn.HeaderText = "Työväline";
            this.tyovalinenimiDataGridViewTextBoxColumn.Name = "tyovalinenimiDataGridViewTextBoxColumn";
            // 
            // tyovalineidDataGridViewTextBoxColumn
            // 
            this.tyovalineidDataGridViewTextBoxColumn.DataPropertyName = "tyovaline_id";
            this.tyovalineidDataGridViewTextBoxColumn.HeaderText = "Työvälineen tunniste numero";
            this.tyovalineidDataGridViewTextBoxColumn.Name = "tyovalineidDataGridViewTextBoxColumn";
            // 
            // vuokrauspvmDataGridViewTextBoxColumn
            // 
            this.vuokrauspvmDataGridViewTextBoxColumn.DataPropertyName = "vuokraus_pvm";
            this.vuokrauspvmDataGridViewTextBoxColumn.HeaderText = "Vuokraus pvm.";
            this.vuokrauspvmDataGridViewTextBoxColumn.Name = "vuokrauspvmDataGridViewTextBoxColumn";
            // 
            // vuokrausfirmaDataGridViewTextBoxColumn
            // 
            this.vuokrausfirmaDataGridViewTextBoxColumn.DataPropertyName = "vuokraus_firma";
            this.vuokrausfirmaDataGridViewTextBoxColumn.HeaderText = "Vuokraus firma";
            this.vuokrausfirmaDataGridViewTextBoxColumn.Name = "vuokrausfirmaDataGridViewTextBoxColumn";
            // 
            // tbltyovalineetBindingSource
            // 
            this.tbltyovalineetBindingSource.DataMember = "tbl_tyovalineet";
            this.tbltyovalineetBindingSource.DataSource = this.tyovalineetDataSet;
            // 
            // tyovalineetDataSet
            // 
            this.tyovalineetDataSet.DataSetName = "tyovalineetDataSet";
            this.tyovalineetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonLisaa
            // 
            this.buttonLisaa.FlatAppearance.BorderSize = 0;
            this.buttonLisaa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonLisaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLisaa.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisaa.Location = new System.Drawing.Point(64, 419);
            this.buttonLisaa.Name = "buttonLisaa";
            this.buttonLisaa.Size = new System.Drawing.Size(75, 29);
            this.buttonLisaa.TabIndex = 8;
            this.buttonLisaa.Text = "Lisää";
            this.buttonLisaa.UseVisualStyleBackColor = true;
            this.buttonLisaa.Click += new System.EventHandler(this.buttonLisaa_Click);
            // 
            // textBoxTyovaline
            // 
            this.textBoxTyovaline.Location = new System.Drawing.Point(387, 58);
            this.textBoxTyovaline.Name = "textBoxTyovaline";
            this.textBoxTyovaline.Size = new System.Drawing.Size(150, 20);
            this.textBoxTyovaline.TabIndex = 7;
            // 
            // textBoxTyovalNumero
            // 
            this.textBoxTyovalNumero.Location = new System.Drawing.Point(387, 153);
            this.textBoxTyovalNumero.Name = "textBoxTyovalNumero";
            this.textBoxTyovalNumero.Size = new System.Drawing.Size(150, 20);
            this.textBoxTyovalNumero.TabIndex = 6;
            // 
            // textBoxVuokrauspvm
            // 
            this.textBoxVuokrauspvm.Location = new System.Drawing.Point(387, 252);
            this.textBoxVuokrauspvm.Name = "textBoxVuokrauspvm";
            this.textBoxVuokrauspvm.Size = new System.Drawing.Size(150, 20);
            this.textBoxVuokrauspvm.TabIndex = 5;
            // 
            // textBoxFirma
            // 
            this.textBoxFirma.Location = new System.Drawing.Point(387, 336);
            this.textBoxFirma.Name = "textBoxFirma";
            this.textBoxFirma.Size = new System.Drawing.Size(150, 20);
            this.textBoxFirma.TabIndex = 4;
            // 
            // labelFirma
            // 
            this.labelFirma.AutoSize = true;
            this.labelFirma.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirma.Location = new System.Drawing.Point(60, 331);
            this.labelFirma.Name = "labelFirma";
            this.labelFirma.Size = new System.Drawing.Size(122, 23);
            this.labelFirma.TabIndex = 3;
            this.labelFirma.Text = "Vuokraus firma";
            // 
            // labelPVM
            // 
            this.labelPVM.AutoSize = true;
            this.labelPVM.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPVM.Location = new System.Drawing.Point(59, 247);
            this.labelPVM.Name = "labelPVM";
            this.labelPVM.Size = new System.Drawing.Size(118, 23);
            this.labelPVM.TabIndex = 2;
            this.labelPVM.Text = "Vuokraus pvm.";
            // 
            // labelValineID
            // 
            this.labelValineID.AutoSize = true;
            this.labelValineID.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValineID.Location = new System.Drawing.Point(59, 150);
            this.labelValineID.Name = "labelValineID";
            this.labelValineID.Size = new System.Drawing.Size(157, 23);
            this.labelValineID.TabIndex = 1;
            this.labelValineID.Text = "Työvälineen numero";
            // 
            // labelTyovaline
            // 
            this.labelTyovaline.AutoSize = true;
            this.labelTyovaline.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTyovaline.Location = new System.Drawing.Point(59, 53);
            this.labelTyovaline.Name = "labelTyovaline";
            this.labelTyovaline.Size = new System.Drawing.Size(78, 23);
            this.labelTyovaline.TabIndex = 0;
            this.labelTyovaline.Text = "Työväline";
            // 
            // tbl_tyovalineetTableAdapter
            // 
            this.tbl_tyovalineetTableAdapter.ClearBeforeFill = true;
            // 
            // Vuokratut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 540);
            this.Controls.Add(this.panelLisaaTyovaline);
            this.Controls.Add(buttonPoistu);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vuokratut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuokratut";
            this.Load += new System.EventHandler(this.Vuokratut_Load);
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLisaaTyovaline.ResumeLayout(false);
            this.panelLisaaTyovaline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTyovalineet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltyovalineetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyovalineetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonVuokratut;
        private System.Windows.Forms.Panel panelVari;
        private System.Windows.Forms.Button buttonYliVK;
        private System.Windows.Forms.Button buttonLisaaTyokalu;
        private System.Windows.Forms.Panel panelVari2;
        private System.Windows.Forms.Panel panelLisaaTyovaline;
        private System.Windows.Forms.TextBox textBoxTyovaline;
        private System.Windows.Forms.TextBox textBoxTyovalNumero;
        private System.Windows.Forms.TextBox textBoxVuokrauspvm;
        private System.Windows.Forms.TextBox textBoxFirma;
        private System.Windows.Forms.Label labelFirma;
        private System.Windows.Forms.Label labelPVM;
        private System.Windows.Forms.Label labelValineID;
        private System.Windows.Forms.Label labelTyovaline;
        private System.Windows.Forms.Button buttonLisaa;
        private tyovalineetDataSet tyovalineetDataSet;
        private System.Windows.Forms.BindingSource tbltyovalineetBindingSource;
        private tyovalineetDataSetTableAdapters.tbl_tyovalineetTableAdapter tbl_tyovalineetTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewTyovalineet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyovalinenimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyovalineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuokrauspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuokrausfirmaDataGridViewTextBoxColumn;
    }
}

