using BeautySalonCRM;
using Mariya.Data;
using Microsoft.EntityFrameworkCore;

namespace Mariya
{
    public partial class FormVisit : Form
    {
        SalonContext context;
        public FormVisit()
        {
            context = new SalonContext();
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Группа: НМТ-133901 ; ФИО: Патракеева Мария Андреевна");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddVisit();
            var dialogResult = form.ShowDialog();
            visitBindingSource.DataSource = context.Visits.ToList();
        }

        private void Visit_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add("Патракеева", "Коваленко", "Светлана", "Маникюр", "19:30", "19.20.2002");
            //dataGridView1.Rows.Add("Новикова", "Шавкунова", "Алана", "Наращивание ресниц", "16:30", "19.20.2002");
            //dataGridView1.Rows.Add("Жилина", "Курбанова", "Юля", "Стрижка", "12:30", "19.20.2002");

            context.Visits.Load();
            visitBindingSource.DataSource = context.Visits.Local.ToBindingList();

            context.Masters.Load();
            masterBindingSource.DataSource = context.Masters.Local.ToBindingList();

            context.Clients.Load();
            clientBindingSource.DataSource = context.Clients.Local.ToBindingList();

            context.Services.Load();
            serviceBindingSource.DataSource = context.Services.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filteredVisits = context.Visits
            .Join(context.Masters,
           visit => visit.MasterId,
           master => master.Id,
           (visit, master) => new { visit, master })
            .Join(context.Clients,
           vm => vm.visit.ClientId,
           client => client.Id,
           (vm, client) => new { vm.visit, vm.master, client })
            .Join(context.Services,
           vmc => vmc.visit.ServiceId,
           service => service.Id,
           (vmc, service) => new
           {
               vmc.visit.Id,
               MasterSurname = vmc.master.Surname,
               ClientSurname = vmc.client.Surname,
               ServiceName = service.Name,
               vmc.visit.Time,
               vmc.visit.Status
           })
     .Where(v => (string.IsNullOrEmpty(textBoxMaster.Text) ||
                  v.MasterSurname.ToLower().Contains(textBoxMaster.Text) ||
                  v.ClientSurname.ToLower().Contains(textBoxMaster.Text) ||
                  v.ServiceName.ToLower().Contains(textBoxMaster.Text)))
     .ToList();

            visitBindingSource.DataSource = filteredVisits;
            dataGridView1.DataSource = visitBindingSource;
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Service();
            form.Show();

        }
        private void buttonMasterTable_Click(object sender, EventArgs e)
        {
            var form = new Master();
            form.Show();

        }
        private void buttonClientsTable_Click(object sender, EventArgs e)
        {
            var form = new FormClients();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormChart();
            form.Show();
        }
    }
}