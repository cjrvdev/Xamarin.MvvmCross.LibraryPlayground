﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;

namespace Xamarin.MvvmCross.LibraryPlayground.Droid
{
    [Application(UsesCleartextTraffic = true)]
    public class MainApplication : MvxAndroidApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer)
             : base(handle, transer)
        {

        }
        public override void OnCreate()
        {
            base.OnCreate();

            Xamarin.Essentials.Platform.Init(this);
        }
    }
}