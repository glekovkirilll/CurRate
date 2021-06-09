using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        const double k = 0.02;
        double currentPrice;
        double moneyInDollars = 1000000;
        double soldPrice;
        double moneyInBitcoin;
        double quantity;
        int days;
        int currentDay = 1;

        Random random = new Random();

        private void startButton_Click(object sender, EventArgs e)
        {
            
            currentPrice = (double)edRate.Value;
            days = (int)edDays.Value;

            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.Series[0].Points.AddXY(0, currentPrice);

            timer1.Start();

            for (int day = 1; day <= days; day++)
            {
                
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentDay <= days)
            {
                currentPrice = currentPrice * (1 + k * (random.NextDouble() - 0.5));
                chart1.Series[0].Points.AddXY(currentDay, currentPrice);
                currentDay++;
            }
            else
                timer1.Stop();

            InformationOutput();
        }

        private void InformationOutput()
        {
            daysIndicator.Text = $"{currentDay}";
            dollars.Text = $"{moneyInDollars}";
            Bitcoin.Text = $"{moneyInBitcoin}";            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            quantity = (double)quantityOfBitcoin.Value;
            if (quantity <= (moneyInDollars / currentPrice))
            {
                moneyInDollars = moneyInDollars + quantity * currentPrice;
                moneyInBitcoin = moneyInBitcoin - quantity;
                

                chart1.Series[0].Points[currentDay - 2].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                chart1.Series[0].Points[currentDay - 2].MarkerSize = 8;
                chart1.Series[0].Points[currentDay - 2].MarkerColor = Color.LimeGreen;

            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            quantity = (double)quantityOfBitcoin.Value;
            if (quantity <= (moneyInDollars / currentPrice))
            {
                moneyInDollars = moneyInDollars - quantity * currentPrice;
                moneyInBitcoin = moneyInBitcoin + quantity;
                soldPrice = currentPrice;

                chart1.Series[0].Points[currentDay - 2].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                chart1.Series[0].Points[currentDay - 2].MarkerSize = 8;
                chart1.Series[0].Points[currentDay - 2].MarkerColor = Color.SandyBrown;

            }
        }
    }
}
