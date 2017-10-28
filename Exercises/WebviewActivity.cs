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
using Android.Webkit;

namespace Exercises
{
    [Activity(Label = "WebviewActivity")]
    public class WebviewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.WebviewLayout);

            var webView = FindViewById<WebView>(Resource.Id.webView1);
            webView.SetWebViewClient(new WebViewClient());
            webView.LoadUrl("http://www.neti.ee");
        }
    }
}