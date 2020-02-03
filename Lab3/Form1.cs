//N5284
//Lab 3
//February 10, 2019
//This program is an example of creating a GUI that calculates the Diameter, Surface area,
//and Volume of a sphere with a radius given by the user

//Auto-Generated user statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Lab 3 Namespace
namespace Lab3
{
    //labThreeForm Class
    public partial class labThreeForm : Form
    {
        //labThreeForm Generation
        public labThreeForm()
        {
            //Initialize the labThreeForm
            InitializeComponent();
        }

        //When the "Calculate" button is pressed, the following calculations will be done
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double radius;          //Variable to hold the user generated radius
            double diameter;        //Variable to hold the calculated diameter of the sphere
            double surfaceArea;     //Variable to hold the calculated surface area of the sphere
            double volume;          //Variable to hold the calculated volume of the sphere

            //Take the radius that the user input, and calculate the diameter, surface area, and volume
            radius = double.Parse(sphereRadiusTxt.Text);
            diameter = 2 * radius;
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;

            //Output the calculated values to their respective labels
            sphereDiameterLbl.Text = $"{diameter:F2}";
            sphereSurfaceAreaLbl.Text = $"{surfaceArea:F2}";
            sphereVolumeLbl.Text = $"{volume:F2}";
        }
    }
}
