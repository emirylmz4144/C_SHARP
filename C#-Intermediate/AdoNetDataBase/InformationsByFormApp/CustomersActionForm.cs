namespace CreateWiewScreeanOfAdoNet
{
    public partial class CustomersActionForm : Form
    {
        CustomerDal customerDal = new CustomerDal();

        //Form initiliaze edilir
        public CustomersActionForm()
        {
            InitializeComponent();
        }

        //Forma yükleme yapýlýr(static metot gibi düþün)
        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerDal.getAll();
        }

        //Ekleme butonunda ne olacaðý
        private void btnAddClick(object sender, EventArgs e)
        {
            customerDal.add(new Customer()
            {
                //Ýlgili nesneden; veriler tabloya veri türüne göre cast edilerek kaydedilir
                Name = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Salary = Convert.ToInt32(txtSalary.Text)
            });
            //Formu kapatmadan direkt güncel hale eriþim
            dataGridView1.DataSource = customerDal.getAll();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgw'de yer alan oto yüklenen tablodaki satýra dokununca update nesnesine o týklanan kiþilere ait veriler yazdýrýlsýn

            //veriler dgwnin ilgili yerlerinden çaðrýlýr
            txtNameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAgeUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSalaryUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer()
            {
                //Id dgwden alýnýrken diðerleri update kýsmýndan alýnýr böylece idye göre güncelleme iþlemi baþarýlý þekilde gerçekleþir


                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = txtNameUpdate.Text,
                Age = Convert.ToInt32(txtAgeUpdate.Text),
                Salary = Convert.ToInt32(txtSalaryUpdate.Text)
            };
            customerDal.update(customer);
            MessageBox.Show("Güncelleme gerçekleþti");
            dataGridView1.DataSource=customerDal.getAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Customer> ourList = customerDal.getAll();
            //Liste boþsa eleman silinme eylemi hata vermesin diye kontrol saðlanýr
            if (ourList.Count!=0)
            {
                //Id numarasý metoda gönderilir
                customerDal.delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Kiþi silindi");
                //dgw'ye Tablonun güncel hali yazdýrýlýr
                dataGridView1.DataSource = customerDal.getAll();
            }
            else
            {
                MessageBox.Show("Liste zaten boþ");
            }
        }

    }
}