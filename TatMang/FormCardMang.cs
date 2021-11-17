using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.TatMang
{
    public partial class FormCardMang : UserControl
    {
        private CardMang cardMang;
        public FormCardMang(CardMang cardMang)
        {
            InitializeComponent();
            this.cardMang = cardMang;
            load();

        }

        public CardMang CardMang { get => cardMang; set => cardMang = value; }

        void load()
        {
            lbNameCard.Text = cardMang.Name;
            lbAdminSate.Text = cardMang.AdminState;
            if (cardMang.AdminState == "Enabled")
                btOnOff.Text = "Disable";
            else
                btOnOff.Text = "Enable";
        }

        private void btOnOff_Click(object sender, EventArgs e)
        {
            if (btOnOff.Text == "Disable")
                cardMang.AdminState = "Disabled";
            else
                cardMang.AdminState = "Enabled";
            cardMang.XuLy(cardMang.AdminState);
            load();
        }
    }
}
