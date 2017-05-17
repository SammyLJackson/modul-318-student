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
            //GridView wird geleert
            gridView.Rows.Clear();
            gridView.Refresh();
            Transport tp = new Transport();
            Connections connections = tp.GetConnections(txtVon.Text, txtNach.Text);
            foreach (Connection connection in connections.ConnectionList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridView);
                row.Cells[0].Value = connection.From.Station.Name;
                row.Cells[1].Value = connection.To.Station.Name;
                String endDauer = connection.Duration.Remove(0, 3);
                row.Cells[2].Value = Convert.ToDateTime(endDauer).ToString("HH:mm:ss");
                row.Cells[3].Value = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                row.Cells[4].Value = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
                row.Cells[5].Value = connection.From.Platform;

                gridView.Rows.Add(row);
            }
        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            gridView.Refresh();
            Transport tp = new Transport();
            Stations stations = tp.GetStations(txtVonStation.Text);
            foreach(Station station in stations.StationList)
            {
                String id = station.Id;
                StationBoardRoot stationBoardRoot = tp.GetStationBoard(txtVonStation.Text, id);
                foreach(StationBoard stBoard in stationBoardRoot.Entries)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gridView);
                    row.Cells[0].Value = stBoard.Name;
                    row.Cells[1].Value = stBoard.To;
                    row.Cells[3].Value = stBoard.Stop.Departure.ToString("HH:mm:ss");

                    gridView.Rows.Add(row);
                }
            }
        }
    }
}
