using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace priyatniy_shelest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addAgent_Click(object sender, EventArgs e)
        {
            AddAgent addAgent = new AddAgent();
            addAgent.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentList agent = new AgentList();
            agent.Show();
            this.Hide();
        }
    }
}
