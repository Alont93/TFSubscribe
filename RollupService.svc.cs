using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace TFSubscriber
{
    public class RollupService : IRollupService
    {
        void IRollupService.Notify(string eventXml, string tfsIdentityXml)
        {
            global::System.Windows.Forms.MessageBox.Show("Test");
            XDocument xml = XDocument.Parse(eventXml);
            string path = xml.Root.Elements().First(e => e.Name == "Artifacts").Elements().ElementAt(1).Attributes("ServerItem").First().Value;


            var dubug = 1;
        }
    }
}
