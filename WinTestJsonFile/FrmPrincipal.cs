using BNVal.Sab.BE.CyLiq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestJsonFile
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["captionForm"];
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            string dataStr = File.ReadAllText(ConfigurationManager.AppSettings["jSonFileName"]);



            var respProc = JsonConvert.DeserializeObject<GeneralResponseCylBE<RespaAsignaBE>>(dataStr);



        }
    }
}
