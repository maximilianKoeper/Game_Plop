﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Plop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            createTable(9);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void createTable(int size)
        {
            int formHeight = dataGridView1.Height;
            int formWidth = dataGridView1.Width;
            dataGridView1.RowTemplate.Height = formHeight / (size);

            for (int i=0; i < size; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.Width = formWidth/(size);
                //column.DefaultHeaderCellType =    TODODODODODDO
            }
            dataGridView1.Rows.Add(size);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
