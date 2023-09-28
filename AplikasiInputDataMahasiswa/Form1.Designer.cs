namespace AplikasiInputDataMahasiswa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textNim = new TextBox();
            textNama = new TextBox();
            textKelas = new TextBox();
            textNilai = new TextBox();
            groupBox1 = new GroupBox();
            listViewMahasiswa = new ListView();
            buttonHapus = new Button();
            buttonTampilkanData = new Button();
            buttonReset = new Button();
            buttonSimpan = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Nim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Kelas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Nilai";
            // 
            // textNim
            // 
            textNim.Location = new Point(100, 18);
            textNim.Name = "textNim";
            textNim.Size = new Size(100, 23);
            textNim.TabIndex = 4;
            // 
            // textNama
            // 
            textNama.Location = new Point(100, 53);
            textNama.Name = "textNama";
            textNama.Size = new Size(186, 23);
            textNama.TabIndex = 5;
            // 
            // textKelas
            // 
            textKelas.Location = new Point(100, 86);
            textKelas.Name = "textKelas";
            textKelas.Size = new Size(100, 23);
            textKelas.TabIndex = 6;
            // 
            // textNilai
            // 
            textNilai.Location = new Point(100, 119);
            textNilai.Name = "textNilai";
            textNilai.Size = new Size(100, 23);
            textNilai.TabIndex = 7;
            textNilai.KeyPress += textNilai_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewMahasiswa);
            groupBox1.Controls.Add(buttonHapus);
            groupBox1.Controls.Add(buttonTampilkanData);
            groupBox1.Location = new Point(292, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 416);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ Daftar Mahasiswa ]";
            // 
            // listViewMahasiswa
            // 
            listViewMahasiswa.Location = new Point(19, 77);
            listViewMahasiswa.Name = "listViewMahasiswa";
            listViewMahasiswa.Size = new Size(566, 333);
            listViewMahasiswa.TabIndex = 12;
            listViewMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(206, 41);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(75, 23);
            buttonHapus.TabIndex = 11;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonTampilkanData
            // 
            buttonTampilkanData.Location = new Point(19, 41);
            buttonTampilkanData.Name = "buttonTampilkanData";
            buttonTampilkanData.Size = new Size(150, 23);
            buttonTampilkanData.TabIndex = 10;
            buttonTampilkanData.Text = "Tampilkan Data";
            buttonTampilkanData.UseVisualStyleBackColor = true;
            buttonTampilkanData.Click += buttonTampilkanData_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(125, 162);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 9;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(12, 162);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(75, 23);
            buttonSimpan.TabIndex = 10;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(buttonSimpan);
            Controls.Add(buttonReset);
            Controls.Add(groupBox1);
            Controls.Add(textNilai);
            Controls.Add(textKelas);
            Controls.Add(textNama);
            Controls.Add(textNim);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Input Data Mahasiswa";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textNim;
        private TextBox textNama;
        private TextBox textKelas;
        private TextBox textNilai;
        private GroupBox groupBox1;
        private ListView listViewMahasiswa;
        private Button buttonHapus;
        private Button buttonTampilkanData;
        private Button buttonReset;
        private Button buttonSimpan;
    }
}