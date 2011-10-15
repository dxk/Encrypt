using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.IO;

namespace EncryptMethod
{
    //加密研究
    public partial class King : Form
    {
        public King()
        {
            InitializeComponent();
        }

        #region 对称加密
        //-------------------Part.1 私钥加密（对称加密)--------------------------
        private byte[] keyIv;//密  *可存储模式
        private byte[] keyKey;//钥  *可以转换为字符串
        //选择文件
        private void btnGetFile_Click(object sender, EventArgs e)
        {
            checkFile(this.label1);
        }
        //加密
        private void btnJiaMi_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                return;
            }
            try
            {
                //生产对称密钥.该密钥用来对XML加密
                RijndaelManaged key = new RijndaelManaged();
                keyIv = key.IV;
                keyKey = key.Key;
                //加载XML对象,定制加密位置
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.Load(this.label1.Text);
                XmlElement elementToEncrypt = xmlDoc.GetElementsByTagName("creditcard")[0] as XmlElement;
                //生产EncrypteData类
                EncryptedData edElement = new EncryptedData();
                edElement.Type = EncryptedXml.XmlEncElementUrl;//填充Url标识符
                string encryptionMethod = null;
                if (key is TripleDES)
                {
                    encryptionMethod = EncryptedXml.XmlEncTripleDESUrl;
                }
                else if (key is DES)
                {
                    encryptionMethod = EncryptedXml.XmlEncDESUrl;
                }
                if (key is Rijndael)
                {
                    switch (key.KeySize)
                    {
                        case 128:
                            encryptionMethod = EncryptedXml.XmlEncAES128Url;
                            break;
                        case 192:
                            encryptionMethod = EncryptedXml.XmlEncAES192Url;
                            break;
                        case 256:
                            encryptionMethod = EncryptedXml.XmlEncAES256Url;
                            break;
                    }
                }
                else
                {
                    throw new CryptographicException("没有为XML加密的指定算法!");
                }
                edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);//生成具有加密算法的Url标识符
                //用EncryptedXml加密xml
                EncryptedXml eXml = new EncryptedXml();
                byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, key, false);
                //把加密的元素添加到EncryptedData中
                edElement.CipherData.CipherValue = encryptedElement;
                //最后将xml中原始数据和EncrytedXml替换
                EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
                xmlDoc.Save(this.label1.Text);
                succes();
            }
            catch (Exception ex)
            {
                fail();
            }
        }
        //解密
        private void btnJieMi_Click(object sender, EventArgs e)
        {
            try
            {
                RijndaelManaged key = new RijndaelManaged();
                key.IV = keyIv;
                key.Key = keyKey;
                XmlDocument Doc = new XmlDocument();
                Doc.PreserveWhitespace = true;
                Doc.Load(this.label1.Text);
                XmlElement encryptedElement = Doc.GetElementsByTagName("EncryptedData")[0] as XmlElement;
                if (encryptedElement == null)
                {
                    throw new XmlException("T错误!");
                }
                EncryptedData edElement = new EncryptedData();
                edElement.LoadXml(encryptedElement);
                EncryptedXml exml = new EncryptedXml();//利用它解密
                byte[] rgbOutput = exml.DecryptData(edElement, key);//利用解药解密
                exml.ReplaceData(encryptedElement, rgbOutput);//替换密文部分
                Doc.Save(this.label1.Text);
                succes();
            }
            catch (Exception ex)
            {
                fail();
            }
        }
        #endregion

        #region 非对称加密
        //-------------------Part.2 非对称加密------------------------
        //--（公钥加密,私钥解密）
        string privateK;//私钥
        string publicK;//公钥
        string keyName = "keyName_1";
        //产生公、私钥
        private void madePuPrKey()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            privateK = rsa.ToXmlString(true);
            publicK = rsa.ToXmlString(false);
        }
        //选择文件
        private void btn2ChoseXML_Click(object sender, EventArgs e)
        {
            madePuPrKey();
            checkFile(this.label2);
        }
        //加密
        private void btn2JiaMi_Click(object sender, EventArgs e)
        {
            try
            {
                //经过咨询微软全球技术服务中心和查阅微软Support站点和Technet站点，得出以下结论：使用EFS加密的文件（夹）一旦密钥丢失以后是不可能恢复的
                //*****生产对称密钥.该密钥用来对XML加密
                //CspParameters cspParams = new CspParameters();
                //cspParams.KeyContainerName = "XML_ENC_RSA_KEY";
                //生成一个对称密钥,对密钥进行加密
                RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
                rsaKey.FromXmlString(publicK);
                //加载XML对象,定制加密位置
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.Load(this.label2.Text);
                XmlElement elementToEncrypt = xmlDoc.GetElementsByTagName("creditcard")[0] as XmlElement;
                //*****处理EncrypteData对象
                EncryptedData edElement = new EncryptedData();
                edElement.Type = EncryptedXml.XmlEncElementUrl;
                edElement.Id = "encryptedElement1";//EncryptionElementID;
                //生成会话密钥的加密算法的 URL 标识符
                edElement.EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncAES256Url);
                //用RijindaelManaged加密元素（即用会话密钥加密元素）
                RijndaelManaged sessionKey = new RijndaelManaged();
                sessionKey.KeySize = 256;
                byte[] encryptedElement = new EncryptedXml().EncryptData(elementToEncrypt, sessionKey, false);
                //用EncrypteKey对象（对会话密钥进行加密）
                EncryptedKey ek = new EncryptedKey();
                byte[] encrytedKey = EncryptedXml.EncryptKey(sessionKey.Key, rsaKey, false);
                ek.CipherData = new CipherData(encrytedKey);
                ek.EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncRSA15Url);
                //将加密的密钥添加到EncrypteData中
                edElement.KeyInfo.AddClause(new KeyInfoEncryptedKey(ek));
                //`````用KeyInfo指定RSA密钥名称，这将帮助解密方识别正确的非对称密钥
                KeyInfoName kin = new KeyInfoName();
                kin.Value = keyName;
                ek.KeyInfo.AddClause(kin);
                //替换xml Dom 元素
                edElement.CipherData.CipherValue = encryptedElement;
                EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
                //保存
                xmlDoc.Save(this.label2.Text);
                succes();
            }
            catch (Exception ess)
            {
                fail();
            }
        }
        //解密
        private void btn2Open_Click(object sender, EventArgs e)
        {
            try
            {
                RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
                rsaKey.FromXmlString(privateK);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.Load(this.label2.Text);
                EncryptedXml exml = new EncryptedXml(xmlDoc);
                exml.AddKeyNameMapping(keyName, rsaKey);
                exml.DecryptDocument();
                xmlDoc.Save(this.label2.Text);
                succes();
            }
            catch (Exception)
            {
                fail();
            }
        }
        //--（私钥加密,公钥验证）
        #endregion

        #region 加密签名验证
        //-------------------Part.3 加密签名验证-------------------------
        //选择文件
        private void btn3Chose_Click(object sender, EventArgs e)
        {
            madePuPrKey();
            checkFile(this.label5);
        }
        //生成
        private string str;
        private void btn3JiaMi_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(privateK);
                    // 加密对象 
                    RSAPKCS1SignatureFormatter f = new RSAPKCS1SignatureFormatter(rsa);
                    f.SetHashAlgorithm("SHA1");
                    //hash后的数据只能通过密钥解密(为了保证数据的安全，可以用对称加密加密一下数据)
                    byte[] source = System.Text.ASCIIEncoding.ASCII.GetBytes("shuju");
                    SHA1Managed sha = new SHA1Managed();
                    byte[] result = sha.ComputeHash(source);
                    string s = Convert.ToBase64String(result);
                    byte[] b = f.CreateSignature(result);
                    str = Convert.ToBase64String(b);
                    succes();
                }
                catch (Exception es)
                {
                    fail();
                }
            }
        }
        //验证
        private void btn3JieMi_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(publicK);
                    RSAPKCS1SignatureDeformatter f = new RSAPKCS1SignatureDeformatter(rsa);
                    f.SetHashAlgorithm("SHA1");
                    byte[] key = Convert.FromBase64String(str);
                    SHA1Managed sha = new SHA1Managed();
                    byte[] name = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes("shuju"));
                    string s = Convert.ToBase64String(name);
                    if (f.VerifySignature(name, key))
                        succes();
                    else
                        fail();
                }
                catch (Exception ee)
                {
                    fail();
                }
            }
        }
        #endregion

        #region Hash算法
        //-------------------Part.4 Hash值----------------------------
        //MD5CryptoServiceProvider-MD5算法
        private string getHashByMD5(string input)
        {
            //将input以MD5形式Hash
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        private bool validateByMD5(string input, string hash)
        {
            string hashOfInput = getHashByMD5(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            //相对顺序的比较，相等为0
            if (0 == comparer.Compare(hashOfInput, hash)) { MessageBox.Show(hashOfInput); return true; } else { fail(); return false; }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string source = "Hello World!";
            string hash = getHashByMD5(source);
            validateByMD5(source, hash);
        }
        //SHA1Managed-SHA1算法
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = this.textBox1.Text;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(txt);//转换string为数组
            string str;
            string str1;
            SHA1 shaM = new SHA1Managed();
            str1 = Convert.ToBase64String(shaM.ComputeHash(data));
            str = Convert.ToBase64String(shaM.ComputeHash(data));
            if (str1.Equals(str))
                MessageBox.Show(str);
        }
        //SHA256Managed-SHA256算法
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = this.textBox1.Text;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(txt);//转换string为数组
            string str;
            string str1;
            SHA256 shaM = new SHA256Managed();
            str1 = Convert.ToBase64String(shaM.ComputeHash(data));
            str = Convert.ToBase64String(shaM.ComputeHash(data));
            if (str1.Equals(str))
                MessageBox.Show(str);
        }
        //SHA384Managed-SHA384算法
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = this.textBox1.Text;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(txt);//转换string为数组
            string str;
            string str1;
            SHA384 shaM = new SHA384Managed();
            str1 = Convert.ToBase64String(shaM.ComputeHash(data));
            str = Convert.ToBase64String(shaM.ComputeHash(data));
            if (str1.Equals(str))
                MessageBox.Show(str);
        }
        //SHA512Managed-SHA512算法
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = this.textBox1.Text;
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(txt);//转换string为数组
            string str;
            string str1;
            SHA512 shaM = new SHA512Managed();
            str1 = Convert.ToBase64String(shaM.ComputeHash(data));
            str = Convert.ToBase64String(shaM.ComputeHash(data));
            if (str1.Equals(str))
                MessageBox.Show(str);
        }
        #endregion

        #region 强随机数
        //-------------------Part.5 强随机数生成----------------------
        public byte RollDice(byte numberSides)
        {
            if (numberSides <= 0)
                throw new ArgumentOutOfRangeException("numberSides");
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            rngCsp.GetBytes(randomNumber);
            return (byte)((randomNumber[0] % numberSides) + 1);
        }
        #endregion

        #region 数字证书
        //--生成数字证书--
        //选择文件路径
        private void btnZhengURL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                this.label8.Text = fb.SelectedPath;
            }
        }
        //选择Makecert
        private void btnMakecert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.label9.Text = dlg.FileName;
            }
        }
        //生成
        private void btnSHEN_Click(object sender, EventArgs e)
        {
            if (k0())
                groupBox4.Text = "定制证书成功";
            else
                groupBox4.Text = "定制证书失败";
            if (k1())
                groupBox4.Text += "---cer文件生成成功";
            else
                groupBox4.Text += "---cer文件生成失败";
            if (k2())
                groupBox4.Text += "---pfx文件生成成功";
            else
                groupBox4.Text += "---pfx文件生成失败";
        }
        private bool k0()
        {
            //创建证书
            try
            {
                string MakeCert = label9.Text;
                string x509Name = "CN=" + tbM.Text.Trim();
                //-pe 将所生成的私钥标记为可导出 | -ss 指定主题的证书存储名称，输出证书即存储在那里 | -n 指定主题的证书名称。此名称必须符合 X.500 标准。最简单的方法是在双引号中指定此名称，并加上前缀 CN=；例如，"CN=myName"。
                //-a 指定签名算法。必须是 md5（默认值）或 sha1 | -b mm/dd/yyyy 指定有效期的开始时间。默认为证书的创建日期。 | -cy 指定证书类型。有效值是 end（对于最终实体）和 authority（对于证书颁发机构）。 
                //-e mm/dd/yyyy 指定有效期的结束时间。默认为 12/31/2039 11:59:59 GMT(晕死，还有默认结束时间) | 　-sk keyname 指定主题的密钥容器位置，该位置包含私钥。如果密钥容器不存在，系统将创建一个。 
                //-sr location 指定主题的证书存储位置。Location 可以是 currentuser（默认值）或 localmachine | 
                string time = "04/30/2011";//设定2011-04-30结束
                string param = " -pe -e \"" + time + "\" -ss my -n \"" + x509Name + "\"";// -e \"" + "04/30/2011 10:02:00 GMT" + "\"";
                Process p = Process.Start(MakeCert, param);
                p.WaitForExit();
                p.Close();
                //MessageBox.Show("创建完毕！");
                return true;
            }
            catch (Exception er)
            {
                return false;
            }
        }
        private bool k1()
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);
            X509Certificate2Collection storecollection = (X509Certificate2Collection)store.Certificates;
            foreach (X509Certificate2 x509 in storecollection)
            {
                if (x509.Subject == "CN=" + tbM.Text.Trim())
                {
                    Debug.Print(string.Format("certificate name: {0}", x509.Subject));
                    byte[] pfxByte = x509.Export(X509ContentType.Cert);
                    using (FileStream fileStream = new FileStream(Path.Combine(label8.Text.Trim(), tbM.Text.Trim() + ".cer"), FileMode.Create))
                    {
                        // Write the data to the file, byte by byte.   
                        for (int i = 0; i < pfxByte.Length; i++)
                            fileStream.WriteByte(pfxByte[i]);
                        // Set the stream position to the beginning of the file.   
                        fileStream.Seek(0, SeekOrigin.Begin);
                        // Read and verify the data.   
                        for (int i = 0; i < fileStream.Length; i++)
                        {
                            if (pfxByte[i] != fileStream.ReadByte())
                            {
                                //MessageBox.Show("Error writing data.");
                                return false;
                            }
                        }
                        fileStream.Close();
                        //MessageBox.Show("导出CER完毕");
                        return true;
                    }
                }
            }
            store.Close();
            store = null;
            storecollection = null;
            return true;
        }
        private bool k2()
        {
            //创建PFX
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);
            X509Certificate2Collection storecollection = (X509Certificate2Collection)store.Certificates;
            foreach (X509Certificate2 x509 in storecollection)
            {
                if (x509.Subject == "CN=" + tbM.Text.Trim())
                {
                    Debug.Print(string.Format("certificate name: {0}", x509.Subject));
                    byte[] pfxByte = x509.Export(X509ContentType.Pfx, tbPass.Text.Trim());
                    using (FileStream fileStream = new FileStream(Path.Combine(label8.Text.Trim(), tbM.Text.Trim() + ".pfx"), FileMode.Create))
                    {
                        // 字节形式写入数据到文件.   
                        for (int i = 0; i < pfxByte.Length; i++)
                            fileStream.WriteByte(pfxByte[i]);
                        // 设置文件的初始流(位置) 
                        fileStream.Seek(0, SeekOrigin.Begin);
                        // 读取并核实数据  
                        for (int i = 0; i < fileStream.Length; i++)
                        {
                            if (pfxByte[i] != fileStream.ReadByte())
                            {
                                //MessageBox.Show("Error writing data.");
                                return false;
                            }
                        }
                        fileStream.Close();
                        //MessageBox.Show("导出PFX完毕");
                        return true;
                    }
                }
            }
            store.Close();
            store = null;
            storecollection = null;
            return true;
        }
        //-------------------Part.6 数字证书--------------------
        //选择cre
        private void btnCre_Click(object sender, EventArgs e)
        {
            checkFile(this.label7);
        }
        //加密
        byte[] enData;
        private void btn4JiaMi_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txt7.Text;
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
                X509Certificate2 cert = new X509Certificate2(label7.Text);
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(cert.PublicKey.Key.ToXmlString(false));
                enData = rsa.Encrypt(data, false);
                succes(Convert.ToBase64String(enData));
            }
            catch (Exception esx)
            {
                fail();
            }
        }
        //选择pfx
        private void btnPfx_Click(object sender, EventArgs e)
        {
            checkFile(this.label7);
        }
        //解密
        private void btn4JieMi_Click(object sender, EventArgs e)
        {
            if (txtPsswords.Text == "") { MessageBox.Show("pfx密码"); return; }
            try
            {
                X509Certificate2 pc = new X509Certificate2(label7.Text, txtPsswords.Text.Trim(), X509KeyStorageFlags.Exportable);
                string prrr = pc.PrivateKey.ToXmlString(true);
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(prrr);
                byte[] data = rsa.Decrypt(enData, false);
                succes(System.Text.Encoding.Default.GetString(data));
            }
            catch (Exception es)
            {
                fail(es.ToString());
            }
        }
        #endregion

        #region PGP加密
        private void encByPgp()
        {
            EncryptPGP();
            Stopwatch sw = new Stopwatch();//准确的测量运行时间
            sw.Start();
            DecryptPGP();
            sw.Stop();
        }
        public static void EncryptPGP()
        {
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = @"E:\Test\GnuPGDotNet\GnuPG\gpg.exe";
            pInfo.Arguments = string.Format("  --homedir \"{0}\" --yes --always-trust  --keyring \"{1}\"  --output \"{2}\" -r zhangwenjie  --encrypt \"{3}\"",
                @"E:\Test\GnuPGDotNet\GnuPG",
                @"F:\Test\pubring.pkr",
                @"F:\Test\License.txt.pgp",
                @"F:\Test\License.txt  ");
            pInfo.CreateNoWindow = true;
            pInfo.UseShellExecute = false;

            pInfo.RedirectStandardInput = true;
            pInfo.RedirectStandardOutput = true;
            pInfo.RedirectStandardError = true;
            Process p = Process.Start(pInfo);

            string strInfo;
            while ((strInfo = p.StandardOutput.ReadLine()) != null)
            {
                Console.WriteLine(strInfo);
            }

            p.WaitForExit();

            if (p.ExitCode == 0)
            {
                Console.WriteLine("成功");
            }
            p.Close();
        }
        public static void DecryptPGP()
        {

            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = @"E:\Test\GnuPGDotNet\GnuPG\gpg.exe";
            pInfo.Arguments = string.Format("  --homedir \"{0}\" --keyring \"{1}\"  --secret-keyring \"{2}\" --passphrase-fd 0 --output \"{3}\" --decrypt \"{4}\"",
             @"E:\Test\GnuPGDotNet\GnuPG",
             @"F:\Test\pubring.pkr",
             @"F:\Test\secring.skr",
             @"F:\Test\Oracle 9i.rar",
             @"F:\Test\Oracle 9i.rar.pgp");
            pInfo.CreateNoWindow = true;
            pInfo.UseShellExecute = false;
            pInfo.RedirectStandardInput = true;
            pInfo.RedirectStandardOutput = true;
            pInfo.RedirectStandardError = true;
            Process p = Process.Start(pInfo);

            p.StandardInput.WriteLine("123456789");
            p.StandardInput.Flush();
            p.StandardInput.Close();

            string strInfo;
            while ((strInfo = p.StandardOutput.ReadLine()) != null)
            {
                Console.WriteLine(strInfo);
            }

            p.WaitForExit();

            if (p.ExitCode == 0)
            {
                Console.WriteLine("成功");
            }
            p.Close();
        }
        #endregion

        #region 公共方法
        //******************公共方法****************
        private void fail()
        {
            MessageBox.Show("失败!");
        }
        private void fail(string str)
        {
            MessageBox.Show(str);
        }//失败
        private void succes()
        {
            MessageBox.Show("成功!");
        }
        private void succes(string str)
        {
            MessageBox.Show(str);
        }//成功
        private string checkFile(Label obj)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                obj.Text = dlg.FileName;
                return dlg.FileName;
            }
            else
            {
                return "";
            }
        }
        private void clearTxt(TextBox tb)
        {
            tb.Text = "";
        }//清空文本框 方法们
        private void tbPass_Click(object sender, EventArgs e)
        {
            clearTxt(tbPass);
        }
        private void tbM_Click(object sender, EventArgs e)
        {
            clearTxt(tbM);
        }
        private void txtPsswords_Click(object sender, EventArgs e)
        {
            clearTxt(txtPsswords);
        }
        private void txt7_Click(object sender, EventArgs e)
        {
            clearTxt(txt7);
        }
        #endregion
    }
}
