using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3
{
    public partial class FormTypeOfPartners : Form
    {
        private DbPartnersContext db;
        public FormTypeOfPartners()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new DbPartnersContext();
            this.db.TypesOfPartners.Load();
            this.dataGridViewType.DataSource = this.db.TypesOfPartners.Local.OrderBy(o => o.TypeOfPartner).ToList();
            dataGridViewType.Columns["Id"].Visible = false;

            dataGridViewType.Columns["TypeOfPartner"].HeaderText = "Тип партнера";
            dataGridViewType.Columns["Partners"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }
        private void FormTypeOfPartners_Load(object sender, EventArgs e)
        {

        }

        private void buttonTypeAdd_Click(object sender, EventArgs e)
        {
            FormAddTypeOfPartners formAddType = new FormAddTypeOfPartners();
            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            TypesOfPartner typeOfPartner = new TypesOfPartner();
            typeOfPartner.TypeOfPartner = formAddType.textBoxTypeName.Text;

            db.TypesOfPartners.Add(typeOfPartner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewType.DataSource = this.db.TypesOfPartners.Local.OrderBy(O => O.TypeOfPartner).ToList();
        }
    }
}
