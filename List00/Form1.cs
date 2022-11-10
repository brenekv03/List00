using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //****************************************
        //Vytvoření instance seznamfilmu třídy List
        //List bude obsahovat řetězce
        
        List<string> seznamfilmu = new List<string>();    //Vytvořili jsme prázdný list řetězců, do seznamu budeme ukládat názvy filmů

        //*****************************************

        private void button1_Click(object sender, EventArgs e)
        {
            //Metoda Add
            //(Jako řetězec zadejte název filmu)
            seznamfilmu.Add("aa");
            seznamfilmu.Add("bbaa");
            seznamfilmu.Add("ccaa");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Počet prvků v kolekci - metoda Count

            listBox1.Items.Clear();
            // *** cyklem foreach ***
            foreach(string s in seznamfilmu)
            {
                listBox1.Items.Add(s);
            }

            // *** cyklem for - přes indexy ***
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //metoda Remove - odstraní první nalezený řetězec
            string film = textBox1.Text;
           if(!seznamfilmu.Remove(film))
            {
                MessageBox.Show("Zadaný film nenalezen");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clear

            seznamfilmu.Clear();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RemoveAt()
            int n = int.Parse(textBox2.Text);
            if (n< seznamfilmu.Count())
                seznamfilmu.RemoveAt(n);
            else MessageBox.Show("Zadany index neni");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Contains
            string prvek = textBox3.Text;
            if(seznamfilmu.Contains(prvek))
            {
                MessageBox.Show("obsahuje");
            }
            else
            {
                MessageBox.Show("neobsahuje");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //IndexOf
            string nazev = textBox4.Text;
            if(seznamfilmu.Contains(nazev))
            {
                MessageBox.Show("Index prvniho vyskytu filmu: " + seznamfilmu.IndexOf(nazev));
            }
            else
            {
                MessageBox.Show("Zadany film neni v seznamu");
            }
           
           
            //Pokud prvek v seznamu není, vrací metoda IndexOf() hodnotu -1
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //LastIndexOf

            //Pokud prvek není v List obsažen, vrátí index -1
            string nazev = textBox5.Text;
            if (seznamfilmu.Contains(nazev))
            {
                MessageBox.Show("index posledniho vyskytu filmu: " + seznamfilmu.LastIndexOf(nazev));
            }
            else
            {
                MessageBox.Show("Zadany film neni v seznamu");
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Distinct
            //Vrátí List s odlišnými prvky
            seznamfilmu = seznamfilmu.Distinct().ToList();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Insert
            int index = int.Parse(textBox7.Text);
            string film = textBox8.Text;
            if(index < seznamfilmu.Count())
            {
                seznamfilmu.Insert(index, film);
            }
            else
            {
                MessageBox.Show("Mimo hranice listu");
            }
       

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Count
            MessageBox.Show("Pocet filmů je: " + seznamfilmu.Count());
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //index píšene stejně jako u pole v hranatých závorkách
            //1. prvek má index 0
            int index = int.Parse(textBox9.Text);
            // MessageBox.Show(seznamfilmu.ElementAt(index));
            MessageBox.Show(seznamfilmu[index]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Sort
           seznamfilmu.Sort();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Reverse
            seznamfilmu.Reverse();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //AddRange
            List<string> novySeznam = seznamfilmu.Take(2).ToList();
            foreach (string film in novySeznam) MessageBox.Show(film);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string[] poleFilmu = new string[seznamfilmu.Count];
            seznamfilmu.CopyTo(poleFilmu);
            foreach (string film in poleFilmu) MessageBox.Show(film);
        }
    }
}
