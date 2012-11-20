namespace SampleGreetHello
{
    partial class WinformsGreetView 
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
            this.btnGreet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAttitudeAdjuster = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.statusGreetCounter = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbAttitudeAdjuster)).BeginInit();
            this.statusGreetCounter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGreet
            // 
            this.btnGreet.AutoSize = true;
            this.btnGreet.Location = new System.Drawing.Point(73, 16);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(139, 27);
            this.btnGreet.TabIndex = 0;
            this.btnGreet.Text = "Click to be greeted!";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "enthusiastic level:";
            // 
            // tbAttitudeAdjuster
            // 
            this.tbAttitudeAdjuster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAttitudeAdjuster.Location = new System.Drawing.Point(0, 124);
            this.tbAttitudeAdjuster.Name = "tbAttitudeAdjuster";
            this.tbAttitudeAdjuster.Size = new System.Drawing.Size(346, 56);
            this.tbAttitudeAdjuster.TabIndex = 2;
            this.tbAttitudeAdjuster.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbAttitudeAdjuster.Value = 3;
            this.tbAttitudeAdjuster.ValueChanged += new System.EventHandler(this.tbAttitudeAdjuster_ValueChanged);
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "still unknown";
            // 
            // statusGreetCounter
            // 
            this.statusGreetCounter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusGreetCounter.Location = new System.Drawing.Point(0, 179);
            this.statusGreetCounter.Name = "statusGreetCounter";
            this.statusGreetCounter.Size = new System.Drawing.Size(346, 23);
            this.statusGreetCounter.SizingGrip = false;
            this.statusGreetCounter.TabIndex = 4;
            this.statusGreetCounter.Tag = "greeted 0 times today";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(153, 18);
            this.toolStripStatusLabel1.Text = "greeted 0 times today";
            // 
            // sampleGreetHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 202);
            this.Controls.Add(this.statusGreetCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAttitudeAdjuster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGreet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sampleGreetHello";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hello there";
            ((System.ComponentModel.ISupportInitialize)(this.tbAttitudeAdjuster)).EndInit();
            this.statusGreetCounter.ResumeLayout(false);
            this.statusGreetCounter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGreet;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TrackBar tbAttitudeAdjuster;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.StatusStrip statusGreetCounter;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

