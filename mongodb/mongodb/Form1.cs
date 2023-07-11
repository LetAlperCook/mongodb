using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
namespace mongodb
{
    public partial class Form1 : Form
    {
        string username_input, password_input = "";
        string correct_username = "admin";
        string correct_password = "alperkaan3131";
        readonly MongoClient dbClient = new("mongodb+srv://admin:onur1234@lifttestdb.exgrjaw.mongodb.net/?retryWrites=true&w=majority");
        bool signedin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMongoDatabase db = dbClient.GetDatabase("KullanýcýDataBase");
            var builder = Builders<BsonDocument>.Filter;
            var col = db.GetCollection<BsonDocument>("Giris");
            var filter = builder.Empty;

            var kullaniciler = col.Find(filter).ToList();
            var kullanicilarArray=kullaniciler.ToArray();
            username_input = usernameTB.Text;
            password_input = passwordTB.Text;
            foreach (var kullanici in kullanicilarArray)
            {
                label1.Text = kullanici[1].ToString();
                label2.Text = kullanici[2].ToString();
                if (username_input.Equals(kullanici[1]) && password_input.Equals(kullanici[2]))
                {
                   
                    MessageBox.Show($"Hoþgeldiniz {username_input} Bey/Haným");
                    signedin = true;
                    break;
                }
            }


            if (!signedin) { MessageBox.Show("Hatalý Giriþ"); }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { passwordTB.UseSystemPasswordChar = true; }
            else { passwordTB.UseSystemPasswordChar = false; }
        }
    }
}