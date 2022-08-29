using System.Collections.Generic;
using Wisej.Web;


namespace WiseyAdressbuch
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.einfuegenT1 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.textBoxEMail = new Wisej.Web.TextBox();
            this.textBoxOrganisation = new Wisej.Web.TextBox();
            this.textBoxTelefonnummer = new Wisej.Web.TextBox();
            this.textBoxNachname = new Wisej.Web.TextBox();
            this.textBoxVorname = new Wisej.Web.TextBox();
            this.textBoxTitel = new Wisej.Web.TextBox();
            this.textBoxAnrede = new Wisej.Web.TextBox();
            this.textBoxID = new Wisej.Web.TextBox();
            this.EMailAdresse = new Wisej.Web.Label();
            this.Organisation = new Wisej.Web.Label();
            this.Telefonnummer = new Wisej.Web.Label();
            this.Nachname = new Wisej.Web.Label();
            this.Vorname = new Wisej.Web.Label();
            this.Titel = new Wisej.Web.Label();
            this.Anrede = new Wisej.Web.Label();
            this.ID = new Wisej.Web.Label();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.einfuegenT2 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
            this.textBoxWebseite = new Wisej.Web.TextBox();
            this.textBoxTelefon = new Wisej.Web.TextBox();
            this.textBoxAdresse = new Wisej.Web.TextBox();
            this.textBoxFirmenname = new Wisej.Web.TextBox();
            this.Webseite = new Wisej.Web.Label();
            this.Telefon = new Wisej.Web.Label();
            this.Adresse = new Wisej.Web.Label();
            this.Firmenname = new Wisej.Web.Label();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.window1BindingSource = new Wisej.Web.BindingSource(this.components);
            this.window1BindingSource1 = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.window1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(17, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new Wisej.Web.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.tabControl1.Size = new System.Drawing.Size(1032, 417);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.KeyDown += new Wisej.Web.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.einfuegenT1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(0, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1030, 374);
            this.tabPage1.Text = "tabPage1";
            // 
            // einfuegenT1
            // 
            this.einfuegenT1.Location = new System.Drawing.Point(946, 37);
            this.einfuegenT1.Name = "einfuegenT1";
            this.einfuegenT1.Size = new System.Drawing.Size(68, 32);
            this.einfuegenT1.TabIndex = 5;
            this.einfuegenT1.Text = "Einfügen";
            this.einfuegenT1.Click += new System.EventHandler(this.einfuegen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(946, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Suchen";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxEMail, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOrganisation, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTelefonnummer, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNachname, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVorname, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAnrede, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EMailAdresse, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.Organisation, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Telefonnummer, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Nachname, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Vorname, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Titel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Anrede, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(702, 37);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEMail.TabIndex = 15;
            this.textBoxEMail.TextChanged += new System.EventHandler(this.textBoxEMail_TextChanged);
            // 
            // textBoxOrganisation
            // 
            this.textBoxOrganisation.Location = new System.Drawing.Point(582, 37);
            this.textBoxOrganisation.Name = "textBoxOrganisation";
            this.textBoxOrganisation.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrganisation.TabIndex = 14;
            this.textBoxOrganisation.TextChanged += new System.EventHandler(this.textBoxOrganisation_TextChanged);
            // 
            // textBoxTelefonnummer
            // 
            this.textBoxTelefonnummer.Location = new System.Drawing.Point(467, 37);
            this.textBoxTelefonnummer.Name = "textBoxTelefonnummer";
            this.textBoxTelefonnummer.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelefonnummer.TabIndex = 13;
            this.textBoxTelefonnummer.TextChanged += new System.EventHandler(this.textBoxTelefonnummer_TextChanged);
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(355, 37);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 22);
            this.textBoxNachname.TabIndex = 12;
            this.textBoxNachname.TextChanged += new System.EventHandler(this.textBoxNachname_TextChanged);
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(243, 37);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(100, 22);
            this.textBoxVorname.TabIndex = 11;
            this.textBoxVorname.TextChanged += new System.EventHandler(this.textBoxVorname_TextChanged);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(131, 37);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitel.TabIndex = 10;
            this.textBoxTitel.TextChanged += new System.EventHandler(this.textBoxTitel_TextChanged);
            // 
            // textBoxAnrede
            // 
            this.textBoxAnrede.Location = new System.Drawing.Point(67, 37);
            this.textBoxAnrede.Name = "textBoxAnrede";
            this.textBoxAnrede.Size = new System.Drawing.Size(58, 22);
            this.textBoxAnrede.TabIndex = 9;
            this.textBoxAnrede.TextChanged += new System.EventHandler(this.textBoxAnrede_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(3, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(58, 22);
            this.textBoxID.TabIndex = 8;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // EMailAdresse
            // 
            this.EMailAdresse.AutoSize = true;
            this.EMailAdresse.Location = new System.Drawing.Point(702, 3);
            this.EMailAdresse.Name = "EMailAdresse";
            this.EMailAdresse.Size = new System.Drawing.Size(85, 15);
            this.EMailAdresse.TabIndex = 7;
            this.EMailAdresse.Text = "EMailAdresse";
            // 
            // Organisation
            // 
            this.Organisation.AutoSize = true;
            this.Organisation.Location = new System.Drawing.Point(582, 3);
            this.Organisation.Name = "Organisation";
            this.Organisation.Size = new System.Drawing.Size(78, 15);
            this.Organisation.TabIndex = 6;
            this.Organisation.Text = "Organisation";
            // 
            // Telefonnummer
            // 
            this.Telefonnummer.AutoSize = true;
            this.Telefonnummer.Location = new System.Drawing.Point(467, 3);
            this.Telefonnummer.Name = "Telefonnummer";
            this.Telefonnummer.Size = new System.Drawing.Size(96, 15);
            this.Telefonnummer.TabIndex = 5;
            this.Telefonnummer.Text = "Telefonnummer";
            // 
            // Nachname
            // 
            this.Nachname.AutoSize = true;
            this.Nachname.Location = new System.Drawing.Point(355, 3);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(67, 15);
            this.Nachname.TabIndex = 4;
            this.Nachname.Text = "Nachname";
            // 
            // Vorname
            // 
            this.Vorname.AutoSize = true;
            this.Vorname.Location = new System.Drawing.Point(243, 3);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(57, 15);
            this.Vorname.TabIndex = 3;
            this.Vorname.Text = "Vorname";
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(131, 3);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(29, 15);
            this.Titel.TabIndex = 2;
            this.Titel.Text = "Titel";
            // 
            // Anrede
            // 
            this.Anrede.AutoSize = true;
            this.Anrede.Location = new System.Drawing.Point(67, 3);
            this.Anrede.Name = "Anrede";
            this.Anrede.Size = new System.Drawing.Size(46, 15);
            this.Anrede.TabIndex = 1;
            this.Anrede.Text = "Anrede";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(3, 3);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(17, 15);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.einfuegenT2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(0, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1030, 374);
            this.tabPage2.Text = "tabPage2";
            // 
            // einfuegenT2
            // 
            this.einfuegenT2.Location = new System.Drawing.Point(946, 35);
            this.einfuegenT2.Name = "einfuegenT2";
            this.einfuegenT2.Size = new System.Drawing.Size(68, 31);
            this.einfuegenT2.TabIndex = 4;
            this.einfuegenT2.Text = "einfuegen";
            this.einfuegenT2.Click += new System.EventHandler(this.einfuegenT2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Suchen";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 47.27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 52.73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 590F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxWebseite, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTelefon, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxAdresse, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxFirmenname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Webseite, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Telefon, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Adresse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Firmenname, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(923, 63);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.TabStop = true;
            // 
            // textBoxWebseite
            // 
            this.textBoxWebseite.Location = new System.Drawing.Point(335, 35);
            this.textBoxWebseite.Name = "textBoxWebseite";
            this.textBoxWebseite.Size = new System.Drawing.Size(100, 22);
            this.textBoxWebseite.TabIndex = 7;
            this.textBoxWebseite.TextChanged += new System.EventHandler(this.textBoxWebseite_TextChanged);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(204, 35);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelefon.TabIndex = 6;
            this.textBoxTelefon.TextChanged += new System.EventHandler(this.textBoxTelefon_TextChanged);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(98, 35);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdresse.TabIndex = 5;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // textBoxFirmenname
            // 
            this.textBoxFirmenname.Location = new System.Drawing.Point(3, 35);
            this.textBoxFirmenname.Name = "textBoxFirmenname";
            this.textBoxFirmenname.Size = new System.Drawing.Size(89, 22);
            this.textBoxFirmenname.TabIndex = 4;
            this.textBoxFirmenname.TextChanged += new System.EventHandler(this.textBoxFirmenname_TextChanged);
            // 
            // Webseite
            // 
            this.Webseite.AutoSize = true;
            this.Webseite.Location = new System.Drawing.Point(335, 3);
            this.Webseite.Name = "Webseite";
            this.Webseite.Size = new System.Drawing.Size(59, 15);
            this.Webseite.TabIndex = 3;
            this.Webseite.Text = "Webseite";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(204, 3);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(48, 15);
            this.Telefon.TabIndex = 2;
            this.Telefon.Text = "Telefon";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(98, 3);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(52, 15);
            this.Adresse.TabIndex = 1;
            this.Adresse.Text = "Adresse";
            // 
            // Firmenname
            // 
            this.Firmenname.AutoSize = true;
            this.Firmenname.Location = new System.Drawing.Point(3, 3);
            this.Firmenname.Name = "Firmenname";
            this.Firmenname.Size = new System.Drawing.Size(39, 15);
            this.Firmenname.TabIndex = 0;
            this.Firmenname.Text = "Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView2.Location = new System.Drawing.Point(17, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(997, 280);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // window1BindingSource
            // 
            this.window1BindingSource.DataSource = typeof(WiseyAdressbuch.Window1);
            // 
            // window1BindingSource1
            // 
            this.window1BindingSource1.DataSource = typeof(WiseyAdressbuch.Window1);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Window1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.window1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private BindingSource window1BindingSource;
        private BindingSource window1BindingSource1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

        private Button button3;
        private Button button2;

        private Label Titel;
        private Label Anrede;
        private Label ID;
        private Label Nachname;
        private Label Vorname;
        private Label Telefonnummer;
        private Label Organisation;
        private Label EMailAdresse;
        private Label Adresse;
        private Label Firmenname;
        private Label Webseite;
        private Label Telefon;

        public DataGridView DataGridView1 { get { return dataGridView1; } set { dataGridView1 = value; } }
        public DataGridView DataGridView2 { get { return dataGridView2; } set { dataGridView2 = value; } }
        public TabControl TabControl1 { get { return tabControl1; } set { tabControl1 = value; } }
        public TabPage TabPage1 { get { return tabPage1; } set { tabPage1 = value; } }
        public TabPage TabPage2 { get { return tabPage2; } set { tabPage2 = value; } }

        public Label[] tab1Labels = new Label[8];
        public Label[] tab2Labels = new Label[4];

        public TextBox[] tab1TextBoxes = new TextBox[8];
        public TextBox[] tab2TextBoxes = new TextBox[4];

        public Dictionary<Label, TextBox> labelTextBoxDict = new Dictionary<Label, TextBox>();
        public Dictionary<Label, int> labelIndex = new Dictionary<Label, int>();
        public Dictionary<TextBox, Label> textBoxLabelDict = new Dictionary<TextBox, Label>();
        public Dictionary<int, Label> indexLable = new Dictionary<int, Label>();
                


        public void InitSearchControls()
        {

            tab1Labels[0] = ID;
            tab1Labels[1] = Anrede;
            tab1Labels[2] = Titel;
            tab1Labels[3] = Vorname;
            tab1Labels[4] = Nachname;
            tab1Labels[5] = Telefonnummer;
            tab1Labels[6] = Organisation;
            tab1Labels[7] = EMailAdresse;

            tab1TextBoxes[0] = textBoxID;
            tab1TextBoxes[1] = textBoxAnrede;
            tab1TextBoxes[2] = textBoxTitel;
            tab1TextBoxes[3] = textBoxVorname;
            tab1TextBoxes[4] = textBoxNachname;
            tab1TextBoxes[5] = textBoxTelefonnummer;
            tab1TextBoxes[6] = textBoxOrganisation;
            tab1TextBoxes[7] = textBoxEMail;

            tab2Labels[0] = Firmenname;
            tab2Labels[1] = Adresse;
            tab2Labels[2] = Telefon;
            tab2Labels[3] = Webseite;

            tab2TextBoxes[0] = textBoxFirmenname;
            tab2TextBoxes[1] = textBoxAdresse;
            tab2TextBoxes[2] = textBoxTelefon;
            tab2TextBoxes[3] = textBoxWebseite;

            for(int i = 0; i < tab1Labels.Length; i++)
            {
                labelTextBoxDict.Add(tab1Labels[i], tab1TextBoxes[i]);
                labelIndex.Add(tab1Labels[i], i);
                textBoxLabelDict.Add(tab1TextBoxes[i], tab1Labels[i]);
                
            }

            for(int i = 0; i < tab2Labels.Length; i++)
            {
                labelTextBoxDict.Add(tab2Labels[i], tab2TextBoxes[i]);
                labelIndex.Add(tab2Labels[i], i);
                textBoxLabelDict.Add(tab2TextBoxes[i], tab2Labels[i]);
                
            }



            //tab1SearchFields = new SearchField[columnNames.Length];


            //if(tableName == "Mitarbeiter")
            //{
            //    for (int i = 0; i < columnNames.Length; i++)
            //    {
            //        tab1SearchFields[i] = new SearchField(columnNames[i]);
            //        tableLayoutPanel1.SetRow(tab1SearchFields[i], 0);
            //        tableLayoutPanel1.SetColumn(tab1SearchFields[i], i);
            //        tab1SearchFields[i].Show();
            //    }
            //}

            //if (tableName == "Organisation")
            //{
            //    for (int i = 0; i < columnNames.Length; i++)
            //    {
            //        tab2SearchFields[i] = new SearchField(columnNames[i]);
            //        tableLayoutPanel2.SetRow(tab1SearchFields[i], 0);
            //        tableLayoutPanel2.SetColumn(tab1SearchFields[i], i);
            //        tab2SearchFields[i].Show();
            //    }
            //}

        }

        private TextBox textBoxEMail;
        private TextBox textBoxOrganisation;
        private TextBox textBoxTelefonnummer;
        private TextBox textBoxNachname;
        private TextBox textBoxVorname;
        private TextBox textBoxTitel;
        private TextBox textBoxAnrede;
        private TextBox textBoxID;
        private TextBox textBoxWebseite;
        private TextBox textBoxTelefon;
        private TextBox textBoxAdresse;
        private TextBox textBoxFirmenname;
        private Button einfuegenT1;
        private Button einfuegenT2;
    }
}

