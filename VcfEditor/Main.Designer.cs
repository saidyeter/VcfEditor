namespace VcfEditor
{
    partial class Main
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
            this.CardList = new System.Windows.Forms.CheckedListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.lbGroup = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.tb1stNumber = new System.Windows.Forms.TextBox();
            this.lb1stNumber = new System.Windows.Forms.Label();
            this.tb2ndNumber = new System.Windows.Forms.TextBox();
            this.lb2ndNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miLoadVcf = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveVcf = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btRemoveDups = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemoveSelected = new System.Windows.Forms.Button();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardList
            // 
            this.CardList.Dock = System.Windows.Forms.DockStyle.Left;
            this.CardList.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.CardList.FormattingEnabled = true;
            this.CardList.Location = new System.Drawing.Point(0, 30);
            this.CardList.Margin = new System.Windows.Forms.Padding(4);
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(464, 702);
            this.CardList.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(588, 28);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(612, 29);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(480, 32);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 22);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "İsim";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbSurname.Location = new System.Drawing.Point(588, 102);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(612, 29);
            this.tbSurname.TabIndex = 3;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbSurname.Location = new System.Drawing.Point(480, 106);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(80, 22);
            this.lbSurname.TabIndex = 4;
            this.lbSurname.Text = "Soyisim";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbMail.Location = new System.Drawing.Point(588, 139);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(612, 29);
            this.tbMail.TabIndex = 3;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbMail.Location = new System.Drawing.Point(480, 143);
            this.lbMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(50, 22);
            this.lbMail.TabIndex = 4;
            this.lbMail.Text = "Mail";
            // 
            // tbGroup
            // 
            this.tbGroup.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbGroup.Location = new System.Drawing.Point(588, 213);
            this.tbGroup.Margin = new System.Windows.Forms.Padding(4);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(612, 29);
            this.tbGroup.TabIndex = 3;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbGroup.Location = new System.Drawing.Point(480, 217);
            this.lbGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(50, 22);
            this.lbGroup.TabIndex = 4;
            this.lbGroup.Text = "Grup";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbNote.Location = new System.Drawing.Point(588, 250);
            this.tbNote.Margin = new System.Windows.Forms.Padding(4);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(612, 29);
            this.tbNote.TabIndex = 3;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbNote.Location = new System.Drawing.Point(480, 255);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(40, 22);
            this.lbNote.TabIndex = 4;
            this.lbNote.Text = "Not";
            // 
            // tb1stNumber
            // 
            this.tb1stNumber.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tb1stNumber.Location = new System.Drawing.Point(588, 287);
            this.tb1stNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb1stNumber.Name = "tb1stNumber";
            this.tb1stNumber.Size = new System.Drawing.Size(612, 29);
            this.tb1stNumber.TabIndex = 3;
            // 
            // lb1stNumber
            // 
            this.lb1stNumber.AutoSize = true;
            this.lb1stNumber.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lb1stNumber.Location = new System.Drawing.Point(480, 291);
            this.lb1stNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1stNumber.Name = "lb1stNumber";
            this.lb1stNumber.Size = new System.Drawing.Size(100, 22);
            this.lb1stNumber.TabIndex = 4;
            this.lb1stNumber.Text = "Numara 1 ";
            // 
            // tb2ndNumber
            // 
            this.tb2ndNumber.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tb2ndNumber.Location = new System.Drawing.Point(588, 324);
            this.tb2ndNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tb2ndNumber.Name = "tb2ndNumber";
            this.tb2ndNumber.Size = new System.Drawing.Size(612, 29);
            this.tb2ndNumber.TabIndex = 3;
            // 
            // lb2ndNumber
            // 
            this.lb2ndNumber.AutoSize = true;
            this.lb2ndNumber.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lb2ndNumber.Location = new System.Drawing.Point(480, 328);
            this.lb2ndNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2ndNumber.Name = "lb2ndNumber";
            this.lb2ndNumber.Size = new System.Drawing.Size(90, 22);
            this.lb2ndNumber.TabIndex = 4;
            this.lb2ndNumber.Text = "Numara 2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoadVcf,
            this.miSaveVcf});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miLoadVcf
            // 
            this.miLoadVcf.Name = "miLoadVcf";
            this.miLoadVcf.Size = new System.Drawing.Size(112, 26);
            this.miLoadVcf.Text = "Vcf Yükle";
            this.miLoadVcf.Click += new System.EventHandler(this.miLoadVcf_Click);
            // 
            // miSaveVcf
            // 
            this.miSaveVcf.Name = "miSaveVcf";
            this.miSaveVcf.Size = new System.Drawing.Size(122, 26);
            this.miSaveVcf.Text = "Vcf Kaydet";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btRemoveDups);
            this.panelBottom.Controls.Add(this.btRemove);
            this.panelBottom.Controls.Add(this.btAdd);
            this.panelBottom.Controls.Add(this.btSave);
            this.panelBottom.Controls.Add(this.btRemoveSelected);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 732);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1213, 61);
            this.panelBottom.TabIndex = 6;
            // 
            // btRemoveDups
            // 
            this.btRemoveDups.BackColor = System.Drawing.Color.Transparent;
            this.btRemoveDups.Dock = System.Windows.Forms.DockStyle.Left;
            this.btRemoveDups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveDups.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveDups.ForeColor = System.Drawing.Color.Maroon;
            this.btRemoveDups.Location = new System.Drawing.Point(230, 0);
            this.btRemoveDups.Margin = new System.Windows.Forms.Padding(4);
            this.btRemoveDups.Name = "btRemoveDups";
            this.btRemoveDups.Size = new System.Drawing.Size(234, 61);
            this.btRemoveDups.TabIndex = 7;
            this.btRemoveDups.Text = "Yinelenenleri Kaldır";
            this.btRemoveDups.UseVisualStyleBackColor = false;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.Transparent;
            this.btRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRemove.Enabled = false;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.Color.Red;
            this.btRemove.Location = new System.Drawing.Point(523, 0);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(230, 61);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Sil";
            this.btRemove.UseVisualStyleBackColor = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAdd.Enabled = false;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAdd.Location = new System.Drawing.Point(753, 0);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(230, 61);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Ekle";
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Transparent;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.btSave.ForeColor = System.Drawing.Color.YellowGreen;
            this.btSave.Location = new System.Drawing.Point(983, 0);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(230, 61);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Kaydet";
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // btRemoveSelected
            // 
            this.btRemoveSelected.BackColor = System.Drawing.Color.Transparent;
            this.btRemoveSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.btRemoveSelected.Enabled = false;
            this.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveSelected.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveSelected.ForeColor = System.Drawing.Color.Brown;
            this.btRemoveSelected.Location = new System.Drawing.Point(0, 0);
            this.btRemoveSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btRemoveSelected.Name = "btRemoveSelected";
            this.btRemoveSelected.Size = new System.Drawing.Size(230, 61);
            this.btRemoveSelected.TabIndex = 8;
            this.btRemoveSelected.Text = "Seçilenleri Sil";
            this.btRemoveSelected.UseVisualStyleBackColor = false;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbMiddleName.Location = new System.Drawing.Point(588, 65);
            this.tbMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(612, 29);
            this.tbMiddleName.TabIndex = 3;
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbMiddleName.Location = new System.Drawing.Point(480, 69);
            this.lbMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(80, 22);
            this.lbMiddleName.TabIndex = 4;
            this.lbMiddleName.Text = "2. İsim";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbCity.Location = new System.Drawing.Point(588, 176);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(612, 29);
            this.tbCity.TabIndex = 3;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbCity.Location = new System.Drawing.Point(480, 180);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(60, 22);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "Şehir";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1213, 793);
            this.Controls.Add(this.lb2ndNumber);
            this.Controls.Add(this.lb1stNumber);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tb2ndNumber);
            this.Controls.Add(this.tb1stNumber);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.CardList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Vcf Editör";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CardList;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox tb1stNumber;
        private System.Windows.Forms.Label lb1stNumber;
        private System.Windows.Forms.TextBox tb2ndNumber;
        private System.Windows.Forms.Label lb2ndNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miLoadVcf;
        private System.Windows.Forms.ToolStripMenuItem miSaveVcf;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btRemoveDups;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemoveSelected;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
    }
}

