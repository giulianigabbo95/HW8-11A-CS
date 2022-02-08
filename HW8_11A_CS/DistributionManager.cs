using System;
using System.Linq;
using System.Collections.Generic;

namespace MyHomework
{
    public class RandomPoint
    {
        public int X { get; set; }
        public double Y { get; set; }
        public int Z { get; set; }

        public RandomPoint()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public RandomPoint(int x, double y, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public class RandomPath
    {
        public List<RandomPoint> Points { get; set; }

        public RandomPath()
        {
            Points = new List<RandomPoint>();
        }
    }

    public class Distribution
    {
        #region MEMBERS

        public List<RandomPath> Paths { get; set; }
        public List<RandomPath> DistanceFromOrigin { get; set; }
        public List<RandomPath> DistanceFromPrevious { get; set; }
        public double lamba { get; set; }

        private Random R;

        private int noPoints { get; set; }
        private int noPaths { get; set; }

        #endregion

        #region CONSTRUCTOR

        public Distribution(int nbPoints, int nbPaths, double Lamba = 50)
        {
            lamba = Lamba;

            noPoints = nbPoints;
            noPaths = nbPaths;

            this.Paths = new List<RandomPath>();
            this.DistanceFromOrigin = new List<RandomPath>();
            this.DistanceFromPrevious = new List<RandomPath>();

            R = new Random();
        }

        #endregion

        #region PUBLIC

        public List<RandomPath> GenerateDistribution()
        {
            double randomVal = 0;
            double probOfSuccess = lamba / noPoints;
            double y;
            int z = 0;

            List<RandomPath> paths = new List<RandomPath>();

            for (int i = 0; i < noPaths; i++)
            {
                y = 0;
                var path = new RandomPath();

                //path.Points.Add(new RandomPoint() { X = 0, Y = 0, Z = 0 });
                for (int x = 1; x <= noPoints; x++)
                {
                    randomVal = R.NextDouble();
                    if (randomVal <= probOfSuccess)
                    {
                        y++;
                        z = 1;
                    }
                    else
                        z = 0;

                    RandomPoint p = new RandomPoint() { X = x, Y = y, Z = z };
                    path.Points.Add(p);
                }

                paths.Add(path);
            }

            return paths;
        }

        public List<RandomPath> GenerateDistanceFromPreviousSequence()
        {
            List<RandomPath> distancePaths = new List<RandomPath>();

            for (int i = 0; i < noPaths; i++)
            {
                var path = Paths[i];

                var newpath = new RandomPath();
                bool isFirst = true;
                int lastNonZeroPoint = 0;

                for (int x = 1; x < path.Points.Count; x++)
                {

                    var point = path.Points[x];
                    if (point.Z == 1)
                    {
                        if (!isFirst)
                        {
                            RandomPoint p = new RandomPoint() { X = x, Y = x - lastNonZeroPoint, Z = 0 };
                            newpath.Points.Add(p);
                        }

                        isFirst = false;
                        lastNonZeroPoint = x;
                    }
                }

                distancePaths.Add(newpath);
            }

            return distancePaths;
        }

        public List<RandomPath> GenerateDistanceFromOriginSequence()
        {
            List<RandomPath> distancePaths = new List<RandomPath>();

            for (int i = 0; i < noPaths; i++)
            {
                var path = Paths[i];
                var newpath = new RandomPath();

                for (int x = 1; x < path.Points.Count; x++)
                {
                    var point = path.Points[x];
                    if (point.Z == 1)
                    {
                        RandomPoint p = new RandomPoint() { X = x, Y = x, Z = 0 };
                        newpath.Points.Add(p);
                    }
                }

                distancePaths.Add(newpath);
            }

            return distancePaths;
        }

        #endregion

        #region PRIVATE

        private double GetRandomRademacherVariable()
        {
            var r1 = R.NextDouble();
            var r2 = r1 < 0.5 ? 1d : 0d;
            var rand_rademacher = r2 * 2 - 1;
            return rand_rademacher;
        }

        private double GetRandomNormalVariable()
        {
            double u1;
            double u2;
            double rand_normal;

            // //< Method 1 >
            //double rSquared;

            //do
            //{
            //    u1 = 2.0 * R.NextDouble() - 1.0;
            //    u2 = 2.0 * R.NextDouble() - 1.0;
            //    rSquared = (u1 * u1) + (u2 * u2);
            //}
            //while (rSquared >= 1.0);
            //// </Method 1>

            ////polar tranformation 
            //double p = Math.Sqrt(-2.0 * Math.Log(rSquared) / rSquared);
            //rand_normal = u1 * p; //* sigma + mu;

            // <Method 2>
            u1 = R.NextDouble();
            u2 = R.NextDouble();
            var rand_std_normal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

            rand_normal = rand_std_normal; //* sigma + mu;
            // </Method 2>

            // result
            return rand_normal;
        }

        #endregion
    }
}
