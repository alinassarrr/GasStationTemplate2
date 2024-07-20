using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStationTemplate2
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            btnGas.Click += iconButton14_Click_1;
            btnWasher.Click += iconButton14_Click_1;
            btnStation.Click += iconButton14_Click_1;
            iconButton14.Click += iconButton14_Click_1;
            btnLang.Click += iconButton14_Click_1;
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeAndDate.Text = DateTime.Now.ToString();
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //invoke method Collapse Menu 
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                rjCircularPictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach(Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign=ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 253;
                rjCircularPictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text ="  "+ menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,0,0);
                    
                }
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }
        private void Open_DropDownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control=(Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
                => DropDownMenu_VisibleChanged(sender2,ev, control));
            dropdownMenu.Show(control, control.Width, 0); 
        }


        private void DropDownMenu_VisibleChanged(object sender,EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                {
                    ctrl.BackColor = Color.FromArgb(89, 102, 224);

                }
                else ctrl.BackColor = Color.FromArgb(98, 102, 244);
            }

        }

        private void rjDropdownMenuSales_Opening(object sender, CancelEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuSales, sender);

        }

        private void collectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuLearnMore, sender);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuTools, sender);

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuServices, sender);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuSales, sender);            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuLearnMore, sender);

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuTools, sender);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Open_DropDownMenu(rjDropdownMenuServices, sender);

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

        }

        // Track the currently selected button
        private Button selectedButton = null;

        private void iconButton14_Click_1(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // If there's a previously selected button, reset its appearance
            if (selectedButton != null)
            {
                ResetButtonAppearance(selectedButton);
            }

            // Update the appearance of the clicked button
            SetButtonAppearance(clickedButton);

            // Set the clicked button as the currently selected button
            selectedButton = clickedButton;
        }

        // Method to set the appearance of the selected button
        private void SetButtonAppearance(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.FromArgb(98, 102, 244);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.White;
            button.FlatAppearance.BorderSize = 1;
           
        }

        private void ResetButtonAppearance(Button button)
        {
            button.BackColor = Color.FromArgb(98, 102, 244);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.White;
            button.FlatAppearance.BorderSize = 0;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton17_Click(object sender, EventArgs e)
        {

        }

        private void btnGas_Click(object sender, EventArgs e)
        {

        }

        private void btnWasher_Click(object sender, EventArgs e)
        {

        }

        private void btnStation_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
