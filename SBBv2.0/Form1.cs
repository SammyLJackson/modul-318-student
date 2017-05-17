using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SBBv2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            //Inhalt der Felder wird getauscht
            String altVon = txtVon.Text;
            txtVon.Text = txtNach.Text;
            txtNach.Text = altVon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gridView.SelectedRows)
            {
                gridView.Rows.RemoveAt(item.Index);
            }
            Transport tp = new Transport();
            Connections connections = tp.GetConnections(txtVon.Text, txtNach.Text);
            foreach (Connection connection in connections.ConnectionList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridView);
                row.Cells[0].Value = connection.From.Station.Name;
                row.Cells[1].Value = connection.To.Station.Name;
                row.Cells[2].Value = connection.Duration;
                row.Cells[3].Value = connection.From.Departure;
                row.Cells[4].Value = connection.To.Arrival;
                row.Cells[5].Value = connection.From.Platform;
                gridView.Rows.Add(row);
            }
        }
    }
}
