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

        //Forma y�kleme yap�l�r(static metot gibi d���n)
        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerDal.getAll();
        }

        //Ekleme butonunda ne olaca��
        private void btnAddClick(object sender, EventArgs e)
        {
            customerDal.add(new Customer()
            {
                //�lgili nesneden; veriler tabloya veri t�r�ne g�re cast edilerek kaydedilir
                Name = txtName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Salary = Convert.ToInt32(txtSalary.Text)
            });
            //Formu kapatmadan direkt g�ncel hale eri�im
            dataGridView1.DataSource = customerDal.getAll();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgw'de yer alan oto y�klenen tablodaki sat�ra dokununca update nesnesine o t�klanan ki�ilere ait veriler yazd�r�ls�n

            //veriler dgwnin ilgili yerlerinden �a�r�l�r
            txtNameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAgeUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSalaryUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer()
            {
                //Id dgwden al�n�rken di�erleri update k�sm�ndan al�n�r b�ylece idye g�re g�ncelleme i�lemi ba�ar�l� �ekilde ger�ekle�ir


                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name = txtNameUpdate.Text,
                Age = Convert.ToInt32(txtAgeUpdate.Text),
                Salary = Convert.ToInt32(txtSalaryUpdate.Text)
            };
            customerDal.update(customer);
            MessageBox.Show("G�ncelleme ger�ekle�ti");
            dataGridView1.DataSource=customerDal.getAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Customer> ourList = customerDal.getAll();
            //Liste bo�sa eleman silinme eylemi hata vermesin diye kontrol sa�lan�r
            if (ourList.Count!=0)
            {
                //Id numaras� metoda g�nderilir
                customerDal.delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Ki�i silindi");
                //dgw'ye Tablonun g�ncel hali yazd�r�l�r
                dataGridView1.DataSource = customerDal.getAll();
            }
            else
            {
                MessageBox.Show("Liste zaten bo�");
            }
        }

    }
}