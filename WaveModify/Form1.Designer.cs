namespace WaveModify
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
            this.choose = new System.Windows.Forms.Button();
            this.anal = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.inputPlayback = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.savePlayback = new System.Windows.Forms.GroupBox();
            this.saveStop = new System.Windows.Forms.Button();
            this.savePlay = new System.Windows.Forms.Button();
            this.multiplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bits = new System.Windows.Forms.TextBox();
            this.inputPlayback.SuspendLayout();
            this.savePlayback.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(13, 13);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 0;
            this.choose.Text = "Choose";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // anal
            // 
            this.anal.Enabled = false;
            this.anal.Location = new System.Drawing.Point(95, 12);
            this.anal.Name = "anal";
            this.anal.Size = new System.Drawing.Size(75, 23);
            this.anal.TabIndex = 1;
            this.anal.Text = "Analyze";
            this.anal.UseVisualStyleBackColor = true;
            this.anal.Click += new System.EventHandler(this.anal_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(176, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(6, 19);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(70, 23);
            this.play.TabIndex = 4;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(82, 19);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(70, 23);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputPlayback
            // 
            this.inputPlayback.Controls.Add(this.play);
            this.inputPlayback.Controls.Add(this.stop);
            this.inputPlayback.Enabled = false;
            this.inputPlayback.Location = new System.Drawing.Point(12, 211);
            this.inputPlayback.Name = "inputPlayback";
            this.inputPlayback.Size = new System.Drawing.Size(158, 51);
            this.inputPlayback.TabIndex = 6;
            this.inputPlayback.TabStop = false;
            this.inputPlayback.Text = "Input Play Back";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(13, 43);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(157, 162);
            this.result.TabIndex = 7;
            this.result.Text = "";
            // 
            // savePlayback
            // 
            this.savePlayback.Controls.Add(this.saveStop);
            this.savePlayback.Controls.Add(this.savePlay);
            this.savePlayback.Enabled = false;
            this.savePlayback.Location = new System.Drawing.Point(176, 211);
            this.savePlayback.Name = "savePlayback";
            this.savePlayback.Size = new System.Drawing.Size(158, 51);
            this.savePlayback.TabIndex = 9;
            this.savePlayback.TabStop = false;
            this.savePlayback.Text = "Output Play Back";
            // 
            // saveStop
            // 
            this.saveStop.Location = new System.Drawing.Point(80, 20);
            this.saveStop.Name = "saveStop";
            this.saveStop.Size = new System.Drawing.Size(70, 23);
            this.saveStop.TabIndex = 1;
            this.saveStop.Text = "Stop";
            this.saveStop.UseVisualStyleBackColor = true;
            this.saveStop.Click += new System.EventHandler(this.saveStop_Click);
            // 
            // savePlay
            // 
            this.savePlay.Location = new System.Drawing.Point(5, 20);
            this.savePlay.Name = "savePlay";
            this.savePlay.Size = new System.Drawing.Size(70, 23);
            this.savePlay.TabIndex = 0;
            this.savePlay.Text = "Play";
            this.savePlay.UseVisualStyleBackColor = true;
            this.savePlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplier
            // 
            this.multiplier.Enabled = false;
            this.multiplier.Location = new System.Drawing.Point(229, 43);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(42, 20);
            this.multiplier.TabIndex = 10;
            this.multiplier.Text = "1";
            this.multiplier.TextChanged += new System.EventHandler(this.multiplier_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "multiplier";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(258, 11);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "# of bits/sample";
            // 
            // bits
            // 
            this.bits.Enabled = false;
            this.bits.Location = new System.Drawing.Point(263, 75);
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(70, 20);
            this.bits.TabIndex = 14;
            this.bits.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 274);
            this.Controls.Add(this.bits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.savePlayback);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputPlayback);
            this.Controls.Add(this.save);
            this.Controls.Add(this.anal);
            this.Controls.Add(this.choose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputPlayback.ResumeLayout(false);
            this.savePlayback.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button anal;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.GroupBox inputPlayback;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.GroupBox savePlayback;
        private System.Windows.Forms.Button saveStop;
        private System.Windows.Forms.Button savePlay;
        private System.Windows.Forms.TextBox multiplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bits;
    }
}

