
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace WiseyAdressbuch
{
    public partial class Window1 : Form
    {
        public delegate void OnCellValueChangedDel(object sender, DataGridViewCellEventArgs e);
        public OnCellValueChangedDel OnCellValueChanged;

        public delegate void OnSearchButtonClickDel(object sender, EventArgs e);
        public OnSearchButtonClickDel OnSearchButtonClick;

        public delegate void OnInsertButtonClickDel(object sender, EventArgs e);
        public OnInsertButtonClickDel OnInsertButtonClick;

        public delegate void OnDeleteKeyPressedDel(object sender, KeyEventArgs keyEventArgs);
        public OnDeleteKeyPressedDel OnDeleteKeyPressed;

        public Dictionary<string, string> searchSelection = new Dictionary<string, string>();

        public Window1
            (            
              OnCellValueChangedDel onCellValueChanged            
            ,OnSearchButtonClickDel onSearchButtonClick
            ,OnInsertButtonClickDel onInsertButtonClick
            ,OnDeleteKeyPressedDel onDeleteKeyPressed
            )
        {
            InitializeComponent();
            
            OnCellValueChanged += onCellValueChanged;
            OnSearchButtonClick += onSearchButtonClick;
            OnInsertButtonClick += onInsertButtonClick;
            OnDeleteKeyPressed += onDeleteKeyPressed;
            
        }
        

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {        
            OnCellValueChanged(sender, e);  
            
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            OnCellValueChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnSearchButtonClick(sender, e);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnSearchButtonClick(sender, e);
            
        }

        

        private void textBoxFirmenname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWebseite_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnrede_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVorname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNachname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefonnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOrganisation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void einfuegen_Click(object sender, EventArgs e)
        {
            OnInsertButtonClick(sender,e);
        }

        private void einfuegenT2_Click(object sender, EventArgs e)
        {
            OnInsertButtonClick(sender, e);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            OnDeleteKeyPressed( sender, e);
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            OnDeleteKeyPressed(sender, e);
        }
    }
}
