using GHIElectronics.DUELink;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace StockTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {

            var availablePort = DUELinkController.GetConnectionPort();
            var httpClient = new HttpClient();
            var dev = new DUELinkController(availablePort);
            int index = 0;
            //Array of stocks to track and target price
            //string[] stock = {stockSymbol1.ToString() , stockSymbol2.ToString(), stockSymbol3.ToString(), stockSymbol4.ToString(), stockSymbol5.ToString()};
            //double[] target = { double.Parse(targetPrice1.Text), double.Parse(targetPrice2.Text), double.Parse(targetPrice3.Text), double.Parse(targetPrice4.Text), double.Parse(targetPrice5.Text) };

            string[] stock = new string[5];
            double[] target = new double[5];

            stock[0] = stockSymbol1.Text;
            target[0] = double.Parse(targetPrice1.Text);
            stock[1] = stockSymbol2.Text;
            target[1] = double.Parse(targetPrice2.Text);
            stock[2] = stockSymbol3.Text;
            target[2] = double.Parse(targetPrice3.Text);
            stock[3] = stockSymbol4.Text;
            target[3] = double.Parse(targetPrice4.Text);
            stock[4] = stockSymbol5.Text;
            target[4] = double.Parse(targetPrice5.Text);


            while (true)
            {
                for (int i = 0; i < stock.Length; i++)
                {
                    dev.Display.Clear(0);
                    var url = "https://finnhub.io/api/v1/quote?symbol=" + stock[i] + "&token=cat09eiad3icrc16c4l0";
                    var json = await httpClient.GetStringAsync(url);
                    var data = JsonDocument.Parse(json);
                    var stockQuote = data.RootElement.GetProperty("c");

                    if (stockQuote.GetDouble() > target[i])
                    {
                        dev.System.Beep('p', 500, 500);
                        dev.System.Beep('p', 200, 500);
                        dev.Led.Set(100, 100, 4);
                        dev.Display.DrawTextScale("^" + stockQuote.ToString(), 1, 0, 30, 3, 3);
                    }
                    else
                    {
                        dev.Display.DrawTextScale(stockQuote.ToString(), 1, 0, 30, 3, 3);
                        dev.System.Beep('p', 200, 5);
                    }
                    dev.Display.DrawTextScale(stock[i], 1, 0, 0, 3, 3);
                    dev.Display.Show();
                    Thread.Sleep(1200);
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = button1_ClickAsync(sender, e);

        }
    }
}