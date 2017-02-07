using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Alex Pauli
 * Purpose: The purpose of this program is to allow a user to select an amount of US dollars and convert the amount
 * to any other currency of their choosing. The program gets up-to-date exchange rate information from a website, which
 * is brought in a JSON data files.
 */
namespace CurrencyConversionProject
{
    public partial class CurrencyCalculatorForm : Form
    {
        private Dollar dollar = null;
        private CurrencyRate currencyRate = null;
        private const string EXCHANGE_RATES_URL = "https://openexchangerates.org/api/latest.json?app_id=d3a15d6e5bc74ae6a23a09e7fa71cbd3";
        private const string CURRENCY_NAME_URL = "https://openexchangerates.org/api/currencies.json?app_id=d3a15d6e5bc74ae6a23a09e7fa71cbd3";
        private Dictionary<string, string> currencyNames = new Dictionary<string, string>();

        public CurrencyCalculatorForm()
        {
            InitializeComponent();
        }

        //JSON data is obtained and deserialized when the form loads. This data is used to populate the list view.
        private void CurrencyCalculatorForm_Load(object sender, EventArgs e)
        {
            PopulateListBox();
            try
            {
                ExchangeServiceAccessor exchangeRate = new ExchangeServiceAccessor(EXCHANGE_RATES_URL);
                CountryCodesToRates countryCodesToRates = exchangeRate.deserializeJson<CountryCodesToRates>();
                PopulateCurrencyNames();
                PopulateListView(countryCodesToRates.Rates);                
            }
            catch(Exception theException)
            {
                MessageBox.Show(theException.Message);
            }
        }

        private void PopulateListBox()
        {
            dollarListBox.Items.AddRange(new Dollar[] { new Dollar(1), new Dollar(5), new Dollar(10), new Dollar(20),
                new Dollar(50), new Dollar(100)});
        }

        //Method PopulateListView() populates the list view with items tagged as CurrencyRate objects.
        private void PopulateListView(Dictionary<string, decimal> ratesDictionary)
        {
            foreach(KeyValuePair<string, decimal> rate in ratesDictionary)
            {
                CurrencyRate currencyRate = new CurrencyRate(currencyNames[rate.Key], Math.Round(rate.Value, 2));
                ListViewItem item = new ListViewItem(new string[] { currencyRate.CurrencyName, currencyRate.Rate.ToString("N") });
                item.Tag = currencyRate;
                codesToRatesListView.Items.Add(item);
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal conversionResult = CurrencyCalculator.GetConversion(dollar, currencyRate);
                conversionOutputLabel.Text = $"{dollar.Value} US dollars = {conversionResult.ToString("N")} {currencyRate.CurrencyName}.";
            }
            catch(DollarException theException)
            {
                MessageBox.Show(theException.Message);
            }
            catch (CurrencyRateException theException)
            {
                MessageBox.Show(theException.Message);
            }
        }

        private void dollarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dollarListBox.SelectedIndex >= 0)
            {
                dollar = (Dollar)dollarListBox.SelectedItem;
            }
        }

        private void codesToRatesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(codesToRatesListView.SelectedItems.Count > 0)
            {
                int itemIndex = codesToRatesListView.FocusedItem.Index;
                currencyRate = (CurrencyRate)codesToRatesListView.Items[itemIndex].Tag;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            codesToRatesListView.SelectedIndices.Clear();
            codesToRatesListView.EnsureVisible(0);
            dollarListBox.SetSelected(0, true);
            dollarListBox.SetSelected(0, false);
            conversionOutputLabel.ResetText();
            dollar = null;
            currencyRate = null;
        }

        private void PopulateCurrencyNames()
        {
            ExchangeServiceAccessor exchangeNames = new ExchangeServiceAccessor(CURRENCY_NAME_URL);
            currencyNames = exchangeNames.deserializeJson<Dictionary<string, string>>();
        }
    }
}
