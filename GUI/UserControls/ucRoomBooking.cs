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
                    Panel roomPanel = CreateRoomPanel(room);
                    flpRoom.Controls.Add(roomPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private Panel CreateRoomPanel(PhongDTO room)
        {
            Panel roomPanel = new Panel();
            roomPanel.BorderStyle = BorderStyle.FixedSingle;
            roomPanel.Size = new Size(200, 200);
            roomPanel.Cursor = Cursors.Hand;
            roomPanel.Click += (sender, e) =>
            {
                MessageBox.Show($"Bạn đã đặt phòng: {room.MoTa}");
            };

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = ByteArrayToImage(room.HinhAnh); 
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(roomPanel.Width, 120); 
            roomPanel.Controls.Add(pictureBox);

            Label nameLabel = new Label();
            nameLabel.Text = room.MoTa; 
            nameLabel.Dock = DockStyle.Top;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            roomPanel.Controls.Add(nameLabel);

            Label priceLabel = new Label();
            priceLabel.Text = $"Giá: {room.GiaPhong:C}"; 
            priceLabel.Dock = DockStyle.Top;
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            roomPanel.Controls.Add(priceLabel);

            Label descriptionLabel = new Label();
            descriptionLabel.Text = room.MoTa; 
            descriptionLabel.Dock = DockStyle.Top;
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            roomPanel.Controls.Add(descriptionLabel);

            return roomPanel;
        }


        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
    }
}

