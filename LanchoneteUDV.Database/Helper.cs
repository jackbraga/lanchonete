using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV
{
    public class Helper
    {
        public void Habilita(params Object[] objetos)
        {

            foreach (Control item in objetos)
            {
                item.Enabled = true;
                item.BackColor = Color.White;
            }
        }

        public void Desabilita(params Object[] objetos)
        {

            foreach (Control item in objetos)
            {
                item.Enabled = false;
                item.BackColor = Color.LightYellow;
            }
        }

        public void ValidaComZero(params Object[] objetos)
        {

            foreach (Control item in objetos)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    item.Text = "0";
                }
            }
        }

    }
}
