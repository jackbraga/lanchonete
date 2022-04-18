//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LanchoneteUDV.DataObject
//{
//    public class RepasseFinanceiroDTO
//    {
//        public RepasseFinanceiroDTO()
//        {
//            this.Itens = new List<RepasseFinanceiroItem>();
//        }
//        public DateTime DataEscala { get; set; }
//        public string DescricaoEscala { get; set; }

//        public string Nome { get; set; }

//        public string PrimeiroNome()
//        {
//            var primeiroNome = this.Nome.Split(' ');
//            return primeiroNome[0];
//        }

//        public List<RepasseFinanceiroItem> Itens = new List<RepasseFinanceiroItem>();

//        public double Total { get; set; }
//    }
//}
