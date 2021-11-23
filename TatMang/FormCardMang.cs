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
            if (cardMang.AdminState == "Enabled")
                tgOnOff.Checked = true;
            else
                tgOnOff.Checked = false;

        }

        public CardMang CardMang { get => cardMang; set => cardMang = value; }

        void load()
        {
            lbNameCard.Text = cardMang.Name;
            lbAdminSate.Text = cardMang.AdminState;
            
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(tgOnOff.Checked)
                cardMang.AdminState = "Enabled";
            else
                cardMang.AdminState = "Disabled";
            cardMang.XuLy(cardMang.AdminState.Substring(0,CardMang.AdminState.Length-1));
            load();
        }
    }
}
