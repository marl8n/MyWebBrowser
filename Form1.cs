﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyWebBrowser.utils.UrlUtils;

namespace MyWebBrowser
{


    public partial class Form1 : Form
    {

        WebBrowser webTab = null;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabMan.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabMan.SelectedTab.Controls[0] as WebBrowser;
            if ( web != null )
            {
                web.Navigate(textUrl.Text);
            }
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabMan.Controls.Add(tab);
            tabMan.SelectTab(tabMan.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed=true } ;
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com/");
            webTab.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabMan.SelectedTab.Controls[0] as WebBrowser;
            if ( web != null)
            {
                if ( web.CanGoBack )
                {
                    web.GoBack();
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabMan.SelectedTab.Controls[0] as WebBrowser;
            if ( web != null )
            {
                if ( web.CanGoForward )
                {
                    webBrowser.GoForward();
                }
            }
        }

        private void textUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
         if ( e.KeyChar == (Char) 13)
            {
                WebBrowser web = tabMan.SelectedTab.Controls[0] as WebBrowser;
                if ( web != null )
                {
                    Regex isSearch = new Regex("^\\w+");

                    textUrl.Text = NormalizeUrl(textUrl.Text);
                    web.Navigate(textUrl.Text);
                }
            }   
        }
    }
}