namespace DIP_hw1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox_extraction = new System.Windows.Forms.GroupBox();
            this.btn_extractB = new System.Windows.Forms.Button();
            this.btn_grayscale = new System.Windows.Forms.Button();
            this.btn_extractG = new System.Windows.Forms.Button();
            this.btn_extractR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_histogram = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_median_filter = new System.Windows.Forms.Button();
            this.btn_mean_filter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar_threshold = new System.Windows.Forms.TrackBar();
            this.btn_threshold = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_edge = new System.Windows.Forms.Button();
            this.btn_sobel_y = new System.Windows.Forms.Button();
            this.btn_sobel_x = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBar_overlap = new System.Windows.Forms.TrackBar();
            this.btn_edge_overlap = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_connect_comp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_extraction.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_threshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_overlap)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_extraction
            // 
            this.groupBox_extraction.Controls.Add(this.btn_extractB);
            this.groupBox_extraction.Controls.Add(this.btn_grayscale);
            this.groupBox_extraction.Controls.Add(this.btn_extractG);
            this.groupBox_extraction.Controls.Add(this.btn_extractR);
            this.groupBox_extraction.Location = new System.Drawing.Point(6, 12);
            this.groupBox_extraction.Name = "groupBox_extraction";
            this.groupBox_extraction.Size = new System.Drawing.Size(180, 79);
            this.groupBox_extraction.TabIndex = 0;
            this.groupBox_extraction.TabStop = false;
            this.groupBox_extraction.Text = "Extraction";
            // 
            // btn_extractB
            // 
            this.btn_extractB.Location = new System.Drawing.Point(9, 48);
            this.btn_extractB.Name = "btn_extractB";
            this.btn_extractB.Size = new System.Drawing.Size(75, 21);
            this.btn_extractB.TabIndex = 3;
            this.btn_extractB.Text = "B";
            this.btn_extractB.UseVisualStyleBackColor = true;
            this.btn_extractB.Click += new System.EventHandler(this.btn_extractB_Click);
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Location = new System.Drawing.Point(90, 48);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(75, 21);
            this.btn_grayscale.TabIndex = 2;
            this.btn_grayscale.Text = "Grayscale";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // btn_extractG
            // 
            this.btn_extractG.Location = new System.Drawing.Point(90, 16);
            this.btn_extractG.Name = "btn_extractG";
            this.btn_extractG.Size = new System.Drawing.Size(75, 21);
            this.btn_extractG.TabIndex = 1;
            this.btn_extractG.Text = "G";
            this.btn_extractG.UseVisualStyleBackColor = true;
            this.btn_extractG.Click += new System.EventHandler(this.btn_extractG_Click);
            // 
            // btn_extractR
            // 
            this.btn_extractR.Location = new System.Drawing.Point(9, 16);
            this.btn_extractR.Name = "btn_extractR";
            this.btn_extractR.Size = new System.Drawing.Size(75, 21);
            this.btn_extractR.TabIndex = 0;
            this.btn_extractR.Text = "R";
            this.btn_extractR.UseVisualStyleBackColor = true;
            this.btn_extractR.Click += new System.EventHandler(this.btn_extractR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_histogram);
            this.groupBox2.Location = new System.Drawing.Point(6, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equalization";
            // 
            // btn_histogram
            // 
            this.btn_histogram.Location = new System.Drawing.Point(9, 20);
            this.btn_histogram.Name = "btn_histogram";
            this.btn_histogram.Size = new System.Drawing.Size(156, 21);
            this.btn_histogram.TabIndex = 6;
            this.btn_histogram.Text = "Histogram Equalization";
            this.btn_histogram.UseVisualStyleBackColor = true;
            this.btn_histogram.Click += new System.EventHandler(this.btn_histogram_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_median_filter);
            this.groupBox1.Controls.Add(this.btn_mean_filter);
            this.groupBox1.Location = new System.Drawing.Point(6, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smooth Filter";
            // 
            // btn_median_filter
            // 
            this.btn_median_filter.Location = new System.Drawing.Point(90, 20);
            this.btn_median_filter.Name = "btn_median_filter";
            this.btn_median_filter.Size = new System.Drawing.Size(75, 21);
            this.btn_median_filter.TabIndex = 5;
            this.btn_median_filter.Text = "Median Filter";
            this.btn_median_filter.UseVisualStyleBackColor = true;
            this.btn_median_filter.Click += new System.EventHandler(this.btn_median_filter_Click);
            // 
            // btn_mean_filter
            // 
            this.btn_mean_filter.Location = new System.Drawing.Point(9, 20);
            this.btn_mean_filter.Name = "btn_mean_filter";
            this.btn_mean_filter.Size = new System.Drawing.Size(75, 21);
            this.btn_mean_filter.TabIndex = 4;
            this.btn_mean_filter.Text = "Mean Filter";
            this.btn_mean_filter.UseVisualStyleBackColor = true;
            this.btn_mean_filter.Click += new System.EventHandler(this.btn_mean_filter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar_threshold);
            this.groupBox3.Controls.Add(this.btn_threshold);
            this.groupBox3.Location = new System.Drawing.Point(675, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thresholding";
            // 
            // trackBar_threshold
            // 
            this.trackBar_threshold.Location = new System.Drawing.Point(5, 17);
            this.trackBar_threshold.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_threshold.Name = "trackBar_threshold";
            this.trackBar_threshold.Size = new System.Drawing.Size(142, 45);
            this.trackBar_threshold.TabIndex = 7;
            // 
            // btn_threshold
            // 
            this.btn_threshold.Location = new System.Drawing.Point(152, 27);
            this.btn_threshold.Name = "btn_threshold";
            this.btn_threshold.Size = new System.Drawing.Size(75, 21);
            this.btn_threshold.TabIndex = 6;
            this.btn_threshold.Text = "Start";
            this.btn_threshold.UseVisualStyleBackColor = true;
            this.btn_threshold.Click += new System.EventHandler(this.btn_threshold_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_edge);
            this.groupBox4.Controls.Add(this.btn_sobel_y);
            this.groupBox4.Controls.Add(this.btn_sobel_x);
            this.groupBox4.Location = new System.Drawing.Point(675, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 64);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sobel Edge Detection";
            // 
            // btn_edge
            // 
            this.btn_edge.Location = new System.Drawing.Point(163, 26);
            this.btn_edge.Name = "btn_edge";
            this.btn_edge.Size = new System.Drawing.Size(64, 21);
            this.btn_edge.TabIndex = 7;
            this.btn_edge.Text = "Combined";
            this.btn_edge.UseVisualStyleBackColor = true;
            this.btn_edge.Click += new System.EventHandler(this.btn_edge_Click);
            // 
            // btn_sobel_y
            // 
            this.btn_sobel_y.Location = new System.Drawing.Point(86, 26);
            this.btn_sobel_y.Name = "btn_sobel_y";
            this.btn_sobel_y.Size = new System.Drawing.Size(64, 21);
            this.btn_sobel_y.TabIndex = 6;
            this.btn_sobel_y.Text = "Horizontal";
            this.btn_sobel_y.UseVisualStyleBackColor = true;
            this.btn_sobel_y.Click += new System.EventHandler(this.btn_sobel_y_Click);
            // 
            // btn_sobel_x
            // 
            this.btn_sobel_x.Location = new System.Drawing.Point(6, 26);
            this.btn_sobel_x.Name = "btn_sobel_x";
            this.btn_sobel_x.Size = new System.Drawing.Size(64, 21);
            this.btn_sobel_x.TabIndex = 5;
            this.btn_sobel_x.Text = "Vertical";
            this.btn_sobel_x.UseVisualStyleBackColor = true;
            this.btn_sobel_x.Click += new System.EventHandler(this.btn_sobel_x_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackBar_overlap);
            this.groupBox5.Controls.Add(this.btn_edge_overlap);
            this.groupBox5.Location = new System.Drawing.Point(675, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 64);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edge Overlapping";
            // 
            // trackBar_overlap
            // 
            this.trackBar_overlap.Location = new System.Drawing.Point(6, 16);
            this.trackBar_overlap.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_overlap.Name = "trackBar_overlap";
            this.trackBar_overlap.Size = new System.Drawing.Size(141, 45);
            this.trackBar_overlap.TabIndex = 8;
            // 
            // btn_edge_overlap
            // 
            this.btn_edge_overlap.Location = new System.Drawing.Point(152, 20);
            this.btn_edge_overlap.Name = "btn_edge_overlap";
            this.btn_edge_overlap.Size = new System.Drawing.Size(75, 21);
            this.btn_edge_overlap.TabIndex = 7;
            this.btn_edge_overlap.Text = "Edge Overlapping";
            this.btn_edge_overlap.UseVisualStyleBackColor = true;
            this.btn_edge_overlap.Click += new System.EventHandler(this.btn_edge_overlap_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_select);
            this.groupBox6.Controls.Add(this.btn_registration);
            this.groupBox6.Location = new System.Drawing.Point(6, 276);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 50);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Image Registration";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(9, 20);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 21);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.Font = new System.Drawing.Font("宋体", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_registration.Location = new System.Drawing.Point(90, 20);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(75, 21);
            this.btn_registration.TabIndex = 7;
            this.btn_registration.Text = "Registration";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.btn_undo);
            this.groupBox7.Controls.Add(this.btn_save);
            this.groupBox7.Controls.Add(this.btn_load);
            this.groupBox7.Location = new System.Drawing.Point(6, 332);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(180, 78);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "function";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(90, 48);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(75, 21);
            this.btn_undo.TabIndex = 8;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(9, 48);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 21);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(9, 21);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 21);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(201, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(420, 13);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(250, 200);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(420, 217);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(250, 200);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btn_connect_comp);
            this.groupBox8.Location = new System.Drawing.Point(6, 220);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(180, 50);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Image Registration";
            // 
            // btn_connect_comp
            // 
            this.btn_connect_comp.Location = new System.Drawing.Point(9, 21);
            this.btn_connect_comp.Name = "btn_connect_comp";
            this.btn_connect_comp.Size = new System.Drawing.Size(156, 21);
            this.btn_connect_comp.TabIndex = 7;
            this.btn_connect_comp.Text = "Connect component";
            this.btn_connect_comp.UseVisualStyleBackColor = true;
            this.btn_connect_comp.Click += new System.EventHandler(this.btn_connect_comp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_extraction);
            this.Name = "Form1";
            this.Text = "DIP HW1";
            this.groupBox_extraction.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_threshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_overlap)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_extraction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_extractB;
        private System.Windows.Forms.Button btn_grayscale;
        private System.Windows.Forms.Button btn_extractG;
        private System.Windows.Forms.Button btn_extractR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_median_filter;
        private System.Windows.Forms.Button btn_mean_filter;
        private System.Windows.Forms.Button btn_histogram;
        private System.Windows.Forms.Button btn_threshold;
        private System.Windows.Forms.Button btn_edge;
        private System.Windows.Forms.Button btn_sobel_y;
        private System.Windows.Forms.Button btn_sobel_x;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_edge_overlap;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TrackBar trackBar_threshold;
        private System.Windows.Forms.TrackBar trackBar_overlap;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_connect_comp;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

