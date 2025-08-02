using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Brush B = new SolidBrush(Color.White);
        Pen P = new Pen(Color.White);
        string type,color;
        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grx = CreateGraphics();
            if (e.Button == MouseButtons.Left && type == "Fill Circle 10")
            {
                grx.FillEllipse(B, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 15")
            {
                grx.FillEllipse(B, e.X - 8, e.Y - 8, 15, 15);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 20")
            {
                grx.FillEllipse(B, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 25")
            {
                grx.FillEllipse(B, e.X - 13, e.Y - 13, 25, 25);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 30")
            {
                grx.FillEllipse(B, e.X - 15, e.Y - 15, 30, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 35")
            {
                grx.FillEllipse(B, e.X - 18, e.Y - 18, 35, 35);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 40")
            {
                grx.FillEllipse(B, e.X - 20, e.Y - 20, 40, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 45")
            {
                grx.FillEllipse(B, e.X - 23, e.Y - 23, 45, 45);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Circle 50")
            {
                grx.FillEllipse(B, e.X - 25, e.Y - 25, 50, 50);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 10")
            {
                grx.DrawEllipse(P, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 15")
            {
                grx.DrawEllipse(P, e.X - 8, e.Y - 8, 15, 15);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 20")
            {
                grx.DrawEllipse(P, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 25")
            {
                grx.DrawEllipse(P, e.X - 13, e.Y - 13, 25, 25);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 30")
            {
                grx.DrawEllipse(P, e.X - 15, e.Y - 15, 30, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 35")
            {
                grx.DrawEllipse(P, e.X - 18, e.Y - 18, 35, 35);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 40")
            {
                grx.DrawEllipse(P, e.X - 20, e.Y - 20, 40, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 45")
            {
                grx.DrawEllipse(P, e.X - 23, e.Y - 23, 45, 45);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Circle 50")
            {
                grx.DrawEllipse(P, e.X - 25, e.Y - 25, 50, 50);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 20 x 10")
            {
                grx.FillRectangle(B, e.X - 10, e.Y - 5, 20, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 30 x 15")
            {
                grx.FillRectangle(B, e.X - 15, e.Y - 8, 30, 15);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 40 x 20")
            {
                grx.FillRectangle(B, e.X - 20, e.Y - 10, 40, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 50 x 25")
            {
                grx.FillRectangle(B, e.X - 25, e.Y - 13, 50, 25);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 60 x 30")
            {
                grx.FillRectangle(B, e.X - 30, e.Y - 15, 60, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 70 x 35")
            {
                grx.FillRectangle(B, e.X - 35, e.Y - 18, 70, 35);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 80 x 40")
            {
                grx.FillRectangle(B, e.X - 40, e.Y - 20, 80, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 90 x 45")
            {
                grx.FillRectangle(B, e.X - 45, e.Y - 23, 90, 45);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Rectangle 100 x 50")
            {
                grx.FillRectangle(B, e.X - 50, e.Y - 25, 100, 50);
            }else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 20 x 10")
            {
                grx.DrawRectangle(P, e.X - 10, e.Y - 5, 20, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 30 x 15")
            {
                grx.DrawRectangle(P, e.X - 15, e.Y - 8, 30, 15);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 40 x 20")
            {
                grx.DrawRectangle(P, e.X - 20, e.Y - 10, 40, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 50 x 25")
            {
                grx.DrawRectangle(P, e.X - 25, e.Y - 13, 50, 25);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 60 x 30")
            {
                grx.DrawRectangle(P, e.X - 30, e.Y - 15, 60, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 70 x 35")
            {
                grx.DrawRectangle(P, e.X - 35, e.Y - 18, 70, 35);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 80 x 40")
            {
                grx.DrawRectangle(P, e.X - 40, e.Y - 20, 80, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 90 x 45")
            {
                grx.DrawRectangle(P, e.X - 45, e.Y - 23, 90, 45);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Rectangle 100 x 50")
            {
                grx.DrawRectangle(P, e.X - 50, e.Y - 25, 100, 50);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 10 x 10")
            {
                grx.FillRectangle(B, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 20 x 20")
            {
                grx.FillRectangle(B, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 30 x 30")
            {
                grx.FillRectangle(B, e.X - 15, e.Y - 15, 30, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 40 x 40")
            {
                grx.FillRectangle(B, e.X - 20, e.Y - 20, 40, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 50 x 50")
            {
                grx.FillRectangle(B, e.X - 25, e.Y - 25, 50, 50);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 60 x 60")
            {
                grx.FillRectangle(B, e.X - 30, e.Y - 30, 60, 60);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 70 x 70")
            {
                grx.FillRectangle(B, e.X - 35, e.Y - 35, 70, 70);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 80 x 80")
            {
                grx.FillRectangle(B, e.X - 40, e.Y - 40, 80, 80);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 90 x 90")
            {
                grx.FillRectangle(B, e.X - 45, e.Y - 45, 90, 90);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Square 100 x 100")
            {
                grx.FillRectangle(B, e.X - 50, e.Y - 50, 100, 100);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 10 x 10")
            {
                grx.DrawRectangle(P, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 20 x 20")
            {
                grx.DrawRectangle(P, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 30 x 30")
            {
                grx.DrawRectangle(P, e.X - 15, e.Y - 15, 30, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 40 x 40")
            {
                grx.DrawRectangle(P, e.X - 20, e.Y - 20, 40, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 50 x 50")
            {
                grx.DrawRectangle(P, e.X - 25, e.Y - 25, 50, 50);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 60 x 60")
            {
                grx.DrawRectangle(P, e.X - 30, e.Y - 30, 60, 60);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 70 x 70")
            {
                grx.DrawRectangle(P, e.X - 35, e.Y - 35, 70, 70);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 80 x 80")
            {
                grx.DrawRectangle(P, e.X - 40, e.Y - 40, 80, 80);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 90 x 90")
            {
                grx.DrawRectangle(P, e.X - 45, e.Y - 45, 90, 90);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Square 100 x 100")
            {
                grx.DrawRectangle(P, e.X - 50, e.Y - 50, 100, 100);
            }
            else if (e.Button == MouseButtons.Left && type == "Line 5")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 5, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 10")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 10, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 15")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 15, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 20")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 20, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 25")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 25, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 30")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 30, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 35")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 35, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 40")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 40, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 45")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 45, e.Y);
            }else if (e.Button == MouseButtons.Left && type == "Line 50")
            {
                grx.DrawLine(P, e.X, e.Y, e.X + 50, e.Y);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Triangle")
            {
                Point point1 = new Point(e.X-10, e.Y-50);
                Point point2 = new Point(e.X-10,e.Y-25);
                Point point3 = new Point(e.X-10,e.Y-5);
                Point point4 = new Point(e.X-50,e.Y-5);
                Point point5 = new Point(e.X-50,e.Y-10);
                Point[] curvePoints =
                {
                     point1,
                     point2,
                     point3,
                     point4,
                     point5
                };
                grx.FillPolygon(B,curvePoints);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Triangle")
            {
                Point point1 = new Point(e.X-10, e.Y-50);
                Point point2 = new Point(e.X-10,e.Y-25);
                Point point3 = new Point(e.X-10,e.Y-5);
                Point point4 = new Point(e.X-50,e.Y-5);
                Point point5 = new Point(e.X-50,e.Y-10);
                Point[] curvePoints =
                {
                     point1,
                     point2,
                     point3,
                     point4,
                     point5
                };
                grx.DrawPolygon(P,curvePoints);
            }
            else if (e.Button == MouseButtons.Left && type == "Fill Polygon")
            {
                Point point1 = new Point(e.X-20, e.Y-20);
                Point point2 = new Point(e.X-30,e.Y-25);
                Point point3 = new Point(e.X-40,e.Y-15);
                Point point4 = new Point(e.X-50,e.Y-10);
                Point point5 = new Point(e.X-10,e.Y-5);
                Point[] curvePoints =
                {
                     point1,
                     point2,
                     point3,
                     point4,
                     point5
                };
                grx.FillPolygon(B,curvePoints);
            }
            else if (e.Button == MouseButtons.Left && type == "Draw Polygon")
            {
                Point point1 = new Point(e.X-20, e.Y-20);
                Point point2 = new Point(e.X-30,e.Y-25);
                Point point3 = new Point(e.X-40,e.Y-15);
                Point point4 = new Point(e.X-50,e.Y-10);
                Point point5 = new Point(e.X-10,e.Y-5);
                Point[] curvePoints =
                {
                     point1,
                     point2,
                     point3,
                     point4,
                     point5
                };
                grx.DrawPolygon(P,curvePoints);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Red,2);
            B = new SolidBrush(Color.Red);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Blue,2);
            B = new SolidBrush(Color.Blue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Green, 2);
            B = new SolidBrush(Color.Green);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.White, 2);
            B = new SolidBrush(Color.White);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Black, 2);
            B = new SolidBrush(Color.Black);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Cyan, 2);
            B = new SolidBrush(Color.Cyan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Yellow, 2);
            B = new SolidBrush(Color.Yellow);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Fuchsia, 2);
            B = new SolidBrush(Color.Fuchsia);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Purple, 2);
            B = new SolidBrush(Color.Purple);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            P = new Pen(Color.Orange, 2);
            B = new SolidBrush(Color.Orange);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grx2 = CreateGraphics();
            if (e.Button == MouseButtons.Left && type == "Eraser 5 x 5")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 3, e.Y - 3, 5, 5);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 10 x 10")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 15 x 15")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 8, e.Y - 8, 15, 15);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 20 x 20")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 25 x 25")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 13, e.Y - 13, 25, 25);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 30 x 30")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 15, e.Y - 15, 30, 30);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 35 x 35")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 18, e.Y - 18, 35, 35);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 40 x 40")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 20, e.Y - 20, 40, 40);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 50 x 50")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 25, e.Y - 25, 50, 50);
            }
            else if (e.Button == MouseButtons.Left && type == "Eraser 100 x 100")
            {
                B = new SolidBrush(Color.FromName(color));
                grx2.FillRectangle(B, e.X - 50, e.Y - 50, 100, 100);
            }
            else if (e.Button == MouseButtons.Left && type == "Pencil 5")
            {
                grx2.FillEllipse(B, e.X-3, e.Y-3, 5, 5);
            }
            else if (e.Button == MouseButtons.Left && type == "Pencil 10")
            {
                grx2.FillEllipse(B, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Left && type == "Pencil 15")
            {
                grx2.FillEllipse(B, e.X - 8, e.Y - 8, 15, 15);
            }
            else if (e.Button == MouseButtons.Left && type == "Pencil 20")
            {
                grx2.FillEllipse(B, e.X - 10, e.Y - 10, 20, 20);
            }
            else if (e.Button == MouseButtons.Left && type == "Pencil 25")
            {
                grx2.FillEllipse(B, e.X - 13, e.Y - 13, 25, 25);
            }




        }


        private void fillToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Fill Triangle";
        }

        private void drawToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Draw Triangle";
        }

        private void fillToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Fill Polygon";
        }

        private void drawToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Draw Polygon";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Pencil 5";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Pencil 10";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Pencil 15";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            type = "Pencil 20";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            type = "Pencil 25";
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 10";
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 15";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 20";
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 25";
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 30";
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 35";
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 40";
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 45";
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            type = "Draw Circle 50";
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 10";
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 15";
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 20";
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 25";
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 30";
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 35";
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 40";
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 45";
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            type = "Fill Circle 50";
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 20 x 10";
        }

        private void x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 30 x 15";
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 40 x 20";
        }

        private void x25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 50 x 25";
        }

        private void x30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 60 x 30";
        }

        private void x35ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 70 x 35";
        }

        private void x40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 80 x 40";
        }

        private void x45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 90 x 45";
        }

        private void x50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Rectangle 100 x 50";
        }

        private void x10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 20 x 10";
        }

        private void x15ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 30 x 15";
        }

        private void x20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 40 x 20";
        }

        private void x25ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 50 x 25";
        }

        private void x30ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 60 x 30";
        }

        private void x35ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 70 x 35";
        }

        private void x40ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 80 x 40";
        }

        private void x45ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 90 x 45";
        }

        private void x50ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Rectangle 100 x 50";
        }

        private void x10ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Fill Square 10 x 10";
        }

        private void x20ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Fill Square 20 x 20";
        }

        private void x30ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Fill Square 30 x 30";
        }

        private void x40ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Fill Square 40 x 40";
        }

        private void x50ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Fill Square 50 x 50";
        }

        private void x60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Square 60 x 60";
        }

        private void x70ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Square 70 x 70";
        }

        private void x80ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Square 80 x 80";
        }

        private void x90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Square 90 x 90";
        }

        private void x100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Fill Square 100 x 100";
        }

        private void x10ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Draw Square 10 x 10";
        }

        private void x20ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Draw Square 20 x 20";
        }

        private void x30ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Draw Square 30 x 30";
        }

        private void x40ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Draw Square 40 x 40";
        }

        private void x50ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Draw Square 50 x 50";
        }

        private void x60ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Square 60 x 60";
        }

        private void x70ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Square 70 x 70";
        }

        private void x80ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Square 80 x 80";
        }

        private void x90ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Square 90 x 90";
        }

        private void x100ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Draw Square 100 x 100";
        }

        private void cmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Line 5";
        }

        private void cmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            type = "Line 10";
        }

        private void cmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Line 15";
        }

        private void cmToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            type = "Line 20";
        }

        private void cmToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Line 25";
        }

        private void cmToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            type = "Line 30";
        }

        private void cmToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            type = "Line 35";
        }

        private void cmToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            type = "Line 40";
        }

        private void cmToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            type = "Line 45";
        }

        private void cmToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            type = "Line 50";
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            type = "Eraser 5 x 5";
        }

        private void x10ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Eraser 10 x 10";
        }

        private void x15ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Eraser 15 x 15";
        }

        private void x20ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Eraser 20 x 20";
        }

        private void x25ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Eraser 25 x 25";
        }

        private void x35ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Eraser 35 x 35";
        }

        private void x30ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Eraser 30 x 30";
        }

        private void x40ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Eraser 40 x 40";
        }

        private void x50ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            type = "Eraser 50 x 50";
        }

        private void x100ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            type = "Eraser 100 x 100";
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Blue";
            this.BackColor = Color.Blue;
            this.Invalidate();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Green";
            this.BackColor = Color.Green;
            this.Invalidate();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "White";
            this.BackColor = Color.White;
            this.Invalidate();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Black";
            this.BackColor = Color.Black;
            this.Invalidate();
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Cyan";
            this.BackColor = Color.Cyan;
            this.Invalidate();
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Yellow";
            this.BackColor = Color.Yellow;
            this.Invalidate();
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Purple";
            this.BackColor = Color.Purple;
            this.Invalidate();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Orange";
            this.BackColor = Color.Orange;
            this.Invalidate();
        }

        private void fuchsiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Fuchsia";
            this.BackColor = Color.Fuchsia;
            this.Invalidate();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = "Red";
            this.BackColor = Color.Red;
            this.Invalidate();
        }
    }
}
