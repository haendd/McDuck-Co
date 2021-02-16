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
        private nProcess cpuProcess;
        private nProcess gpuProcess;
        private bool cpuRunning = false;
        private bool gpuRunning = false;
        private string type;
        private static string current;
        private Color activeColor = Color.LawnGreen;
        private Color deactiveColor = Color.LightCoral;

        public Form()
        {
            InitializeComponent();
            current = Directory.GetCurrentDirectory();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            string line;
            int i;
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
                            if(Int32.TryParse(line.Substring(4), out i))
                                ethereumPoolAddressInput.SelectedIndex = i;
                            else
                                ethereumPoolAddressInput.SelectedIndex = 0;
                            break;
                        case "XMR":
                            moneroWalletAddressInput.Text = line.Substring(4);
                            line = sr.ReadLine();
                            if (Int32.TryParse(line.Substring(4), out i))
                                moneroPoolAddressInput.SelectedIndex = i;
                            else
                                moneroPoolAddressInput.SelectedIndex = 0;
                            break;
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
            Directory.SetCurrentDirectory(current);

            bool isCPU = false;
            if( homeTabControl.SelectedTab == cpuPage )
            {
                isCPU = true;
                if( cpuRunning )
                {
                    return;
                }
                type = cpuCryptoSelector.Text;
            }
            else
            {
                isCPU = false;
                if( gpuRunning )
                {
                    return;
                }
                type = gpuCryptoSelector.Text;
            }

            string walletAddress = "N/A";
            string poolAddress = "N/A";

            switch (type) 
            {
                case "Ethereum":
                {
                    if( isCPU )
                    {

                    }
                    else
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

                        gpuProcess = new nProcess(process, Directory.GetCurrentDirectory() + "\\Mining\\Ethereum");
                        gpuProcess.ths = new ThreadStart(() => gpuProcess.launchMiner());
                        gpuProcess.th = new Thread(gpuProcess.ths);

                        gpuRunning = true;
                        gpuStatusLabel.Text = "Running";
                        gpuStatusLabel.BackColor = activeColor;
                        gpuProcess.th.Start();
                        Thread.Sleep(0);
                    }
                    break;
                }
                case "Monero":
                {
                    if( isCPU )
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

                        cpuProcess = new nProcess(process, Directory.GetCurrentDirectory() + "\\Mining\\Monero");
                        cpuProcess.ths = new ThreadStart(() => cpuProcess.launchMiner());
                        cpuProcess.th = new Thread(cpuProcess.ths);

                        cpuRunning = true;
                        cpuStatusLabel.Text = "Running";
                        cpuStatusLabel.BackColor = activeColor;
                        cpuProcess.th.Start();
                        Thread.Sleep(0);
                    }
                    else
                    {

                    }
                    break;
                }
                default:
                    break;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            bool isCPU = false;
            if(homeTabControl.SelectedTab == cpuPage)
            {
                isCPU = true;
                if(!cpuRunning)
                {
                    return;
                }
                type = cpuCryptoSelector.Text;
            }
            else
            {
                isCPU = false;
                if(!gpuRunning)
                {
                    return;
                }
                type = gpuCryptoSelector.Text;
            }
            switch (type)
            {
                case "Ethereum":
                { 
                    if (isCPU)
                    {

                    }
                    else
                    {
                        foreach (var process in Process.GetProcessesByName("EthDcrMiner64"))
                        {
                            process.Kill();
                        }
                        foreach (var process in Process.GetProcessesByName("cmd"))
                        {
                            process.Kill();
                        }
                        Directory.SetCurrentDirectory(current);
                        gpuRunning = false;
                        gpuStatusLabel.Text = "Not Running";
                        gpuStatusLabel.BackColor = deactiveColor; 
                    }
                    break;
                }
                case "Monero":
                {
                    if (isCPU)
                    {
                        foreach (var process in Process.GetProcessesByName("xmrig"))
                        {
                            process.Kill();
                        }
                        foreach (var process in Process.GetProcessesByName("cmd"))
                        {
                            process.Kill();
                        }
                        Directory.SetCurrentDirectory(current);
                        cpuRunning = false;
                        cpuStatusLabel.Text = "Not Running";
                        cpuStatusLabel.BackColor = deactiveColor;
                    }
                    else
                    {

                    }
                    break;
                }
                default:
                    break;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (gpuRunning || cpuRunning)
            {
                return;
            }
            string current = Directory.GetCurrentDirectory();
            string configPath = current + "\\config.txt";
            StreamWriter sw = new StreamWriter(configPath);
            string start;

            start = "ETH ";
            sw.WriteLine(start + ethereumWalletAddressInput.Text);
            sw.WriteLine(start + ethereumPoolAddressInput.SelectedIndex);

            start = "XMR ";
            sw.WriteLine(start + moneroWalletAddressInput.Text);
            sw.WriteLine(start + moneroPoolAddressInput.SelectedIndex);

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
            process.Start();
        }
    }
}
