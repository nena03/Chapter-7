namespace TrainGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.throttle = new System.Windows.Forms.TrackBar();
            this.reset = new System.Windows.Forms.Button();
            this.fire = new System.Windows.Forms.PictureBox();
            this.train1 = new TrainGame.Train();
            this.track1 = new TrainGame.Track();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // throttle
            // 
            this.throttle.LargeChange = 10;
            this.throttle.Location = new System.Drawing.Point(12, 104);
            this.throttle.Maximum = 50;
            this.throttle.Name = "throttle";
            this.throttle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.throttle.Size = new System.Drawing.Size(45, 139);
            this.throttle.SmallChange = 5;
            this.throttle.TabIndex = 2;
            this.throttle.TickFrequency = 10;
            this.throttle.ValueChanged += new System.EventHandler(this.throttle_ValueChanged);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(149, 172);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Ukrcajte se";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // fire
            // 
            this.fire.Image = global::TrainGame.Properties.Resources.Google_Noto_Emoji_Travel_Places_42697_fire;
            this.fire.Location = new System.Drawing.Point(240, 66);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(32, 32);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire.TabIndex = 1;
            this.fire.TabStop = false;
            // 
            // train1
            // 
            this.train1.BackgroundImage = global::TrainGame.Properties.Resources.Train_icon1;
            this.train1.Location = new System.Drawing.Point(-2, 51);
            this.train1.Name = "train1";
            this.train1.Size = new System.Drawing.Size(48, 38);
            this.train1.Speed = 0;
            this.train1.TabIndex = 3;
            this.train1.DistanceChanged += new TrainGame.Train.DistanceChangedEventHandler(this.train1_DistanceChanged);
            // 
            // track1
            // 
            this.track1.FireFrequency = 3;
            this.track1.Location = new System.Drawing.Point(-2, 83);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(287, 15);
            this.track1.TabIndex = 0;
            this.track1.CaughtOfFire += new TrainGame.Track.CoughtOfFireEventHandler(this.track1_CaughtOfFire);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.train1);
            this.Controls.Add(this.throttle);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.track1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Track track1;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.TrackBar throttle;
        private Train train1;
        private System.Windows.Forms.Button reset;
    }
}

