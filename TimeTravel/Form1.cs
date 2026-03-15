using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeTravel
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ToolTip sqwimbleTip;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eraBox.SelectedIndex = 1;

            sqwimbleTip = new System.Windows.Forms.ToolTip();
            sqwimbleTip.AutoPopDelay = 5000;
            sqwimbleTip.ReshowDelay = 100;
            sqwimbleTip.InitialDelay = 500;
            sqwimbleTip.ShowAlways = true;

            sqwimbleTip.SetToolTip(sqwimbleBar,
                "Well, below -12 sqwimbles actually allows for a little bit of extra flexibility for those with the skill to\n" +
                "manage it. Of course, no newbie should attempt it, but many veterans actually prefer to be in the -20\n" +
                "to -30 range. Some people have been known to go down to -70, but those people are absolute\n" +
                "morons who don't respect the craft and are just doing it for thrill-seeking. Damn bougie hobbyist time\n" +
                "travelers, ruining it for the rest of us.\n" +
                "-u/ObberGobb"
            );
        }

        // googled these latitude and longitude formatters...
        private static string FormatLatitude(string latitude)
        {
            double value;
            if (!double.TryParse(latitude, out value)) return null;
            if (value < -90 || value > 90) return null;

            string direction = value >= 0 ? "N" : "S";
            value = Math.Abs(value);

            return value.ToString("0.#####") + "Åã" + direction;
        }

        private static string FormatLongitude(string longitude)
        {
            double value;
            if (!double.TryParse(longitude, out value)) return null;
            if (value < -180 || value > 180) return null;

            string direction = value >= 0 ? "E" : "W";
            value = Math.Abs(value);

            return value.ToString("0.#####") + "Åã" + direction;
        }

        private string Validator(object UIElement)
        {
            if (UIElement == null) return null;

            System.Type type = UIElement.GetType();

            if (type == typeof(System.Windows.Forms.TrackBar))
            {
                System.Windows.Forms.TrackBar trackBar = (System.Windows.Forms.TrackBar)UIElement;
                return trackBar.Value.ToString();
            }

            if (type == typeof(System.Windows.Forms.CheckBox))
            {
                System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)UIElement;
                return checkBox.Checked ? "true" : "false";
            }

            System.Reflection.PropertyInfo textProp = type.GetProperty("Text");
            System.Reflection.PropertyInfo nameProp = type.GetProperty("Name");

            if (textProp == null || nameProp == null) return null;

            object textObj = textProp.GetValue(UIElement, null);
            object nameObj = nameProp.GetValue(UIElement, null);

            if (textObj == null || nameObj == null) return null;

            string textValue = textObj.ToString();
            string nameValue = nameObj.ToString();

            if (textValue.Length == 0 || nameValue.Length == 0) return null;

            switch (nameValue)
            {
                case "latitudeBox":
                    return FormatLatitude(textValue);
                case "longitudeBox":
                    return FormatLongitude(textValue);
                case "eraBox":
                    if (textValue == "BC" || textValue == "CE") return textValue;
                        else return null;
                default:
                    int intTest;
                    if (int.TryParse(textValue, out intTest)) return intTest.ToString(); 
                        else return null;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string Day = Validator(dayBox);
            string Month = Validator(monthBox);
            string Year = Validator(yearBox);
            string Era = Validator(eraBox);
            string Latitude = Validator(latitudeBox);
            string Longitude = Validator(longitudeBox);
            string Sqwimble = Validator(sqwimbleBar);
            string Deterministic = Validator(deterministicBox);
            string AssumeForm = Validator(assumeFormBox);


            if (Day == null || Month == null || Year == null || Era == null || 
                Latitude == null || Longitude == null || Sqwimble == null || 
                Deterministic == null || AssumeForm == null)
            {
                MessageBox.Show("One or more parameters are invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (MessageBox.Show(
                string.Format(
                    "Are you sure you wish to teleport to: {0}/{1}/{2} {3} \n{4}\n{5}\nSqwimble: {6}\nDeterministic: {7}\nAssume Form: {8}",
                    Day, Month, Year, Era, Latitude, Longitude, Sqwimble, Deterministic, AssumeForm),
                "Teleportation Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // teleport
                    // not sure how to implement yet
                }
            }
        }
    }
}
