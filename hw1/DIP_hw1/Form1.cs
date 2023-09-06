using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP_hw1
{

    public partial class Form1 : Form
    {
        Color white = Color.FromArgb(255, 255, 255);
        Color black = Color.FromArgb(0, 0, 0);
        Random random = new Random();

        List<Point> pictureBox1_pos = new List<Point>();
        List<Point> pictureBox2_pos = new List<Point>();

        Bitmap undo;

        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 255;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            trackBar_threshold.SetRange(1, 255);
            trackBar_overlap.SetRange(1, 255);
            label1.Text = "";
        }

        private Bitmap grayscale(Image image)
        {
            Bitmap result = new Bitmap(image);

            for (int i = 0; i < image.Width; ++i)
            {
                for (int j = 0; j < image.Height; ++j)
                {
                    Color color = ((Bitmap)image).GetPixel(i, j);
                    int val = Convert.ToInt32(color.B * 0.07 + color.G * 0.72 + color.R * 0.21);

                    result.SetPixel(i, j, Color.FromArgb(val, val, val));
                }
            }
            return result;
        }

        private double checkRange(double n)
        {
            if (n < 0) return 0;
            else if (n > 255) return 255;
            return n;
        }

        private int checkRange(int n)
        {
            if (n < 0) return 0;
            else if (n > 255) return 255;
            return n;
        }

        private void setPicture(Bitmap bitmap)
        {
            undo = new Bitmap(pictureBox2.Image);
            pictureBox2.Image = bitmap;
        }

        private Bitmap Conv(Image image, double[,] filter)
        {
            Bitmap bitmap = (Bitmap)image;
            Bitmap result = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < bitmap.Width; ++i)
            {
                for(int j = 0; j < bitmap.Height; ++j)
                {
                    double Rval = 0, Gval = 0, Bval = 0;
                    for (int u = 0; u < 3; ++u)
                    {
                        for (int v = 0; v < 3; ++v)
                        {
                            try
                            {
                                Color color = bitmap.GetPixel(i - 1 + u, j - 1 + v);
                                Rval += color.R * filter[u, v];
                                Gval += color.G * filter[u, v];
                                Bval += color.B * filter[u, v];
                            }
                            catch(Exception ex) { }
                        }
                    }
                    Rval = checkRange(Math.Abs(Rval));
                    Gval = checkRange(Math.Abs(Gval));
                    Bval = checkRange(Math.Abs(Bval));
                    result.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(Rval), Convert.ToInt32(Gval), Convert.ToInt32(Bval)));
                }
            }
            return result;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                undo = new Bitmap(pictureBox2.Image);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ALL Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btn_extractR_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox2.Image);
                Bitmap r = new Bitmap(bitmap.Width, bitmap.Height);
                for(int i = 0; i < bitmap.Width; ++i)
                {
                    for(int j = 0; j < bitmap.Height; ++j)
                    {
                        int val = bitmap.GetPixel(i, j).R;
                        bitmap.SetPixel(i, j, Color.FromArgb(val, val, val));
                        Color color = bitmap.GetPixel(i, j);

                    }
                }

                setPicture(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_extractB_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox2.Image);
                Bitmap r = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; ++i)
                {
                    for (int j = 0; j < bitmap.Height; ++j)
                    {
                        int val = bitmap.GetPixel(i, j).B;
                        bitmap.SetPixel(i, j, Color.FromArgb(val, val, val));
                        Color color = bitmap.GetPixel(i, j);

                    }
                }

                setPicture(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_extractG_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox2.Image);
                Bitmap r = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; ++i)
                {
                    for (int j = 0; j < bitmap.Height; ++j)
                    {
                        int val = bitmap.GetPixel(i, j).G;
                        bitmap.SetPixel(i, j, Color.FromArgb(val, val, val));
                        Color color = bitmap.GetPixel(i, j);

                    }
                }

                setPicture(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox2.Image);
            
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Color color = (bitmap).GetPixel(i, j);
                    int val = Convert.ToInt32(color.B * 0.07 + color.G * 0.72 + color.R * 0.21);

                    bitmap.SetPixel(i, j, Color.FromArgb(val, val, val));
                }
            }
            setPicture(bitmap);
        }

        private void btn_mean_filter_Click(object sender, EventArgs e)
        {
            double[,] filter = new double[3, 3] { {1.0/9, 1.0/9, 1.0/9}, { 1.0 / 9, 1.0 / 9, 1.0 / 9 }, { 1.0 / 9, 1.0 / 9, 1.0 / 9 } }; 

            Bitmap bitmap = Conv(pictureBox2.Image, filter);
            setPicture(bitmap);
        }

        private void btn_median_filter_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(pictureBox2.Image);
            Bitmap bitmap = new Bitmap(original);
            int[] val = new int[9];

            for (int i = 0; i < original.Width; ++i)
            {
                for (int j = 0; j < original.Height; ++j)
                {
                    for (int n = 0; n < 9; ++n)
                    {
                        try { val[n] = original.GetPixel(i - 1 + n % 3, j - 1 + n / 3).R; }
                        catch { val[n] = 0; }
                    }
                    Array.Sort(val);
                    if(val[4] == 0)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(val[6], val[6], val[6]));
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(val[4], val[4], val[4]));
                    }
                }
            }
            setPicture(bitmap);
        }

        private void btn_histogram_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox2.Image);

            int[] nums = new int[256];
            double total_size = bitmap.Width * bitmap.Height;
            double[] pdf = new double[256];

            for(int i = 0; i < bitmap.Width; ++i)
            {
                for(int j = 0; j < bitmap.Height; ++j)
                {
                    int val = bitmap.GetPixel(i, j).R;
                    chart1.Series[0].Points.AddXY( val, ++nums[val]);
                }
            }

            for(int i = 0, cumulation = 0; i < 256; ++i)
            {
                cumulation += nums[i];
                pdf[i] = Math.Round(255 * cumulation / total_size);
                chart2.Series[0].Points.AddXY(pdf[i], nums[i]);
            }

            for(int i = 0; i < bitmap.Width; ++i)
            {
                for(int j = 0; j < bitmap.Height; ++j)
                {
                    int val = Convert.ToInt32(pdf[bitmap.GetPixel(i, j).R]);
                    bitmap.SetPixel(i, j, Color.FromArgb(val, val, val));
                }
            }
            setPicture(bitmap);
        }

        private void btn_sobel_x_Click(object sender, EventArgs e)
        {
            double[,] filter = new double[3, 3] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            setPicture(Conv(pictureBox2.Image, filter));
        }

        private void btn_sobel_y_Click(object sender, EventArgs e)
        {
            double[,] filter = new double[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            setPicture(Conv(pictureBox2.Image, filter));
        }

        private void btn_edge_Click(object sender, EventArgs e)
        {
            double[,] filter_x = new double[3, 3] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            Bitmap result_x = Conv(grayscale(pictureBox2.Image), filter_x);

            double[,] filter_y = new double[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            Bitmap result_y = Conv(grayscale(pictureBox2.Image), filter_y);

            for(int i = 0; i < result_x.Width; ++i)
            {
                for (int j = 0; j < result_x.Height; ++j)
                {
                    int val = Convert.ToInt32(Math.Sqrt(Math.Pow(result_x.GetPixel(i, j).R, 2) + Math.Pow(result_y.GetPixel(i, j).R, 2)));
                    val = checkRange(val);
                    result_x.SetPixel(i, j, Color.FromArgb(val, val, val));
                }
            }
            setPicture(result_x);
        }

        private void btn_edge_overlap_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox2.Image);
            Bitmap original = new Bitmap(pictureBox1.Image);

            int threshold = trackBar_overlap.Value;

            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    int val = bitmap.GetPixel(i, j).R;
                    if (val >= threshold)
                    {
                        original.SetPixel(i, j, Color.FromArgb(0, 255, 0));
                    }
                }
            }
            setPicture(original);
        }

        private void fillColor(Bitmap bitmap, int width, int heigh, Color color)
        {
            try
            {
                if (bitmap.GetPixel(width, heigh).Equals(black))
                {
                    bitmap.SetPixel(width, heigh, color);
                    for (int i = -1; i < 2; ++i)
                    {
                        for (int j = -1; j < 2; ++j)
                        {
                            fillColor(bitmap, width + i, heigh + j, color);
                        }
                    }
                }
            }
            catch { }
        }

        private void btn_connect_comp_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            int count = 0;

            for(int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    if(color.Equals(black))
                    {
                        do
                        {
                            color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                        } while (color.Equals(white) || color.Equals(black));
                    
                        fillColor(bitmap, i, j, color);
                        ++count;
                    }
                }
            }
            label1.Text = "Num of Connected region : " + count;
            setPicture(bitmap);
        }

        private void btn_threshold_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox2.Image);
            int threshold = trackBar_threshold.Value;

            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    int val = bitmap.GetPixel(i, j).R;
                    if (val < threshold)
                    {
                        bitmap.SetPixel(i, j, black);
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, white);
                    }
                }
            }
            setPicture(bitmap);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            pictureBox1_pos.Clear();
            pictureBox2_pos.Clear();
            pictureBox1.Click += new EventHandler(pictureBox1_Click);
            pictureBox2.Click += new EventHandler(pictureBox2_Click);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.Location.X - pictureBox2.Width / 2;
            int y = me.Location.Y - pictureBox2.Height / 2;
            pictureBox2_pos.Add(new Point(x, y));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.Location.X - pictureBox1.Width / 2;
            int y = me.Location.Y - pictureBox1.Height / 2;
            pictureBox1_pos.Add(new Point(x, y));
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            pictureBox1.Click -= new EventHandler(pictureBox1_Click);
            pictureBox2.Click -= new EventHandler(pictureBox2_Click);

            label1.Text = "";

            double theta = 0, scale = 0;

            for(int i = 0; i < 4; ++i)
            {
                double[] tf = transform(pictureBox1_pos[i], pictureBox2_pos[i]);
                theta += tf[0];
                scale += tf[1];
            }

            theta = theta / 4 * 180 / Math.PI;
            scale /= 4;


            Bitmap original = (Bitmap)pictureBox2.Image;
            Bitmap bitmap = new Bitmap(original.Width, original.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.TranslateTransform(bitmap.Width / 2, bitmap.Height / 2);
            graphics.ScaleTransform((float)scale, (float)scale);
            graphics.RotateTransform((float)theta);
            graphics.TranslateTransform(-bitmap.Width / 2, -bitmap.Height / 2);
            graphics.DrawImage(original, new Point(0, 0));

            setPicture(bitmap);

            double intensity = 0;
            for(int i = 0; i < bitmap.Width; ++i)
            {
                for(int j = 0; j < bitmap.Height; ++j)
                {
                    intensity += Math.Abs(bitmap.GetPixel(i, j).R - original.GetPixel(i, j).R);
                }
            }
            intensity /= (bitmap.Width * bitmap.Height);

            label1.Text = "Angle: " + theta + "\nScale: " + scale + "\nintensity: " + intensity;
        }

        private double[] transform(Point p1, Point p2)
        {
            double len1 = Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2));
            double len2 = Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));

            double[] result = new double[2];

            //angle
            result[0] = Math.Acos((p1.X * p2.X + p1.Y * p2.Y) / (len1 * len2));
            //orientation
            if ((p1.X * p2.Y - p2.X * p1.Y) > 0.0)
            {
                result[0] *= -1;
            }

            result[1] = len1 / len2;
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                undo = new Bitmap(pictureBox2.Image);
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = undo;
        }
    }
}
