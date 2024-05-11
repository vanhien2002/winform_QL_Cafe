using BLL;
using BLL.Core;
using BLL.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Frm
{
    public partial class frm_TachBan : Form
    {
        XuLyBan xuLyBan = new XuLyBan();
        XuLyHoaDon xuLyHoaDon = new XuLyHoaDon();
        XuLyTrangThaiBan xuLyTrangThaiBan = new XuLyTrangThaiBan();
        XuLyChiTietHoaDon xuLyChiTietHoaDon = new XuLyChiTietHoaDon();
        XuLySanPham xuLySanPham = new XuLySanPham();
        XuLyKhachHang xuLyKhachHang = new XuLyKhachHang();
        private List<Panel> danhSachPanelDaChon = new List<Panel>();
        //
        List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
        //
        //các column trong datatable CTHD
        private string CTHDclThanhTien = "Thành tiền";
        private string CTHDclMaHoaDon = "Mã hóa đơn";
        private string CTHDclTenSP = "Tên sản phẩm";
        private string CTHDclSoLuong = "Số lượng";
        private string CTHDclDonGia = "Đơn giá";
        private string CTHDclMaSP = "Mã sản phẩm";
        //
        DataTable dataTableCTHoaDon2, dataTableCTHoaDon;
        //
        private string trangThaiBanTrong = "bàn trống";
        private string trangThaiBanDaDat = "bàn đã đặt";
        private string trangThaiBanCoKhach = "đã có khách";
        private string trangThaiHD_DaTT = "đã thanh toán";
        private string trangThaiHD_chuaTT = "chưa thanh toán";
        public frm_TachBan()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
           TaoDSban();
        }
        public Panel taoBan(string maBan, string TenBan, string trangthai)
        {
            Panel panel = new Panel
            {
                Width = 60,
                Height = 60,
                // Set the border style
                BorderStyle = BorderStyle.FixedSingle,
                Name = TenBan,
            };
            //màu theo trạng thái và TAG
            switch (trangthai)
            {
                case var x when x.Equals(trangThaiBanCoKhach):
                    {
                        panel.BackColor = Color.LightCoral;
                        panel.Tag = trangThaiBanCoKhach;
                        break;
                    }
                case var x when x.Equals(trangThaiBanDaDat):
                    {
                        panel.BackColor = Color.LightYellow;
                        panel.Tag = trangThaiBanDaDat;
                        break;
                    }
                case var x when x.Equals(trangThaiBanTrong):
                    {
                        panel.BackColor = Color.LimeGreen;
                        panel.Tag = trangThaiBanTrong;
                        break;
                    }
                default:
                    break;
            }
            panel.Click += Panel_Click;
            Label label = new Label
            {
                Text = TenBan,
                Location = new Point(0, 0),
                Name = maBan,
                Font = new Font("Arial", 12), // Set the font with size 12
            };
            panel.Controls.Add(label);
            return panel;
        }
        private void khoiTaoDTBL_CTHoaDon()
        {
            dataTableCTHoaDon = new DataTable();
            dataTableCTHoaDon.Columns.Add(CTHDclTenSP);
            dataTableCTHoaDon.Columns.Add(CTHDclSoLuong);
            dataTableCTHoaDon.Columns.Add(CTHDclDonGia);
            dataTableCTHoaDon.Columns.Add(CTHDclThanhTien);
            dtgv_CTHoaDon.DataSource = dataTableCTHoaDon;
        }
        private void khoiTaoDTBL_CTHoaDon2()
        {
            dataTableCTHoaDon2 = new DataTable();
            dataTableCTHoaDon2.Columns.Add(CTHDclTenSP);
            dataTableCTHoaDon2.Columns.Add(CTHDclSoLuong);
            dataTableCTHoaDon2.Columns.Add(CTHDclDonGia);
            dataTableCTHoaDon2.Columns.Add(CTHDclThanhTien);
            dtgv_BanMuonTach.DataSource = dataTableCTHoaDon2;
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            //có 3 trạng thái : đã có khách, bàn trống, và đã đặt
            //đã có khách thì hiển thị hóa đơn bàn đó lên
            //bàn trống khỏi hiển thị
            //đặt bàn thì hiên thị nhận bàn
            Panel p = (Panel)sender;
            txtTenBan.Text = p.Name;
            string tenBan = p.Name;
            string maBan = xuLyBan.LayMaBan(tenBan);
            khoiTaoDTBL_CTHoaDon();
            switch (p.Tag)
            {
                case var x when x.Equals(trangThaiBanCoKhach):
                    {
                        //hiển thị hóa đơn bàn đó lên
                        HoaDon hd = xuLyHoaDon.LayHoaDon(maBan, trangThaiHD_chuaTT);
                        if (hd != null)
                        {
                            txtMaHD.Text = hd.MaHD;
                            chiTietHoaDons = new List<ChiTietHoaDon>();
                            chiTietHoaDons = xuLyChiTietHoaDon.LayChiTietHoaDon(hd.MaHD);
                            LoadDGV_CTHoaDon(chiTietHoaDons);
                        }
                        break;
                    }
                case var x when x.Equals(trangThaiBanDaDat):
                    {
                        //hiển thị nhận bàn
                        khoiTaoDTBL_CTHoaDon();
                        break;
                    }
                case var x when x.Equals(trangThaiBanTrong):
                    {
                        //cho phép tách bàn
                        khoiTaoDTBL_CTHoaDon2();
                        LoadDGV_CTHoaDon2();
                        break;
                    }
                default:
                    break;
            }
        }
        private void LoadDGV_CTHoaDon(List<ChiTietHoaDon> cthoadons)
        {
            khoiTaoDTBL_CTHoaDon();
            if (cthoadons != null)
            {
                int tongsl = 0;
                int tongSP = 0;
                double tongTien = 0;
                string trangthaiHD = "null";
                string maHD = "";
                foreach (ChiTietHoaDon cthd in cthoadons)
                {
                    maHD = cthd.MaHD;
                    tongsl += cthd.SoLuong.Value;
                    tongTien += cthd.SoLuong.Value * cthd.DonGia.Value;
                    LoadDGV_CTHoaDon(cthd);
                }
                tongSP = cthoadons.Count();
                if (!String.IsNullOrEmpty(maHD) || maHD != "") { trangthaiHD = xuLyHoaDon.TimKiem(maHD).TrangThai; }
                //txtTongSanPham.Text = tongSP.ToString();
                //txtTrangThaiHD.Text = trangthaiHD;
                //txtTongSL.Text = tongsl.ToString();
                //txtTongTien.Text = Librari.ConvertFormatTien(tongTien);
            }
        }
        private void LoadDGV_CTHoaDon2(List<ChiTietHoaDon> cthoadons)
        {
            khoiTaoDTBL_CTHoaDon2();
            if (cthoadons != null)
            {
                int tongsl = 0;
                int tongSP = 0;
                double tongTien = 0;
                string trangthaiHD = "null";
                string maHD = "";
                foreach (ChiTietHoaDon cthd in cthoadons)
                {
                    maHD = cthd.MaHD;
                    tongsl += cthd.SoLuong.Value;
                    tongTien += cthd.SoLuong.Value * cthd.DonGia.Value;
                    LoadDGV_CTHoaDon2(cthd);
                }
                tongSP = cthoadons.Count();
                if (!String.IsNullOrEmpty(maHD) || maHD != "") { trangthaiHD = xuLyHoaDon.TimKiem(maHD).TrangThai; }
                //txtTongSanPham.Text = tongSP.ToString();
                //txtTrangThaiHD.Text = trangthaiHD;
                //txtTongSL.Text = tongsl.ToString();
                //txtTongTien.Text = Librari.ConvertFormatTien(tongTien);
            }
        }

        private void LoadDGV_CTHoaDon()
        {
            List<ChiTietHoaDon> cthoadon = new List<ChiTietHoaDon>();
            LoadDGV_CTHoaDon(cthoadon);
        }
        private void LoadDGV_CTHoaDon2()
        {
            List<ChiTietHoaDon> cthoadon = new List<ChiTietHoaDon>();
            LoadDGV_CTHoaDon2(cthoadon);
        }
        
        private void LoadDGV_CTHoaDon(ChiTietHoaDon cthd)
        {
            if (cthd != null)
            {
                DataRow row = dataTableCTHoaDon.NewRow();
                row[CTHDclTenSP] = xuLySanPham.layTenSP(cthd.MaSP);
                row[CTHDclSoLuong] = cthd.SoLuong.Value;
                row[CTHDclDonGia] = cthd.DonGia;
                row[CTHDclThanhTien] = cthd.SoLuong * cthd.DonGia;
                dataTableCTHoaDon.Rows.Add(row);
                dtgv_CTHoaDon.DataSource = dataTableCTHoaDon;
            }
        }
        private void LoadDGV_CTHoaDon2(ChiTietHoaDon cthd)
        {
            if (cthd != null)
            {
                DataRow row = dataTableCTHoaDon.NewRow();
                row[CTHDclTenSP] = xuLySanPham.layTenSP(cthd.MaSP);
                row[CTHDclSoLuong] = cthd.SoLuong.Value;
                row[CTHDclDonGia] = cthd.DonGia;
                row[CTHDclThanhTien] = cthd.SoLuong * cthd.DonGia;
                dataTableCTHoaDon.Rows.Add(row);
                dtgv_BanMuonTach.DataSource = dataTableCTHoaDon;
            }
        }

        public ChiTietHoaDon layTT_DGV_HoaDon(int rowclick)
        {
            if (dtgv_CTHoaDon.CurrentCell != null)
            {
                ChiTietHoaDon chitiethoadon = new ChiTietHoaDon();
                string mahd = chiTietHoaDons[rowclick].MaHD.ToString();
                chitiethoadon = xuLyChiTietHoaDon.layChiTietHoaDon(mahd);
                return chitiethoadon;
            }
            return null;
        }
        int indexClickDGVSP = -1;

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            
            if (indexClickDGVSP == -1) { return; }

            ChiTietHoaDon ct = layTT_DGV_HoaDon(indexClickDGVSP);
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            if (ct != null)
            {
                string mahd = txtMaHD.Text;
                cthd.MaHD = mahd;
                cthd.MaSP = ct.MaSP;
                cthd.SoLuong = int.Parse(txtSoLuong.Value.ToString());
                cthd.DonGia = ct.TongTien;
                xuLyChiTietHoaDon.Them_CTHoaDon(cthd);
                //xuLyChiTietHoaDon.Xoa_CTHoaDon(mahd);
                List<ChiTietHoaDon> listCTHD = xuLyChiTietHoaDon.LayChiTietHoaDon(mahd);
                LoadDGV_CTHoaDon2(listCTHD);
            }

        }

        private void dtgv_CTHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dtgv_CTHoaDon.CurrentCell != null)
            {
                indexClickDGVSP = index;
                //khoiTaoDTBL_CTHoaDon2();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string tenBan = txtTenBan.Text;
            string maban = xuLyBan.LayMaBan(tenBan);
            List<ChiTietHoaDon> cthd = new List<ChiTietHoaDon>();
            if (danhSachPanelDaChon.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một bàn để tách hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //cập nhật trạng thái bàn 
            string matrangthai = xuLyTrangThaiBan.layMaTrangThai(trangThaiBanCoKhach);
            int kq = xuLyBan.capNhatTrangThaiBan(maban, matrangthai);
            //Lấy hoá đơn
            HoaDon hd = new HoaDon();
            hd.MaBan = maban;
            hd.NgayLap = DateTime.Now;
            hd.TrangThai = trangThaiHD_chuaTT;
            hd.TongTien = cthd.Sum(x => x.DonGia * x.SoLuong);
            kq = xuLyHoaDon.Them(hd);
            txtMaHD.Text = hd.MaHD;
            
            xuLyBan.capNhatTrangThaiBan(maban, trangThaiBanTrong);

            TaoDSban();
            danhSachPanelDaChon.Clear();
            //LoadDGV_CTHoaDon(gopHD);
            //reload lại bàn
            if (kq == 1)
            {
                MessageBox.Show("Tách thành công");
                TaoDSban();
                //CoHieuLucControl(btnChon);
            }
        }

        public void TaoDSban()
        {
            try
            {
                groupBox1.Controls.Clear();
                List<BAN> listBan = xuLyBan.getAllBan();
                int x = 10, y = 10;
                int indexBan = 0;
                for (int row = 0; row < listBan.Count; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        string tenTT = xuLyTrangThaiBan.layTenTrangThai(listBan[indexBan].MaTrangThai);
                        Panel p = taoBan(listBan[indexBan].MaBan, listBan[indexBan].TenBan, tenTT);
                        p.Location = new Point(x, y);
                        groupBox1.Controls.Add(p);
                        x += p.Width + 10;
                        indexBan++;
                    }
                    x = 10;
                    y += 70;
                }
            }
            catch { }
        }
    }
}
