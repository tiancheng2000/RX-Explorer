﻿using System;

namespace RX_Explorer.Class
{
    public sealed class ListViewHeaderController
    {
        public static ListViewHeaderController Create()
        {
            return new ListViewHeaderController();
        }

        public FilterController Filter { get; private set; }

        public SortIndicatorController Indicator { get; private set; }

        private ListViewHeaderController()
        {
            Filter = new FilterController();
            Indicator = new SortIndicatorController();
        }
    }
}
