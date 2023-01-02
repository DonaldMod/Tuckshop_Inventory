using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace Log_in_System
{
    public partial class MakeOrder : Form
    {
        Product Order;
        internal static List<Product> ProductList;
        public static string OrderIds, ProductName, Description, CustomerName;
        public static double Price, Total;
        public static int Quantity;


        public MakeOrder()
        {
            InitializeComponent();
        }


        private void txtorderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            String ulg;
            ulg = "ADMIN";
            frm_Home fh = new frm_Home(ulg);
            fh.Show();
            this.Close();
        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        public void Delete()
        {
            int Val = 0, Index = 90000000;

            OrderIds = txtOrderID.Text;

            
            foreach (var item in ProductList)
            {
                if (item.OrderID == txtOrderID.Text)
                {
                    Index = Val;
                    
                }
                Val++;
            }
            ProductList.RemoveAt(Index);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductList;

            MessageBox.Show("Delete Successful");
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Updates();
        }
        public void Updates()
        {
            int Value = 0, Index = 90000000;

            foreach (var item in ProductList)
            {
                if (item.OrderID == txtOrderID.Text)
                {
                    Index = Value;
                }
                Value++;
            }
            if (Index != 90000000)
            {
                Price = double.Parse(txtprice.Text);
                Quantity = int.Parse(txtquantity.Text);

                ProductList[Index].OrderID = txtOrderID.Text;
                ProductList[Index].NameOfProduct = txtProductName.Text;
                ProductList[Index].DescriptionOfProduct = txtdesciption.Text;
                ProductList[Index].NameOfCustomer = txtCustomer.Text;
                ProductList[Index].PriceOfProduct = Price;
                ProductList[Index].ProductQuantity = Quantity;
                ProductList[Index].TotalAmount = Price * Quantity;

                Total = Price * Quantity;
                tbxTotal.Text = Total.ToString();

                MessageBox.Show("Update was successfull, please refer to the All Orders Table");
            }
            else
            {
                MessageBox.Show("Product does not exist, please refer to the All Orders page to.");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductList;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DisplayOrder DO = new DisplayOrder();
            DO.Show();
            this.Close();
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            ProductList = new List<Product>();

            tbxTotal.Text = Total.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OrderCollection();
        }

        private void txtOrderID_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        public void OrderCollection()
        {
            OrderIds = txtOrderID.Text;
            ProductName = txtProductName.Text;
            Description = txtdesciption.Text;
            CustomerName = txtCustomer.Text;
            Price = double.Parse(txtprice.Text);
            Quantity = int.Parse(txtquantity.Text);
            Total = Price * Quantity;
            tbxTotal.Text = Total.ToString();

            Order = new Product(OrderIds, ProductName, Description, Price, Quantity, CustomerName, Total);
            ProductList.Add(Order);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductList;
        }
    }
}
