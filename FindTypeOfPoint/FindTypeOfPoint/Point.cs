using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FindTypeOfPoint
{
    /// <summary>
    /// Represents an ordered pair of integer x- and y-coordinates that defines a point in a two-dimensional plane.
    /// </summary>
    public class Point
    {
        private int x, y;

        /// <summary>
        /// Property that returns the x-coordinate of the point.
        /// </summary>
        
        public int X { get { return x; } }

        /// <summary>
        /// Property that returns the y-coordinate of the point.
        /// </summary>
        
        public int Y { get { return y; } }

        /// <summary>
        ///	Point Constructor
        /// </summary>
        ///
        /// <remarks>
        ///	Creates a Point from a specified x,y coordinate pair.
        /// </remarks>

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Determines the distance between two points.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>The distance between two points.</returns>
        
        public static double GetDistanceBetween(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        /// <summary>
        /// Position of <paramref name="p3"/> with respect to vector with origins 
        /// at point <paramref name="p1"/> and end at point <paramref name="p2"/>.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns>
        ///  1 - If the <paramref name="p1"/> is to the left of the vector with origins 
        /// at point <paramref name="p1"/> and end at point <paramref name="p2"/>.<br/>
        /// -1 - If the <paramref name="p1"/> is to the right of the vector with origins 
        /// at point <paramref name="p1"/> and end at point <paramref name="p2"/>.<br/>
        /// 0 - If the <paramref name="p1"/> is on the straight line containing the vector with origins 
        /// at point <paramref name="p1"/> and end at point <paramref name="p2"/>.
        /// </returns>

        public static int LeftOrRight(Point p1, Point p2, Point p3)
        {
            return Math.Sign((p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X));
        }

        /// <summary>
        /// The method checks whether a point belongs to a line segment.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p"></param>
        /// <returns>
        /// True - If point <paramref name="p"/> belongs to a line segment <paramref name="p1"/>-<paramref name="p2"/>.<br/>
        /// True - If point <paramref name="p"/> doesn't belong to a line segment <paramref name="p1"/>-<paramref name="p2"/>.
        /// </returns>

        public static bool IsPointOnLineSegment(Point p1 ,Point p2, Point p)
        {
            return Math.Round((GetDistanceBetween(p1, p) + GetDistanceBetween(p2, p) - GetDistanceBetween(p1, p2)), 15) == 0.0;
        }
    }
}
