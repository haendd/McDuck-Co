using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDuck
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            string line;
            string current = Directory.GetCurrentDirectory();
            string configPath = current + "\\config.txt";
            if (!File.Exists(configPath)) 
            {
                File.Create(configPath);
            }
            else
            {
                StreamReader sr = new StreamReader(configPath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    if( line.Length < 3 )
                    {
                        Console.WriteLine("Config File Error");
                        return;
                    }
                    string start = line.Substring(0, 3);
                    switch (start)
                    {
                        case "ETH":
                            ethereumWalletAddressInput.Text = line.Substring(4);
                            line = sr.ReadLine();
                            ethereumPoolAddressInput.Text = line.Substring(4);
                            break;
                        case "XMR":
                            moneroWalletAddressInput.Text = line.Substring(4);
                            line = sr.ReadLine();
                            moneroPoolAddressInput.Text = line.Substring(4);
                            break;
                        default:

                            break;
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }

        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string type = launcherCryptoSelector.Text;
            string walletAddress = "N/A";
            string poolAddress = "N/A";
            string current = Directory.GetCurrentDirectory();

            switch (type) 
            {
                case "Ethereum":
                    walletAddress = ethereumWalletAddressInput.Text;
                    poolAddress = ethereumPoolAddressInput.Text;
                    StreamWriter sw = new StreamWriter(current + "\\Mining\\Ethereum\\1_Ehereum-nanopool.bat");
                    sw.WriteLine("EthDcrMiner64.exe -epool " + poolAddress + " -ewal " + walletAddress + " -eworker Claymore -epsw x -mode 1 -r 0 -dbg -1 -mport 0 -etha 0 -retrydelay 1 -ftime 55 -tt 79 -ttli 77 -tstop 89 -tstart 79");
                    sw.WriteLine("pause");
                    sw.Close();
                    Directory.SetCurrentDirectory(current + "\\Mining\\Ethereum");
                    System.Diagnostics.Process.Start("1_Ehereum-nanopool.bat");
                    Directory.SetCurrentDirectory(current);
                    break;
                case "Monero":
                    walletAddress = moneroWalletAddressInput.Text;
                    poolAddress = moneroPoolAddressInput.Text;
                    break;
                default:

                    break;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string current = Directory.GetCurrentDirectory();
            string configPath = current + "\\config.txt";
            StreamWriter sw = new StreamWriter(configPath);
            string start;

            start = "ETH ";
            sw.WriteLine(start + ethereumWalletAddressInput.Text);
            sw.WriteLine(start + ethereumPoolAddressInput.Text);

            start = "XMR ";
            sw.WriteLine(start + moneroWalletAddressInput.Text);
            sw.WriteLine(start + moneroPoolAddressInput.Text);

            //close the file
            sw.Close();
        }
    }
}
