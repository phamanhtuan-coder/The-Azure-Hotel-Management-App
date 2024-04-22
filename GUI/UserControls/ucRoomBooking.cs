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

namespace GUI.UserControls
{
    public partial class ucRoomBooking : UserControl
    {
        private PhongBLL phongBLL = new PhongBLL();
        public ucRoomBooking()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void ucRoomBooking_Load(object sender, EventArgs e)
        {
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
                    if (i ==0)
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

            SplitContainer chiaPanel = new SplitContainer();
            Label thongTinLabel = new Label();
            PictureBox hinhAnhPictureBox = new PictureBox();


            panelPhong.ParentChanged += (sender, e) =>
            {
                if (panelPhong.Parent != null)
                {
                    panelPhong.Parent.SizeChanged += (parentSender, parentE) =>
                    {
                        int w = (panelPhong.Parent.Size.Width / 2) -20 ;
                        panelPhong.Size = new Size(w, 200);
                        hinhAnhPictureBox.Width = panelPhong.Width / 3;
                    };
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

            hinhAnhPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            hinhAnhPictureBox.Dock = DockStyle.Left;
            
            hinhAnhPictureBox.Margin = new Padding(0);
            chiaPanel.Panel1.Controls.Add(hinhAnhPictureBox);

            thongTinLabel.Dock = DockStyle.Fill;
            thongTinLabel.Padding = new Padding(10, 5, 10, 5);
            thongTinLabel.Text = $"Phòng: {phong.MoTa}\nGiá: {phong.GiaPhong:C}\nMô tả: {phong.MoTa}";
            chiaPanel.Panel2.Controls.Add(thongTinLabel);

            if (phong.HinhAnh != null && phong.HinhAnh.Length > 0)
            {
                Image hinhAnh = ByteArrayToImage(phong.HinhAnh);
                if (hinhAnh != null)
                {
                    hinhAnhPictureBox.Image = hinhAnh;
                }
                else
                {
                   
                }
            }
            else
            {
                
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


    }
}

