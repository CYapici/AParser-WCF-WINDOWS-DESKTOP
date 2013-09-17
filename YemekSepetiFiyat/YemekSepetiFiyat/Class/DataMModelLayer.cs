using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSepetiFiyat.Class
{
    public class DataMModelLayer
    {
        [BsonId]
        private ObjectId Idd { get; set; }

        public string productName { get; set; }
        public string productPrice { get; set; }
        public string productDescription { get; set; }
        public string productCompanyName { get; set; }
        public DateTime archiveDateAdded { get; set; }
        public string changedPriceField { get; set; }
    }

    public class DataMModelLayer1
    {
        [BsonId]
        private ObjectId Idd { get; set; }

        public string productName { get; set; }
        public string productPrice { get; set; }
        public string productDescription { get; set; }
        public string productCompanyName { get; set; }
        public DateTime archiveDateAdded { get; set; }
        public string changedPriceField { get; set; }
    }

}
