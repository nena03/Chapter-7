﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void track1_CaughtOfFire(object sender, CaughtOnFireEventArgs e)
        {
            fire.Location = new Point(track1.Left + e.Location, track1.Top - fire.Height);
        }

        private void train1_DistanceChanged(object sender, Train.DistanceChangedEventArgs e)
        {
            train1.Left = track1.Left + e.Distance;
            if (train1.Right >= track1.Right)
            {
                train1.Speed = 0;
                throttle.Value = 0;
            }
        }

        private void throttle_ValueChanged(object sender, EventArgs e)
        {
            if (train1.Right < track1.Right)
            {
                train1.Speed = throttle.Value;
            }
            else throttle.Value = 0;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            train1.Restart();
            throttle.Value = 0;
            train1.Speed = 0;
            train1.Left = track1.Left;
        }
    }
}
