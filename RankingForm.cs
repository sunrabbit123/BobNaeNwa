﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobNaeNwa
{
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();

            OnRangeChanged("주간");
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            OnRangeChanged("주간");
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            OnRangeChanged("월간");
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            OnRangeChanged("연간");
        }

        private void OnRangeChanged(string range)
        {
            // 여기에서 리스트 잘 업데이트
        }
    }
}
