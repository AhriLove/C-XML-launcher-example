using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MyLauncher
{
    public partial class Form1 : Form
    {
        // Config URL params
        private string xmlUrl = "http://www.myserver.com/launcher_info.php";
        private string articleUrl = "http://www.myserver.com/article/";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();

            try
            {
                xDoc.Load(xmlUrl);
            }
            catch (Exception /*e*/)
            {
                // Error
            }

            // Load global info of XML
            XmlNode info = xDoc.SelectSingleNode("ServerInfo");

            // Get news datas
            XmlNode newsData = info.SelectSingleNode("News");
            XmlNodeList articleList = newsData.SelectNodes("article");
            int articleOrder = 0;

            foreach (XmlNode article in articleList)
            {
                // Title
                LinkLabel title = new LinkLabel();
                title.Text = article.SelectSingleNode("title").InnerText;
                title.AutoSize = false;
                title.Size = new Size(300, 15);
                title.Location = new Point(15, 40 + (60 * articleOrder)); // Multiply Height position with articleOrder to order articles
                title.Tag = articleUrl + article.SelectSingleNode("id").InnerText; // Assing url on Tag propery to handle
                title.LinkClicked += new LinkLabelLinkClickedEventHandler(GoToArticle);

                title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                title.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                title.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                title.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                newsPanel.Controls.Add(title);

                // Date
                Label date = new Label();
                date.Text = "[" + article.SelectSingleNode("date").InnerText + "]";
                date.AutoSize = false;
                date.Size = new Size(120, 15);
                date.TextAlign = System.Drawing.ContentAlignment.TopRight;
                date.ForeColor = System.Drawing.ColorTranslator.FromHtml("#533100");
                date.Location = new Point(368, title.Location.Y);
                newsPanel.Controls.Add(date);

                // Summary
                Label summary = new Label();
                summary.Text = article.SelectSingleNode("summary").InnerText;
                summary.AutoSize = false;
                summary.Size = new Size(400, 40);
                summary.Location = new Point(title.Location.X, title.Location.Y + 15);
                summary.ForeColor = System.Drawing.Color.DarkGray;
                newsPanel.Controls.Add(summary);

                articleOrder++;
            }

            // Get server status datas and update UI
            XmlNode statusData = info.SelectSingleNode("ServerStatus");
            status.Text = statusData.SelectSingleNode("status").InnerText;
            onlinePlayers.Text = statusData.SelectSingleNode("playersOnline").InnerText + " jugadores online";
            allianceOnline.Text = statusData.SelectSingleNode("allianceOnline").InnerText;
            hordeOnline.Text = statusData.SelectSingleNode("hordeOnline").InnerText;

            // Show panels
            statusPanel.Visible = true;
            newsPanel.Visible = true;
        }

        private void GoToArticle(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            System.Diagnostics.Process.Start(link.Tag.ToString());
        }
    }
}
