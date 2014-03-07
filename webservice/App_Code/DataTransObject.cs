using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///DataTransObject 的摘要说明
/// </summary>
public class DataTransObject
{
    private String clientName;
    private String message;

    public String ClientName
    {
        get { return clientName; }
        set { clientName = value; }
    }

    public String Message
    {
        get { return message; }
        set { message = value; }
    }

    public DataTransObject()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
        clientName = string.Empty;
        message = string.Empty;
    }

}