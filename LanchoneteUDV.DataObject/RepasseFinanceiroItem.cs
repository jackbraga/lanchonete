using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.DataObject
{
    public class RepasseFinanceiroItem
    {
        public string Produto { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public double SubTotal()
        {
            return this.PrecoUnitario * this.Quantidade;
        }

    }
}
