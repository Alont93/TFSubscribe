using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TFSubscriber
{
    [ServiceContract(Namespace="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03")]
    public interface IRollupService
    {
 
        [OperationContract(Action = "http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/Notify")]
        [XmlSerializerFormat(Style = OperationFormatStyle.Document)]
        void Notify(string eventXml, string tfsIdentityXml);
 
    }
 

}
