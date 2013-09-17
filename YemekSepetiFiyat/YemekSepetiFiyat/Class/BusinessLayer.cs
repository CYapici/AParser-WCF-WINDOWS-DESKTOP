using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSepetiFiyat.Class;

namespace YemekSepetiFiyat.Class
{
    public class BusinessLayer : IDisposable
    {
        public event EventHandler Disposed;

        public void Dispose()
        {
            if (this.Disposed != null)
                this.Disposed(this, EventArgs.Empty);
        }
        public int r = 0;

        

        public void insertData( string productCompanyName, string productDescription, string productName, string productPrice, string changedPriceState)
        {
            using (DataAccessLayer cs= new DataAccessLayer())
            {
                var collection1 = cs.returnCollection("priceTable", false);
                try
                {
                    collection1.Insert(new DataMModelLayer { archiveDateAdded = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 0, 0, 0), productCompanyName = productCompanyName, productDescription = productDescription, productName = productName, productPrice = productPrice, changedPriceField = changedPriceState });
                    r++;
                }
                catch (Exception ex)
                {
 
                }
            }
      

        }
        public bool ping()
        {
            try
            {
                var connectionString = "mongodb://192.168.202.42:27017/";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();

                server.Ping();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public IEnumerable<DataMModelLayer> getData()
        {

            using (DataAccessLayer cs = new DataAccessLayer())
            {
                var collection1 = cs.returnCollection("priceTable", false);
                // collection1.RemoveAll();
                try
                {

                    // collection1.RemoveAll();
                    //    collection1.Insert(new DataMModelLayer { IDM = 1, archiveDateAdded = DateTime.Now, productCompanyName = "mc", productDescription = "doner+kola+may", productName = "mc menu", productPrice = "12.99" });
                    var list = collection1.FindAllAs<DataMModelLayer>().Reverse().ToList();
                    return list;

                }
                catch (Exception ex)
                {

                    return null;
                }

            }
        }


        public List<DataMModelLayer> getDataToCompare()
        {


            using (DataAccessLayer cs = new DataAccessLayer())
            {
                var collection1 = cs.returnCollection("priceTable", false);
                // collection1.RemoveAll();
                try
                {


                    var list = collection1.FindAllAs<DataMModelLayer>().Reverse().Where(r => r.archiveDateAdded < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1, 23, 59, 59) && r.archiveDateAdded > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1, 00, 00, 00)).ToList();
                    return list;

                }
                catch (Exception ex)
                {

                    return null;
                }

            }
        }

        public bool testRow()
        {
            using (DataAccessLayer cs = new DataAccessLayer())
            {
                bool result = false;
                var collection1 = cs.returnCollection("priceTable", false);

                try
                {


                    var list = collection1.FindAllAs<DataMModelLayer>().Reverse().ToList();
                    result = true;
                    return result;
                }
                catch (Exception ex)
                {

                    return result;
                }
            }

        }
        public void formatTheCollection()
        {
            using (DataAccessLayer cs = new DataAccessLayer())
            {
                var collection1 = cs.returnCollection("priceTable", false);
                collection1.RemoveAll();
            }
        }

        public IEnumerable<DataMModelLayer> getByNameOrDate(string name, DateTime startdate, DateTime enddate, bool getByDate)
        {

            if (getByDate)
            {

                var tempData = getData().Where(p => p.archiveDateAdded <= enddate && p.archiveDateAdded >= startdate).ToList();
                return tempData;
            }

            else
            {
                try
                {

                    var containsName = getData().Where(p => p.productName.ToLower().Contains(name.ToLower()));

                    return containsName.ToList();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

    }
}

//var connectionString = "mongodb://localhost";
//            var client = new MongoClient(connectionString);
//            var server = client.GetServer();
//            var database = server.GetDatabase("test");
//            var collection = database.GetCollection<Entity>("entities");

//            var entity = new Entity { Name = "Tom" };
//            collection.Insert(entity);
//            var id = entity.Id;

//            var query = Query<Entity>.EQ(r => r.Id, id);
//            entity = collection.FindOne(query);

//            MessageBox.Show(entity.Name);
//            //entity.Name = "Dick";
//            //collection.Save(entity);

//            //var update = Update<Entity>.Set(w => w.Name, "Harry");
//            //collection.Update(query, update);

//            //collection.Remove(query);

