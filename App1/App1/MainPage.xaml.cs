using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           InitializeComponent();
        }

        private void aumento(object sender, EventArgs e)
        {
            int conteo = int.Parse(contador.Text);
            
            conteo++;

            string conteo2 = conteo.ToString();

            contador.Text = conteo2;
        }
    }
}
