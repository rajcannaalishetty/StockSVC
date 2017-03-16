using StockQuoteConsume.StockServiceConsume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockQuoteConsume
{
    public partial class DisplayStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StockServiceClient myStockSvc = new StockServiceClient();
            lblQuote.Text = myStockSvc.GetQuote(txtSymbol.Text);
        }
    }
}