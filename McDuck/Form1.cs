using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace McDuck
{
    public partial class Form : System.Windows.Forms.Form
    {

        private string consoleOutput = "";
        private nProcess np;
        private bool runing = false;
        private string type;
        private static string current = Directory.GetCurrentDirectory();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            string line;
            String configPath = Directory.GetCurrentDirectory();
            configPath += "\\config.txt";
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

        private InvalidateEventHandler consoleWrite()
        {
            consoleTextBox.Text += consoleOutput;
            return null;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {

            if(runing)
            {
                return;
            }
            type = launcherCryptoSelector.Text;
            string walletAddress = "N/A";
            string poolAddress = "N/A";


            switch (type) 
            {

                case "Ethereum":
                {
                    walletAddress = ethereumWalletAddressInput.Text;
                    poolAddress = ethereumPoolAddressInput.Text;
                    StreamWriter sw = new StreamWriter(current + "\\Mining\\Ethereum\\1_Ehereum-nanopool.bat");
                    sw.WriteLine("EthDcrMiner64.exe -epool " + poolAddress + " -ewal " + walletAddress +
                                 " -eworker Claymore -epsw x -mode 1 -r 0 -dbg -1 -mport 0 -etha 0 -retrydelay 1 -ftime 55 -tt 79 -ttli 77 -tstop 89 -tstart 79");
                    sw.WriteLine("pause");
                    sw.Close();

                    var process = new Process();
                    var startinfo = new ProcessStartInfo("1_Ehereum-nanopool.bat");

                    startinfo.RedirectStandardOutput = false;
                    startinfo.UseShellExecute = false;
                    startinfo.CreateNoWindow = false;
                    process.StartInfo = startinfo;
                    process.EnableRaisingEvents = true;

                    np = new nProcess(process, Directory.GetCurrentDirectory() + "\\Mining\\Ethereum");
                    np.ths = new ThreadStart(() => np.launchMiner());
                    np.th = new Thread(np.ths);

                    runing = true;
                    np.th.Start();
                    break;
                }
                case "Monero":
                {
                    walletAddress = moneroWalletAddressInput.Text;
                    poolAddress = moneroPoolAddressInput.Text;

                    JObject o1 = JObject.Parse(File.ReadAllText(current +  "\\Mining\\Monero\\config.json"));
                    JArray item = (JArray) o1["pools"];
                    foreach (var thing in item)
                    {
                        thing["url"] = poolAddress;
                        thing["user"] = walletAddress;

                    }

                    File.WriteAllText(current + "\\Mining\\Monero\\config.json", o1.ToString());
                    var process = new Process();
                    var startinfo = new ProcessStartInfo("xmrig.exe");

                    startinfo.RedirectStandardOutput = false;
                    startinfo.UseShellExecute = false;
                    startinfo.CreateNoWindow = false;
                    process.StartInfo = startinfo;
                    process.EnableRaisingEvents = true;

                    np = new nProcess(process, Directory.GetCurrentDirectory() + "\\Mining\\Monero");
                    np.ths = new ThreadStart(() => np.launchMiner());
                    np.th = new Thread(np.ths);

                    runing = true;
                    np.th.Start();

                    break;
                }
                default:

                    break;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(!runing)
            {
                return;
            }
            switch (type)
            {
                case "Ethereum":
                    foreach (var process in Process.GetProcessesByName("EthDcrMiner64"))
                    {
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName("cmd"))
                    {
                        process.Kill();
                    }
                    Directory.SetCurrentDirectory(current);
                    runing = false;
                    break;

                case "Monero":
                    foreach (var process in Process.GetProcessesByName("xmrig"))
                    {
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName("cmd"))
                    {
                        process.Kill();
                    }
                    Directory.SetCurrentDirectory(current);
                    runing = false;
                    break;

                default:
                    break;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (runing)
            {
                return;
            }
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

    public class nProcess
    {
        public ThreadStart ths;
        public Thread th;
        public Process process;
        private String directory;

        public nProcess(Process proc, String direct)
        {
            process = proc;
            directory = direct;
        }

        public void launchMiner()
        {
            Directory.SetCurrentDirectory(directory);
            bool started = process.Start();
        }
    }
}
