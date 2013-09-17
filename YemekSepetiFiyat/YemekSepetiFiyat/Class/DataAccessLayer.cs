using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSepetiFiyat.Class
{
    public class DataAccessLayer:IDisposable
    {
        public event EventHandler Disposed;

        public void Dispose()
        {
            if (this.Disposed != null)
                this.Disposed(this, EventArgs.Empty);
        }

        public MongoDatabase connectToServerAndReturnDB()
        {


            try
            {
                var connectionString = "mongodb://192.168.202.42:27017/";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();

                var database = server.GetDatabase("myDB");

                return database;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string ping()
        {


            try
            {
                var connectionString = "mongodb://192.168.202.42:27017/";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();

                server.Ping();

                return "ping";
            }
            catch (Exception ex)
            {

               return "";
            }
        }

        public MongoCollection returnCollection(string tableName, bool wantToCreate)
        {
            var _db = connectToServerAndReturnDB();
            if (wantToCreate)
            {

                _db.CreateCollection(tableName);
                return (null);
            }

            else
            {
                try
                {
                    var colleciton = _db.GetCollection<DataMModelLayer>(tableName); //bura generic olabilir
                    return colleciton;
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }


        }


        //try
        //{

        //    var database = server.GetDatabase("myDB");
        //    database.CreateCollection("priceTable")s;
        //    int m = 2;

        //   // var colleciton = database.GetCollection("test");

        //    //var data = colleciton.FindAll().ToList();
        //    //foreach (var item in data)
        //    //{
        //    //    MessageBox.Show(item.Values.Skip(1).First().ToString());
        //    //}
        //    //colleciton.Insert(new customcagatayclass { Name = "dominosPizza" });
        //    //colleciton.Insert(new customcagatayclass { Name = "sofware" });
        //    //colleciton.Insert(new customcagatayclass { Name = "development" });

        //}


    }


}
