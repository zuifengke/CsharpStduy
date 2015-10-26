using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTree1.Fill(GetDataTable(), "0");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Value:"+comboBoxTree1.Value+
                "\nText:"+comboBoxTree1.Text+
                "\nFullPath:"+comboBoxTree1.FullPath
                
                );
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //comboBoxTree1.SelectedByValue(3, "Name333");
            comboBoxTree1.SelectedByValue(6, "ComboBoxTree6");
        }



        private DataTable GetDataTable()
        {

            string[,] array3D = { 
                                { "1", "ComboBoxTree1", "0"}, 
                                { "2", "ComboBoxTree2", "1"}, 
                                { "3", "ComboBoxTree3", "1"}, 
                                { "4", "ComboBoxTree4", "2"}, 
                                { "5", "ComboBoxTree5", "2"}, 
                                { "6", "ComboBoxTree6", "5"}, 
                                };
            return ArrayToDataTable.ArrayToDataTable.Convert(array3D);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Iexplore.exe", "http://www.yongfa365.com/?ComboBoxTree");
        }

    }
}
