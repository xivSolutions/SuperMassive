using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinnookDb;
using SuperMassive;


namespace DataServiceExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var newCustomer = new Customer { FirstName = "John", LastName = "Atten", Company = "xivSolutions", Email = "xivSolutions@gmail.com" };
            this.insertCustomer(newCustomer);
            var customers = this.getCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} ID: {2}", customer.FirstName, customer.LastName, customer.CustomerId);
            }
        }

        IEnumerable<Customer> getCustomers()
        {
            var tbl = new DynamicModel("ChinookDb", "Customer", "CustomerId");
            return tbl.All<Customer>();
        }


        void insertCustomer(Customer customer)
        {
            var tbl = new DynamicModel("ChinookDb", "Customer", "CustomerId");
            tbl.Insert(customer);
        }
    }
}
