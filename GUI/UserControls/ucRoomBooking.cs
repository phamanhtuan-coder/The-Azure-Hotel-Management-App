using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace GUI.UserControls
{
    public partial class ucRoomBooking : UserControl
    {
        
        private PhongBLL phongBLL = new PhongBLL();
        public int maKH { get; set; }
        public ucRoomBooking()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void ucRoomBooking_Load(object sender, EventArgs e)
        {
            dtpCheckInDate.MinDateTime = DateTime.Now;
            LoadAvailableRooms();
      
        }
       
        private void LoadAvailableRooms()
        {
            try
            {
                var availableRooms = phongBLL.GetAvailableRooms();
                int i = 0;
                foreach (var room in availableRooms)
                {
                    Panel roomPanel = TaoPanelPhong(room);
                    roomPanel.Dock = DockStyle.Top;
                    if (i == 0)
                    {
                        roomPanel.Margin = new Padding(5, 5, 0, 0);

                    }
                    flpRoom.Controls.Add(roomPanel);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private Panel TaoPanelPhong(PhongDTO phong)
        {
            Panel panelPhong = new Panel();
            panelPhong.BorderStyle = BorderStyle.FixedSingle;
            panelPhong.BackColor = Color.White;

            int parentPanelWidth = (flpRoom.ClientSize.Width / 2) - 10;

            panelPhong.Size = new Size(parentPanelWidth, 200);

            SplitContainer chiaPanel = new SplitContainer();
            Label thongTinLabel = new Label();
            PictureBox hinhAnhPictureBox = new PictureBox();
            hinhAnhPictureBox.Width = parentPanelWidth / 3;

            flpRoom.SizeChanged += (sender, e) =>
            {

                if (flpRoom != null)
                {
                    int parentWidth = flpRoom.ClientSize.Width;
                    int childPanelWidth = (parentWidth / 2) - 10;
                    panelPhong.Size = new Size(childPanelWidth, 200);
                    hinhAnhPictureBox.Width = childPanelWidth / 3;
                }
            };

            panelPhong.Cursor = Cursors.Hand;
            panelPhong.Click += (sender, e) =>
            {
                MessageBox.Show($"Bạn đã đặt phòng: {phong.MoTa}");
            };

            chiaPanel.Dock = DockStyle.Fill;
            chiaPanel.BorderStyle = BorderStyle.None;
            chiaPanel.SplitterWidth = 5;
            chiaPanel.IsSplitterFixed = false;
            chiaPanel.FixedPanel = FixedPanel.None;

            hinhAnhPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            hinhAnhPictureBox.Dock = DockStyle.Fill;
            hinhAnhPictureBox.Margin = new Padding(0);
            chiaPanel.Panel1.Controls.Add(hinhAnhPictureBox);

            thongTinLabel.AutoSize = true;
            thongTinLabel.Location = new Point(10, 10);
            thongTinLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            thongTinLabel.Padding = new Padding(10, 5, 10, 5);
            string giaPhong = string.Format("{0:000,0}", phong.GiaPhong);
            thongTinLabel.Text = $"Phòng: {phong.MoTa}\nGiá: {giaPhong} VNĐ \nMô tả: {phong.MoTa}";
            chiaPanel.Panel2.Controls.Add(thongTinLabel);



            SfButton btnDatPhong = new SfButton();
            btnDatPhong.Margin = new Padding(10, 5, 10, 5);
            btnDatPhong.Text = "Chọn phòng";
            btnDatPhong.Font = new Font("Montserrat", 12F);
            btnDatPhong.AutoSize = true;
            btnDatPhong.Style.BackColor = Color.ForestGreen;
            btnDatPhong.Style.ForeColor = Color.White;
            chiaPanel.Panel2.Controls.Add(btnDatPhong);

            btnDatPhong.Click += (sender, e) =>
            {
                frmMain parentForm = this.ParentForm as frmMain;
                frmBookingController bookingController = new frmBookingController();
                bookingController.maKH = this.maKH;
                bookingController.maPhong = phong.MaPHG;
                bookingController.ngayDat= dtpCheckInDate.Value.ToString();
                bookingController.soKhach= (int)nudSucChua.Value; 
                bookingController.ShowDialog();
            };




            chiaPanel.SizeChanged += (sender, e) =>
            {
                int splitterDistance = chiaPanel.ClientSize.Width / 3;

                
                if (splitterDistance < chiaPanel.Panel1MinSize)
                {
                    splitterDistance = chiaPanel.Panel1MinSize;
                }
                else if (splitterDistance > chiaPanel.ClientSize.Width - chiaPanel.Panel2MinSize)
                {
                    splitterDistance = chiaPanel.ClientSize.Width - chiaPanel.Panel2MinSize;
                }

                
                chiaPanel.SplitterDistance = splitterDistance;
                thongTinLabel.Location = new Point((int)Math.Floor(chiaPanel.Panel2.ClientSize.Width * 0.055) - 10, 10);
                thongTinLabel.TextAlign = ContentAlignment.TopLeft;
                btnDatPhong.Location = new Point(chiaPanel.Panel2.ClientSize.Width - btnDatPhong.Width - 10, thongTinLabel.Bottom + 50);

            };

            if (phong.HinhAnh != null && phong.HinhAnh.Length > 0)
            {
                Image hinhAnh = ByteArrayToImage(phong.HinhAnh);
                if (hinhAnh != null)
                {
                    hinhAnhPictureBox.Image = hinhAnh;
                }
                else
                {
                    hinhAnhPictureBox.Image = GUI.Properties.Resources.no_pictures;
                }
            }
            else
            {
                hinhAnhPictureBox.Image = GUI.Properties.Resources.no_pictures;
            }

            panelPhong.Controls.Add(chiaPanel);

            return panelPhong;
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException(nameof(byteArray), "Byte array cannot be null.");
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(byteArray);
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }

        private void btnTraCuuRoomType_Click(object sender, EventArgs e)
        {
            try
            {
                // Trích xuất tiêu chí lọc
                DateTime ngayCheckIn = (DateTime)dtpCheckInDate.Value;
                int soLuongKhach = (int)nudSucChua.Value;
                decimal priceMin = nudPriceMin.Value;
                decimal priceMax = nudPriceMax.Value;

                // Gọi phương thức để lấy các phòng đã lọc
                List<PhongDTO> filteredRooms = phongBLL.FilterRooms(ngayCheckIn, soLuongKhach, priceMin, priceMax);

                // Xóa các panel phòng đã có
                flpRoom.Controls.Clear();

                // Kiểm tra nếu danh sách phòng lọc là rỗng
                if (filteredRooms != null && filteredRooms.Any())
                {
                    // Có phòng, hiển thị các phòng đã lọc
                    foreach (var room in filteredRooms)
                    {
                        Panel roomPanel = TaoPanelPhong(room);
                        roomPanel.Dock = DockStyle.Top;
                        roomPanel.Margin = new Padding(5, 5, 0, 0);
                        flpRoom.Controls.Add(roomPanel);
                    }
                }
                else
                {
                    // Không có phòng, thêm một nhãn vào panel
                    Label lblNoRoomsAvailable = new Label();
                    lblNoRoomsAvailable.Text = "Xin lỗi! Hiện tại chúng tôi không tìm thấy phòng phù hợp với tiêu chí của bạn! \n Bạn hãy vui lòng thử tìm kiếm lại";
                    lblNoRoomsAvailable.ForeColor = Color.Red;
                    lblNoRoomsAvailable.Dock = DockStyle.Fill;
                    lblNoRoomsAvailable.TextAlign = ContentAlignment.MiddleCenter;

                    lblNoRoomsAvailable.Font = new Font("Montserrat", 18, FontStyle.Bold);

                    Panel noRoomsPanel = new Panel();
                    noRoomsPanel.Width = flpRoom.Width;
                    noRoomsPanel.Height = flpRoom.Height;
                    noRoomsPanel.BorderStyle = BorderStyle.FixedSingle;
                    noRoomsPanel.BackColor = Color.White;
                    noRoomsPanel.Dock = DockStyle.Top;
                    noRoomsPanel.Controls.Add(lblNoRoomsAvailable);

                    flpRoom.Controls.Add(noRoomsPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


    
    }
}

