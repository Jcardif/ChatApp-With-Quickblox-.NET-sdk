using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quickblox.Sdk;
using Quickblox.Sdk.Modules.AuthModule.Models;

namespace XamarinQuickBlox.Activities
{
    [Activity(Label = "LogInActivity", MainLauncher = true, Theme = "@style/LogIn")]
    public class LogInActivity : AppCompatActivity, View.IOnClickListener
    {
        private EditText _usernameEdtTxt, _emailEdtTxt, _passwordEdtTxt;
        private Button _loginBtn, _signUpBtn;

        private const int APP_ID = 1;
        private const string AUTH_KEY = "";
        private const string AUTH_SECRET = "";
        private const string ACCOUNT_KEY = "";
        private QuickbloxClient _QBClient;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Init QuickBlox
             _QBClient = new QuickbloxClient(APP_ID,AUTH_KEY,AUTH_SECRET, "https://api.quickblox.com ", "");

            //Init View
            SetContentView(Resource.Layout.MainLogInLayout);
            _usernameEdtTxt = FindViewById<EditText>(Resource.Id.usernameEdtTxt);
            _emailEdtTxt = FindViewById<EditText>(Resource.Id.emailEdtTxt);
            _passwordEdtTxt = FindViewById<EditText>(Resource.Id.passowrdEdtTxt);
            _loginBtn = FindViewById<Button>(Resource.Id.loginBtn);
            _signUpBtn = FindViewById<Button>(Resource.Id.signUpBtn);

            //Handle clicks
            _loginBtn.SetOnClickListener(this);
            _signUpBtn.SetOnClickListener(this);
        }

        public async void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.loginBtn:
                   await _QBClient.ChatXmppClient.Connect(Convert.ToInt32(_usernameEdtTxt.Text), _passwordEdtTxt.Text);
                    break;

                case Resource.Id.signUpBtn:
                    await _QBClient.ChatXmppClient.
                    break;
            }
        }
    }
}