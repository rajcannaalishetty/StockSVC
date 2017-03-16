using StockSVC.StockWebService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace StockSVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StockService" in both code and config file together.
    public class StockService : IStockService
    {
        public Stock GetQuote(string codename)
        {
            StockQuoteSoapClient stckclient = new StockQuoteSoapClient();
            var quote = stckclient.GetQuote(codename);
            return XmlToStock(quote);


        }

        public Stock XmlToStock(string xml)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Stock obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(typeof(Stock));
                xmlReader = new XmlTextReader(strReader);
                obj = (Stock)serializer.Deserialize(xmlReader);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }

    }
    }
}
