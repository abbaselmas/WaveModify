using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WaveModify
{
    class wave
    {
        public int length;
        public short channels;
        public int SampleRate;
        public int DataLength;
        public short inputBps;
        public short BitsPerSample;
        public string path_Input = "";
        public string path_Output = "";
        public int multiplier = 1;
        public short shiftRightvalue = 0;
      
        public void inputFile()
        {
            FileStream fs = new FileStream(path_Input, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
            length = (int)fs.Length - 8;
            fs.Position = 22;
            channels = br.ReadInt16();
            fs.Position = 24;
            SampleRate = br.ReadInt32();
            fs.Position = 34;

            inputBps = br.ReadInt16();
            BitsPerSample = inputBps;
            DataLength = (int)fs.Length - 44;
            br.Close();
            fs.Close();
        }

        public void headerYazdır()
        {
            FileStream fs = new FileStream(path_Output, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            fs.Position = 0;
            bw.Write(new char[4] { 'R', 'I', 'F', 'F' });
            bw.Write(length);
            bw.Write(new char[8] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
            bw.Write((int)16);
            bw.Write((short)1);
            bw.Write(channels);
            bw.Write(SampleRate);
            bw.Write((int)(SampleRate * (short)(BitsPerSample / 8 * channels)));
            bw.Write((short)(BitsPerSample/8 * channels));
            bw.Write(BitsPerSample);
            bw.Write(new char[4] { 'd', 'a', 't', 'a' });
            bw.Write(DataLength);
            bw.Close();
            fs.Close();
        }

        public void DataYazdır()
        {
            FileStream fs = new FileStream(path_Input, FileMode.Open, FileAccess.Read);
            byte[] arrfile = new byte[fs.Length - 44];
            fs.Position = 44;
            fs.Read(arrfile, 0, arrfile.Length);
            fs.Close();

            //yeni data boyutu kadarını eski data içinden al
            byte[] temparr = new byte[this.DataLength];
            for (int i = 0, j=0; i<temparr.Length ; j++ )
            {
                if (j % multiplier == 0)
                {
                    temparr[i++] = arrfile[j];
                }
            }


            FileStream fo = new FileStream(path_Output, FileMode.Append, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fo);

            int[] a = new int[temparr.Length];
            for (int i = 0; i< temparr.Length ;i++ )
            {
                a[i] = temparr[i] >> this.shiftRightvalue;
            }

            char[] t = new char[a.Length * BitsPerSample];
            char[] bu = new char[BitsPerSample];
            char[] s = new char[BitsPerSample];
            //int z=0;

            for (int i = 0; i<a.Length; i++)
            {
                int z = 0;
                s = Convert.ToString(a[i], 2).ToCharArray();
                for (int u = 0; u < BitsPerSample - s.Length; u++)
                {
                    bu[z++] = '0';
                }
                for (int y= 0; y<s.Length; y++)
                {
                    bu[z++] = s[y];
                }
                bw.Write(bu);
                
            }

            
           // bw.Write(temparr);
            bw.Close();
            fo.Close();

        }
        public void reset()
        {
            this.inputBps = 0;
            this.BitsPerSample = 0;
            this.DataLength = 0;
            this.SampleRate = 0;
            this.length = 0;
            this.multiplier = 1;
            this.path_Input = "";
            this.path_Output = "";
        }
      
    }
}
