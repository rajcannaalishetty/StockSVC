using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsStockSvcHost
{
    public partial class StockService : ServiceBase
    {
        ServiceHost host;

        public StockService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof (StockSVC.StockService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
