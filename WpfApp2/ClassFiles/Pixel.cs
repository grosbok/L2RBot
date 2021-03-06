﻿using System.Drawing;

namespace L2RBot
{
    public class Pixel
    {
        public Color Color { get; set; }

        public Point Point { get; set; }

        /// <summary>
        /// Looks for the Color at the Point on the game screen.
        /// </summary>
        /// <param name="Screen"></param>
        /// <param name="Tolerance"></param>
        /// <returns>True: Color detected</returns>
        /// <returns>False: Color NOT detected</returns>
        public bool IsPresent(Rectangle Screen, int Tolerance)
        {
            return L2RBot.Screen.CompareColor(Color, L2RBot.Screen.GetColor(Screen, Point.X, Point.Y), Tolerance);
        }

        /// <summary>
        /// looks to see what the current pixels color value is.
        /// </summary>
        /// <param name="_Screen"></param>
        /// <returns></returns>
        public Color CurrentValue(Rectangle _Screen)
        {
            return Screen.GetColor(_Screen, Point.X, Point.Y);
        }

        /// <summary>
        /// Updates the Pixel's Color value with the current game screen Color at the defined Point.
        /// </summary>
        /// <param name="Screen"></param>
        public void UpdateColor(Rectangle Screen)
        {
            Color = CurrentValue(Screen);
        }

        /// <summary>
        /// Displays Pixel's string value in a specific format.
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return "(" + Point.X + ", " + Point.Y + ")TargetL[" + Color.A + "," + Color.R + "," + Color.G + "," + Color.B + "]";
        }
    }
}
