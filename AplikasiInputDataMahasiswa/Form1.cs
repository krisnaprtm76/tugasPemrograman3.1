namespace AplikasiInputDataMahasiswa
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            InitialisasiListView();
        }

        // atur kolom listview
        private void InitialisasiListView()
        {
            listViewMahasiswa.View = View.Details;
            listViewMahasiswa.FullRowSelect = true;
            listViewMahasiswa.GridLines = true;

            listViewMahasiswa.Columns.Add("No.", 40, HorizontalAlignment.Center);
            listViewMahasiswa.Columns.Add("Nim", 91, HorizontalAlignment.Center);
            listViewMahasiswa.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            listViewMahasiswa.Columns.Add("Kelas", 70, HorizontalAlignment.Center);
            listViewMahasiswa.Columns.Add("Nilai", 50, HorizontalAlignment.Center);
            listViewMahasiswa.Columns.Add("Nilai Huruf", 100, HorizontalAlignment.Center);
        }

        void ResetForm()
        {
            textNama.Clear();
            textNim.Clear();
            textKelas.Clear();
            textNilai.Text = "0";
           
            textNim.Focus();

        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private void TampilkanData()
        {
            listViewMahasiswa.Items.Clear();

            foreach (var mhs in list)
            {
                var noUrut = listViewMahasiswa.Items.Count + 1;

                if(mhs.Nilai > 80)
                {
                    mhs.Huruf = "A";
                } else if(mhs.Nilai > 60)
                {
                    mhs.Huruf = "B";
                }else if(mhs.Nilai > 40)
                {
                    mhs.Huruf = "C";
                }else if(mhs.Nilai > 20)
                {
                    mhs.Huruf = "D";
                }
                else
                {
                    mhs.Huruf= "E";
                }

                

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Kelas);
                item.SubItems.Add(mhs.Nilai.ToString());
                item.SubItems.Add(mhs.Huruf);
                

                listViewMahasiswa.Items.Add(item);
            }
        }




        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nim = textNim.Text;
            mhs.Nama = textNama.Text;
            mhs.Kelas = textKelas.Text;
            mhs.Nilai = int.Parse(textNilai.Text);
            

            list.Add(mhs);
            var msg = "Data Mahasiswa berhasil disimpan";

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }

        private void buttonTampilkanData_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            // cek apakah data mahasiswa sudah dipilih
            if (listViewMahasiswa.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index list yang di pilih
                    var index = listViewMahasiswa.SelectedIndices[0];
                    // hapus objek mahasiswa dari list
                    list.RemoveAt(index);
                    // refresh tampilan listivew
                    TampilkanData();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

    class Mahasiswa
    {
        public string Nim { get; set; }
        public string Kelas { get; set; }
        public string Nama { get; set; }
        public int Nilai { get; set; }

        public string Huruf = "a";

        
    }
}