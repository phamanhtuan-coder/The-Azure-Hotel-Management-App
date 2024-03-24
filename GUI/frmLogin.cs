using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUI.customForm;

namespace GUI
{
   

    public partial class frmLogin : Form
    {
        private Timer timerLoop;
        private int gifDuration = 18000;
        private int elapsed = 0;

        private userBLL userBLL;

        public frmLogin()
        {
            InitializeComponent();
            InitializeTimer();
            this.DoubleBuffered = true;

            userBLL = new userBLL();
        }

        private void InitializeTimer()
        {
            timerLoop = new Timer();
            timerLoop.Interval = 50;
            timerLoop.Tick += Timer_Tick;
            timerLoop.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsed += timerLoop.Interval;

            if (elapsed >= gifDuration)
            {
                this.picLoginBG.Image = global::GUI.Properties.Resources.backgroundLogin_LowRes;
                elapsed %= gifDuration;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            using (customMessageBox messageBox = new customMessageBox("Bạn có muốn thoát chương trình không?"))
            {
                DialogResult dr = messageBox.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    messageBox.Close();
                    return;
                }
                else if (dr == DialogResult.OK)
                {
                    this.Close();
                    messageBox.Close();
                }
            }
            Application.Exit();
        }

  

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            this.Hide();
            mainForm.Show();
            this.Close();


            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();

            //bool isValidLogin = userBLL.KiemTraDangNhap(username, password);

            //if (isValidLogin)
            //{
            //    //MessageBox.Show("Đăng nhập thành công!");
            //    // Thực hiện các hành động sau khi đăng nhập thành công
            //    frmMain mainForm = new frmMain();
            //    mainForm.Show();
            //    this.Hide();
            //    this.FormClosing -= frmLogin_FormClosing;
            //    this.Close();
            //    this.FormClosing += frmLogin_FormClosing;
            //}
            //else
            //{
            //    // Đăng nhập thất bại
            //    //MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
            //}

        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
           
            
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panLogin.Location.X == 60)
            {
                tmrTransistion.Start();
            }
            
        }

        private void tmrTransistion_Tick(object sender, EventArgs e)
        {
            int targetX = 520; 
            int speed = 40; 

            if (panLogin.Location.X < targetX)
            {
                int newX = panLogin.Location.X + speed;
                if (newX > targetX)
                    newX = targetX;

                panLogin.Location = new Point(newX, panLogin.Location.Y);
            }
            else
            {
                
                tmrTransistion.Stop();
            }

        }
    }


    public class SemiTransparentPanel : Panel
    {
        public SemiTransparentPanel()
        {
            this.DoubleBuffered = true; 
            this.SetStyle(ControlStyles.ResizeRedraw, true); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            GraphicsPath path = new GraphicsPath();
            int radius = 20; 
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);   
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90); 
            path.CloseFigure();

            
            Color semiTransparentColor = Color.FromArgb(128, this.BackColor);

            
            using (SolidBrush brush = new SolidBrush(semiTransparentColor))
            {
                e.Graphics.FillPath(brush, path);
            }

          
            path.Dispose();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate(); 
        }
    }

    public class SemiTransparentButton : Button
    {
    
        public SemiTransparentButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; 
            this.BackColor = Color.Transparent; 
            this.FlatAppearance.MouseOverBackColor = Color.Transparent; 
            this.FlatAppearance.MouseDownBackColor = Color.Transparent; 
            this.ImageAlign = ContentAlignment.MiddleCenter; 
            this.TextImageRelation = TextImageRelation.ImageBeforeText; 
            this.ForeColor = Color.White; 
            this.Font = new Font("Segoe UI Semibold", 9F); 
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.Clear(this.BackColor);
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate(); 
        }
    }
}
