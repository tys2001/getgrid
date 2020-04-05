using System;
using System.Windows.Forms;
using System.Xml;

namespace GetGrid
{
    public partial class ConfigForm : Form
    {
        private bool confirmed;

        public ConfigForm()
        {
            InitializeComponent();
            confirmed = false;
        }

        public static AppConfig ShowDialogAndGetResult(AppConfig preConfig)
        {
            ConfigForm configForm = new ConfigForm();
            if(preConfig != null)
            {
                configForm.textNull.Text = preConfig.AsNull;
                configForm.textSeparator.Text = preConfig.Separator;
                configForm.textQuotePre.Text = preConfig.QuotePre;
            }
            configForm.ShowDialog();
            if (configForm.confirmed)
            {
                preConfig.InitValues();
                preConfig.AsNull = configForm.textNull.Text;
                preConfig.Separator = configForm.textSeparator.Text;
                preConfig.QuotePre = configForm.textQuotePre.Text;
                return preConfig;
            }
            else return null;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            confirmed = true;
            this.Close();
        }
    }
    public class AppConfig
    {
        private string configFilePath;
        private string asNull;
        private string separator;
        private string quotePre;

        public string AsNull
        {
            get { return asNull; }
            set { asNull = value; }
        }

        public string Separator
        {
            get { return separator; }
            set { separator = value; }
        }

        public string QuotePre
        {
            get { return quotePre; }
            set { quotePre = value; }
        }

        public string ConfigFilePath
        {
            get { return configFilePath; }
            set { configFilePath = value; }
        }

        public AppConfig(string configFilePath0)
        {
            configFilePath = configFilePath0;
            InitValues();
        }

        public void InitValues()
        {
            asNull = "";
            separator = "";
            quotePre = "";
        }

        public void ReadConfigXml()
        {
            XmlDocument document = new XmlDocument();
            InitValues();
            try
            {
                document.Load(configFilePath);
                asNull = document.DocumentElement["textNull"].InnerText;
                separator = document.DocumentElement["textSeparator"].InnerText;
                quotePre = document.DocumentElement["textQuotePre"].InnerText;
            }
            catch (Exception) { }
        }

        public void WriteConfigXml()
        {
            XmlDocument document = new XmlDocument();
            XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement configRoot = document.CreateElement("config");
            document.AppendChild(declaration);
            document.AppendChild(configRoot);
            try
            {
                XmlElement element;
                element = document.CreateElement("textNull");
                element.InnerText = asNull;
                configRoot.AppendChild(element);
                element = document.CreateElement("textSeparator");
                element.InnerText = separator;
                configRoot.AppendChild(element);
                element = document.CreateElement("textQuotePre");
                element.InnerText = quotePre;
                configRoot.AppendChild(element);
                document.Save(configFilePath);
            }
            catch (Exception) { }
        }
    }
}
