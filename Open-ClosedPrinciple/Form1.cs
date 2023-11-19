using static Open_ClosedPrinciple.Prodoct;

namespace Open_ClosedPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductType2 pT = new ProductType2();
            pT.Name = "peoduct1";
            pT.Price = 100000;


            MessageBox.Show(pT.GetDiscount().ToString());
        }
    }
}
