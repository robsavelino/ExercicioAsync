using System.Diagnostics;

namespace ExercicioAsync
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void lblOutPayCheck_Click(object sender, EventArgs e)
        {

        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            await CalculateAll();

        }
        private async Task CalculateAll()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            btnCalculate.Enabled = false;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "Calculando";


            var calcExpenses = CalculateExpenses();
            var calcTaxes = CalculateTaxes();
            var calcPayCheck = CalculatePaycheck();
            var calcRevenue = CalculateRevenue();

            await calcPayCheck;
            await calcTaxes;
            await calcRevenue;
            await calcExpenses;

            lblExpenses.Text = calcExpenses.Result;
            lblOutTaxes.Text = calcTaxes.Result;
            lblOutPayCheck.Text = calcPayCheck.Result;
            lblOutRevenue.Text = calcRevenue.Result;

            btnCalculate.Enabled = true;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Finalizado";

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}.{1:00} Segundos",
            ts.Seconds,
            ts.Milliseconds / 10);

            lblExecTime.Text = elapsedTime;
            
        }

        private async Task<string> CalculateTaxes()
        {
            await Task.Delay(1000);
            return "Resultado Impostos";

        }
        private async Task<string> CalculatePaycheck()
        {
            await Task.Delay(2000);
            return "Resultado Folha de Pagamento";
        }
        private async Task<string> CalculateRevenue()
        {
            await Task.Delay(3000);
            return "Resultado Receita";
        }
        private async Task<string> CalculateExpenses()
        {
            await Task.Delay(4000);
            return "Resultado Despesas";
        }

    }
}