using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。 
// [System.Web.Script.Services.ScriptService]

public class MyService : System.Web.Services.WebService
{
    public MyService()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public string SendMessage(DataTransObject dataTransObject)
    {
        if (string.IsNullOrEmpty(dataTransObject.ClientName))
        {
            return "Who are you?";
        }
        if (string.IsNullOrEmpty(dataTransObject.Message))
        {
            return "What are you say";
        }
        return dataTransObject.ClientName + " Send :" + dataTransObject.Message;
    }

}