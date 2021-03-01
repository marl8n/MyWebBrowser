
namespace MyWebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabMan = new System.Windows.Forms.TabControl();
            this.textUrl = new System.Windows.Forms.ComboBox();
            this.btnDateDesc = new System.Windows.Forms.Button();
            this.btnDateAsc = new System.Windows.Forms.Button();
            this.btnVistsDesc = new System.Windows.Forms.Button();
            this.btnVisitsAsc = new System.Windows.Forms.Button();
            this.tabPage.SuspendLayout();
            this.tabMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 48);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(72, 48);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(48, 28);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(873, 48);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(61, 28);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTab.Location = new System.Drawing.Point(942, 48);
            this.btnNewTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(100, 28);
            this.btnNewTab.TabIndex = 3;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.webBrowser);
            this.tabPage.Location = new System.Drawing.Point(4, 25);
            this.tabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage.Size = new System.Drawing.Size(1021, 467);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "tabPage1";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(4, 4);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1013, 459);
            this.webBrowser.TabIndex = 0;
            // 
            // tabMan
            // 
            this.tabMan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMan.Controls.Add(this.tabPage);
            this.tabMan.Location = new System.Drawing.Point(16, 81);
            this.tabMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMan.Name = "tabMan";
            this.tabMan.SelectedIndex = 0;
            this.tabMan.Size = new System.Drawing.Size(1029, 496);
            this.tabMan.TabIndex = 5;
            // 
            // textUrl
            // 
            this.textUrl.FormattingEnabled = true;
            this.textUrl.Location = new System.Drawing.Point(16, 17);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(1026, 24);
            this.textUrl.TabIndex = 6;
            this.textUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUrl_KeyPress);
            // 
            // btnDateDesc
            // 
            this.btnDateDesc.Location = new System.Drawing.Point(791, 51);
            this.btnDateDesc.Name = "btnDateDesc";
            this.btnDateDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDateDesc.TabIndex = 8;
            this.btnDateDesc.Text = "Date ⬇";
            this.btnDateDesc.UseVisualStyleBackColor = true;
            this.btnDateDesc.Click += new System.EventHandler(this.btnDateDesc_Click);
            // 
            // btnDateAsc
            // 
            this.btnDateAsc.Location = new System.Drawing.Point(710, 52);
            this.btnDateAsc.Name = "btnDateAsc";
            this.btnDateAsc.Size = new System.Drawing.Size(75, 23);
            this.btnDateAsc.TabIndex = 9;
            this.btnDateAsc.Text = "Date ⬆";
            this.btnDateAsc.UseVisualStyleBackColor = true;
            this.btnDateAsc.Click += new System.EventHandler(this.btnDateAsc_Click);
            // 
            // btnVistsDesc
            // 
            this.btnVistsDesc.Location = new System.Drawing.Point(629, 52);
            this.btnVistsDesc.Name = "btnVistsDesc";
            this.btnVistsDesc.Size = new System.Drawing.Size(75, 23);
            this.btnVistsDesc.TabIndex = 10;
            this.btnVistsDesc.Text = "Visits ⬇";
            this.btnVistsDesc.UseVisualStyleBackColor = true;
            this.btnVistsDesc.Click += new System.EventHandler(this.btnVistsDesc_Click);
            // 
            // btnVisitsAsc
            // 
            this.btnVisitsAsc.Location = new System.Drawing.Point(548, 52);
            this.btnVisitsAsc.Name = "btnVisitsAsc";
            this.btnVisitsAsc.Size = new System.Drawing.Size(75, 23);
            this.btnVisitsAsc.TabIndex = 11;
            this.btnVisitsAsc.Text = "Visits ⬆";
            this.btnVisitsAsc.UseVisualStyleBackColor = true;
            this.btnVisitsAsc.Click += new System.EventHandler(this.btnVisitsAsc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 590);
            this.Controls.Add(this.btnVisitsAsc);
            this.Controls.Add(this.btnVistsDesc);
            this.Controls.Add(this.btnDateAsc);
            this.Controls.Add(this.btnDateDesc);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.tabMan);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage.ResumeLayout(false);
            this.tabMan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabControl tabMan;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ComboBox textUrl;
        private System.Windows.Forms.Button btnDateDesc;
        private System.Windows.Forms.Button btnDateAsc;
        private System.Windows.Forms.Button btnVistsDesc;
        private System.Windows.Forms.Button btnVisitsAsc;
    }
}

