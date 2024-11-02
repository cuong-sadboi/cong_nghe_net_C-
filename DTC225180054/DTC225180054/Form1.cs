namespace DTC225180054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new DTC225180054Context())
            {
                var product = context.Productss.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (product != null)
                {
                    context.Productss.Remove(product);
                    int ret = context.SaveChanges();
                    if (ret != 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                }
            }
            btnLoadData.PerformClick();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new DTC225180054Context())
            {
                var products = context.Productss.ToList();
                grvData.DataSource = products;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new DTC225180054Context())
            {
                var product = new Product
                {
                    //Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                };
                context.Productss.Add(product);
                int ret = context.SaveChanges();
                if (ret != 0)
                {
                    MessageBox.Show("Them moi thanh cong");
                    btnLoadData.PerformClick();
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new DTC225180054Context())
            {
                var product = context.Productss.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (product != null)
                {
                    product.Name = txtName.Text;
                    product.Price = decimal.Parse(txtPrice.Text);
                    product.Quantity = int.Parse(txtQuantity.Text);
                    product.Description = txtDescription.Text;
                    context.SaveChanges();
                }
            }
            btnLoadData.PerformClick();
        }

        private void grvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grvData.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = grvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = grvData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = grvData.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = grvData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void grvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
