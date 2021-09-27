using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinaProjekt
{
	public partial class Form1 : Form
	{
		List<Saljare> saljareLista = new List<Saljare>();

		

		public Form1()
		{
			InitializeComponent();
		}

		private void btnLäggTill_Click(object sender, EventArgs e)
		{

			Saljare saljare = new Saljare();
			saljare.namn = tbxNamn.Text;
			saljare.personNummer = tbxPersonNr.Text;
			saljare.distrikt = tbxDistrikt.Text;
			saljare.antalArtiklar = int.Parse(tbxAntalArtiklar.Text);

			if (saljare.antalArtiklar < 50)
			{
				saljare.niva = 1; }
			else if (saljare.antalArtiklar > 50 && saljare.antalArtiklar < 100) {
				saljare.niva = 2;
			}

			else if (saljare.antalArtiklar > 100 &&  saljare.antalArtiklar < 200) {
				saljare.niva = 3;
			}
			else if (saljare.antalArtiklar > 199){
				saljare.niva = 4;
			}


			saljareLista.Add(saljare);


			tbxNamn.Clear();
			tbxPersonNr.Clear();
			tbxDistrikt.Clear();
			tbxAntalArtiklar.Clear();

		}

		private void btnResultat_Click(object sender, EventArgs e)
		{
			String rubrik = "Namn \t Personnummer \t Distrikt \t Antal Artiklar " + Environment.NewLine;

			tbxResultat.Text = ToString("Namn", "Personnummer", "Distrikt", "Antal Artiklar" + Environment.NewLine);

			Sortera(saljareLista);

			int niva = 0;
			int antal = 0;

			foreach (Saljare s in saljareLista)
			{

				if (s.niva != niva && antal != 0)
				{
					tbxResultat.AppendText( antal +" säljare har nått nivå: " + niva.ToString()+ Environment.NewLine);
					antal = 0;
				}

				niva = s.niva;
				antal++;

				string resultat = ToString(s.namn, s.personNummer, s.distrikt, s.antalArtiklar.ToString());
				tbxResultat.AppendText(resultat + Environment.NewLine);

			}

			if (antal != 0)
			{
				tbxResultat.AppendText(antal + " säljare har nått nivå: " + niva.ToString() + Environment.NewLine);
				antal = 0;
			}

		}

		public string ToString(string namn, string personNummer, string distrikt, string antalArtiklar)
		{
			return string.Format("{0,-25}{1,-15}{2,-15}{3,-10}", namn, personNummer, distrikt, antalArtiklar);
		}

		public class Saljare
		{
			public string namn;
			public string personNummer;
			public string distrikt;
			public int antalArtiklar;
			public int niva;

		}


		// metod för att sortera antal sålda artiklar
		public void Sortera(List<Saljare> antalLista)
		{
			int i, n;
			int length = antalLista.Count;
			Saljare temp;

			for (n = 1; n < length; n++)
			{
				temp = antalLista[n];
				i = n - 1;

				while (i >= 0 && antalLista[i].antalArtiklar > temp.antalArtiklar)
				{
					antalLista[i + 1] = antalLista[i];
					i--;
				}
				antalLista[i + 1] = temp;
			}
		}
	}
}
