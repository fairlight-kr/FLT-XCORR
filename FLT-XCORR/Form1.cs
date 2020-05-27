using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DSPLib;
using MathNet.Numerics.IntegralTransforms;
using PlotWrapper;

namespace FLT_XCORR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            splitContainer1.SuspendLayout();
            SuspendLayout();

            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(textBoxData1);
            splitContainer1.Panel2.Controls.Add(textBoxData2);
            textBoxData1.Dock = DockStyle.Fill;
            textBoxData2.Dock = DockStyle.Fill;
            groupBox1.Controls.Add(splitContainer1);

            ResumeLayout();
            splitContainer1.ResumeLayout();
        }

        public class LagCorr
        {
            public double[] Lag { get; set; }
            public double[] Corr { get; set; }
        }

        private void buttonSpectrumData1_Click(object sender, EventArgs e)
        {
            try
            {
                GetSpectrum(1);
            }
            catch
            {
                MessageBox.Show("Input data is wrong.");
            }
        }

        private void textBoxData1_TextChanged(object sender, EventArgs e)
        {
            labelData1Count.Text = "Data #1 Count : " + (textBoxData1.Text.Split('\n')).Length;
        }

        private void buttonSpectrumData2_Click(object sender, EventArgs e)
        {
            try
            {
                GetSpectrum(2);
            }
            catch
            {
                MessageBox.Show("Input data is wrong.");
            }
        }

        private void textBoxData2_TextChanged(object sender, EventArgs e)
        {
            labelData2Count.Text = "Data #2 Count : " + (textBoxData2.Text.Split('\n')).Length;
        }

        private void GetSpectrum(uint dataNumber)
        {
            string[] textBoxRaw;

            if (dataNumber == 1)
            {
                if (String.IsNullOrEmpty(textBoxData1.Text))
                {
                    return;
                }

                if (String.IsNullOrEmpty(textBoxFreq1.Text))
                {
                    MessageBox.Show("Input sampling rate");
                    return;
                }

                textBoxRaw = textBoxData1.Text.Split('\n');
            }
            else
            {
                if (String.IsNullOrEmpty(textBoxData2.Text))
                {
                    return;
                }

                if (String.IsNullOrEmpty(textBoxFreq2.Text))
                {
                    MessageBox.Show("Input sampling rate");
                    return;
                }

                textBoxRaw = textBoxData2.Text.Split('\n');
            }

            int len = textBoxRaw.Length;
            uint padLength = 0;
            double[] inputData = new double[len];
            int i = 0;

            for (int j = 0; ; j++)
            {
                if (Math.Pow(2, j) > len)
                {
                    padLength = Convert.ToUInt32(Math.Pow(2, j));
                    break;
                }
            }

            if (dataNumber == 1)
            {
                labelData1Count.Text = "Data #1 Count : " + len;
            }
            else
            {
                labelData2Count.Text = "Data #2 Count : " + len;
            }

            foreach (string data in textBoxRaw)
            {
                if (String.IsNullOrEmpty(data) || String.IsNullOrWhiteSpace(data))
                    continue;

                inputData[i] = Convert.ToDouble(data);
                i++;
            }

            FFT fft = new FFT();
            fft.Initialize((uint)len, (uint)(padLength - len));

            Complex[] cpx = fft.Execute(inputData);

            double[] sptr = DSP.ConvertComplex.ToMagnitude(cpx);

            Array.Resize(ref sptr, sptr.Length / 2);

            double[] freqSpan;

            if (dataNumber == 1)
            {
                freqSpan = fft.FrequencySpan(double.Parse(textBoxFreq1.Text));
            }
            else
            {
                freqSpan = fft.FrequencySpan(double.Parse(textBoxFreq2.Text));
            }

            Array.Resize(ref freqSpan, freqSpan.Length / 2);

            Plot plot = new Plot("FFT Spectrum Display", "FFT Bin (Freq. = x * 2)", "Magnitude (Vrms)");
            plot.PlotData(freqSpan, sptr);
            plot.Show();
        }

        private void buttonXCORR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxData1.Text) ||
                String.IsNullOrEmpty(textBoxData2.Text))
            {
                return;
            }

            string[] tbx1raw = textBoxData1.Text.Split('\n');
            string[] tbx2raw = textBoxData2.Text.Split('\n');

            var inputDataList1 = new List<Complex>();
            var inputDataList2 = new List<Complex>();
            int i = 0;

            foreach (string data in tbx1raw)
            {
                if (String.IsNullOrEmpty(data) || String.IsNullOrWhiteSpace(data))
                    continue;

                inputDataList1.Add(new Complex(Convert.ToDouble(data), 0.0));
                i++;
            }

            i = 0;

            foreach (string data in tbx2raw)
            {
                if (String.IsNullOrEmpty(data) || String.IsNullOrWhiteSpace(data))
                    continue;

                inputDataList2.Add(new Complex(Convert.ToDouble(data), 0.0));
                i++;
            }
            
            uint data1len = (uint)(inputDataList1.Count);
            uint data2len = (uint)(inputDataList2.Count);
            uint len = data1len + data2len;
            Complex[] inputData1 = new Complex[len];
            Complex[] inputData2 = new Complex[len];
            inputDataList1.CopyTo(inputData1);
            inputDataList2.CopyTo(inputData2);

            Fourier.Forward(inputData1, FourierOptions.Matlab);
            Fourier.Forward(inputData2, FourierOptions.Matlab);
            
            Complex[] resFinal = new Complex[len];
            
            for (int k = 0; k < len; k++)
            {
                resFinal[k] = Complex.Multiply(inputData1[k], Complex.Conjugate(inputData2[k]));
            }
            
            Fourier.Inverse(resFinal);

            double[] xcorrRes = new double[len];
            double[] xcorrResShift = new double[len];

            for (int k = 0; k < len; k++)
            {
                xcorrRes[k] = resFinal[k].Real;
            }

            Array.Copy(xcorrRes, 0, xcorrResShift, len / 2, len / 2);
            Array.Copy(xcorrRes, len / 2, xcorrResShift, 0, len / 2);

            double mx = xcorrResShift.Max();
            int delayIndex = Array.IndexOf(xcorrResShift, mx);
            int delay = (int)(len / 2) - delayIndex;

            string title = String.Empty;

            if (delay < 0)
            {
                title = "XCorr Result : Left data (#1) is faster, difference = " + delay;
            }
            else if (delay == 0)
            {
                title = "XCorr Result : Same time";
            }
            else
            {
                title = "XCorr Result : Right data (#2) is faster, difference = " + delay;
            }

            Plot plot = new Plot(title, "Samples", "Magnitude");
            plot.PlotData(xcorrResShift);
            plot.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FLT-XCORR\n" +
                "1. Get single-sided spectrum\n" +
                "2. Get cross-correlation result and delay\n" +
                "This software using DSPLib v1.03.1 by Steve Hageman\n" +
                "and Math.NET Numerics v4.11.00\n" +
                "Software for private use, will be not maintained.\n" +
                "FLT (skycraper3 @ gmail), 2020");
        }
    }
}
