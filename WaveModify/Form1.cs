using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WaveModify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream playback_input;
        FileStream playback_output;
        wave ses;
        System.Media.SoundPlayer sp1;
        System.Media.SoundPlayer sp2;

        private void choose_Click(object sender, EventArgs e)
        {
            ses = new wave();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            ses.path_Input = dlg.FileName;
            ses.path_Output = dlg.FileName + "_output.wav";

            anal.Enabled = true;
            reset.Enabled = true;
        }

        private void anal_Click(object sender, EventArgs e)
        {
            ses.inputFile();

            result.Text = ses.BitsPerSample + " bits per sample\n\n" +
                          ses.channels + " kanal\n\n" +
                          ses.DataLength + " data boyutu\n\n" +
                          ses.SampleRate + " sample rate\n\n" +
                          ses.length + " bytes\n\n" +
                          ses.path_Input;

            inputPlayback.Enabled = true;
            save.Enabled = true;
            multiplier.Enabled = true;
            bits.Enabled = true;
            bits.Text = ses.inputBps.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ses.headerYazdır();
            ses.DataYazdır();
            savePlayback.Enabled = true; 
        }


        private void play_Click(object sender, EventArgs e)
        {
            playback_input = new FileStream(ses.path_Input, FileMode.Open, FileAccess.Read);
            sp1 = new System.Media.SoundPlayer(playback_input);
            sp1.Play();
            playback_input.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp1.Stop();
            playback_input.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playback_output = new FileStream(ses.path_Output, FileMode.Open, FileAccess.Read);
            sp2 = new System.Media.SoundPlayer(playback_output);
            sp2.Play();
            playback_output.Close();
        }

        private void saveStop_Click(object sender, EventArgs e)
        {
            sp2.Stop();
            playback_output.Close();
        }

        private void multiplier_TextChanged(object sender, EventArgs e)
        {
            ses.multiplier = Convert.ToInt32(multiplier.Text);
            ses.SampleRate /= ses.multiplier;
            ses.DataLength /= ses.multiplier;
            ses.length = ses.DataLength + 36;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ses.reset();
            multiplier.Text = ses.multiplier.ToString();
            anal.Enabled = false;
            result.Text = "";
            save.Enabled = false;
            inputPlayback.Enabled = false;
            savePlayback.Enabled = false;
            multiplier.Enabled = false;
            bits.Text = ses.inputBps.ToString();
            bits.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ses.BitsPerSample = short.Parse(bits.Text);
            ses.shiftRightvalue = (Int16)(ses.inputBps- ses.BitsPerSample);
        }
    }
}
