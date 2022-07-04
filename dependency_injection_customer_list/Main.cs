using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
// https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
// https://docs.microsoft.com/en-us/dotnet/core/extensions/generic-host

namespace DL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            _repo = (IRepo<Customer>)Program.ServiceProvider.GetService(typeof(IRepo<Customer>));
        }
        private IRepo<Customer> _repo;

        /// <summary>
        /// A binding list will notify DGV when data changes
        /// </summary>
        public BindingList<Customer> Customers { get; } = new BindingList<Customer>();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dataGridViewCust.DataSource = Customers;

            foreach (var customer in _repo.GetAllMock())
            {
                Customers.Add(customer);
            }
            foreach (DataGridViewColumn column in dataGridViewCust.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
