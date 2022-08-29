using System;
using Wisej.Web;
using System.Data.SQLite;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace WiseyAdressbuch
{
    static class Program
    {

        private static string connectionString = @"dataSource=Adressbuch.db";
        private static SQLiteConnection connection;

        private static SQLiteCommand selectCommand;
        private static SQLiteCommand insertCommand;
        private static SQLiteCommand updateCommand;
        private static SQLiteCommand modifyOrganisation;
        private static SQLiteCommand deleteCommand;
        

        private static DataTable dataTable;
        private static SQLiteDataAdapter dataAdapter;                

        private static SQLiteTransaction transaction;
        private static Window1 windowHandle;

        private static string[] mitarbeiterColumnNames = new string[8];
        private static string[] organisationColumnNames = new string[4];

        public static string currentTableName;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {            
            Application.Desktop = new MyDesktop();

            connectionString = @"dataSource=" + Application.CommonAppDataPath + @"\Adressbuch.db";
            Window1 window = new Window1
                (
                  OnCellValueChanged                
                , OnSearchButtonClick
                , OnInsertButtonClick
                , OnDeleteKeyPressed
                );

            windowHandle = window;
            window.Show();            

            windowHandle.TabPage1.Text = "Mitarbeiter";
            windowHandle.TabPage2.Text = "Organisation";

            connection = new SQLiteConnection(connectionString);

            CreateSelectCommand();

            //dataAdapter
            dataAdapter = new SQLiteDataAdapter(selectCommand);
            dataAdapter.AcceptChangesDuringUpdate = true;
            dataAdapter.RowUpdated += DataAdapter_RowUpdated;
            //--


            windowHandle.TabControl1.Selected += TabControl1_Selected;
            currentTableName = windowHandle.TabControl1.SelectedTab.Text;
            connection.Open();
            transaction = connection.BeginTransaction();
            FillCurrentDataGrid(CreateSelectCommand());
            InitializeSearchUI();
            
            

        }


        private static int GetDBEntriesCount(string tableName, string columnName, string searchPhrase)
        {
            SQLiteDataReader reader;
            SQLiteCommand com = null;
            try
            {
                com = connection.CreateCommand();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            com.CommandText = "select * from " + tableName + " where " + columnName + " like '" + searchPhrase + "'";


            int stepCount = 0;

            try
            {
                reader = com.ExecuteReader();
                while (reader.Read()) ;
                stepCount = reader.StepCount;
                reader.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return stepCount;
        }



        private static SQLiteCommand CreateSelectCommand()
        {
            selectCommand = new SQLiteCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "SELECT * FROM " + currentTableName;
            return selectCommand;
        }



        private static SQLiteCommand CreateSelectCommand(string[] columns, object[] values)
        {            
            selectCommand = new SQLiteCommand();
            selectCommand.Connection = connection;
            string selectedTable = windowHandle.TabControl1.GetControl(windowHandle.TabControl1.SelectedIndex).Text;            

            StringBuilder sb = new StringBuilder("select * from " + selectedTable);  

            for (int i = 0; i < columns.Length; i++)
            {                

                if (i == 0)
                {
                    sb.Append(" where ");
                }

                if((string)values[i] != string.Empty)
                {
                    if (i > 0)
                    {
                        sb.Append(" AND ");
                    }


                    if (GetDBEntriesCount(selectedTable,columns[i] ,(string)values[i]) == 0)
                    {
                        sb.Append(columns[i] + " like '" + values[i] + "%' ");

                    }
                    else
                    {
                        sb.Append(columns[i] + " like '" + values[i] + "' ");

                    }
                }              


            }

            selectCommand.CommandText = sb.ToString();
            return selectCommand;
        }


        private static void BuildInsertCommand()
        {

        }


        private static void BuildDeleteCommand()
        {

        }


        private static void BuildUpdateCommand()
        {

        }


        private static void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            currentTableName = e.TabPage.Text;
            FillCurrentDataGrid(CreateSelectCommand());
        }

        private static void FillCurrentDataGrid(SQLiteCommand _selectCommand)
        {
            CreateSelectCommand();
            dataTable = new DataTable();
            dataAdapter.SelectCommand = _selectCommand;
            dataAdapter.Fill(dataTable);
            Control.ControlCollection controls = windowHandle.TabControl1.GetControl(windowHandle.TabControl1.SelectedIndex).Controls;

            foreach (Control item in controls)
            {
                if (item.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)item).Fill(dataTable.DefaultView);
                }
            }
        }


        private static void DataAdapter_RowUpdated(object sender, System.Data.Common.RowUpdatedEventArgs e)
        {
            dataAdapter.Fill(dataTable);
            //windowHandle.dataGridView.Fill(dataTable.DefaultView);
        }
        

       

        public static void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView currentDataGridView = ((DataGridView)sender);
            Label label = null;
            TextBox textBox = null;

            if (e.RowIndex == currentDataGridView.RowCount-1)
            {
                MessageBox.Show("Ignore");
            }
            else
            {
                object cellValue = currentDataGridView.CurrentCell.Value;
                dataTable.Rows[e.RowIndex][e.ColumnIndex] = cellValue;

                if(currentTableName == "Mitarbeiter")
                {
                    label = windowHandle.tab1Labels[e.ColumnIndex];
                    textBox = windowHandle.tab1TextBoxes[e.ColumnIndex];
                }
                else
                {
                    label = windowHandle.tab2Labels[e.ColumnIndex];
                    textBox = windowHandle.tab2TextBoxes[e.ColumnIndex];
                }
                
                
                dataAdapter.UpdateCommand = CreateUpdateCommand(label,cellValue.ToString(),e.RowIndex,dataTable.Rows[e.RowIndex][0])  ;
                dataAdapter.Update(dataTable);
                transaction.Commit();
                
            }

        }




        public static void OnSearchButtonClick(object sender, EventArgs e)
        {
            List<string> labels = new List<string>();
            List<string> textBoxes = new List<string>();
            

            if(currentTableName == "Mitarbeiter")
            {
                for (int i = 0; i < windowHandle.tab1Labels.Length; i++)
                {
                    if (windowHandle.tab1TextBoxes[i] != null && windowHandle.tab1TextBoxes[i].Text != string.Empty)
                    {
                        textBoxes.Add(windowHandle.tab1TextBoxes[i].Text);
                        labels.Add(windowHandle.tab1Labels[i].Text);
                    }
                }
            }
            else
            {
                for (int i = 0; i < windowHandle.tab2Labels.Length; i++)
                {
                    if (windowHandle.tab2TextBoxes[i] != null && windowHandle.tab2TextBoxes[i].Text != string.Empty)
                    {
                        textBoxes.Add(windowHandle.tab2TextBoxes[i].Text);
                        labels.Add(windowHandle.tab2Labels[i].Text);
                    }
                }
            }
            

            FillCurrentDataGrid(CreateSelectCommand(labels.ToArray(),textBoxes.ToArray()));
        }

      
        public static void OnInsertButtonClick(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataAdapter.InsertCommand = CreateInsertCommand();
            dataAdapter.InsertCommand.ExecuteNonQuery();
            dataAdapter.Fill(dataTable);
            dataAdapter.Update(dataTable);
            transaction.Commit();
            insertCommand = CreateSelectCommand();
            if(insertCommand != null)
            FillCurrentDataGrid(insertCommand);
        }



        public static void OnDeleteKeyPressed(object sender,KeyEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;

            foreach (DataGridViewRow item in rows)
            {
                dataAdapter.DeleteCommand = CreateDeleteCommand(dataTable.Columns[0].ColumnName, item.Cells[0].Value.ToString());
                dataAdapter.DeleteCommand.ExecuteNonQuery();
                
            }
            dataAdapter.Fill(dataTable);
            dataAdapter.Update(dataTable);            
            FillCurrentDataGrid(CreateSelectCommand());
            
        }

        private static SQLiteCommand CreateInsertCommand( )
        {
            insertCommand = new SQLiteCommand();
            insertCommand.Connection = connection;
            StringBuilder insertString = new StringBuilder("Insert into " + currentTableName);
            StringBuilder values = new StringBuilder();
            StringBuilder labels = new StringBuilder();
            List<Label> labelList = new List<Label>();
            List<TextBox> valueList = new List<TextBox>();

            if(currentTableName == "Mitarbeiter")
            {
                foreach (TextBox item in windowHandle.tab1TextBoxes)
                {
                    if (item.Text != string.Empty)
                    {
                        labelList.Add(windowHandle.textBoxLabelDict[item]) ;
                        valueList.Add(item);
                    }
                }
            }
            else
            {
                foreach (TextBox item in windowHandle.tab2TextBoxes)
                {
                    if (item.Text != string.Empty)
                    {
                        labelList.Add(windowHandle.textBoxLabelDict[item]);
                        valueList.Add(item);
                    }
                }
            }

            


            for (int i = 0; i < labelList.Count; i++)
            {                

                if (valueList[i].Text != string.Empty)
                {
                    if (i > 0)
                    {

                        values.Append(",");
                        values.Append("'" + valueList[i].Text + "'");

                        labels.Append(",");
                        labels.Append("'" + labelList[i].Text + "'");

                    }
                    else
                    {

                        labels.Append("'" + labelList[i].Text + "'");
                        values.Append("'" + valueList[i].Text + "'");

                    }
                }


            }


            insertString.Append("(" + labels.ToString() + ") VALUES (" + values.ToString() + ")");
            insertCommand.CommandText = insertString.ToString();

            if (valueList.Count == 0)
            {
                return null;
            }
            else
            {
                return insertCommand;
            }            

        }


        private static SQLiteCommand CreateUpdateCommand(Label label, string text, int rowIndex, object pKeyValue)
        {
            SQLiteCommand updateCommand = new SQLiteCommand();
            updateCommand.Connection = connection;
            var pKey = dataTable.Rows[rowIndex][0];
            updateCommand.CommandText = "UPDATE "+currentTableName+" SET "+label.Text+"='"+text+"' WHERE "+dataTable.Columns[0].ColumnName+" ="+pKeyValue.ToString();
            return updateCommand;
        }

       
        private static SQLiteCommand CreateDeleteCommand(string pKeyName, string pKeyValue)
        {
            deleteCommand = new SQLiteCommand();
            deleteCommand.Connection = connection;
            deleteCommand.CommandText = "DELETE FROM " + currentTableName + " WHERE " + pKeyName + "='" + pKeyValue + "'";
            dataAdapter.DeleteCommand = deleteCommand;

            return deleteCommand;
        }



        private static void InitializeSearchUI()
        {
            DataTable mitarbeiterTable = new DataTable();
            DataTable organisationTable = new DataTable();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            windowHandle.InitSearchControls();

            //tab1 Mitarbeiter
            dataAdapter.SelectCommand = new SQLiteCommand("SELECT * FROM Mitarbeiter LIMIT 1",connection);
            dataAdapter.Fill(mitarbeiterTable);

            for(int i = 0; i < Program.mitarbeiterColumnNames.Length; i++)
            {
                mitarbeiterColumnNames[i] = mitarbeiterTable.Columns[i].ColumnName;
            }

            //tab2 Organisation
            dataAdapter.SelectCommand = new SQLiteCommand("SELECT * FROM Organisation LIMIT 1", connection);
            dataAdapter.Fill(organisationTable);

            for(int i = 0; i < Program.organisationColumnNames.Length; i++)
            {
                organisationColumnNames[i] = organisationTable.Columns[i].ColumnName;
            }

        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}