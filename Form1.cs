using MyWebBrowser.models;
using MyWebBrowser.persistance;
using MyWebBrowser.persistance.toFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private string localDir = AppContext.BaseDirectory;

        WebBrowser webTab = null;
        History history = null;
        WriteHtml writeHtml = null;

        public Form1()
        {
            InitializeComponent();
            history = new History();
            writeHtml = new WriteHtml();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            if (history.VisitedUrls != null)
            {
                history.VisitedUrls.ForEach(Visit => textUrl.Items.Add(Visit.Url));
            }
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabMan.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            go();
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
                    textUrl.Text = webBrowser.Url.ToString();
                    history.AddUrl(textUrl.Text);
                    loadUrls(history.VisitedUrls);
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
                    textUrl.Text = webBrowser.Url.ToString();
                    history.AddUrl(textUrl.Text);
                    loadUrls(history.VisitedUrls);
                }
            }
        }

        private void textUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                go();
            }
        }

        private void go()
        {
            WebBrowser web = tabMan.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                Regex isSearch = new Regex("^¿?([\\wáéíóú]+\\s?)+\\??$");
                if (isSearch.IsMatch(textUrl.Text))
                {
                    textUrl.Text = $"http://www.google.com/search?q={textUrl.Text}";
                    web.Navigate(textUrl.Text);
                    webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
                }
                else
                {
                    textUrl.Text = NormalizeUrl(textUrl.Text);
                    web.Navigate(textUrl.Text);
                }
            }
            history.AddUrl(textUrl.Text);
            loadUrls(history.VisitedUrls);
        }

        private void loadUrls( List<Visit> visits )
        {
            textUrl.Items.Clear();
            visits.ForEach(visit => textUrl.Items.Add(visit.Url));
        }

        private void btnVisitsAsc_Click(object sender, EventArgs e)
        {
            var list = history.VisitedUrls.OrderBy(visit => visit.TimesVisited).Reverse().ToList();
            loadUrls(list);
        }

        private void btnVistsDesc_Click(object sender, EventArgs e)
        {
            var list = history.VisitedUrls.OrderBy(visit => visit.TimesVisited).ToList();
            loadUrls(list);
        }

        private void btnDateAsc_Click(object sender, EventArgs e)
        {
            var list = history.VisitedUrls.OrderBy(visit => visit.LastVisit).Reverse().ToList();
            loadUrls(list);
        }

        private void btnDateDesc_Click(object sender, EventArgs e)
        {
            var list = history.VisitedUrls.OrderBy(visit => visit.LastVisit).ToList();
            loadUrls(list);
        }
    }
}
