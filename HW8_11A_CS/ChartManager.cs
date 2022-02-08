using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomework
{
    public class ChartManager
    {
        #region Members

        private ggPictureBox ggPictBox;
        private ggPictureBox ggPictBox2;
        private ggPictureBox ggPictBox3;
        private Bitmap bmp;
        private Rectangle viewPort;
        private Rectangle viewPort2;
        private Rectangle viewPort3;
        private Graphics G;

        private int nbPoints;         // number of points for each path
        private int tPoint;           // point in time

        private Random R = new Random();
        private Distribution D;

        private Pen blackPen = new Pen(Color.Black);
        private Pen whitePen = new Pen(Color.White);

        #endregion

        #region Constructor

        public ChartManager(Distribution rn, ggPictureBox pictureBox, int T)
        {
            if (T == -1)
            {
                ggPictBox2 = pictureBox;
                bmp = new Bitmap(ggPictBox2.Width, ggPictBox2.Height);
            }
            else if (T == -2)
            {
                ggPictBox3 = pictureBox;
                bmp = new Bitmap(ggPictBox3.Width, ggPictBox3.Height);
            }
            else
            {
                ggPictBox = pictureBox;
                bmp = new Bitmap(ggPictBox.Width, ggPictBox.Height);
            }

            G = Graphics.FromImage(bmp);
            D = rn;

            nbPoints = D.Paths[0].Points.Count;
            tPoint = T;
        }

        #endregion

        #region Public

        public void DrawChart(int nbClusters = 0)
        {
            viewPort = new Rectangle(0, 0, ggPictBox.Width * 3 / 4 - 1, ggPictBox.Height - 1);
            G.FillRectangle(Brushes.Black, viewPort);

            double minX = 0;
            double maxX = nbPoints;
            double minY = 0;
            double maxY = 0;

            foreach (var path in D.Paths)
            {
                var ymax = path.Points.Max(m => m.Y);
                if (ymax > maxY) maxY = ymax;
            }

            double rangeX = maxX - minX;
            double rangeY = maxY - minY;

            DrawPaths(minX, minY, rangeX, rangeY);

            int noCluster = nbClusters == 0 ? 10 : nbClusters;
            DrawHistogram(noCluster, tPoint, minX, minY, rangeX, rangeY);
            DrawHistogram(noCluster, nbPoints, minX, minY, rangeX, rangeY);

            ggPictBox.Image = bmp;
        }
        public void DrawDistancesFromOrigin(int nbClusters = 0)
        {
            viewPort2 = new Rectangle(0, 0, ggPictBox2.Width - 1, ggPictBox2.Height - 1);
            G.FillRectangle(Brushes.Navy, viewPort2);

            double minX = 0;
            double maxX = nbPoints;
            double minY = 0;
            double maxY = 0;

            foreach (var path in D.DistanceFromOrigin)
            {
                var ymax = path.Points.Max(m => m.Y);
                if (ymax > maxY) maxY = ymax;
            }

            double rangeX = maxX - minX;
            double rangeY = maxY - minY;

            DrawDistanceHistogram(D.DistanceFromOrigin, viewPort2, nbClusters, minX, minY, rangeX, rangeY);

            ggPictBox2.Image = bmp;
        }
        public void DrawDistancesFromPrevious(int nbClusters = 0)
        {
            viewPort3 = new Rectangle(0, 0, ggPictBox3.Width - 1, ggPictBox3.Height - 1);
            G.FillRectangle(Brushes.ForestGreen, viewPort3);

            double minX = 0;
            double maxX = nbPoints;
            double minY = 0;
            double maxY = 0;

            foreach (var path in D.DistanceFromPrevious)
            {
                var ymax = path.Points.Max(m => m.Y);
                if (ymax > maxY) maxY = ymax;
            }

            double rangeX = maxX - minX;
            double rangeY = maxY - minY;

            DrawDistanceHistogram(D.DistanceFromPrevious, viewPort3, nbClusters, minX, minY, rangeX, rangeY);

            ggPictBox3.Image = bmp;
        }

        #endregion

        #region Private

        private void DrawPaths(double startX, double startY, double rangeX, double rangeY)
        {
            PointF origin = AdjustPoint(viewPort, new RandomPoint(0, 0), startX, startY, rangeX, rangeY);

            // Points Adjustment and drawing
            for (int i = 0; i < D.Paths.Count(); i++)
            {
                var path = D.Paths[i];

                SolidBrush randomBrush = new SolidBrush(Color.FromArgb(R.Next(255), R.Next(255), R.Next(255)));
                Pen randomPen = new Pen(randomBrush, 1.0f);

                var adjustedPoints = GetAdjustedPoints(viewPort, path.Points, startX, startY, rangeX, rangeY);
                for (int j = 0; j < adjustedPoints.Count - 1; j++)
                {
                    if (j == 0)
                        G.DrawLine(randomPen, (float)origin.X, (float)origin.Y, (float)adjustedPoints[j + 1].X, (float)adjustedPoints[j + 1].Y);
                    else
                        G.DrawLine(randomPen, (float)adjustedPoints[j].X, (float)adjustedPoints[j].Y, (float)adjustedPoints[j + 1].X, (float)adjustedPoints[j + 1].Y);
                }
            }

            //foreach (var path in D.Paths)
            //{
            //    PointF origin = AdjustPoint(new RandomPoint(0, 0), startX, startY, rangeX, rangeY);

            //    SolidBrush randomBrush = new SolidBrush(Color.FromArgb(R.Next(255), R.Next(255), R.Next(255)));
            //    Pen randomPen = new Pen(randomBrush, 1.0f);

            //    for (int i = 1; i < path.Points.Count; i++)
            //    {
            //        PointF lastPoint;
            //        PointF currPoint = AdjustPoint(new RandomPoint(path.Points[i].X, path.Points[i].Y), startX, startY, rangeX, rangeY);
            //        if (i == 1)
            //            lastPoint = origin;
            //        else
            //            lastPoint = AdjustPoint(new RandomPoint(path.Points[i - 1].X, path.Points[i - 1].Y), startX, startY, rangeX, rangeY);

            //        G.DrawLine(randomPen, currPoint.X, currPoint.Y, lastPoint.X, lastPoint.Y);
            //    }
            //}

            var font = new Font("Calibri", 10.0f);
            G.DrawString("T = " + tPoint.ToString(), font, Brushes.White, new PointF(origin.X, origin.Y / 2));
        }

        private void DrawHistogram(int nbClusters, int T, double startX, double startY, double rangeX, double rangeY)
        {
            int x = (int)AdjustX(viewPort, T, startX, rangeX);

            int w = 0;
            int y;
            int h;
            int maxOccurs = 0;

            // Find min and max value in T
            var tPoints = new List<double>();
            foreach (var path in D.Paths)
            {
                var tPoint = path.Points.Where(f => f.X == T).FirstOrDefault();
                if (tPoint != null)
                    tPoints.Add(tPoint.Y);
            }
            tPoints.Sort();
            var mint = tPoints.First();
            var maxt = tPoints.Last();
            var rng = maxt - mint > 0 ? maxt - mint : maxt;

            // Adjusts coordinates to viewport
            var y1 = (int)AdjustY(viewPort, mint, startY, rangeY);
            var y2 = (int)AdjustY(viewPort, maxt, startY, rangeY);

            // Creates clusters for histogram 
            var clusters = new List<double>();
            double clusterSize = rng / nbClusters;
            for (int i = 0; i < nbClusters; i++)
            {
                // valori positivi
                var min = mint;
                var max = min + clusterSize;
                var occurs = tPoints.Where(d => d >= min && d < max).Count();
                clusters.Add(occurs);
                mint = max;
            }

            // Calculates height of bars
            h = (y1 - y2) / clusters.Count;

            // Draws bars
            y = (int)y2;
            for (int i = 0; i < clusters.Count; i++)
            {
                w = (int)clusters[i];

                if (w > maxOccurs)
                    maxOccurs = w;

                if (i == clusters.Count - 1)
                {
                    h = (int)(y1 - y);
                }

                Rectangle rectangle = new Rectangle(x, y - 1, w + 1, h);
                G.DrawRectangle(Pens.Black, rectangle);

                rectangle = new Rectangle(x, y, w + 1, h - 1);
                G.FillRectangle(Brushes.Gold, rectangle);

                G.DrawString(clusters[i].ToString(), new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold), Brushes.White, new Point(x - 30, y));
                y = y + h;
            }

            // Draws frames
            w = maxOccurs;

            //var frame = new Rectangle(x, y2, maxOccurs, y1 - y2);
            //G.DrawRectangle(Pens.Gold, frame);

            var frame = new Rectangle(x, 0, w + 1, ggPictBox.Height - 2);
            var pen = T == nbPoints ? Pens.Red : Pens.Blue;
            G.DrawRectangle(pen, frame);
        }

        private void DrawDistanceHistogram(List<RandomPath> paths, Rectangle vp, int nbClusters, double startX, double startY, double rangeX, double rangeY)
        {
            int x = (int)AdjustX(vp, 0, startX, rangeX) + 50;

            int w = 0;
            int y;
            int h;

            // Find min and max value in T
            var tPoints = new List<double>();
            foreach (var path in paths)
            {
                foreach (var tPoint in path.Points)
                    tPoints.Add(tPoint.Y);
            }
            tPoints.Sort();
            var mint = tPoints.First();
            var maxt = tPoints.Last();
            var rng = maxt - mint > 0 ? maxt - mint : maxt;

            // Adjusts coordinates to viewport
            var y1 = (int)AdjustY(vp, mint, startY, rangeY);
            var y2 = (int)AdjustY(vp, maxt, startY, rangeY);

            // Creates clusters for histogram 
            var clusters = new List<double>();
            double clusterSize = rng / nbClusters;
            for (int i = 0; i < nbClusters; i++)
            {
                // valori positivi
                var min = mint;
                var max = min + clusterSize;
                var occurs = tPoints.Where(d => d >= min && d < max).Count();
                clusters.Add(occurs * 1/D.lamba);
                mint = max;
            }

            // Calculates height of bars
            h = (y1 - y2) / clusters.Count;

            // Draws bars
            y = (int)y2;
            for (int i = 0; i < clusters.Count; i++)
            {
                w = (int)clusters[i];

                if (i == clusters.Count - 1)
                {
                    h = (int)(y1 - y);
                }

                Rectangle rectangle = new Rectangle(x, y - 1, w + 1, h);
                G.DrawRectangle(Pens.Black, rectangle);

                rectangle = new Rectangle(x, y, w + 1, h - 1);
                G.FillRectangle(Brushes.Gold, rectangle);

                G.DrawString(Math.Round(clusters[i], 0).ToString(), new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold), Brushes.White, new Point(x - 30, y));
                y = y + h;
            }
        }

        private List<PointF> GetAdjustedPoints(Rectangle vp, List<RandomPoint> points, double startX, double startY, double rangeX, double rangeY)
        {
            // Adjusts all points to viewport area
            List<PointF> adjustedPoints = new List<PointF>();

            foreach (RandomPoint point in points)
            {
                var adjPoint = AdjustPoint(vp, point, startX, startY, rangeX, rangeY);
                adjustedPoints.Add(adjPoint);
            }

            return adjustedPoints;
        }

        private PointF AdjustPoint(Rectangle vp, RandomPoint point, double startX, double startY, double rangeX, double rangeY)
        {
            // Adjusts the point to viewport area
            PointF adjustedPoint = new PointF();

            var X = AdjustX(vp, point.X, startX, rangeX);
            var Y = AdjustY(vp, point.Y, startY, rangeY);
            adjustedPoint = new PointF((float)X, (float)Y);

            return adjustedPoint;
        }

        private float AdjustX(Rectangle vp, double x, double startX, double rangeX)
        {
            return (float)(vp.Left + vp.Width * ((x - startX) / rangeX));
        }

        private float AdjustY(Rectangle vp, double y, double startY, double rangeY)
        {
            return (float)(vp.Top + vp.Height - (vp.Height * ((y - startY) / rangeY)));
        }

        #endregion
    }
}
