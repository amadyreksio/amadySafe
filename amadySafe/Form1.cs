using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace amadySafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mainPath = @"c:\amady\safe\";
        string tempPath = @"c:\amady\safe\tmp\";
        string configname = "c281d527-4619-40de-a0ac-85cba8d30531.f";
        public string password = null;
        Dictionary<string,string> config = new Dictionary<string,string>();
        ImageList imgList = new ImageList();
        private void Form1_Load(object sender, EventArgs e)
        {
            dane.mainform = this;
            imgList.ImageSize = new Size(16, 16);
            listView1.SmallImageList = imgList;
            listView1.LargeImageList = imgList;
            listView1.StateImageList = imgList;
            new Thread(() => { 
            //using (var rng = RandomNumberGenerator.Create())
            //{
            //    rng.GetBytes(salt);
            //}
            Directory.CreateDirectory(mainPath);
            Directory.CreateDirectory(tempPath);
                if (File.Exists(mainPath + configname))
                {
                    //OPEN
                    status = "Waiting for user input...";
                    password = PasswordInputBox.Show("Provide the password", "Open the safe");
                    if (password == string.Empty){ Application.Exit(); return;
                }
                    status = "Decrypting the config file...";
                    byte[] dec = decrypt(File.ReadAllBytes(Path.Combine(mainPath, configname)), password);
                if (dec == null) { MessageBox.Show("WRONG PASSWORD IDIOT"); Form1_Load(sender, e);return; }
                string cfg = Encoding.UTF8.GetString(dec);
                    status = "Parsing...";
                    config = JsonConvert.DeserializeObject<Dictionary<string, string>>(cfg);
                    int cnt = 0;
                foreach (KeyValuePair<string, string> entry in config)
                {
                    ListViewItem item=new ListViewItem();
                    item.Text = entry.Key;
                    item.Tag = entry.Value;
                        string extension = Path.GetExtension(item.Text);
                        if (!imgList.Images.ContainsKey(extension))
                        {
                            Icon icon = FileIconHelper.GetIconByExtension(extension);
                            this.Invoke(new Action(() => imgList.Images.Add(extension, icon)));
                        }
                        item.ImageKey = extension;
                        this.Invoke(new Action(()=>listView1.Items.Add(item)));
                }
                    

                //MessageBox.Show(cfg);
            }
            else
            {
                    //CREATE
                    status = "Waiting for user input...";
                    password = PasswordInputBox.Show("Provide the password", "Create the safe");
                    status = "Creating the safe...";
                    string cfg = "{}";
                config=JsonConvert.DeserializeObject<Dictionary<string, string>>(cfg);

                File.WriteAllBytes(Path.Combine(mainPath, configname), encrypt(System.Text.Encoding.UTF8.GetBytes(cfg), password));
            }
                this.Invoke(new Action(() => logo.Hide()));
                this.Invoke(new Action(() => panel1.Show()));
                status = "Done.";
            }).Start();
        }
        byte[] salt = new byte[] { 0x12, 0xAB, 0x34, 0xCD, 0x56, 0xEF, 0x78, 0x90 };
            

        byte[] encrypt(byte[] bajty, string password)
        {
                var aes = new AesEncryptionWithPassword(password, salt);

                byte[] encrypted = aes.Encrypt(bajty);
            
            return encrypted;
            
        }
        byte[] decrypt(byte[] bajty, string password) {
            var aes = new AesEncryptionWithPassword(password, salt);
            byte[] decrypted = aes.Decrypt(bajty);
            return decrypted;
            //string decryptedText = Encoding.UTF8.GetString(decrypted);
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "ALL FILES|*.*|FEET PICS i mean photos|*.JPG";
            dlg.Title = "Select your secret you wanna hide";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                new Thread(() => {

                    status = "Reading file bytes...";
                    byte[] fbytes=File.ReadAllBytes(dlg.FileName);
                    status = "Encrypting...";
                    byte[] encrypted = encrypt(fbytes, password);
                string name = Guid.NewGuid().ToString() + ".f";
                    status = "Saving the file...";
                    File.WriteAllBytes(mainPath + name, encrypted);
                config.Add(Path.GetFileName(dlg.FileName),name);
                saveConfig();
                    status = "Parsing...";
                    ListViewItem item = new ListViewItem();
                item.Text = Path.GetFileName(dlg.FileName);
                item.Tag = name;
                    string extension = Path.GetExtension(item.Text);
                    if (!imgList.Images.ContainsKey(extension))
                    {
                        Icon icon = FileIconHelper.GetIconByExtension(extension);
                        this.Invoke(new Action(() => imgList.Images.Add(extension, icon)));
                    }
                    item.ImageKey = extension;

                    this.Invoke(new Action(() => { listView1.Items.Add(item); }));
                    status = "Done.";
            }).Start();
            }
        }

        void item_click()
        {

        }
        void saveFILE(string fname, byte[] bytes)
        {
            File.WriteAllBytes(mainPath+fname,encrypt(bytes,password));
            status = "Done.";
        }
        void saveConfig()
        {
            status = "Saving config file...";
            saveFILE(mainPath + configname, JsonConvert.SerializeObject(config));
        }
        void saveFILE(string fname, string content)
        {
            File.WriteAllBytes(fname, encrypt(Encoding.UTF8.GetBytes(content), password));
            status = "Done.";
        }
        void clearTemp()
        {
            status = "Clearing TEMP...";
            Directory.Delete(tempPath, true);
            Directory.CreateDirectory(tempPath);
            status = "Done.";
        }
        int prg = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count == 0) return;
            string tag = listView1.SelectedItems[0].Tag.ToString();
            string text = listView1.SelectedItems[0].Text;
            string fname = tempPath + tag.Replace(".f", Path.GetExtension(text));
            if (File.Exists(fname))
            {
                Process p = new Process();
                p.StartInfo.FileName = fname;
                p.Start();
                status = "Done.";
                return;
            }
            new Thread(() => {
                prg = 0;

                //open a file
                status = "Reading file bytes...";
                byte[] fbytes = File.ReadAllBytes(mainPath + tag);
                prg = 25;
                status = "Decrypting the byte array...";
                byte[] decrypted=decrypt(fbytes, password);
                prg = 50;
                
            File.WriteAllBytes(fname,decrypted);
                prg = 90;
                status = "Starting Process...";
                Process p=new Process();
            p.StartInfo.FileName = fname;
            p.Start();
                prg = 100;
                status = "Done.";
            }).Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearTemp();
        }
        string status = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            fancyProgressBar1.Value = prg;
            statustext.Text = status;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            string tag = listView1.SelectedItems[0].Tag.ToString();
            string text = listView1.SelectedItems[0].Text;
            foreach(KeyValuePair<string,string> kvp in config)
            {
                if (kvp.Key == text && kvp.Value == tag)
                {
                    config.Remove(kvp.Key);
                    File.Delete(mainPath + kvp.Value);
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    saveConfig();
                    break;
                }
            }
        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C&&e.Control)
            {
                if (listView1.SelectedItems.Count == 0) return;
                string tag = listView1.SelectedItems[0].Tag.ToString();
                string text = listView1.SelectedItems[0].Text;
                new Thread(() => {
                    prg = 0;

                    //open a file
                    status = "Reading file bytes...";
                    byte[] fbytes = File.ReadAllBytes(mainPath + tag);
                    prg = 25;
                    status = "Decrypting the byte array...";
                    byte[] decrypted = decrypt(fbytes, password);
                    prg = 50;
                    string fname = tempPath + text;
                    status = "Saving to TEMP...";
                    File.WriteAllBytes(fname, decrypted);
                    prg = 100;
                }).Start();
                status = "Copying to clipboard...";
                StringCollection paths = new StringCollection();
                paths.Add(tempPath+listView1.SelectedItems[0].Text.ToString());
                Clipboard.SetFileDropList(paths);
                status = "Done.";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                listView1_DoubleClick(sender, e);
            }
        }

        private void amadyButton1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            string newname = Microsoft.VisualBasic.Interaction.InputBox("Provide the new file name", "Refactor");
            if(newname==null||newname==String.Empty) return;
            string tag = listView1.SelectedItems[0].Tag.ToString();
            string text = listView1.SelectedItems[0].Text;
            string ext=Path.GetExtension(text);
            status = "Changing filename...";
            listView1.SelectedItems[0].Text = newname+ext;
            string key = config[text];
            config.Remove(text);
            config[newname+ext] = key;
            saveConfig();
            status = "Done.";
        }

        private void amadyButton2_Click(object sender, EventArgs e)
        {
            new SafeEditor().Show();
        }
        public void applySettings(string pwd)
        {
            if (password != pwd)
            {
                changePassword(pwd);
            }

        }
        void changePassword(string pwd)
        {
            panel1.Hide();
            logo.Show();
            new Thread(() => { 
            foreach (KeyValuePair<string,string> kvp in config)
            {
                    prg = 10;
                    status = $"Reading bytes...[{kvp.Key}]";
                    byte[]encrBytes=File.ReadAllBytes(mainPath+kvp.Value);
                    prg = 20;
                    status = $"Decrypting byte array...[{kvp.Key}]";
                    byte[] decrBytes = decrypt(encrBytes, password);
                    prg = 70;
                    status = $"Encrypting byte array with the new password...[{kvp.Key}]";
                    byte[] finalBytes = encrypt(decrBytes, pwd);
                    prg = 90;
                    status = $"Saving...[{kvp.Key}]";
                    File.WriteAllBytes(mainPath+kvp.Value, finalBytes);
                    prg = 100;
                }
                prg = 60;
                status = "Reading bytes...[CONFIG]";
                byte[] encrBytesc = File.ReadAllBytes(mainPath + configname);
                prg = 70;
                status = "Decrypting byte array...[CONFIG]";
                byte[] decrBytesc = decrypt(encrBytesc, password);
                prg = 80;
                status = "Encrypting byte array with the new password...[CONFIG]";
                byte[] finalBytesc = encrypt(decrBytesc, pwd);
                prg = 90;
                status = "Saving...[CONFIG]";
                File.WriteAllBytes(mainPath + configname, finalBytesc);
                prg = 100;
                password = pwd;
                status = "Done.";
                this.Invoke(new Action(() => {
                    panel1.Show();
                    logo.Hide();
                }));
            }).Start();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
