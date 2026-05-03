using TradingSystem.Models;
using TradingSystem.Services;

namespace TradingSystem
{
    public partial class Form1 : Form
    {
        private readonly ITradesService _tradeService;
        private readonly IPositionCalculationService _positionCalService;
        public Form1(ITradesService tradeService, IPositionCalculationService positionCalService)
        {
            InitializeComponent();
            _tradeService = tradeService;
            _positionCalService = positionCalService;
            cmbPortfolio.Items.AddRange(new[]
            {
                        "",
                        "Growth Fund",
                         "Income Fund",
                        "Pension Fund"
            });

            cmbState.Items.AddRange(new[]
            {
                    "",
                    "New",
                    "Confirmed",
                    "Booked",
                    "Settled",
                    "Cancelled"
            });
            cmbType.Items.AddRange(new[]
               {
                    "",
                    "Buy",
                    "Sell",
                    "Transfer",
                    "Dividend",
                    "Fee"
                });
            cmbPortfolio.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }

        private async void btnGetTrades_Click(object sender, EventArgs e)
        {
            var filter = new TradeFilter
            {
                DateFrom = dtpDateFrom.Value.Date,
                DateTo = dtpDateTo.Value.Date,

                Security = string.IsNullOrWhiteSpace(txtBoxSecurity.Text) ? null : txtBoxSecurity.Text.Trim(),

                Portfolio = string.IsNullOrWhiteSpace(cmbPortfolio.Text) ? null : cmbPortfolio.Text,

                TradeState = string.IsNullOrWhiteSpace(cmbState.Text) ? null : cmbState.Text,

                TradeTypeDescription = string.IsNullOrWhiteSpace(cmbType.Text) ? null : cmbType.Text
            };

            var filteredTradesList = await _tradeService.GetFilteredTrades(filter);

            try
            {
                if (!filteredTradesList.Any())
                {
                    MessageBox.Show("No trades found.");
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredTradesList;
            }

            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Apie request failed: {ex.Message}");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Request timed out");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"unexpected exception: {ex.Message}");
            }

        }

        private async void btnConfirmTrade_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("no rows were seleted");
                return;
            }
            var selectedRow = dataGridView1.SelectedRows[0];

            var tradeNo = selectedRow.Cells["TradeNo"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(tradeNo))
            {
                MessageBox.Show("Trade is empty");
                return;
            }
            var res = await _tradeService.ConfirmTrade(tradeNo);

            if (!res.success)
            {
                MessageBox.Show(res.error);
            }


            dataGridView1.Refresh();
        }

        private async void btnCalPos_Click(object sender, EventArgs e)
        {
            var isin = txtBoxIsinCal.Text;
            var portfolio = txtBoxPortfolioCal.Text;
            var trades = await _tradeService.GetTradesForCalculations(portfolio, isin);


            var calculationResults = _positionCalService.Calculate(trades);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = trades;
            // call callculation service
            Console.WriteLine(  );
        }
    }
}
