using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgwProducts.CellClick += DgwProducts_CellClick;
        }

        ProductDal productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void DgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameU.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceU.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountU.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = productDal.GetAll();
        }

        private List<Product> SearchProducts(string key)
        {
            // dgwProducts.DataSource = productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
            // ^ Küçük büyük harf duyarlı olduğundan aradığımız ve anahtar kelimleri küçülterek arıyoruz. ds pd'da
            return productDal.GetByName(key);
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
            productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Deleted");
            LoadProducts();
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource = SearchProducts(((TextBox)sender).Text);
        }
    }
}
