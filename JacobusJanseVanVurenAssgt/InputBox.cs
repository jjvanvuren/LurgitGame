using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobusJanseVanVurenAssgt
{
    public partial class InputBox : Form
    {
        // InputBox code sourced from lecture demo

        // Default Constructor
        public InputBox()
        {
            InitializeComponent();
        }

        // Additional Constructor
        public InputBox(string sPrompt, string sTitle)
        {   
            InitializeComponent();
            Text = sTitle;
            lblPrompt.Text = sPrompt;
        } 

        // String storing the input
        public string sInputValue
        {   
            get { return txbxInput.Text; }
            set { txbxInput.Text = value; }
        }
    }
}
