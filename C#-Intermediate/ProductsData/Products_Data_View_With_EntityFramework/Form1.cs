namespace Products_Data_View_With_EntityFramework
{
    public partial class Form1 : Form
    {
        private ProductDal productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        //Form Yüklenir Yüklenmez ne olacaðý
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            //data grid view'in data kaynaðý productDalda List dönen getAll metodudur
            dgwProducts.DataSource = productDal.getAll();
        }
       
        //Data Grid View'de bir hücreye týklayýnca ne olacak
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cells[0] Id ye denk gelir
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.addProduct(
                new Product()
                {
                    Name = txtName.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    StockAmount=Convert.ToInt32(txtStockAmount.Text)
                });
            LoadProducts();
            MessageBox.Show("Ürün Eklendi");
        }

        
        //Yukarýdaki ile aynýdýr tek fark vardýr
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productDal.updateProduct(new Product()
            {
                /*Hangi kullanýcýyý deðiþtireceðimiz dgw'den alýnan ýd bilgisi ile yapýlýr bu yüzden id hücrelerden alýnýp deðiþtirilmez dgw'de var olan id ile atama yapýlýr*/
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtNameUpdate.Text,
                Price = Convert.ToInt32(txtPriceUpdate.Text),
                StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün Güncellendi");
        }

        //Silme iþleminde sadece dgw'den gelen id ile kullanýcý bulunup silinir
        private void btnDelete_Click(object sender, EventArgs e)
        {
            productDal.deleteProduct(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Ürün Silindi");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearch.Text);
        }

        
      
        private void SearchProducts(string key)
        {
            /*Bu yöntem ile veri tabanı bağlantısı sağlanır liste alınır ve ardından
             veri tabanı kapanır filtreleme işlemi ise veri tabanından dönen liste 
            üzerinde yapılır bu da 2 iş anlamına gelip oldukçca performanssız iş anlamına gelmektedir.

            dgwProducts.DataSource = productDal
                                    .getAll()
                                    .Where((p) => p.Name.ToLower().Contains(key.ToLower())).ToList(); */

            /*
             Burada ise veri tabanına erişilir ve filtreleme işlemi veri tabanında yapılır
            bu durum ise oldukça performanslı işlemler yapıldığına göstergedir.
            nedenini merak ediyosan bu işlemin ProductDal sınıfındaki metoduna bak
             */ 
           dgwProducts.DataSource= productDal.getAllByName(key);
        }
    }
}
