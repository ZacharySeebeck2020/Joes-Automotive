﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive
{
    public partial class VehicleEdit : Form
    {
        int customerID;
        public VehicleEdit(int CustomerID)
        {
            customerID = CustomerID;
            InitializeComponent();
        }
    }
}
