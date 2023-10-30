using LARVA_UI.TwinCATConnector;
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
                foreach (XElement Diagnostic in PlcConfig.Root.Descendants())
                {
                    if (Diagnostic.Attribute("Tag") == null) continue;

                    if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_do"))
                    {
                        DiagConfig.Root.Add(new XElement("Do", new XAttribute("Name", Diagnostic.Attribute("Name").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value)));
                    }
                    else if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_di"))
                    {
                        DiagConfig.Root.Add(new XElement("Di", new XAttribute("Name", Diagnostic.Attribute("Name").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value)));
                    }
                    else if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_ao"))
                    {
                        DiagConfig.Root.Add(new XElement("Ao", new XAttribute("Name", Diagnostic.Attribute("Name").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value)));
                    }
                    else if (Diagnostic.Attribute("Tag").Value.ToLower().Equals("diagnostic_ai"))
                    {
                        DiagConfig.Root.Add(new XElement("Ai", new XAttribute("Name", Diagnostic.Attribute("Name").Value), new XAttribute("Index", Diagnostic.Attribute("Index").Value)));
                    }
                }
            }
            catch (Exception ex)
            {
                TwincatConnector.LogMessage(string.Format("{0} - {1}", "HMI Diagnostic page", "Unable to create Do/Di/Ao/Ai :" + ex.Message));
            }

            DiagConfig.Save(Properties.Settings.Default.DiagPageConfigPath);
        }
    }
}
