namespace winform
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.list = new System.Windows.Forms.ListBox();
            this.Betoltes = new System.Windows.Forms.Button();
            this.Mentes = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblHobbi = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzulDatum = new System.Windows.Forms.Label();
            this.lblNeme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnFerfi = new System.Windows.Forms.RadioButton();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtSzulDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Szöveges Fájl(.txt)|*.txt|Minden Fájl|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(194, 32);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(129, 134);
            this.list.TabIndex = 0;
            // 
            // Betoltes
            // 
            this.Betoltes.Location = new System.Drawing.Point(104, 200);
            this.Betoltes.Name = "Betoltes";
            this.Betoltes.Size = new System.Drawing.Size(75, 23);
            this.Betoltes.TabIndex = 1;
            this.Betoltes.Text = "Betöltés";
            this.Betoltes.UseVisualStyleBackColor = true;
            this.Betoltes.Click += new System.EventHandler(this.Betoltes_Click);
            // 
            // Mentes
            // 
            this.Mentes.Location = new System.Drawing.Point(6, 200);
            this.Mentes.Name = "Mentes";
            this.Mentes.Size = new System.Drawing.Size(75, 23);
            this.Mentes.TabIndex = 2;
            this.Mentes.Text = "Mentes";
            this.Mentes.UseVisualStyleBackColor = true;
            this.Mentes.Click += new System.EventHandler(this.Mentes_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(194, 174);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(129, 20);
            this.txt1.TabIndex = 3;
            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyDown);
            // 
            // lblHobbi
            // 
            this.lblHobbi.AutoSize = true;
            this.lblHobbi.Location = new System.Drawing.Point(191, 16);
            this.lblHobbi.Name = "lblHobbi";
            this.lblHobbi.Size = new System.Drawing.Size(81, 13);
            this.lblHobbi.TabIndex = 4;
            this.lblHobbi.Text = "Kedvenc Hobbi";
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(12, 19);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(27, 13);
            this.lblNev.TabIndex = 5;
            this.lblNev.Text = "Név";
            // 
            // lblSzulDatum
            // 
            this.lblSzulDatum.AutoSize = true;
            this.lblSzulDatum.Location = new System.Drawing.Point(12, 54);
            this.lblSzulDatum.Name = "lblSzulDatum";
            this.lblSzulDatum.Size = new System.Drawing.Size(61, 13);
            this.lblSzulDatum.TabIndex = 6;
            this.lblSzulDatum.Text = "Szül.Datum";
            // 
            // lblNeme
            // 
            this.lblNeme.AutoSize = true;
            this.lblNeme.Location = new System.Drawing.Point(12, 86);
            this.lblNeme.Name = "lblNeme";
            this.lblNeme.Size = new System.Drawing.Size(32, 13);
            this.lblNeme.TabIndex = 7;
            this.lblNeme.Text = "Nem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Új hobbi:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(130, 84);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnNo.TabIndex = 10;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "Nő";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnFerfi
            // 
            this.rbtnFerfi.AutoSize = true;
            this.rbtnFerfi.Location = new System.Drawing.Point(79, 84);
            this.rbtnFerfi.Name = "rbtnFerfi";
            this.rbtnFerfi.Size = new System.Drawing.Size(45, 17);
            this.rbtnFerfi.TabIndex = 11;
            this.rbtnFerfi.TabStop = true;
            this.rbtnFerfi.Text = "Férfi";
            this.rbtnFerfi.UseVisualStyleBackColor = true;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(79, 16);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 12;
            // 
            // txtSzulDatum
            // 
            this.txtSzulDatum.Location = new System.Drawing.Point(79, 51);
            this.txtSzulDatum.Name = "txtSzulDatum";
            this.txtSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.txtSzulDatum.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 252);
            this.Controls.Add(this.txtSzulDatum);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.rbtnFerfi);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNeme);
            this.Controls.Add(this.lblSzulDatum);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.lblHobbi);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.Mentes);
            this.Controls.Add(this.Betoltes);
            this.Controls.Add(this.list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button Betoltes;
        private System.Windows.Forms.Button Mentes;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblHobbi;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblSzulDatum;
        private System.Windows.Forms.Label lblNeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnFerfi;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtSzulDatum;
    }
}

