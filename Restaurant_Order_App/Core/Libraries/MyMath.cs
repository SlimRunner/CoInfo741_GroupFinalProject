using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_App.Core.Libraries
{
    class MyMath
    {
        /// <summary>
        /// Transforms a number that follows a linear transition to an
        /// arbitrary cubic bezier spline. Anchors of spline are fixed
        /// to 0,0 and 1,1.
        /// </summary>
        /// <param name="trans">A number between 0 and 1.</param>
        /// <param name="pivot1_X">X coordinate of the first pivot.</param>
        /// <param name="pivot1_Y">Y coordinate of the first pivot.</param>
        /// <param name="pivot2_X">X coordinate of the second pivot.</param>
        /// <param name="pivot2_Y">Y coordinate of the second pivot.</param>
        /// <returns>The transformed number that follows the specified curve.</returns>
        static public double getBezier(double trans,
            double pivot1_X, double pivot1_Y,
            double pivot2_X, double pivot2_Y)
        {
            const double TOLERANCE = 0.0001;
            double x_out, y_out;
            double newTrans;
            double leftNode, rightNode;
            double seekLocation;

            /*
             * This function calculates the location of Y on a bezier spline given a linear X
             * coordinate.
             * This is achieved by using a binary search on the curve X coordinate until the
             * transition matches the output of x_out.
             * 
             * This is a naive algorithm. A better way is achieved by solving the mathematical
             * formula of 'x_out' for 'trans'. I'm no mathematician. I couldn't solve it.
             */

            //confines 'trans' to a valid range of [0, 1]
            if (trans > 1)
                trans = 1;
            else if (trans < 0)
                trans = 0;

            //convering nodes of the binary search
            leftNode = 0;
            rightNode = 1;

            //base calculation for convergence
            x_out = 3 * pivot1_X * trans * Math.Pow(1 - trans, 2) +
                3 * pivot2_X * Math.Pow(trans, 2) * (1 - trans) +
                Math.Pow(trans, 3);

            //negative is left side of traget, positive is right side target
            //left side searches by adding, right side searches by deducting
            seekLocation = x_out - trans;

            //'trans' needs to be preserved so this is a proxy of it
            newTrans = trans;

            //repeat until convergence is within valid range
            while (Math.Abs(seekLocation) > TOLERANCE)
            {
                //moves the appropriate search node
                if (seekLocation > 0)
                    rightNode = newTrans;
                else
                    leftNode = newTrans;

                //gets average of search nodes
                newTrans = (leftNode + rightNode) * 0.5;

                //new convergence value
                x_out = 3 * pivot1_X * newTrans * Math.Pow(1 - newTrans, 2) +
                    3 * pivot2_X * Math.Pow(newTrans, 2) * (1 - newTrans) +
                    Math.Pow(newTrans, 3);

                //update seek location
                seekLocation = x_out - trans;
            }

            //calculates the transformed transition
            y_out = 3 * pivot1_Y * newTrans * Math.Pow(1 - newTrans, 2) +
                3 * pivot2_Y * Math.Pow(newTrans, 2) * (1 - newTrans) +
                Math.Pow(newTrans, 3);

            return y_out;
        }
    }
}
