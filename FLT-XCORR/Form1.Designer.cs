namespace FLT_XCORR
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.buttonSpectrumData1 = new System.Windows.Forms.Button();
            this.buttonSpectrumData2 = new System.Windows.Forms.Button();
            this.buttonXCORR = new System.Windows.Forms.Button();
            this.labelData1Count = new System.Windows.Forms.Label();
            this.labelData2Count = new System.Windows.Forms.Label();
            this.textBoxFreq1 = new System.Windows.Forms.TextBox();
            this.textBoxFreq2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Inputs";
            // 
            // textBoxData1
            // 
            this.textBoxData1.Location = new System.Drawing.Point(0, 0);
            this.textBoxData1.MaxLength = 0;
            this.textBoxData1.Multiline = true;
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData1.Size = new System.Drawing.Size(378, 374);
            this.textBoxData1.TabIndex = 0;
            this.textBoxData1.TextChanged += new System.EventHandler(this.textBoxData1_TextChanged);
            // 
            // textBoxData2
            // 
            this.textBoxData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData2.Location = new System.Drawing.Point(2, 0);
            this.textBoxData2.MaxLength = 0;
            this.textBoxData2.Multiline = true;
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData2.Size = new System.Drawing.Size(377, 374);
            this.textBoxData2.TabIndex = 1;
            this.textBoxData2.TextChanged += new System.EventHandler(this.textBoxData2_TextChanged);
            // 
            // buttonSpectrumData1
            // 
            this.buttonSpectrumData1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSpectrumData1.Location = new System.Drawing.Point(12, 418);
            this.buttonSpectrumData1.Name = "buttonSpectrumData1";
            this.buttonSpectrumData1.Size = new System.Drawing.Size(100, 31);
            this.buttonSpectrumData1.TabIndex = 1;
            this.buttonSpectrumData1.Text = "Spectrum #1";
            this.buttonSpectrumData1.UseVisualStyleBackColor = true;
            this.buttonSpectrumData1.Click += new System.EventHandler(this.buttonSpectrumData1_Click);
            // 
            // buttonSpectrumData2
            // 
            this.buttonSpectrumData2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSpectrumData2.Location = new System.Drawing.Point(118, 418);
            this.buttonSpectrumData2.Name = "buttonSpectrumData2";
            this.buttonSpectrumData2.Size = new System.Drawing.Size(100, 31);
            this.buttonSpectrumData2.TabIndex = 2;
            this.buttonSpectrumData2.Text = "Spectrum #2";
            this.buttonSpectrumData2.UseVisualStyleBackColor = true;
            this.buttonSpectrumData2.Click += new System.EventHandler(this.buttonSpectrumData2_Click);
            // 
            // buttonXCORR
            // 
            this.buttonXCORR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonXCORR.Location = new System.Drawing.Point(224, 418);
            this.buttonXCORR.Name = "buttonXCORR";
            this.buttonXCORR.Size = new System.Drawing.Size(100, 31);
            this.buttonXCORR.TabIndex = 3;
            this.buttonXCORR.Text = "XCORR";
            this.buttonXCORR.UseVisualStyleBackColor = true;
            this.buttonXCORR.Click += new System.EventHandler(this.buttonXCORR_Click);
            // 
            // labelData1Count
            // 
            this.labelData1Count.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelData1Count.AutoSize = true;
            this.labelData1Count.Location = new System.Drawing.Point(630, 418);
            this.labelData1Count.Name = "labelData1Count";
            this.labelData1Count.Size = new System.Drawing.Size(101, 12);
            this.labelData1Count.TabIndex = 4;
            this.labelData1Count.Text = "Data #1 Count : 0";
            // 
            // labelData2Count
            // 
            this.labelData2Count.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelData2Count.AutoSize = true;
            this.labelData2Count.Location = new System.Drawing.Point(630, 437);
            this.labelData2Count.Name = "labelData2Count";
            this.labelData2Count.Size = new System.Drawing.Size(101, 12);
            this.labelData2Count.TabIndex = 5;
            this.labelData2Count.Text = "Data #2 Count : 0";
            // 
            // textBoxFreq1
            // 
            this.textBoxFreq1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxFreq1.Location = new System.Drawing.Point(469, 424);
            this.textBoxFreq1.Name = "textBoxFreq1";
            this.textBoxFreq1.Size = new System.Drawing.Size(60, 21);
            this.textBoxFreq1.TabIndex = 6;
            // 
            // textBoxFreq2
            // 
            this.textBoxFreq2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxFreq2.Location = new System.Drawing.Point(564, 424);
            this.textBoxFreq2.Name = "textBoxFreq2";
            this.textBoxFreq2.Size = new System.Drawing.Size(60, 21);
            this.textBoxFreq2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(402, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rate #1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(535, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "#2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxData1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxData2);
            this.splitContainer1.Size = new System.Drawing.Size(764, 377);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonInfo.Location = new System.Drawing.Point(330, 418);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(30, 30);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFreq2);
            this.Controls.Add(this.textBoxFreq1);
            this.Controls.Add(this.labelData2Count);
            this.Controls.Add(this.labelData1Count);
            this.Controls.Add(this.buttonXCORR);
            this.Controls.Add(this.buttonSpectrumData2);
            this.Controls.Add(this.buttonSpectrumData1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FLT-XCORR";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxData2;
        private System.Windows.Forms.TextBox textBoxData1;
        private System.Windows.Forms.Button buttonSpectrumData1;
        private System.Windows.Forms.Button buttonSpectrumData2;
        private System.Windows.Forms.Button buttonXCORR;
        private System.Windows.Forms.Label labelData1Count;
        private System.Windows.Forms.Label labelData2Count;
        private System.Windows.Forms.TextBox textBoxFreq1;
        private System.Windows.Forms.TextBox textBoxFreq2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonInfo;
    }
}

