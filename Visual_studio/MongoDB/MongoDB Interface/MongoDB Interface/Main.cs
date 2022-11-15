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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int id;
        int Time;
        string Name = "";
        string Date = DateTime.Today.ToString();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("TestDB");
            var coll = database.GetCollection<BsonDocument>("TestC");

            Timer.Start();
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

               while (true)
               {

                var coll2 = database.GetCollection<BsonDocument>("Security");
                var fil = Builders<BsonDocument>.Filter.Eq("_id", id);
                var filteredDocument = coll2.Find(fil).FirstOrDefault();
                if (filteredDocument == null)
                    {
                        var newDoc = new BsonDocument { { "_id", id }, { "Name", Name }, { "Time", Time }, { "Date", Date } };
                        coll.InsertOne(newDoc);
                    }
                    else { MessageBox.Show("ID already exists!"); }
                }
            }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            View.Items.Clear();
            View2.Items.Clear();
            View3.Items.Clear();
            if (MainSort.Text == "Dont sort")
            {

                //Dont sort just pull all results.
                var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                var client = new MongoClient(settings);
                var database = client.GetDatabase("TestDB");
                var coll = database.GetCollection<BsonDocument>("TestC");
                var Search = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Include("Series")).ToList();
                foreach (var OneDocument in Search)
                {
                    View.Items.Add(OneDocument.GetElement("_id").Value);
                    View2.Items.Add(OneDocument.GetElement("Name").Value);
                    View3.Items.Add(OneDocument.GetElement("Series").Value);
                }
            }
            else if (MainSort.Text == "Sort")
            {
                if (Direction.Text == "Ascending")
                {


                    //sort ascending other box variables.
                    var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
                    settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                    var client = new MongoClient(settings);
                    var database = client.GetDatabase("TestDB");
                    var coll = database.GetCollection<BsonDocument>("TestC");
                    var Sort = Builders<BsonDocument>.Sort.Ascending(Sorting.Text);
                    var Result = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Include("Series").Include(Sorting.Text)).Sort(Sort).ToList();
                    foreach (var OneDocument in Result)
                    {
                        View.Items.Add(OneDocument.GetElement("_id").Value);
                        View2.Items.Add(OneDocument.GetElement("Name").Value);
                        View3.Items.Add(OneDocument.GetElement("Series").Value);

                    }
                }
                else if (Direction.Text == "Descending")
                {
                    //sort Descending other box variables.
                    var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
                    settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                    var client = new MongoClient(settings);
                    var database = client.GetDatabase("TestDB");
                    var coll = database.GetCollection<BsonDocument>("TestC");
                    var Sort = Builders<BsonDocument>.Sort.Descending(Sorting.Text);
                    var Result = coll.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Include("Series").Include(Sorting.Text)).Sort(Sort).ToList();
                    foreach (var OneDocument in Result)
                    {
                        View.Items.Add(OneDocument.GetElement("_id").Value);
                        View2.Items.Add(OneDocument.GetElement("Name").Value);
                        View3.Items.Add(OneDocument.GetElement("Series").Value);
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time = Time +1;
        }

        private void View_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = View.SelectedIndex;
            View2.SelectedIndex = Index;
            View3.SelectedIndex = Index;
        }

        private void View2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = View.SelectedIndex;
            View.SelectedIndex = Index;
            View3.SelectedIndex = Index;
        }

        private void View3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = View.SelectedIndex;
            View2.SelectedIndex = Index;
            View.SelectedIndex = Index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = int.Parse(View.Text);
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1); var client = new MongoClient(settings);
            var database = client.GetDatabase("TestDB");
            var coll = database.GetCollection<BsonDocument>("TestC");
            String Name = View2.Text;
            String Series = View3.Text;
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

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            IDT.Text = View.Text;
            NameT.Text = View2.Text;
            SeriesT.Text = View3.Text;
        }

        private void Update2_Click(object sender, EventArgs e)
        {
            id = int.Parse(View.Text);
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1); var client = new MongoClient(settings);
            var database = client.GetDatabase("TestDB");
            var coll = database.GetCollection<BsonDocument>("TestC");
            String Name = NameT.Text;
            String Series = SeriesT.Text;
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

        private void Remove_Click(object sender, EventArgs e)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://root:1234@cluster0.0nscevn.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("TestDB");
            var coll = database.GetCollection<BsonDocument>("TestC");
            int id = int.Parse(IDT.Text);
            if (id == null)
            {
                MessageBox.Show("ID not found!");
            }
            var fil_1 = Builders<BsonDocument>.Filter.Eq("_id", id);
            coll.DeleteOne(fil_1);
            MessageBox.Show("Deleting was a succes.");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Takes to add form
            this.Hide();
            Add frm2 = new Add();
            frm2.ShowDialog();
        }
    }
    }