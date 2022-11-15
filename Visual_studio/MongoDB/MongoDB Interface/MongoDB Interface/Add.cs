using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDB_Interface
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }


        int id;

        private void button2_Click(object sender, EventArgs e)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings); var database = client.GetDatabase("TestDB");
            var coll = database.GetCollection<BsonDocument>("TestC");
            var Search = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Include("Series")).ToList();
            foreach (var OneDocument in Search)
            {
                TestID.Items.Add(OneDocument.GetElement("_id").Value);
            }
            int Lenght = TestID.Items.Count;
            for (int i = 0; i < Lenght; i++)
            {
                if (id == int.Parse(TestID.Text))
                {
                    id = id + 1;
                }
            }
            //Take the values from AName and ASeries and add 
            String name = AName.Text;
            String Series = ASeries.Text;
            var fil = Builders<BsonDocument>.Filter.Eq("_id", id);
            var filteredDocument = coll.Find(fil).FirstOrDefault();
            if (filteredDocument == null)
            {
                var newDoc = new BsonDocument { { "_id", id }, { "Name", name }, { "Series", Series } };
                coll.InsertOne(newDoc);
            }
            else { MessageBox.Show("ID already exists!"); }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frm2 = new Main();
            frm2.ShowDialog();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Updating_Click(object sender, EventArgs e)
        {
            //Take the values from AName and ASeries and update
            {
                var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
                settings.ServerApi = new ServerApi(ServerApiVersion.V1); var client = new MongoClient(settings);
                var database = client.GetDatabase("TestDB");
                var coll = database.GetCollection<BsonDocument>("TestC");
                String Name = AName.Text;
                String Series = ASeries.Text;
                var fil1 = Builders<BsonDocument>.Filter.Eq("_id", id);
                var filteredDocument = coll.Find(fil1).FirstOrDefault();
                if (filteredDocument == null)
                {
                    MessageBox.Show("ID not found!");
                }
                else
                {
                    var fil = Builders<BsonDocument>.Filter.Eq("_id", id);
                    var update = Builders<BsonDocument>.Update.Set("Name", Name).Set("Series", Series);
                    coll.UpdateOne(fil, update); MessageBox.Show("Documents updated.");
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //Remove function
            {
                var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                var client = new MongoClient(settings);
                var database = client.GetDatabase("TestDB");
                var coll = database.GetCollection<BsonDocument>("TestC");
                int id = int.Parse(ID.Text);
                if (id == null)
                {
                    MessageBox.Show("ID not found!");
                }
                var fil_1 = Builders<BsonDocument>.Filter.Eq("_id", id);
                coll.DeleteOne(fil_1);
                MessageBox.Show("Deleting was a succes."); }
        }
    }
}

