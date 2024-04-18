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
            LoadAvailableRooms();
        }

        private void ucRoomBooking_Load(object sender, EventArgs e)
        {
          
        }
        private void LoadAvailableRooms()
        {
            try
            {
                var availableRooms = phongBLL.GetAvailableRooms();

                foreach (var room in availableRooms)
                {
                    Panel roomPanel = TaoPanelPhong(room);
                    roomPanel.Dock = DockStyle.Top; // Set the room panel to fill the remaining space
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
            panelPhong.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            int w = (flpRoom.Size.Width / 2) -10;
            panelPhong.Size = new Size(w, 200);
            panelPhong.Cursor = Cursors.Hand;
            panelPhong.Click += (sender, e) =>
            {
                MessageBox.Show($"Bạn đã đặt phòng: {phong.MoTa}");
            };

            SplitContainer chiaPanel = new SplitContainer();
            chiaPanel.Dock = DockStyle.Fill;
            chiaPanel.BorderStyle = BorderStyle.None;
            chiaPanel.SplitterWidth = 5;
            chiaPanel.IsSplitterFixed = false;
            chiaPanel.FixedPanel = FixedPanel.None;

            PictureBox hinhAnhPictureBox = new PictureBox();
            hinhAnhPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            hinhAnhPictureBox.Dock = DockStyle.Left;
            hinhAnhPictureBox.Width = panelPhong.Width / 3; // Set the width to one-third of the panel width
            hinhAnhPictureBox.Margin = new Padding(0);
            chiaPanel.Panel1.Controls.Add(hinhAnhPictureBox);

            Label thongTinLabel = new Label();
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
                    // Handle case where the byte array cannot be converted to an image
                    // Maybe display a placeholder image or show an error message
                }
            }
            else
            {
                // Handle case where HinhAnh is null or empty
                // Maybe display a placeholder image or show an error message
            }

            panelPhong.Controls.Add(chiaPanel);

            return panelPhong;
        }







        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
            {
                // Handle null byte array case, maybe return a default image or throw an exception
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

