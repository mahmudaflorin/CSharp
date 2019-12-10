using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.CustomControls
{
    class TransTextBox : TextBox
    {
        Color bottomBorderColor = Color.Black;
        Label bottomBorder = new Label();
        public Color BottomBorderColor
        {
            get { return bottomBorderColor; }
            set
            {
                bottomBorderColor = value;
                bottomBorder.BackColor = BottomBorderColor;
                Invalidate();
            }
        }
        /*Color bottomBorderColor = Color.Black;
        Color topBorderColor = Color.Black;
        Color leftBorderColor = Color.Black;
        Color rightBorderColor = Color.Black;
        Color allBorderColor = Color.Black;

        Label topBorder = new Label(), bottomBorder = new Label(), leftBorder = new Label(), rightBorder = new Label();



        public Color BottomBorderColor
        {
            get { return bottomBorderColor; }
            set
            {
                bottomBorderColor = value;
                bottomBorder.BackColor = BottomBorderColor;
                Invalidate();
            }
        }
        public Color TopBorderColor
        {
            get { return topBorderColor; }
            set
            {
                topBorderColor = value;
                topBorder.BackColor = TopBorderColor;
                Invalidate();
            }
        }
        public Color LeftBorderColor
        {
            get { return leftBorderColor; }
            set
            {
                leftBorderColor = value;
                leftBorder.BackColor = LeftBorderColor;
                Invalidate();
            }
        }
        public Color RightBorderColor
        {
            get { return rightBorderColor; }
            set
            {
                rightBorderColor = value;
                rightBorder.BackColor = RightBorderColor;
                Invalidate();
            }
        }

        public Color AllBorderColor
        {
            get { return allBorderColor; }
            set
            {
                allBorderColor = value;
                RightBorderColor = value;
                LeftBorderColor = value;
                TopBorderColor = value;
                BottomBorderColor = value;
                //rightBorderColor = value;

                //rightBorder.BackColor = AllBorderColor;
                //leftBorder.BackColor = AllBorderColor;
                //topBorder.BackColor = AllBorderColor;
                //bottomBorder.BackColor = AllBorderColor;
                Invalidate();
            }
        }

        private int borderSize = 1;
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                rightBorder.Width = value;
                leftBorder.Width = value;
                topBorder.Height = value;
                bottomBorder.Height = value;
                this.Padding = new Padding(value, value, value, value);
                Invalidate();
            }
        }
        */




        public TransTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw, true);
            bottomBorder.Height = 1;
            bottomBorder.Dock = DockStyle.Bottom;
            bottomBorder.BackColor = BottomBorderColor;

            Controls.Add(bottomBorder);

            /* 
             rightBorder.Width = 1;
             rightBorder.Dock = DockStyle.Right;
             rightBorder.BackColor = RightBorderColor;

             leftBorder.Width = 1;
             leftBorder.Dock = DockStyle.Left;
             leftBorder.BackColor = LeftBorderColor;

             topBorder.Height = 1; 
             topBorder.Dock = DockStyle.Top;
             topBorder.BackColor = TopBorderColor;

             bottomBorder.Height = 1;
             bottomBorder.Dock = DockStyle.Bottom;
             bottomBorder.BackColor = BottomBorderColor ;

             BottomBorderColor = Color.Black;
             TopBorderColor = Color.Black;
             LeftBorderColor = Color.Black;
             RightBorderColor = Color.Black;

             Controls.Add(topBorder);
             Controls.Add(leftBorder);
             Controls.Add(bottomBorder);
             Controls.Add(rightBorder);
             */


            BorderStyle = System.Windows.Forms.BorderStyle.None;


            AutoSize = false; //Allows you to change height to have bottom padding

        }


    }
}
