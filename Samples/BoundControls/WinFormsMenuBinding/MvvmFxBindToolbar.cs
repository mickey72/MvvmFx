﻿using System;
using System.Windows.Forms;
using BoundControls.Business;
using MvvmFx.CaliburnMicro;

namespace WinForms.MenuBinding
{
    public partial class MvvmFxBindToolbar : Form
    {
        private readonly MvvmFxBindComponents _binder = new MvvmFxBindComponents();

        public MvvmFxBindToolbar()
        {
            InitializeComponent();
        }

        private void MvvmFxBindToolbar_Load(object sender, EventArgs e)
        {
            var menu = MenuCollection.GetMenu("menuItem6");
            menu.Visible = false;
            menu.Text = "Hidden";
            menu.ToolTipText = "Hidden menu entry";

            _binder.SetMvvmFxBindings(this);
        }

        private void showItem_Click(object sender, System.EventArgs e)
        {
            var menu = MenuCollection.GetMenu("menuItem6");
            menu.Visible = true;
        }

        private void changeItem_Click(object sender, System.EventArgs e)
        {
            var menu = MenuCollection.GetMenu("menuItem6");
            menu.Text = "Help";
            menu.ToolTipText = "Help menu entry";
        }
    }
}