using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Access;

namespace RenameFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              

        private void RenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ExcelName.Text) && !string.IsNullOrEmpty(textBox1.Text))
                {
                    DataTable dtCSV = new DataTable();
                    dtCSV = GetDataTabletFromCSVFile(ExcelName.Text);

                    progressBar1.Maximum = dtCSV.Rows.Count;
                    progressBar1.Step = 1;

                    string folderPath = textBox1.Text + "\\";
                    for (int i = 0; i < dtCSV.Rows.Count; i++)
                    {
                       
                        progressBar1.PerformStep();
                        string oldfilename = folderPath + dtCSV.Rows[i]["OldFileName"].ToString();
                        string newfilename = folderPath + dtCSV.Rows[i]["NewFileName"].ToString();
                        try
                        {
                            System.IO.File.Move(oldfilename, newfilename);
                        }
                        catch (Exception ex)
                        {
                            
                        }
                        
                    }
                    MessageBox.Show("File rename completed.");
                }
                else
                {
                    MessageBox.Show("Please select CSV file and folder for file to rename.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           
            
        }

        private void SelectExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = string.Empty;
                string fileExt = string.Empty;
                OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
                {
                    ExcelName.Text = file.FileName;
                    filePath = file.FileName; //get the path of the file  
                    fileExt = Path.GetExtension(filePath); //get the file extension  
                    if (fileExt.CompareTo(".csv") == 0)
                    {
                        try
                        {
                            DataTable dtExcel = new DataTable();
                            dtExcel = GetDataTabletFromCSVFile(filePath); //read file  
                            dataGridView1.Visible = true;
                            dataGridView1.DataSource = dtExcel;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose .csv file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }         

        }

        public DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();

            try
            {

                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return csvData;
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        textBox1.Text = fbd.SelectedPath.ToString();
                        string[] files = Directory.GetFiles(fbd.SelectedPath);

                        // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                        Filecount.Text = "Files found: " + files.Length.ToString();

                        DataTable tbl = new DataTable();
                        tbl.Columns.Add("FileName");

                        foreach (string s in files)
                        {
                            DataRow row = tbl.NewRow();
                            // string[] numb = s.Split(',');
                            row["FileName"] = s.Replace(fbd.SelectedPath.ToString(), "").Replace("\\", "");

                            tbl.Rows.Add(row);
                        }

                        dataGridView2.Visible = true;
                        dataGridView2.DataSource = tbl;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
    }
}
