﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TrafficLightSimulator_Aplicada
{
    public class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(pe);
        }

    }
}
