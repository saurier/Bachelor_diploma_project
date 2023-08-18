using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WinFormsApp1 
{
    public partial class Form1 : Form
    {
        private Pen pen = new Pen(Color.Black);
        private Graphics g;
        public const int counter = 72;
        Point[] pointsRE0 = new Point[counter + 1];
        Point[] pointsIM0 = new Point[counter + 1];

        Point[] pointsRE1 = new Point[counter + 1];
        Point[] pointsIM1 = new Point[counter + 1];

        Point[] pointsREPL1 = new Point[counter + 1];
        Point[] pointsIMPL1 = new Point[counter + 1];

        Point[,] pointsPL = new Point [counter + 20, counter + 20];
        public Form1()
        {
            InitializeComponent();
            pointsIM0[0] = new Point(1, 1);

            pointsRE0[0] = new Point(18, 205);
            pointsRE0[1] = new Point(22, 190);
            pointsRE0[2] = new Point(29, 179);
            pointsRE0[3] = new Point(38, 169);

            pointsRE0[4] = new Point(38, 169);
            pointsRE0[5] = new Point(106, 154);
            pointsRE0[6] = new Point(195, 154);
            pointsRE0[7] = new Point(232, 149);

            pointsRE0[8] = new Point(232, 149);
            pointsRE0[9] = new Point(242, 111);
            pointsRE0[10] = new Point(288, 117);
            pointsRE0[11] = new Point(284, 149);

            pointsRE0[12] = new Point(284, 149);
            pointsRE0[13] = new Point(292, 154);
            pointsRE0[14] = new Point(303, 157);
            pointsRE0[15] = new Point(313, 154);

            pointsRE0[16] = new Point(313, 154);
            pointsRE0[17] = new Point(350, 98);
            pointsRE0[18] = new Point(431, 13);
            pointsRE0[19] = new Point(488, 1);

            pointsRE0[20] = new Point(488, 1);
            pointsRE0[21] = new Point(540, 6);
            pointsRE0[22] = new Point(552, 25);
            pointsRE0[23] = new Point(567, 32);

            pointsRE0[24] = new Point(567, 32);
            pointsRE0[25] = new Point(587, 51);
            pointsRE0[26] = new Point(514, 140);
            pointsRE0[27] = new Point(470, 191);

            pointsRE0[28] = new Point(470, 191);
            pointsRE0[29] = new Point(481, 206);
            pointsRE0[30] = new Point(504, 217);
            pointsRE0[31] = new Point(510, 222);

            pointsRE0[32] = new Point(510, 222);
            pointsRE0[33] = new Point(553, 198);
            pointsRE0[34] = new Point(547, 235);
            pointsRE0[35] = new Point(548, 252);

            pointsRE0[36] = new Point(548, 252);
            pointsRE0[37] = new Point(562, 264);
            pointsRE0[38] = new Point(576, 274);
            pointsRE0[39] = new Point(593, 285);

            pointsRE0[40] = new Point(593, 285);
            pointsRE0[41] = new Point(593, 297);
            pointsRE0[42] = new Point(585, 308);
            pointsRE0[43] = new Point(567, 315);

            pointsRE0[44] = new Point(567, 315);
            pointsRE0[45] = new Point(540, 299);
            pointsRE0[46] = new Point(471, 282);
            pointsRE0[47] = new Point(407, 268);

            pointsRE0[48] = new Point(407, 268);
            pointsRE0[49] = new Point(393, 282);
            pointsRE0[50] = new Point(372, 307);
            pointsRE0[51] = new Point(338, 294);

            pointsRE0[52] = new Point(338, 294);
            pointsRE0[53] = new Point(301, 336);
            pointsRE0[54] = new Point(254, 326);
            pointsRE0[55] = new Point(204, 318);

            pointsRE0[56] = new Point(204, 318);
            pointsRE0[57] = new Point(211, 306);
            pointsRE0[58] = new Point(145, 288);
            pointsRE0[59] = new Point(123, 286);

            pointsRE0[60] = new Point(123, 286);
            pointsRE0[61] = new Point(108, 272);
            pointsRE0[62] = new Point(158, 255);
            pointsRE0[63] = new Point(178, 262);

            pointsRE0[64] = new Point(178, 262);
            pointsRE0[65] = new Point(179, 245);
            pointsRE0[66] = new Point(166, 230);
            pointsRE0[67] = new Point(153, 212);

            pointsRE0[68] = new Point(153, 212);
            pointsRE0[69] = new Point(127, 210);
            pointsRE0[70] = new Point(62, 196);
            pointsRE0[71] = new Point(18, 205);
            //--------------------------------------------
            pointsIM1[0] = new Point(1, 1);

            pointsRE1[0] = new Point(18, 205);
            pointsRE1[1] = new Point(22, 190);
            pointsRE1[2] = new Point(29, 179);
            pointsRE1[3] = new Point(38, 169);

            pointsRE1[4] = new Point(38, 169);
            pointsRE1[5] = new Point(106, 154);
            pointsRE1[6] = new Point(195, 154);
            pointsRE1[7] = new Point(232, 149);

            pointsRE1[8] = new Point(232, 149);
            pointsRE1[9] = new Point(242, 111);
            pointsRE1[10] = new Point(288, 117);
            pointsRE1[11] = new Point(284, 149);

            pointsRE1[12] = new Point(284, 149);
            pointsRE1[13] = new Point(292, 154);
            pointsRE1[14] = new Point(303, 157);
            pointsRE1[15] = new Point(313, 154);

            pointsRE1[16] = new Point(313, 154);
            pointsRE1[17] = new Point(350, 98);
            pointsRE1[18] = new Point(431, 13);
            pointsRE1[19] = new Point(488, 1);

            pointsRE1[20] = new Point(488, 1);
            pointsRE1[21] = new Point(540, 6);
            pointsRE1[22] = new Point(552, 25);
            pointsRE1[23] = new Point(567, 32);

            pointsRE1[24] = new Point(567, 32);
            pointsRE1[25] = new Point(587, 51);
            pointsRE1[26] = new Point(514, 140);
            pointsRE1[27] = new Point(470, 191);

            pointsRE1[28] = new Point(470, 191);
            pointsRE1[29] = new Point(481, 206);
            pointsRE1[30] = new Point(504, 217);
            pointsRE1[31] = new Point(510, 222);

            pointsRE1[32] = new Point(510, 222);
            pointsRE1[33] = new Point(553, 198);
            pointsRE1[34] = new Point(547, 235);
            pointsRE1[35] = new Point(548, 252);

            pointsRE1[36] = new Point(548, 252);
            pointsRE1[37] = new Point(562, 264);
            pointsRE1[38] = new Point(576, 274);
            pointsRE1[39] = new Point(593, 285);

            pointsRE1[40] = new Point(593, 285);
            pointsRE1[41] = new Point(593, 297);
            pointsRE1[42] = new Point(585, 308);
            pointsRE1[43] = new Point(567, 315);

            pointsRE1[44] = new Point(567, 315);
            pointsRE1[45] = new Point(540, 299);
            pointsRE1[46] = new Point(471, 282);
            pointsRE1[47] = new Point(407, 268);

            pointsRE1[48] = new Point(407, 268);
            pointsRE1[49] = new Point(393, 282);
            pointsRE1[50] = new Point(372, 307);
            pointsRE1[51] = new Point(338, 294);

            pointsRE1[52] = new Point(338, 294);
            pointsRE1[53] = new Point(301, 336);
            pointsRE1[54] = new Point(254, 326);
            pointsRE1[55] = new Point(204, 318);

            pointsRE1[56] = new Point(204, 318);
            pointsRE1[57] = new Point(211, 306);
            pointsRE1[58] = new Point(145, 288);
            pointsRE1[59] = new Point(123, 286);

            pointsRE1[60] = new Point(123, 286);
            pointsRE1[61] = new Point(108, 272);
            pointsRE1[62] = new Point(158, 255);
            pointsRE1[63] = new Point(178, 262);

            pointsRE1[64] = new Point(178, 262);
            pointsRE1[65] = new Point(179, 245);
            pointsRE1[66] = new Point(166, 230);
            pointsRE1[67] = new Point(153, 212);

            pointsRE1[68] = new Point(153, 212);
            pointsRE1[69] = new Point(127, 210);
            pointsRE1[70] = new Point(62, 196);
            pointsRE1[71] = new Point(18, 205);
            //---------------------------------
            pointsREPL1[0] = new Point(Convert.ToInt32(textBox33.Text), Convert.ToInt32(textBox37.Text));
            pointsREPL1[1] = new Point(Convert.ToInt32(textBox34.Text), Convert.ToInt32(textBox38.Text));
            pointsREPL1[2] = new Point(Convert.ToInt32(textBox35.Text), Convert.ToInt32(textBox39.Text));
            pointsREPL1[3] = new Point(Convert.ToInt32(textBox36.Text), Convert.ToInt32(textBox40.Text));

            pointsIMPL1[0] = new Point(Convert.ToInt32(textBox41.Text), Convert.ToInt32(textBox45.Text));
            //---------------------------------
            pointsPL[0,0] = new Point(0, 0);
        }
        private void Calculate(int start, int end, int choose)
        {
            switch (choose)
            {
                case 1:
                    findIMforZero(start, end);
                    break;
                case 2:
                    findIMfor1(start, end);
                    break;
                case 3:
                    findIMforPL1(start, end);
                    break;
            }
        }
        private void findIMforZero(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                int Xim = findXIMforZero(pointsRE0[i].X, pointsRE0[i].Y, pointsIM0[i].X, pointsIM0[i].Y, pointsRE0[i + 1].X, pointsRE0[i + 1].Y);
                int Yim = findYIforZero(pointsRE0[i].X, pointsRE0[i].Y, pointsIM0[i].X, pointsIM0[i].Y, pointsRE0[i + 1].X, pointsRE0[i + 1].Y);
                pointsIM0[i + 1] = new Point(Xim, Yim);
            }
        }
        public static int findXIMforZero(int XAre, int YAre, int XAim, int YAim, int XBre, int YBre)
        {
            int XBim = -YBre + XAim + YAre;
            return XBim;
        }
        public static int findYIforZero(int XAre, int YAre, int XAim, int YAim, int XBre, int YBre)
        {
            int YBim = XBre - XAre + YAim;
            return YBim;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < counter; i++)
            {
                Calculate(i, i + 4, 1);
                i += 3;
            }
            
            e.Graphics.TranslateTransform(pictureBox1.Width / 2, 1);
            e.Graphics.ScaleTransform(1, 1);

            Pen blackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 1);

            e.Graphics.DrawLine(blackPen, new Point(0, -200), new Point(0, 200));//y
            e.Graphics.DrawLine(blackPen, new Point(-200, 0), new Point(200, 0));//x

            for (int i = 0; i < counter; i++)
            {
                e.Graphics.DrawBezier(bluePen, pointsIM0[i], pointsIM0[i + 1], pointsIM0[i + 2], pointsIM0[i + 3]);
                i += 3;
            }
            for (int i = 0; i < counter; i++)
            {
                e.Graphics.DrawBezier(blackPen, pointsRE0[i], pointsRE0[i + 1], pointsRE0[i + 2], pointsRE0[i + 3]);
                i += 3;
            }
        }
        private void findIMfor1(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                int Xim = findXIMfor1(pointsRE1[i].X, pointsRE1[i].Y, pointsIM1[i].X, pointsIM1[i].Y, pointsRE1[i + 1].X, pointsRE1[i + 1].Y);
                int Yim = findYIfor1(pointsRE1[i].X, pointsRE1[i].Y, pointsIM1[i].X, pointsIM1[i].Y, pointsRE1[i + 1].X, pointsRE1[i + 1].Y);
                pointsIM1[i + 1] = new Point(Xim, Yim);
            }
        }
        public static int findXIMfor1(int XAre, int YAre, int XAim, int YAim, int XBre, int YBre)
        {
            int XBim = -YBre + XAim + YAre - 1;
            return XBim;
        }
        public static int findYIfor1(int XAre, int YAre, int XAim, int YAim, int XBre, int YBre)
        {
            int YBim = XBre - XAre + YAim - 1;
            return YBim;
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < counter; i++)
            {
                Calculate(i, i + 4, 2);
                i += 3;
            }

            e.Graphics.TranslateTransform(pictureBox2.Width / 2, 1);
            e.Graphics.ScaleTransform(1, 1);

            Pen blackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 1);

            e.Graphics.DrawLine(blackPen, new Point(0, -200), new Point(0, 200));//y
            e.Graphics.DrawLine(blackPen, new Point(-200, 0), new Point(200, 0));//x

            for (int i = 0; i < counter; i++)
            {
                e.Graphics.DrawBezier(bluePen, pointsIM1[i], pointsIM1[i + 1], pointsIM1[i + 2], pointsIM1[i + 3]);
                i += 3;
            }
            for (int i = 0; i < counter; i++)
            {
                e.Graphics.DrawBezier(blackPen, pointsRE1[i], pointsRE1[i + 1], pointsRE1[i + 2], pointsRE1[i + 3]);
                i += 3;
            }
        }
        private void findIMforPL1(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                int Xim = findXIMforPL1(pointsREPL1[i].X, pointsREPL1[i].Y, pointsIMPL1[i].X, pointsIMPL1[i].Y, pointsREPL1[i + 1].X, pointsREPL1[i + 1].Y);
                int Yim = findYIforPL1(pointsREPL1[i].X, pointsREPL1[i].Y, pointsIMPL1[i].X, pointsIMPL1[i].Y, pointsREPL1[i + 1].X, pointsREPL1[i + 1].Y);
                pointsIMPL1[i + 1] = new Point(Xim, Yim);
            }
        }
        public static int findXIMforPL1(int XAre, int YAre, int XAim, int YAim, int XBre, int YBre)
        {
            int XBim = Convert.ToInt32(-YBre + XAim + YAre);
            return XBim;
        }
        public static int findYIforPL1(int XAre, int YAre, int XAim, int YAim, int XBre, int YBre)
        {
            int YBim = Convert.ToInt32(XBre - XAre + YAim);
            return YBim;
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            letstry(pointsREPL1[0].X, pointsREPL1[1].X, pointsREPL1[2].X, pointsREPL1[3].X, pointsREPL1[0].Y, pointsREPL1[1].Y, pointsREPL1[2].Y, pointsREPL1[3].Y, pointsIMPL1[0].X, pointsIMPL1[0].Y);
            
            Pen blackPen = new Pen(Color.Black, 1);
            Pen bluePen = new Pen(Color.Blue, 2);
            Pen grayPen = new Pen(Color.Gray, 1);

            e.Graphics.TranslateTransform(pictureBox3.Width / 2, pictureBox3.Height/2);
            e.Graphics.ScaleTransform(2, -2);
            e.Graphics.DrawLine(grayPen, new Point(0, -200), new Point(0, 200));
            e.Graphics.DrawLine(grayPen, new Point(-200, 0), new Point(200, 0));
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter + 1; j++)
                {
                    e.Graphics.DrawBezier(blackPen, pointsPL[i, j], pointsPL[i + 1, j], pointsPL[i + 2, j], pointsPL[i + 3, j]);
                    j++; 
                }
                i++; i++; i++;
            }
            e.Graphics.DrawBezier(bluePen, pointsREPL1[0], pointsREPL1[1], pointsREPL1[2], pointsREPL1[3]);
            e.Graphics.DrawLine(bluePen, pointsREPL1[0], pointsREPL1[1]);
            e.Graphics.DrawLine(bluePen, pointsREPL1[1], pointsREPL1[2]);
            e.Graphics.DrawLine(bluePen, pointsREPL1[2], pointsREPL1[3]);
        }
        float Map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }
        private void letstry(float r00xre, float r10xre, float r20xre, float r30xre, float r00yre, float r10yre, float r20yre, float r30yre, float r00xim, float r00yim)
        {
            float r10xim = -r10yre + r00xim + r00yre;
            float r10yim = r10xre - r00xre + r00yim;
            float r20xim = -r20yre + r10xim + r10yre;
            float r20yim = r20xre - r10xre + r10yim;
            float r30xim = -r30yre + r20xim + r20yre;
            float r30yim = r30xre - r20xre + r20yim;
            Complex r00x = new Complex(r00xre, r00xim);
            Complex r10x = new Complex(r10xre, r10xim);
            Complex r20x = new Complex(r20xre, r20xim);
            Complex r30x = new Complex(r30xre, r30xim);
            Complex r00y = new Complex(r00yre, r00yim);
            Complex r10y = new Complex(r10yre, r10yim);
            Complex r20y = new Complex(r20yre, r20yim);
            Complex r30y = new Complex(r30yre, r30yim);

            float k = (float)Convert.ToDouble(textBox49.Text);
            float h = (float)Convert.ToDouble(textBox50.Text);
            for (int i = 0; i < counter; i++)
            {
                float v = Map(i, 0, counter, 0, 1);
                for (int j = 0; j < counter; j++)
                {
                    float u = Map(j, 0, counter, 0, 1);
                    Complex t = new Complex(k*u, h*v);
                    Complex rx = r00x * (1 - t) * (1 - t) * (1 - t) + 3 * r10x * t * (1 - t) * (1 - t) + 3 * r20x * (1 - t) * t * t + r30x * t * t * t;
                    Complex ry = r00y * (1 - t) * (1 - t) * (1 - t) + 3 * r10y * t * (1 - t) * (1 - t) + 3 * r20y * (1 - t) * t * t + r30y * t * t * t;
                    int rxRE = Convert.ToInt32(rx.Real);
                    int ryRE = Convert.ToInt32(ry.Real);
                    pointsPL[i,j] = new Point (rxRE, ryRE);
                }
            }
            textBox41.Text = Convert.ToString(r00yim);
            textBox42.Text = Convert.ToString(r10xim);
            textBox43.Text = Convert.ToString(r20xim);
            textBox44.Text = Convert.ToString(r30xim);
            textBox45.Text = Convert.ToString(r00yim);
            textBox46.Text = Convert.ToString(r10yim);
            textBox47.Text = Convert.ToString(r20yim);
            textBox48.Text = Convert.ToString(r30yim);
        }
        private void bttn_Click(object sender, EventArgs e)
        {
            pointsREPL1[0] = new Point(Convert.ToInt32(textBox33.Text), Convert.ToInt32(textBox37.Text));
            pointsREPL1[1] = new Point(Convert.ToInt32(textBox34.Text), Convert.ToInt32(textBox38.Text));
            pointsREPL1[2] = new Point(Convert.ToInt32(textBox35.Text), Convert.ToInt32(textBox39.Text));
            pointsREPL1[3] = new Point(Convert.ToInt32(textBox36.Text), Convert.ToInt32(textBox40.Text));
            pictureBox3.Refresh();
        }
    }
}