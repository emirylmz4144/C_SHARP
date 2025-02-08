using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CreateWiewScreeanOfAdoNet
{
    internal class CustomerDal
    {
        //Hangi veri tabanına bağlanacağız
        SqlConnection connection = new SqlConnection
            (@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        //DataGridView'e döndürülecek liste
        public List<Customer> getAll()
        {
            //Veri tabanına bağlantı yapılmışmı kontrolü
            ConnectionControl();

            //Sql komutu ile ne yapılacağı belirlenir(Customer'dan...)
            SqlCommand command = new SqlCommand("Select * from Customer",connection);
            
            //(...verileri oku) verilen komutun işlevlendirilmesi
           SqlDataReader reader= command.ExecuteReader();
           List<Customer> customers=new List<Customer>();

           //Verilerin listeye aktarılması
           while (reader.Read())
           {
               Customer customer = new Customer()
               {
                   Id = Convert.ToInt32(reader["Id"]),
                   Age = Convert.ToInt32(reader["Age"]),
                   Name = reader["Name"].ToString(),
                   Salary = Convert.ToInt32(reader["Salary"])
               };
               customers.Add(customer);
           }
           connection.Close();

           //Listenin dgw'ye döndürülmesi
           return customers;
        }

        public void add(Customer customer)
        {


           ConnectionControl();

           //Sql komutu ile ne yapılacağı belirlenir(Yeterince detaylıdır)
            SqlCommand command = new SqlCommand("Insert into Customer values(@name,@age,@salary)", connection);

            //Komuta atanan yer tutucu parametlerin(@name vs..) değerlerinin atanması
           command.Parameters.AddWithValue("@name", customer.Name);
           command.Parameters.AddWithValue("@age", customer.Age);
           command.Parameters.AddWithValue("@salary", customer.Salary);

           //Ardından komut okunur ve çalıştırılır
           command.ExecuteNonQuery();
           connection.Close();
        }

        public void update(Customer customer)
        {
            
            ConnectionControl();

            //Veri tabanında karşılaşacağı şeyler ve yer tutucu valueslerin atanması
            SqlCommand command = new SqlCommand("Update Customer set Name=@name,Age=@age,Salary=@salary where Id=@id",
                connection);

            //Yer tutucu values'lara gerçekte nereyi tutacağı bilgisi veriliyor
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@age", customer.Age);
            command.Parameters.AddWithValue("@salary", customer.Salary);
            command.Parameters.AddWithValue("@id", customer.Id);

            //Komut okunur ve çalıştırılır
            command.ExecuteNonQuery();

        }

        public void delete(int id)
        {
            
            
                ConnectionControl();

                //Komut verilir ve detaylandırılır
                SqlCommand command = new SqlCommand("Delete from Customer where Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);

                //Komut okunur ve çalıştırılır
                command.ExecuteNonQuery();
                
        }

        //Bağlantıyı kontrol eden metot
        private void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
