using DevExpress.Xpo.Logger;
using EPLE.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LARVA_UI.Config
{
    internal class SetupManager
    {
        public static void Load_DiagConfig()
        {
            XDocument DiagConfig = XDocument.Parse("<Diagnostic></Diagnostic>");
            XDocument PlcConfig = XDocument.Load(Properties.Settings.Default.PlcConfigPath);
            try
            {
                foreach (XElement Diagnostic in PlcConfig.Root.Elements("PlcVar"))//.Descendants())
                {
                    foreach (XElement Parameter in Diagnostic.Elements("Param"))
                    {
                        if (Diagnostic.Attribute("Tag") == null) continue;

                        if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_do"))
                        {
                            DiagConfig.Root.Add(new XElement("Do", new XAttribute("Name", Parameter.Attribute("Name").Value), new XAttribute("PlcVar", Diagnostic.Attribute("Name").Value), new XAttribute("Type", Diagnostic.Attribute("DataType").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value), new XAttribute("Offset", Parameter.Attribute("Offset").Value)));
                        }
                        else if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_di"))
                        {
                            DiagConfig.Root.Add(new XElement("Di", new XAttribute("Name", Parameter.Attribute("Name").Value), new XAttribute("PlcVar", Diagnostic.Attribute("Name").Value), new XAttribute("Type", Diagnostic.Attribute("DataType").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value), new XAttribute("Offset", Parameter.Attribute("Offset").Value)));
                        }
                        else if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_ao"))
                        {
                            DiagConfig.Root.Add(new XElement("Ao", new XAttribute("Name", Parameter.Attribute("Name").Value), new XAttribute("PlcVar", Diagnostic.Attribute("Name").Value), new XAttribute("Type", Diagnostic.Attribute("DataType").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value), new XAttribute("Offset", Parameter.Attribute("Offset").Value)));
                        }
                        else if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_ai"))
                        {
                            DiagConfig.Root.Add(new XElement("Ai", new XAttribute("Name", Parameter.Attribute("Name").Value), new XAttribute("PlcVar", Diagnostic.Attribute("Name").Value), new XAttribute("Type", Diagnostic.Attribute("DataType").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value), new XAttribute("Offset", Parameter.Attribute("Offset").Value)));
                        }
                    }              
                }
            }
            catch (Exception ex)
            {
                LogHelper.Instance.ErrorLog.Error(ex.ToString());
            }

            DiagConfig.Save(Properties.Settings.Default.DiagPageConfigPath);
        }
    }
}
