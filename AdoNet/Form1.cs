using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = productDal.GetAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            productDal.Add(new Product
            {
                Name = tbxName.Text.ToString(),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Added");
            LoadProducts();
        }

        private void DgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameU.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceU.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountU.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameU.Text.ToString(),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceU.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountU.Text)
            });
            MessageBox.Show("Updated");
            LoadProducts();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            productDal.Delete(Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value));
            MessageBox.Show("Deleted");
            LoadProducts();
        }
    }
}
