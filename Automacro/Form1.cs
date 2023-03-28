using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automacro
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
        
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {/*
            Font newfont = new Font(this.Font.FontFamily, 9.0f / factor.Height);
            void Search(Control item)
            {
                foreach (Control child in item.Controls)
                {
                    Search(child);
                }
                item.Font = newfont;
                //item.Width = (int)(item.Width / factor.Width);
                //item.Height = (int)(item.Height / factor.Height);
            }
            Search(this);
            */
        }

    }
}
