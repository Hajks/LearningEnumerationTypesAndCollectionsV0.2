using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Card card = new Card((Suits)random.Next(4), (Values)random.Next(1,14)); //So we gonna take 1 of 4 possible types of cards, and then we gonna take random value of card for example "Five of Hearts"
            string cardName = card.Name;
            MessageBox.Show(cardName);
        }
    }
}
