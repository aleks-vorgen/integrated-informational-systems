using lab1.ExchangeRateAPI.Adapter;
using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class ExchangeRate : Form
    {
        public ExchangeRate()
        {
            InitializeComponent();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            PBExchangeRateAdapter pb = new PBExchangeRateAdapter();
            MBExchangeRateAdapter mb = new MBExchangeRateAdapter();

            addColumns();

            foreach (var item in pb.GetExchangeRates())
            {
                dataCurrencyTable.Rows.Add("privatbank", item.GetCcy(), item.GetBuy(), item.GetSale());
            }
            if (mb.GetExchangeRates() != null)
            {
                foreach (var item in mb.GetExchangeRates())
                {
                    dataCurrencyTable.Rows.Add("monobank", item.GetCurrencyCodeA(), item.GetRateBuy(), item.GetRateSell());
                }
            }
        }

        private void dataCurrencyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addColumns()
        {
            dataCurrencyTable.Rows.Clear();
            dataCurrencyTable.Columns.Clear();
            dataCurrencyTable.Columns.Add("ResourceColumn", "Resource");
            dataCurrencyTable.Columns.Add("CurrencyColumn", "Currency");
            dataCurrencyTable.Columns.Add("PurchaseColumn", "Purchase");
            dataCurrencyTable.Columns.Add("SaleColumn", "Sale");
        }
    }
}
