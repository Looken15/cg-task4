﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class clear_button : Form
    {
        Bitmap bitmap;
        Graphics g;

        Point prim_point;
        const int point_radius = 5;

        Edge prim_edge;
        int edge_c = 0;

        Polygon prim_polygon;
        bool first_point = true;
        const int locate_radius = 20;

        Point origin;

        double angle;

        double dx_shift;
        double dy_shift;

        double kx_scale;
        double ky_scale;

        Color point_color = Color.Blue;

        public clear_button()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
            prim_edge = new Edge();
            prim_polygon = new Polygon();
            origin = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g.FillEllipse(new SolidBrush(Color.Red), origin.X, origin.Y, 10, 10);
        }

        private void RedrawScene()
        {
            g.Clear(Color.White);
            DrawPoint(prim_point.X, prim_point.Y, point_radius);

            if (prim_edge != null && prim_edge.p1.X != -1)
            {
                DrawEdge();
            }

            if (!first_point || prim_polygon.done)
            {
                DrawPolygon();
            }

            g.FillEllipse(new SolidBrush(Color.Red), origin.X, origin.Y, 10, 10);

            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            if (!point_button.Enabled)
            {
                prim_point = me.Location;
                RedrawScene();
            }
            else if (!edge_button.Enabled)
            {
                if (edge_c == 0)
                {
                    prim_edge.p1 = me.Location;
                    edge_c++;
                    prim_edge.p2 = new Point(-1, -1);
                }
                else
                {
                    prim_edge.p2 = me.Location;
                    edge_c--;
                }

                if (prim_edge.p1.X != -1 && prim_edge.p2.X != -1)
                {
                    RedrawScene();
                }
            }
            else if (!polygon_button.Enabled)
            {
                if (prim_polygon.done)
                    prim_polygon = new Polygon();
                if (first_point)
                {
                    first_point = false;
                    prim_polygon.addPoint(me.Location);
                }
                else if (LocatePoint(me.Location))
                {
                    prim_polygon.addPoint(prim_polygon.start.ToPoint());
                    first_point = true;
                    RedrawScene();
                }
                else { prim_polygon.addPoint(me.Location); }

                RedrawScene();
            }
            else if (!origin_button.Enabled)
            {
                origin = me.Location;
                RedrawScene();
            }
            pictureBox1.Image = bitmap;
        }

        private void DrawPoint(int x, int y, int r)
        {
            g.FillEllipse(new SolidBrush(point_color), x - r, y - r, 2 * r, 2 * r);
            pictureBox1.Refresh();
        }

        private void DrawEdge()
        {
            DrawPoint(prim_edge.p1.X, prim_edge.p1.Y, point_radius);
            DrawPoint(prim_edge.p2.X, prim_edge.p2.Y, point_radius);
            g.DrawLine(new Pen(point_color, 3), prim_edge.p1, prim_edge.p2);
            pictureBox1.Refresh();
        }

        private void DrawPolygon()
        {
            PolygonPoint p = prim_polygon.start;
            if (prim_polygon.size == 1)
            {
                DrawPoint((int)p.x, (int)p.y, point_radius);
                return;
            }
            PolygonPoint p1 = new PolygonPoint();
            for (int i = 0; i < prim_polygon.size - 1; ++i)
            {
                DrawPoint((int)p.x, (int)p.y, point_radius);
                p1 = p.next;
                g.DrawLine(new Pen(point_color, 3), p.ToPoint(), p1.ToPoint());
                DrawPoint((int)p1.x, (int)p1.y, point_radius);
                p = p1;
            }
            if (prim_polygon.done)
                g.DrawLine(new Pen(point_color, 3), p.ToPoint(), prim_polygon.start.ToPoint());
            else
                g.DrawLine(new Pen(point_color, 3), p.ToPoint(), p1.ToPoint());
            pictureBox1.Refresh();
        }


        private bool LocatePoint(Point p)
        {
            return Math.Abs(p.X - prim_polygon.start.x) < locate_radius && Math.Abs(p.Y - prim_polygon.start.y) < locate_radius;
        }

        private void point_button_Click(object sender, EventArgs e)
        {
            point_button.Enabled = false;
            edge_button.Enabled = true;
            polygon_button.Enabled = true;
            origin_button.Enabled = true;
        }
        private void edge_button_Click(object sender, EventArgs e)
        {
            edge_button.Enabled = false;
            point_button.Enabled = true;
            polygon_button.Enabled = true;
            origin_button.Enabled = true;
        }

        private void polygon_button_Click(object sender, EventArgs e)
        {
            polygon_button.Enabled = false;
            edge_button.Enabled = true;
            point_button.Enabled = true;
            origin_button.Enabled = true;
        }

        private void clear_butt_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prim_point = new Point();
            prim_edge = new Edge();
            prim_polygon = new Polygon();

            g.FillEllipse(new SolidBrush(Color.Red), origin.X, origin.Y, 10, 10);

            origin.X = pictureBox1.Width / 2;
            origin.Y = pictureBox1.Height / 2;

            RedrawScene();

            pictureBox1.Refresh();

        }

        private void origin_button_Click(object sender, EventArgs e)
        {
            origin_button.Enabled = false;
            polygon_button.Enabled = true;
            edge_button.Enabled = true;
            point_button.Enabled = true;
        }

        private void afinne(string name)
        {
            Matrix m = new Matrix(3);

            if (name == "rotate")
            {
                var rad_angle = angle * Math.PI / 180;
                m[0, 0] = Math.Cos(rad_angle);
                m[0, 1] = Math.Sin(rad_angle);
                m[0, 2] = 0;
                m[1, 0] = -Math.Sin(rad_angle);
                m[1, 1] = Math.Cos(rad_angle);
                m[1, 2] = 0;
                m[2, 0] = 0;
                m[2, 1] = 0;
                m[2, 2] = 1;
            }
            else if (name == "shift")
            {
                m[0, 0] = 1;
                m[0, 1] = 0;
                m[0, 2] = 0;
                m[1, 0] = 0;
                m[1, 1] = 1;
                m[1, 2] = 0;
                m[2, 0] = -dx_shift;
                m[2, 1] = -dy_shift;
                m[2, 2] = 1;
            }
            else if (name == "scale")
            {
                m[0, 0] = 1 / kx_scale;
                m[0, 1] = 0;
                m[0, 2] = 0;
                m[1, 0] = 0;
                m[1, 1] = 1 / ky_scale;
                m[1, 2] = 0;
                m[2, 0] = 0;
                m[2, 1] = 0;
                m[2, 2] = 1;
            }

            if (prim_polygon.done)
            {
                var prim = prim_polygon.start;
                var new_prim_polygon = new Polygon();
                for (int i = 0; i < prim_polygon.size; ++i)
                {
                    Matrix p = new Matrix(1, 3);
                    p[0, 0] = prim.x - origin.X;
                    p[0, 1] = prim.y - origin.Y;
                    p[0, 2] = 1;

                    Matrix res = p * m;
                    new_prim_polygon.addPoint(new PointF((int)res[0, 0] + origin.X, (int)res[0, 1] + origin.Y));

                    prim = prim.next;
                }
                new_prim_polygon.done = true;


                prim_polygon = new_prim_polygon;
                RedrawScene();
            }
        }

        private void rotate_button_Click(object sender, EventArgs e)
        {
            afinne("rotate");
        }

        private void shift_button_Click(object sender, EventArgs e)
        {
            afinne("shift");
        }

        private void scale_button_Click(object sender, EventArgs e)
        {
            afinne("scale");
        }

        private void edge_rotate_button_Click(object sender, EventArgs e)
        {
            Matrix m = new Matrix(3);

            var rad_angle = 90 * Math.PI / 180;
            m[0, 0] = Math.Cos(rad_angle);
            m[0, 1] = Math.Sin(rad_angle);
            m[0, 2] = 0;
            m[1, 0] = -Math.Sin(rad_angle);
            m[1, 1] = Math.Cos(rad_angle);
            m[1, 2] = 0;
            m[2, 0] = 0;
            m[2, 1] = 0;
            m[2, 2] = 1;

            var xc = (prim_edge.p1.X + prim_edge.p2.X) / 2;
            var yc = (prim_edge.p1.Y + prim_edge.p2.Y) / 2;

            Matrix a = new Matrix(1, 3);
            a[0, 0] = prim_edge.p1.X - xc;
            a[0, 1] = prim_edge.p1.Y - yc;
            a[0, 2] = 1;

            Matrix b = new Matrix(1, 3);
            b[0, 0] = prim_edge.p2.X - xc;
            b[0, 1] = prim_edge.p2.Y - yc;
            b[0, 2] = 1;

            var res_a = a * m;
            var res_b = b * m;

            prim_edge = new Edge(new Point((int)res_a[0, 0] + xc, (int)res_a[0, 1] + yc), new Point((int)res_b[0, 0] + xc, (int)res_b[0, 1] + yc));

            RedrawScene();
        }

        private void rotate_textbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(rotate_text_box.Text, out angle);
        }

        private void dx_shift_textbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(dx_shift_textbox.Text, out dx_shift);
        }

        private void dy_shift_textbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(dy_shift_textbox.Text, out dy_shift);
        }

        private void kx_scale_textbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(kx_scale_textbox.Text, out kx_scale);
        }

        private void ky_scale_textbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(ky_scale_textbox.Text, out ky_scale);
        }


    }

    public class Edge
    {
        public Point p1;
        public Point p2;
        public Edge()
        {
            p1 = new Point(-1, -1);
            p2 = new Point(-1, -1);
        }
        public Edge(Point _p1, Point _p2)
        {
            p1 = _p1;
            p2 = _p2;
        }
    }

    public class PolygonPoint
    {
        public float x;
        public float y;
        public PolygonPoint prev;
        public PolygonPoint next;

        public PolygonPoint()
        {
            x = -1;
            y = -1;
            prev = null;
            next = null;
        }
        public PolygonPoint(PointF _p, PolygonPoint _prev, PolygonPoint _next)
        {
            x = _p.X;
            y = _p.Y;
            prev = _prev;
            next = _next;
        }
        public PolygonPoint(PointF _p)
        {
            x = _p.X;
            y = _p.Y;
            prev = null;
            next = null;
        }
        public PolygonPoint(float _x, float _y, PolygonPoint _prev, PolygonPoint _next)
        {
            x = _x;
            y = _y;
            prev = _prev;
            next = _next;
        }
        public Point ToPoint()
        {
            return new Point((int)x, (int)y);
        }
    }

    public class Polygon
    {
        public PolygonPoint start;
        public int size;
        public bool done;

        public Polygon()
        {
            start = null;
            size = 0;
            done = false;
        }

        public Polygon(PointF p)
        {
            start = new PolygonPoint(p);
            size = 1;
            done = false;
        }

        public PolygonPoint getlast()
        {
            if (done) return start;
            PolygonPoint pp = start;
            while (pp.next != null)
            {
                pp = pp.next;
            }
            return pp;
        }

        public void addPoint(PointF p)
        {
            if (done) return;
            PolygonPoint pp = start;
            if (pp == null)
            {
                start = new PolygonPoint(p);
                size = 1;
                return;
            }
            Point pPoint = pp.ToPoint();
            if (pPoint == p)
            {
                PolygonPoint last = getlast();
                last.next = start;
                start.prev = last;
                done = true;
                return;
            }
            while (pp.next != null)
            {
                pp = pp.next;
            }
            pp.next = new PolygonPoint(p);
            PolygonPoint ppp = pp.next;
            ppp.prev = pp;
            size++;
        }
    }
}
