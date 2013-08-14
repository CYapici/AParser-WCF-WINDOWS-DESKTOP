using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace testMONGODBFW35
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");
            var collection = database.GetCollection<Entity>("entities");

            var entity = new Entity { Name = "Tom" };
            collection.Insert(entity);
            var id = entity.Id;
          
            var query = Query<Entity>.EQ(r => r.Id, id);
            entity = collection.FindOne(query);

            Response.Write(entity.Name);
            //entity.Name = "Dick";
            //collection.Save(entity);

            //var update = Update<Entity>.Set(w => w.Name, "Harry");
            //collection.Update(query, update);

            //collection.Remove(query);

        }

        public class Entity
        {
            public ObjectId Id { get; set; }
            public string Name { get; set; }
        }

    }
}