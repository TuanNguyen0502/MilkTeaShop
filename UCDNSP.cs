﻿using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class UCDNSP : UserControl
    {
        public UCDNSP()
        {
            InitializeComponent();
        }
        public GunaLabel LblMaDNSP { get => lblMaDNSP; set => lblMaDNSP = value; }
        public GunaLabel LblImportDate { get => lblNgayNhap; set => lblNgayNhap = value; }
        public GunaLabel LblTriGia { get => lblTongDon; set => lblTongDon = value; }
        public GunaLabel LblTenNCC { get => lblTenNCC; set => lblTenNCC = value; }
    }
}
