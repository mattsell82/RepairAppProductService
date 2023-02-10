using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ProduktService : IProduktService
    {
        public List<Produkter1> VisaAllaProdukter()
        {
            using (ProduktModell db = new ProduktModell())
            {
               List<Produkter1> ProduktLista1 = new List<Produkter1>();

               var ProduktLista = db.Produkter.ToList();

                foreach (var p in ProduktLista)
                {
                    Produkter1 tempprodukt = new Produkter1();
                    tempprodukt.Id = p.Id;
                    tempprodukt.Märke = p.Märke;
                    tempprodukt.Modell = p.Modell;
                    tempprodukt.Serienummer = p.Serienummer;
                    tempprodukt.Årsmodell = p.Årsmodell;
                    ProduktLista1.Add(tempprodukt);

                }
                return ProduktLista1;
            }
        }

        public Produkter1 VisaProdukt(int id) {
            using (ProduktModell db = new ProduktModell())
            {
                Produkter p = db.Produkter.Find(id);

                if (p is null)
                {
                    return null;
                }

                Produkter1 produkter1 = new Produkter1 { Id = p.Id, Märke = p.Märke, Modell = p.Modell, Serienummer = p.Serienummer, Årsmodell = p.Årsmodell };

                return produkter1;
            }
        }
    }
}
