﻿using BoundControls.Business;
using MvvmFx.CaliburnMicro;
using Wisej.Web;

namespace WisejWeb.MenuBinding
{
    public partial class MvvmFxBind : Form
    {
        private readonly MvvmFxBindComponents _binder = new MvvmFxBindComponents();

        public MvvmFxBind()
        {
            InitializeComponent();
        }


        private void MvvmFxBind_Load(object sender, System.EventArgs e)
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