﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfApp1
{
    public interface ITask
    {

        public void remove();
        public void create(string s);
        public void dothis();
        public void seemore();
    }
}
