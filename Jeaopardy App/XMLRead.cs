using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Jeaopardy_App
{
    class XMLRead
    {
        public static void XmlCreate()
        {
            XDocument xdoc = XDocument.Load("https://instructure-uploads.s3.amazonaws.com/account_83640000000000001/attachments/38342/Jeopardy.xml?response-content-disposition=inline%3B%20filename%3D%22Jeopardy.xml%22%3B%20filename%2A%3DUTF-8%27%27Jeopardy.xml&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAJDW777BLV26JM2MQ%2F20180730%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20180730T033019Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=994eecee8eb18c17f75af22c13d95ad4d02ea63321277c9ddd81fabe4b675877");
        }
    }
}
