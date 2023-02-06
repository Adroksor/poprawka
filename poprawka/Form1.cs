using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poprawka
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            GridLoad();
        }

        private void GridLoad()
        {
            using (var db = new ObslugaBazyDanych())
            {
                var query = from s in db.stanMagazynowy
                            join t in db.towar on s.ID_Towaru equals t.ID
                            select new
                {
                    t.ID,
                    t.Nazwa,
                    t.Jednostka,
                    s.Ilosc
                };

                GridView.DataSource = query.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Jednostki = new List<string>()
            {
                "Kg",
                "Gram",
                "Litr",
                "Metr"
            };
            foreach(string j in Jednostki)
            {
                ListaJednostek.Items.Add(j);
            }

        }

        private void DodajRekord_Click(object sender, EventArgs e)
        {
            using(var strukturaDanych = new ObslugaBazyDanych())
            {
                strukturaDanych.towar.Add(new Towar() {Nazwa = Nazwa.Text, Jednostka = ListaJednostek.SelectedItem.ToString(), });
                strukturaDanych.SaveChanges();

                strukturaDanych.stanMagazynowy.Add(new StanMagazynowy
                {

                    Ilosc = Convert.ToInt32(Ilosc.Text),
                    ID_Towaru = strukturaDanych.towar.Count()
                }) ;
                strukturaDanych.SaveChanges();
            }

            GridLoad();
        }


        //to na dole jest nie potrzebne
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
