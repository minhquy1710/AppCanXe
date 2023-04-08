using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tramcan2.models;

namespace tramcan2.form
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
            Loaddata();
           
        }
        CanDbcontext db = new CanDbcontext();
        void Loaddata()
        {
            
                var result = from c in db.khachHangs select c;  // c1: lấy ra cái mong muốn, theo thứ tự  //c2 db.Product.tostring(); lấy hết
                                                                // var result = from c in db.Products //where c.Id < 10  select c;
                dataGridView1.DataSource = result.ToList();

                 

        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            string Name_t = textBox_tenkh.Text;
            
            string CMND_t = textBox_cmnd.Text;
            int CMND = int.Parse(CMND_t);
            string SDTKH_t = textBox_sdtkh.Text;
            int SDTKH = int.Parse(SDTKH_t);
            string DiaChiKH_t = textBox_diachikh.Text;
            string time_t = DateTime.Now.ToString("dd/MM/yyyy");
            string NoiCapKH = textBox_noicap.Text;
            


            KhachHang KH = new KhachHang() { TenKhachHang = Name_t, DtKH = SDTKH, DiaChiKH = DiaChiKH_t,CMNDKH=CMND,NoiCapKH = NoiCapKH,NgayCapKH = time_t };
            
            if (KH != null)
            {
                db.khachHangs.Add(KH);
                db.SaveChanges();
                Loaddata();

            }
            else
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string MaKH_t = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int MaKH = int.Parse(MaKH_t);

           KhachHang KH = db.khachHangs.Find(MaKH);
            if (KH != null)
            {
                db.khachHangs.Remove(KH);
                db.SaveChanges();
                Loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaKH_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["MaKH"].Value.ToString();
            int MaKH = int.Parse(MaKH_t);

            KhachHang KH = db.khachHangs.Find(MaKH);
            KH.TenKhachHang = textBox_tenkh.Text;
            KH.DiaChiKH = textBox_diachikh.Text;
            KH.NgayCapKH = textBox_ngaycapkh.Text;
            string DtKH_t =textBox_sdtkh.Text;
            KH.DtKH = int.Parse(DtKH_t);
            
            if (KH != null)
            {
                db.SaveChanges();
                Loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_makh.DataBindings.Clear();
            textBox_makh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaKH"));
            textBox_ngaycapkh .DataBindings.Clear();
            textBox_ngaycapkh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NgayCapKH"));
            textBox_noicap .DataBindings.Clear();
            textBox_noicap.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NoiCapKH"));
            textBox_tenkh.DataBindings.Clear();
            textBox_tenkh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenKhachHang"));
            textBox_sdtkh .DataBindings.Clear();
            textBox_sdtkh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DtKH"));
            textBox_diachikh.DataBindings.Clear();
            textBox_diachikh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DiaChiKH"));
            textBox_cmnd.DataBindings.Clear();
            textBox_cmnd.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "CMNDKH"));
        }
    }
}
