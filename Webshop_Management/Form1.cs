using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop_Management {
    public partial class From_Management : Form {

        List<Product> productList = new List<Product>();
        int SelectedRadioButton = 0; //0 = Save changes; 1 = Remove

        public From_Management() {
            InitializeComponent();
        }

        /**
         * Ein neues Produkt kann erzeugt werden.
         * Dabei stehen dem Benutzer Eingaben für den Namen des Produkts, einer Produktbeschreibung und der Anzahl der verfügbaren Produkte zur Verfügung.
         * Der Name des Produkts ist eine Pflichteingabe. Leere Produktnamen werden nicht akzeptiert.
         * Die Eingabe einer Beschreibung oder einer Anzahl ist optional. Allerdings wird vor dem Speichern gefragt, ob das Produkt ohne Beschreibung, bzw. ohne
         * Anzahl erzeugt werden soll. 
         * Wenn ein Produkt ohne Anzahl erzeugt wird, wird diese automatisch auf 0 gesetzt.
         * Negative Werte für die Anzahl sind nicht zulässig. Auf Abfrage wird die Anzahl dann auf 0 gesetzt.
         */
        private void btnSaveNewItem_Click(object sender, EventArgs e) {
            try {

                DialogResult result = DialogResult.Yes;

                //Die einzelnen Fälle, wie die Felder befüllt sein können, werden abgefragt.
                //Entsprechend den leeren Feldern wird eine Abfrage durch eine Messagebox durchgeführt.
                //Z.B. muss ein Name immer vorhanden sein, während eine Beschreibung oder Anzahl optional ist.
                if (this.tbxNewItemName.Text == "") {
                    MessageBox.Show("Bitte einen Namen für das Produkt eingeben.", "Fehler", MessageBoxButtons.OK);
                    result = DialogResult.No;
                } else if (this.rtbxNewItemDescription.Text == "" && this.tbxNewAmount.Text == "") {
                    result = MessageBox.Show("Möchten Sie das Produkt ohne Beschreibung und ohne Anzahl speichern? Die Anzahl wird dabei auf 0 gesetzt.", "Warnung", MessageBoxButtons.YesNo);
                } else if (this.rtbxNewItemDescription.Text == "") {
                    result = MessageBox.Show("Möchten Sie das Produkt ohne Beschreibung speichern?", "Warnung", MessageBoxButtons.YesNo);
                } else if (this.tbxNewAmount.Text == "") {
                    result = MessageBox.Show("Möchten Sie das Produkt ohne Anzahl speichern? Die Anzahl wird dabei auf 0 gesetzt.", "Warnung", MessageBoxButtons.YesNo);
                } else if (Convert.ToInt32(this.tbxNewAmount.Text) < 0) {
                    result = MessageBox.Show("Negative Mengen sind nicht zulässig. Soll die Anzahl auf 0 gesetzt werden?", "Fehler", MessageBoxButtons.YesNo);
                }

                //Wenn der Name vorhanden ist, werden die übrigen Fälle abgefragt. Die Produkte werden entsprechend erzeugt und in der Liste angehangen.
                if (result == DialogResult.Yes) {

                    //Anzahl und Beschreibung fehlen; nur Produktname wird eingegeben.
                    if (this.rtbxNewItemDescription.Text == "" && tbxNewAmount.Text == "") {
                        productList.Add(new Product(tbxNewItemName.Text));
                        //Anzahl fehlt; Produktname und Beschreibung wird eingegeben.
                    } else if (tbxNewAmount.Text == "" || (Convert.ToInt32(tbxNewAmount.Text) < 0)) {
                        productList.Add(new Product(tbxNewItemName.Text, this.rtbxNewItemDescription.Text));
                        //Beschreibung fehlt; Produktname und Anzahl wird eingegeben.
                    } else if (rtbxNewItemDescription.Text == "") {
                        productList.Add(new Product(tbxNewItemName.Text, Convert.ToInt32(tbxNewAmount.Text)));
                        //Alles vorhanden; Produktname, Beschreibung und Anzahl wird eingegeben.
                    } else {
                        productList.Add(new Product(tbxNewItemName.Text, rtbxNewItemDescription.Text, Convert.ToInt32(tbxNewAmount.Text)));
                    }

                    //Das erzeugte Produkt wird in einem Buffer gespeichert.
                    //Die Felder für das neue Produkt werden geleert.
                    //Die Liste wird sortiert. Nach der Sortierung wird der Index des vorher erzeugten Produkts aus der Liste anhand des Buffers gesucht.
                    //Der Auswahlindex der ListBox wird entsprechend gesetzt; --> Das neue Produkt wird automatisch ausgewählt.
                    Product buffer = productList.Last();

                    tbxNewItemName.Text = "";
                    rtbxNewItemDescription.Text = "";
                    tbxNewAmount.Text = "";
                    FillItemList();

                    var selectIndex = productList.IndexOf(buffer);
                    lstbxItems.SelectedIndex = selectIndex;
                }

            }
            catch (FormatException) {
                MessageBox.Show("Bitte einen gültigen Wert als Anzahl eingeben.", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void tbnSave_Click(object sender, EventArgs e) {

        }

        /**
         * Beim Wechsel des ausgewählten Elements der ListBox werden die Daten (Name, Beschreibung, Anzahl) des neuen ausgewählten Eintrags in die entsprechenden
         * Felder des Ausgewählten Produkts übertragen.
         * Da beim Löschen eines Produkts ggf. der SelectIndex einen ungültigen Wert erreichen kann, wird dann der Index auf 0 gesetzt.
         */
        private void lstbxItems_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                this.tbxSelectedItemName.Text = (productList.ElementAt(this.lstbxItems.SelectedIndex)).Name;
                this.rtbxSelectedItemDescription.Text = (productList.ElementAt(this.lstbxItems.SelectedIndex)).Description;
                this.tbxSelectedAmount.Text = "" + (productList.ElementAt(this.lstbxItems.SelectedIndex)).Anzahl;
            }
            catch (IndexOutOfRangeException) {
                this.lstbxItems.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) {
                this.lstbxItems.SelectedIndex = 0;
            }
        }

        private void rbtnSaveChanges_CheckedChanged(object sender, EventArgs e) {

        }

        private void rbtnRemoveItem_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnIncreaseSelectedAmount_Click(object sender, EventArgs e) {

        }

        private void btnReduceSelectedAmount_Click(object sender, EventArgs e) {

        }

        /**
         * Die Produktliste wird mit der Sortiermethode der Klasse List sortiert (siehe produktliste.Sort()).
         * Die ListBox wird geleert und die sortierte Produktliste wird in die ListBox eingetragen.
         */
        private void FillItemList() {
            this.lstbxItems.Items.Clear();
            productList.Sort((x, y) => x.Name.CompareTo(y.Name));

            //Einbinden der sortierten Liste in die ListBox.
            for (int i = 0; i < productList.Count; i++) {
                Product aktuellesProdukt = productList.ElementAt(i);
                this.lstbxItems.Items.Add(aktuellesProdukt.Name);
            }
        }
    }
}
