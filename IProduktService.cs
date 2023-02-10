using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProduktService
    {

        [OperationContract]
        List<Produkter1> VisaAllaProdukter();

        [OperationContract]
        Produkter1 VisaProdukt(int id);  
      
    }
    [DataContract]

    public partial class Produkter1
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Märke { get; set; }
        [DataMember]
        public string Modell { get; set; }
        [DataMember]
        public int? Serienummer { get; set; }
        [DataMember]
        public DateTime? Årsmodell { get; set; }
    }



}
