using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataBindingForWinForms
{
    public partial class MainView : Form
    {
        private MainPresenter _presenter;

        public MainView()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
        }
    }
}
