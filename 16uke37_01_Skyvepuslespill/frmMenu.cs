using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMenu : Form
    {

        int size;           //Antall brikker langs hver side i spillet
        string path = "";   //Filplassering til bilde
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)   // Metoden er lånt av Arne Wallerud. Den viser en dialogboks der man kan veget et bilde man vil bruke i spillet.
        {
            {
                OpenFileDialog filePathDialog = new OpenFileDialog();   //Lager en ny "OpenFileDialog"
                filePathDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff" +
                "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|";        // Angi filtyper det skal være mulig å velge.
                filePathDialog.Title = "Velg bilde";        //Legger til overskrift i FileDialog-vinduet
                if (filePathDialog.ShowDialog() == DialogResult.OK)     //Viser filePathDialog-dialogboksen. Hvis lastingen av bilde var vellykket:
                {
                    try     //(prøv) Gjør dette:
                    {
                        path = filePathDialog.FileName;     //Legg inn filepath til det valgte bildet i variabelen path.
                        pic1.Image = Image.FromFile(path);  //Legg det valgte bildet inn i den lille pictureboksen.(forhåndsvisning)
                    }
                    catch (Exception)   //Hvis dette ikke går:
                    {
                        MessageBox.Show("Feil under lasting av bilde");     //Vis en messagebox med meldingen: "Feil under lasting av bilde". 
                        throw;
                        //Dette gjør at man ikke får en feilmelding som stopper programmet.
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)     //Metoden åpner et nytt vindu og sender med spillstørrelse, koordinater og filplassering.
        {
            size = Convert.ToInt32(numSize.Text);       
            int size0 = size - 1;                       // size0 er antall brikker langs hver side - 1. Det må trekkes fra en, fordi 0 også er en verdi.
            Point missingPiece;                         //Koordinatene til den manglende brikken.

            switch (cmbMissing.Text)                    //Velger koordinater til den manglende brikken. Det sjekkes hvilken tekst som er valgt, og det gis derretter en verdi til variabelen missingpiece av datatypen point, som brukes som koordinater for den manglende brikken. Siden det bare kan velges hjørner eller brikken i midten, trenger koorinatene bare å inneholde tallene 0, size0 og size0/2.
            {
                case "Senter":
                    missingPiece = new Point(size0 / 2, size0 / 2);
                    break;
                case "Nede til høyre":
                    missingPiece = new Point(size0, size0);
                    break;
                case "Nede til venstre":
                    missingPiece = new Point(0, size0);
                    break;
                case "Oppe til høyre":
                    missingPiece = new Point(size0, 0);
                    break;
                case "Oppe til venstre":
                default:
                    missingPiece = new Point(0, 0);
                    break;
            }
            frmGame frmgame = new frmGame(size, missingPiece, path);      //Starter "game" og sender med verdier til constructor-metoden.
            frmgame.ShowDialog();                                   // Viser det nye vinduet.
        }
    }
}
