﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySabinoRoad.View
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage : MasterDetailPage
    {
        public NavPage()
        {
            InitializeComponent();
        }

    }

}
