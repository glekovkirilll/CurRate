namespace CurRate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buyButton = new System.Windows.Forms.Button();
            this.Bitcoin = new System.Windows.Forms.Label();
            this.dollars = new System.Windows.Forms.Label();
            this.daysIndicator = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityOfBitcoin = new System.Windows.Forms.NumericUpDown();
            this.continueButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.edDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityOfBitcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.Bitcoin);
            this.panel1.Controls.Add(this.dollars);
            this.panel1.Controls.Add(this.daysIndicator);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantityOfBitcoin);
            this.panel1.Controls.Add(this.continueButton);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.edDays);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 123);
            this.panel1.TabIndex = 0;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(554, 46);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(100, 28);
            this.buyButton.TabIndex = 16;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // Bitcoin
            // 
            this.Bitcoin.AutoSize = true;
            this.Bitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bitcoin.Location = new System.Drawing.Point(458, 74);
            this.Bitcoin.Name = "Bitcoin";
            this.Bitcoin.Size = new System.Drawing.Size(16, 17);
            this.Bitcoin.TabIndex = 15;
            this.Bitcoin.Text = "  ";
            // 
            // dollars
            // 
            this.dollars.AutoSize = true;
            this.dollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollars.Location = new System.Drawing.Point(458, 52);
            this.dollars.Name = "dollars";
            this.dollars.Size = new System.Drawing.Size(16, 17);
            this.dollars.TabIndex = 14;
            this.dollars.Text = "  ";
            // 
            // daysIndicator
            // 
            this.daysIndicator.AutoSize = true;
            this.daysIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysIndicator.Location = new System.Drawing.Point(458, 19);
            this.daysIndicator.Name = "daysIndicator";
            this.daysIndicator.Size = new System.Drawing.Size(16, 17);
            this.daysIndicator.TabIndex = 13;
            this.daysIndicator.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Валюта(₿):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Валюта($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дней прошло:";
            // 
            // quantityOfBitcoin
            // 
            this.quantityOfBitcoin.DecimalPlaces = 8;
            this.quantityOfBitcoin.Location = new System.Drawing.Point(554, 17);
            this.quantityOfBitcoin.Name = "quantityOfBitcoin";
            this.quantityOfBitcoin.Size = new System.Drawing.Size(100, 22);
            this.quantityOfBitcoin.TabIndex = 9;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(890, 13);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(100, 28);
            this.continueButton.TabIndex = 8;
            this.continueButton.Text = "Продолжить";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(782, 13);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 28);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "Пауза";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(674, 13);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(554, 82);
            this.sellButton.Margin = new System.Windows.Forms.Padding(4);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(100, 28);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Продать";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // edDays
            // 
            this.edDays.Location = new System.Drawing.Point(169, 65);
            this.edDays.Margin = new System.Windows.Forms.Padding(4);
            this.edDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.edDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edDays.Name = "edDays";
            this.edDays.Size = new System.Drawing.Size(129, 22);
            this.edDays.TabIndex = 3;
            this.edDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дней";
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(169, 22);
            this.edRate.Margin = new System.Windows.Forms.Padding(4);
            this.edRate.Maximum = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            this.edRate.Minimum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(129, 22);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс($)";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 50D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 123);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f2";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1011, 431);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 554);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityOfBitcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown edDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown quantityOfBitcoin;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label Bitcoin;
        private System.Windows.Forms.Label dollars;
        private System.Windows.Forms.Label daysIndicator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buyButton;
    }
}

