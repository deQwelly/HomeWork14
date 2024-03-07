using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeWork14
{
    public partial class CowshedApp : Form
    {
        public CowshedApp()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "xml-files |*.xml| json-files |*.json";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = ofd.FileName;
                if (path.Contains(".xml"))
                {
                    var xmlSerializer = new XmlSerializer(typeof(AllData));
                    using (var fs = new FileStream(path, FileMode.Open))
                    {
                        var xmlData = xmlSerializer.Deserialize(fs);
                    }

                    var doc = XDocument.Load(path);

                    CreateMainTree(doc.Root, MainTree.Nodes);


                }
                else
                {
                    var json = File.ReadAllText(path);
                    var jsonData = JsonSerializer.Deserialize<AllData>(json);
                    MessageBox.Show("json");
                }
            }
        }

        private void CreateMainTree(XElement xmlElement, TreeNodeCollection treeNodes)
        {

            var newNode = treeNodes.Add(xmlElement.Name.ToString());
            foreach (XElement childElement in xmlElement.Elements())
            {
                CreateMainTree(childElement, newNode.Nodes);
            }
            if (!xmlElement.HasElements)
            {
                newNode.Text = xmlElement.Value.Trim();
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var buttonShowForm = new ButtonShowForm();
            buttonShowForm.Show();
        }
    }
}
