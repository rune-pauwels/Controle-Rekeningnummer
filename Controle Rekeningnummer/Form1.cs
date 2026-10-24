using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Controle_Rekeningnummer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*=======Analyse Functie 1 (isCorrectRekeningnummer)======

*1. Invoer: Welke invoer mag je verwachten voor jouw controlefunctie? Geef zowel een naam/beschrijving als een datatype.
        een IBAN nummer - string
*
*2a. Bewerking: Hoe ga je bepalen of de invoer correct is qua vorm? Welke reguliere expressie ga je hiervoor gebruiken?
        ^BE[0-9]{2} [0-9]{4} [0-9]{4} [0-9]{4}$
*       gebeurt als de functie isCorrecteVorm wordt opgeroepen

*2b.  Hoe ga je bepalen of de invoer correct is qua inhoud ? Hoe bepaal je de laatste 12 cijfers en daarvan de eerste 10 en de laatste 2? Welke stappen ga je hiervoor doorlopen (en welke functies gebruik je hiervoor)?
        place spatie met niks
        laatste 12 = substring(4, 12)
        eerste 10 = substring(0, 10)
        laatste 2 = substring(10, 2)
        als rest na deling van eerste 10 door 97 = laatste 2 is dan is de inhoud correct
*

*3. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
        true or false - bool
*

*4.  Naamgeving: Welke naam ga je deze functie geven?
        isCorrectRekeningnummer
*

*=======Analyse Functie 2 (omzettingNaarOudFormaat)======

*1. Invoer: Welke invoer mag je verwachten voor jouw omzettingsfunctie? Geef zowel een naam/beschrijving als een datatype.
        een iban nummer - string
*
*2a. Bewerking: Hoe ga je bepalen of de invoer een correct IBAN nummer is?
        door te kijken of de iscorrect functie true of false is
*

*2b. Hoe ga je de invoer omzetten? Hoe bepaal je de laatste 12 cijfers en hoe ga je deze in de 'oude' notatie zetten?
        replace spatie met niks
        laatste 12 = substring(4, 12)
        eerste 3 = substring(0, 3)
        middelste 7 = substring(3, 7)
        laatste 2 = substring(10, 2)
        oudenotatie = eerste3 + " " + middelste7 + " " + laatste2
* 

*3a. Uitvoer: Welke uitvoer zal de functie geven? Geef zowel een naam/beschrijving als een datatype.
        een rekeningnummer in de oude notatie - string
*

*3b. Wat ga je uitgeven als de invoer geen correct IBAN nummer was?
        een message box
*

*4.  Naamgeving: Welke naam ga je deze functie geven?
        omzettingNaarOudFormaat
*

*==========Testdata=========
*5. Testdata: Verzin en noteer (of zoek op internet) testgegevens voor alle mogelijke gevallen. Zo weet je of je oefening klopt.
        BE68 5390 0754 7034 true
        BE68539007547034 false
        NL68 5390 0754 7034 false
        BE68 5390 0754 7034 => 539 0075470 34
*

*===========================*/
        private void button1_Click(object sender, EventArgs e)
        {
            string IBANnummer = Convert.ToString(IBANTextBox.Text);
            bool IsCorrectRekeningNummer = isCorrectRekeningnummer(IBANnummer);
            if (IsCorrectRekeningNummer)
            {
                JuistOfFoutLabel.Text = "Juist";
                JuistOfFoutLabel.ForeColor = System.Drawing.Color.Green;
            }
            else 
            {
                JuistOfFoutLabel.Text = "Fout";
                JuistOfFoutLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IBANnummer = Convert.ToString(IBANTextBox.Text);
            bool IsCorrectRekeningNummer = isCorrectRekeningnummer(IBANnummer);
            if (IsCorrectRekeningNummer)
            {
                string OudeNotatie = omzettingNaarOudFormaat(IBANnummer);
                OudeNotatieTextBox.Text = OudeNotatie;
            }
            else
            {
                MessageBox.Show("Dit IBANnummer is niet geldig!", "IBANnummer niet geldig...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool isCorrectRekeningnummer(string IBANnummer)
        {
            bool IsRegexJuist = isCorrecteVorm(IBANnummer);
            if (IsRegexJuist)
            {
                string IBANnummerNoSpatie = IBANnummer.Replace(" ", "");
                string laatste12 = IBANnummerNoSpatie.Substring(4, 12);
                long eerste10 = Convert.ToInt64(laatste12.Substring(0, 10));
                int laatste2 = Convert.ToInt32(laatste12.Substring(10, 2));
                return ((eerste10 % 97) == laatste2);
            }
            else
            {
                return false;
            }
        }


        private string omzettingNaarOudFormaat(string IBANnummer)
        {
            string IBANnummerNoSpatie = IBANnummer.Replace(" ", "");
            string laatste12 = IBANnummerNoSpatie.Substring(4, 12);
            string eerste3 = laatste12.Substring(0, 3);
            string middelste7 = laatste12.Substring(3, 7);
            string laatste2 = laatste12.Substring(10, 2);
            return eerste3 + "-" + middelste7 + "-" + laatste2;
        }

        private bool isCorrecteVorm(string IBANnummer)
        {
            string IBANnummerPatroon = @"^BE[0-9]{2} [0-9]{4} [0-9]{4} [0-9]{4}$";
            return Regex.IsMatch(IBANnummer, IBANnummerPatroon);
        }
    }
}
