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
using System.Net;
using System.Diagnostics;

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
            String altVon = cmbVon.Text;
            cmbVon.Text = cmbNach.Text;
            cmbNach.Text = altVon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GridView wird geleert
            gridView.Rows.Clear();
            gridView.Refresh();

            //Neue Verbindung wird gesucht u
            Transport tp = new Transport();
            string date = dateTimePickerDatum.Value.ToString("yyyy-MM-dd");
            string time = dateTimePickerUhrzeit.Value.ToString("HH:mm");
            Connections connections = tp.GetConnectionsDetailed(cmbVon.Text, cmbNach.Text, date, time);
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
            //Reihen werden geleert
            gridView.Rows.Clear();
            gridView.Refresh();

            //Neue Suche wird gestartet
            Transport tp = new Transport();
            Stations stations = tp.GetStations(txtVonStation.Text);
            foreach(Station station in stations.StationList)
            {
                String id = station.Id;
                StationBoardRoot stBoardRoot = tp.GetStationBoard(txtVonStation.Text, id);
                foreach(StationBoard stBoard in stBoardRoot.Entries)
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

        private void cmbVon_DropDown(object sender, EventArgs e)
        {
            dropDownFuellen(cmbVon);
        }

        private void cmbNach_DropDown(object sender, EventArgs e)
        {
            dropDownFuellen(cmbNach);
        }

        private void dropDownFuellen(ComboBox cmbBox)
        {
            try
            {
                String suchText = cmbBox.Text;
                Transport tp = new Transport();
                Stations stationen = tp.GetStations(suchText);
                if (suchText.Length <= 3)
                    return;
                cmbBox.Items.Clear();

                //Liste wird abgefüllt in comboBox
                List<Station> stationList = tp.GetStations(suchText).StationList;
                foreach (Station station in stationList)
                {
                    cmbBox.Items.Add(station.Name);
                }
            }
            catch (WebException fehler)
            {
                MessageBox.Show("Sie haben zu viele Serveranfragen auf einmal gestellt.\nBitte versuchen Sie es erneut!\n\n" + fehler.Message, "Zu viele Anfragen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMapsVon_Click(object sender, EventArgs e)
        {
            if(cmbVon.Text != null || cmbVon.Text != "")
            {
                browserOeffnen(cmbVon);
            }
        }

        private void btnMapsNach_Click(object sender, EventArgs e)
        {
            if (cmbNach.Text != null || cmbNach.Text != "")
            {
                browserOeffnen(cmbNach);
            }
        }

        private void browserOeffnen(ComboBox cmbBox)
        { 
            Transport tp = new Transport();
            Stations stationVon = tp.GetStations(cmbBox.Text);
            foreach (Station station in stationVon.StationList)
            {
                Coordinate cordinates = station.Coordinate;
                string xValue = cordinates.XCoordinate.ToString().Replace(",", ".");
                string yValue = cordinates.YCoordinate.ToString().Replace(",", ".");
                string url = "https://www.google.ch/maps/?q=loc:" + xValue + "+" + yValue;
                Process.Start(url);
            }
        }
    }
}
