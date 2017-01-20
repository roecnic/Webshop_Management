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
                if (tbxNewItemName.Text == "") {
                    MessageBox.Show("Bitte einen Namen für das Produkt eingeben.", "Fehler", MessageBoxButtons.OK);
                    result = DialogResult.No;
                } else if (rtbxNewItemDescription.Text == "" && tbxNewAmount.Text == "") {
                    result = MessageBox.Show("Möchten Sie das Produkt ohne Beschreibung und ohne Anzahl speichern? Die Anzahl wird dabei auf 0 gesetzt.", "Warnung", MessageBoxButtons.YesNo);
                } else if (rtbxNewItemDescription.Text == "") {
                    result = MessageBox.Show("Möchten Sie das Produkt ohne Beschreibung speichern?", "Warnung", MessageBoxButtons.YesNo);
                } else if (tbxNewAmount.Text == "") {
                    result = MessageBox.Show("Möchten Sie das Produkt ohne Anzahl speichern? Die Anzahl wird dabei auf 0 gesetzt.", "Warnung", MessageBoxButtons.YesNo);
                } else if (Convert.ToInt32(tbxNewAmount.Text) < 0) {
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

        /**
         * Es kann ausgewählt werden, ob das Produkt gelöscht werden soll, oder ob die Änderungen, die in den Feldern für das ausgewählte Produkt vorgenommen wurden,
         * gespeichert werden sollen.
         * 
         * Beim Speichern der Änderungen wird überprüft, ob die Eingaben korrekt sind (Name vorhanden; Anzahl >= 0).
         * Ggf. wird eine entsprechende Fehlermeldung ausgegeben.
         * Wenn alle Eingaben korrekt sind, werden die Änderungen gespeichert. Die Liste wird dann neu sortiert und das geänderte Produkt bleibt ausgewählt.
         * 
         * Wird ein Produkt gelöscht, wird es aus der Liste entfernt.
         * Die Liste wird dann neu sortiert und ausgegeben.
         * Es wird dann kein anderes Produkt automatisch ausgewählt.
         */
        private void tbnSave_Click(object sender, EventArgs e) {
            try {

                if (lstbxItems.SelectedIndex >= 0) {

                    //Auswahl, welcher Button gedrückt ist (0 = Produkt bearbeiten; 1 = Produkt entfernen).
                    switch (this.SelectedRadioButton) {
                        case 0:

                            DialogResult resultChange = DialogResult.No;

                            //Überprüfung, ob die angegebene Anzahl immer noch größer als 0 ist.
                            //Wenn nicht, wird angeboten, die Anzahl auf 0 zu ändern.
                            if (Convert.ToInt32(tbxSelectedAmount.Text) < 0) {
                                resultChange = MessageBox.Show("Negative Menggen sind nicht zulässig. Soll die Anzahl stattdessen auf 0 gesetzt werden?", "Fehler", MessageBoxButtons.YesNo);
                                if (resultChange == DialogResult.Yes) {
                                    tbxSelectedAmount.Text = "" + 0;
                                }
                                //Überprüfung, ob der Produktname noch vorhanden ist. Wenn nicht, wird ausgegeben, dass ein Name eingegeben werden muss.
                            } else if (tbxSelectedItemName.Text != "") {
                                resultChange = MessageBox.Show("Möchten Sie die Änderungen speichern?", "Warnung", MessageBoxButtons.YesNo);
                            } else {
                                MessageBox.Show("Bitte geben Sie einen Namen für das Produkt ein.", "Fehler", MessageBoxButtons.OK);
                                resultChange = DialogResult.No;
                            }

                            //Das aktuelle Produkt wird in einer Buffer-Instanz gespeichert, damit es nachher in der Liste wieder gefunden werden kann, falls sich der
                            //Name des Produkts geändert hat.
                            Product buffer = productList.ElementAt(lstbxItems.SelectedIndex);

                            if (resultChange == DialogResult.Yes) {
                                (productList.ElementAt(lstbxItems.SelectedIndex)).Name = tbxSelectedItemName.Text;
                                (productList.ElementAt(lstbxItems.SelectedIndex)).Description = rtbxSelectedItemDescription.Text;
                                (productList.ElementAt(lstbxItems.SelectedIndex)).Anzahl = Convert.ToInt32(tbxSelectedAmount.Text);
                            }

                            //Die Liste wird neu sortiert und das Produkt, das vorher in der Buffer-Instanz gespeichert wurde, wird ausgewählt.
                            FillItemList();
                            lstbxItems.SelectedIndex = productList.IndexOf(buffer);

                            break;

                        case 1:

                            DialogResult resultRemove = MessageBox.Show("Möchten Sie den ausgewählten Eintrag wirklich löschen?", "Warnung", MessageBoxButtons.YesNo);

                            //Das Produkt wird aus der Liste gelöscht.
                            //Der Auswahlknopf wird auf "Änderungen speichern" zurück gesetzt, damit nicht versehentlich ein weiteres Produkt gelöscht wird.
                            if (resultRemove == DialogResult.Yes) {
                                productList.RemoveAt(lstbxItems.SelectedIndex);
                                SelectedRadioButton = 0;
                                rbtnRemoveItem.Checked = false;
                                rbtnSaveChanges.Checked = true;

                                tbxSelectedAmount.Text = "";
                                rtbxSelectedItemDescription.Text = "";
                                tbxSelectedItemName.Text = "";

                                FillItemList();
                            }

                            break;
                    }

                } else {
                    MessageBox.Show("Bitte einen Eintrag auswählen.", "Fehler", MessageBoxButtons.OK);
                }

            }
            catch (FormatException) {
                MessageBox.Show("Bitte einen gültigen Wert als Anzahl eingeben.", "Fehler", MessageBoxButtons.OK);
            }
            catch (ArgumentOutOfRangeException) {
                //
            }
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
