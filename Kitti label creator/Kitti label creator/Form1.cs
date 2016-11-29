using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace Kitti_label_creator
{
    public partial class Form1 : Form
    {
        Bitmap basePic, marks = new Bitmap(10, 10);
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            createBase();
            defPicSize();
        }

        List<string> files;
        string dir;
        int idx = 0;
        double scale = 0;
        string kitti = "";
        List<double> points = new List<double>();
        List<double> origin = new List<double>();
        Regex exp = new Regex(@"//.+");
        Pen blackPen = new Pen(Color.Red, 3);


        private void dirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.ShowDialog();
            dir = dialog.SelectedPath;

            IEnumerable<string> file = Directory.EnumerateFiles(dir + "//", "*.*").Where(s => s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase));
            files = file.ToList();
            Directory.CreateDirectory(dir + "//images//");
            Directory.CreateDirectory(dir + "//labels//");
            Directory.CreateDirectory(dir + "//processed//");
            Directory.CreateDirectory(dir + "//discarted//");
            progressBar.Maximum = files.Count;
            progressBar.Value = 0;
            pictureBox1.BackgroundImage = nextPicture();
            saveBtn.Focus();
        }

        Bitmap nextPicture()
        {
            Bitmap picture = newPic(files[idx]);
            idx++;
            label1.Text = "File " + idx.ToString() + " of " + files.Count.ToString();
            progressBar.Value++;

            return picture;
        }

        double[] relSize()
        {
            double relx = float.Parse(xTxt.Text) / picPnl.Width;
            double rely = float.Parse(yTxt.Text) / picPnl.Height;

            if (relx > rely)
                return new double[] { relx, 0 };
            return new double[] { rely, 1 };
        }

        void defPicSize()
        {
            double[] res = relSize();
            scale = res[0];

            if (res[1] == 0)
            {
                pictureBox1.Width = picPnl.Width;
                pictureBox1.Height = (int)(int.Parse(yTxt.Text) / scale);
            }
            else
            {
                pictureBox1.Width = (int)(int.Parse(xTxt.Text) / scale);
                pictureBox1.Height = picPnl.Height;
            }
            pictureBox1.Location = new Point((picPnl.Width - pictureBox1.Width) / 2, (picPnl.Height - pictureBox1.Height) / 2);
        }

        Bitmap newPic(string path)
        {
            again:
            try
            {
                using (var picture = (Bitmap)Image.FromFile(files[idx]))
                {
                    double scale = 0, temp = 0;
                    int[] offset = new int[2];

                    if (picture.Height <= basePic.Height && picture.Width <= basePic.Width)
                    {
                        offset[0] = (basePic.Width - picture.Width) / 2;
                        offset[1] = (basePic.Height - picture.Height) / 2;
                        return place(picture, offset);

                    }
                    else
                    {
                        scale = (double)basePic.Width / picture.Width;
                        temp = (double)basePic.Height / picture.Height;
                        Size size;

                        if (scale < temp)
                        {
                            size = new Size(basePic.Width, (int)(picture.Height * scale));

                        }
                        else
                        {
                            size = new Size((int)(picture.Width * temp), basePic.Height);
                        }
                        offset[0] = (basePic.Width - size.Width) / 2;
                        offset[1] = (basePic.Height - size.Height) / 2;
                        return place(new Bitmap(picture, size), offset);
                    }
                }
            }
            catch (SystemException)
            {
                string name = exp.Match(files[idx]).Value;
                File.Move(files[idx], dir + "\\discarted" + name);
                if (idx == files.Count)
                {
                    saveBtn.Enabled = false;
                }
                idx++;
                goto again;
            }
        }

        Bitmap place(Bitmap Picture, int[] offset)
        {
            for (int i = 0; i < Picture.Width; i++)
            {
                for (int a = 0; a < Picture.Height; a++)
                {
                    //Color test = Picture.GetPixel(i, a);
                    basePic.SetPixel(i + offset[0], a + offset[1], Picture.GetPixel(i, a));
                }
            }
            return basePic;
        }

        void createBase()
        {
            int x = int.Parse(xTxt.Text), y = int.Parse(yTxt.Text);
            basePic = new Bitmap(x, y);
            if (x != marks.Width || y != marks.Height)
            {
                marks.Dispose();
                marks = new Bitmap(x, y);
            }
            pictureBox1.Image = marks;
            for (int i = 0; i < x; i++)
            {
                for (int a = 0; a < y; a++)
                {
                    basePic.SetPixel(i, a, Color.Gray);
                }
            }
            //pictureBox1.BackgroundImage = basePic;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            defPicSize();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            for (int i = 4; i <= points.Count; i += 4)
            {
                kitti += "car 0.0 0 0.0 " + (points[i - 4] * scale).ToString() + " " +
                    (points[i - 3] * scale).ToString() + " " + (points[i - 2] * scale).ToString() +
                    " " + (points[i - 1] * scale).ToString() + " 0.0 0.0 0.0 0.0 0.0 0.0 0.0\r\n";
            }

            points.Clear();
            origin.Clear();

            string fileName = (idx + int.Parse(startTxt.Text) - 1).ToString();
            while (fileName.Length < 5)
                fileName = "0" + fileName;
            pictureBox1.BackgroundImage.Save(dir + "\\images\\" + fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            File.WriteAllText(dir + "\\labels\\" + fileName + ".txt", kitti);
            string name = exp.Match(files[idx - 1]).Value;
            File.Move(files[idx - 1], dir + "\\processed" + name);
            //nextPicture().Dispose();
            basePic.Dispose();
            createBase();
            kitti = "";
            if (idx == files.Count)
            {
                saveBtn.Enabled = false;
                return;
            }
            pictureBox1.BackgroundImage = nextPicture();
        }

        bool marking = false;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            marking = !marking;
            if (marking)
            {
                points.Add(e.X);
                points.Add(e.Y);
                origin.Add(e.X);
                origin.Add(e.Y);
                points.Add(e.X * scale);
                points.Add(e.Y * scale);
            }
            else
                pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!marking)
                return;
            if (e.X > origin[origin.Count - 2])
            {
                points[points.Count - 2] = e.X;
                points[points.Count - 4] = origin[origin.Count - 2];
            }
            else
            {
                points[points.Count - 4] = e.X;
                points[points.Count - 2] = origin[origin.Count - 2];
            }
            if (e.Y > origin[origin.Count - 1])
            {
                points[points.Count - 1] = e.Y;
                points[points.Count - 3] = origin[origin.Count - 1];
            }
            else
            {
                points[points.Count - 3] = e.Y;
                points[points.Count - 1] = origin[origin.Count - 1];
            }
            pictureBox1.Refresh();
        }

        private void discBtn_Click(object sender, EventArgs e)
        {
            string name = exp.Match(files[idx - 1]).Value;
            File.Move(files[idx - 1], dir + "\\discarted" + name);
            //nextPicture().Dispose();
            basePic.Dispose();
            createBase();
            if (idx == files.Count)
            {
                saveBtn.Enabled = false;
                return;
            }
            pictureBox1.BackgroundImage = nextPicture();
            saveBtn.Focus();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int limit = points.Count;
            for (int i = 4; i <= limit; i += 4)
            {
                Rectangle rect = new Rectangle((int)points[i - 4], (int)points[i - 3],
                    (int)(points[i - 2] - points[i - 4]), (int)(points[i - 1] - points[i - 3]));
                e.Graphics.DrawRectangle(blackPen, rect);
            }

        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            points.Clear();
            origin.Clear();
            pictureBox1.Refresh();
            saveBtn.Focus();
        }
    }
}