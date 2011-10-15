namespace EncryptMethod
{
    partial class King
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJiaMi = new System.Windows.Forms.Button();
            this.btnJieMi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn3JiaMi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn3Chose = new System.Windows.Forms.Button();
            this.btn3JieMi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn2JiaMi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2ChoseXML = new System.Windows.Forms.Button();
            this.btn2Open = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn4JieMi = new System.Windows.Forms.Button();
            this.btn4JiaMi = new System.Windows.Forms.Button();
            this.btnPfx = new System.Windows.Forms.Button();
            this.btnCre = new System.Windows.Forms.Button();
            this.btnZhengURL = new System.Windows.Forms.Button();
            this.btnSHEN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMakecert = new System.Windows.Forms.Button();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.txtPsswords = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(16, 31);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(75, 23);
            this.btnGetFile.TabIndex = 0;
            this.btnGetFile.Text = "选择XML文件";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // btnJiaMi
            // 
            this.btnJiaMi.Location = new System.Drawing.Point(140, 30);
            this.btnJiaMi.Name = "btnJiaMi";
            this.btnJiaMi.Size = new System.Drawing.Size(75, 23);
            this.btnJiaMi.TabIndex = 2;
            this.btnJiaMi.Text = "加密";
            this.btnJiaMi.UseVisualStyleBackColor = true;
            this.btnJiaMi.Click += new System.EventHandler(this.btnJiaMi_Click);
            // 
            // btnJieMi
            // 
            this.btnJieMi.Location = new System.Drawing.Point(264, 30);
            this.btnJieMi.Name = "btnJieMi";
            this.btnJieMi.Size = new System.Drawing.Size(75, 23);
            this.btnJieMi.TabIndex = 2;
            this.btnJieMi.Text = "解密";
            this.btnJieMi.UseVisualStyleBackColor = true;
            this.btnJieMi.Click += new System.EventHandler(this.btnJieMi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJiaMi);
            this.groupBox1.Controls.Add(this.btnJieMi);
            this.groupBox1.Controls.Add(this.btnGetFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对称加密";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(0, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 162);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "非对称加密";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "(私钥加密 · 签名验证)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "(公钥加密)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn3JiaMi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn3Chose);
            this.panel2.Controls.Add(this.btn3JieMi);
            this.panel2.Location = new System.Drawing.Point(7, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 61);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 9;
            // 
            // btn3JiaMi
            // 
            this.btn3JiaMi.Location = new System.Drawing.Point(132, 30);
            this.btn3JiaMi.Name = "btn3JiaMi";
            this.btn3JiaMi.Size = new System.Drawing.Size(75, 23);
            this.btn3JiaMi.TabIndex = 1;
            this.btn3JiaMi.Text = "加密";
            this.btn3JiaMi.UseVisualStyleBackColor = true;
            this.btn3JiaMi.Click += new System.EventHandler(this.btn3JiaMi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, -13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "(私钥加密)";
            // 
            // btn3Chose
            // 
            this.btn3Chose.Location = new System.Drawing.Point(8, 30);
            this.btn3Chose.Name = "btn3Chose";
            this.btn3Chose.Size = new System.Drawing.Size(75, 23);
            this.btn3Chose.TabIndex = 0;
            this.btn3Chose.Text = "选择XML文件";
            this.btn3Chose.UseVisualStyleBackColor = true;
            this.btn3Chose.Click += new System.EventHandler(this.btn3Chose_Click);
            // 
            // btn3JieMi
            // 
            this.btn3JieMi.Location = new System.Drawing.Point(256, 30);
            this.btn3JieMi.Name = "btn3JieMi";
            this.btn3JieMi.Size = new System.Drawing.Size(75, 23);
            this.btn3JieMi.TabIndex = 2;
            this.btn3JieMi.Text = "公钥验证";
            this.btn3JieMi.UseVisualStyleBackColor = true;
            this.btn3JieMi.Click += new System.EventHandler(this.btn3JieMi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn2JiaMi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn2ChoseXML);
            this.panel1.Controls.Add(this.btn2Open);
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 55);
            this.panel1.TabIndex = 5;
            // 
            // btn2JiaMi
            // 
            this.btn2JiaMi.Location = new System.Drawing.Point(133, 28);
            this.btn2JiaMi.Name = "btn2JiaMi";
            this.btn2JiaMi.Size = new System.Drawing.Size(75, 23);
            this.btn2JiaMi.TabIndex = 1;
            this.btn2JiaMi.Text = "加密";
            this.btn2JiaMi.UseVisualStyleBackColor = true;
            this.btn2JiaMi.Click += new System.EventHandler(this.btn2JiaMi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // btn2ChoseXML
            // 
            this.btn2ChoseXML.Location = new System.Drawing.Point(9, 28);
            this.btn2ChoseXML.Name = "btn2ChoseXML";
            this.btn2ChoseXML.Size = new System.Drawing.Size(75, 23);
            this.btn2ChoseXML.TabIndex = 0;
            this.btn2ChoseXML.Text = "选择XML文件";
            this.btn2ChoseXML.UseVisualStyleBackColor = true;
            this.btn2ChoseXML.Click += new System.EventHandler(this.btn2ChoseXML_Click);
            // 
            // btn2Open
            // 
            this.btn2Open.Location = new System.Drawing.Point(257, 28);
            this.btn2Open.Name = "btn2Open";
            this.btn2Open.Size = new System.Drawing.Size(75, 23);
            this.btn2Open.TabIndex = 2;
            this.btn2Open.Text = "解密";
            this.btn2Open.UseVisualStyleBackColor = true;
            this.btn2Open.Click += new System.EventHandler(this.btn2Open_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.linkLabel6);
            this.groupBox3.Controls.Add(this.linkLabel4);
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Location = new System.Drawing.Point(1, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 68);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "哈希算法";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "2";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(296, 17);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(41, 12);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "SHA512";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(217, 17);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(41, 12);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "SHA384";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(138, 17);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(41, 12);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "SHA256";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(77, 17);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(23, 12);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "SHA";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MD5";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbPass);
            this.groupBox4.Controls.Add(this.tbM);
            this.groupBox4.Controls.Add(this.btnMakecert);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnSHEN);
            this.groupBox4.Controls.Add(this.btnZhengURL);
            this.groupBox4.Controls.Add(this.txtPsswords);
            this.groupBox4.Controls.Add(this.txt7);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn4JieMi);
            this.groupBox4.Controls.Add(this.btn4JiaMi);
            this.groupBox4.Controls.Add(this.btnPfx);
            this.groupBox4.Controls.Add(this.btnCre);
            this.groupBox4.Location = new System.Drawing.Point(1, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 103);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数字证书";
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(172, 77);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(86, 21);
            this.txt7.TabIndex = 5;
            this.txt7.Text = "要加密的数据";
            this.txt7.Click += new System.EventHandler(this.txt7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 4;
            // 
            // btn4JieMi
            // 
            this.btn4JieMi.Location = new System.Drawing.Point(300, 75);
            this.btn4JieMi.Name = "btn4JieMi";
            this.btn4JieMi.Size = new System.Drawing.Size(47, 23);
            this.btn4JieMi.TabIndex = 3;
            this.btn4JieMi.Text = "解密";
            this.btn4JieMi.UseVisualStyleBackColor = true;
            this.btn4JieMi.Click += new System.EventHandler(this.btn4JieMi_Click);
            // 
            // btn4JiaMi
            // 
            this.btn4JiaMi.Location = new System.Drawing.Point(46, 75);
            this.btn4JiaMi.Name = "btn4JiaMi";
            this.btn4JiaMi.Size = new System.Drawing.Size(43, 23);
            this.btn4JiaMi.TabIndex = 2;
            this.btn4JiaMi.Text = "加密";
            this.btn4JiaMi.UseVisualStyleBackColor = true;
            this.btn4JiaMi.Click += new System.EventHandler(this.btn4JiaMi_Click);
            // 
            // btnPfx
            // 
            this.btnPfx.Location = new System.Drawing.Point(260, 75);
            this.btnPfx.Name = "btnPfx";
            this.btnPfx.Size = new System.Drawing.Size(37, 23);
            this.btnPfx.TabIndex = 1;
            this.btnPfx.Text = "PFX";
            this.btnPfx.UseVisualStyleBackColor = true;
            this.btnPfx.Click += new System.EventHandler(this.btnPfx_Click);
            // 
            // btnCre
            // 
            this.btnCre.Location = new System.Drawing.Point(7, 75);
            this.btnCre.Name = "btnCre";
            this.btnCre.Size = new System.Drawing.Size(37, 23);
            this.btnCre.TabIndex = 1;
            this.btnCre.Text = "CRE";
            this.btnCre.UseVisualStyleBackColor = true;
            this.btnCre.Click += new System.EventHandler(this.btnCre_Click);
            // 
            // btnZhengURL
            // 
            this.btnZhengURL.Location = new System.Drawing.Point(7, 32);
            this.btnZhengURL.Name = "btnZhengURL";
            this.btnZhengURL.Size = new System.Drawing.Size(43, 23);
            this.btnZhengURL.TabIndex = 6;
            this.btnZhengURL.Text = "路径";
            this.btnZhengURL.UseVisualStyleBackColor = true;
            this.btnZhengURL.Click += new System.EventHandler(this.btnZhengURL_Click);
            // 
            // btnSHEN
            // 
            this.btnSHEN.Location = new System.Drawing.Point(301, 32);
            this.btnSHEN.Name = "btnSHEN";
            this.btnSHEN.Size = new System.Drawing.Size(44, 23);
            this.btnSHEN.TabIndex = 6;
            this.btnSHEN.Text = "生成证书对";
            this.btnSHEN.UseVisualStyleBackColor = true;
            this.btnSHEN.Click += new System.EventHandler(this.btnSHEN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 7;
            // 
            // btnMakecert
            // 
            this.btnMakecert.Location = new System.Drawing.Point(54, 32);
            this.btnMakecert.Name = "btnMakecert";
            this.btnMakecert.Size = new System.Drawing.Size(47, 23);
            this.btnMakecert.TabIndex = 8;
            this.btnMakecert.Text = "Makecert";
            this.btnMakecert.UseVisualStyleBackColor = true;
            this.btnMakecert.Click += new System.EventHandler(this.btnMakecert_Click);
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(202, 34);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(93, 21);
            this.tbM.TabIndex = 9;
            this.tbM.Text = "证书名称";
            this.tbM.Click += new System.EventHandler(this.tbM_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 10;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(106, 34);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(90, 21);
            this.tbPass.TabIndex = 9;
            this.tbPass.Text = "录入pfx密码";
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            // 
            // txtPsswords
            // 
            this.txtPsswords.Location = new System.Drawing.Point(95, 77);
            this.txtPsswords.Name = "txtPsswords";
            this.txtPsswords.Size = new System.Drawing.Size(71, 21);
            this.txtPsswords.TabIndex = 5;
            this.txtPsswords.Text = "输入pfx密码";
            this.txtPsswords.Click += new System.EventHandler(this.txtPsswords_Click);
            // 
            // King
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 411);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "King";
            this.Text = "King";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJiaMi;
        private System.Windows.Forms.Button btnJieMi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn2ChoseXML;
        private System.Windows.Forms.Button btn2JiaMi;
        private System.Windows.Forms.Button btn2Open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn3JiaMi;
        private System.Windows.Forms.Button btn3Chose;
        private System.Windows.Forms.Button btn3JieMi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn4JieMi;
        private System.Windows.Forms.Button btn4JiaMi;
        private System.Windows.Forms.Button btnCre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPfx;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Button btnSHEN;
        private System.Windows.Forms.Button btnZhengURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Button btnMakecert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox txtPsswords;
    }
}

