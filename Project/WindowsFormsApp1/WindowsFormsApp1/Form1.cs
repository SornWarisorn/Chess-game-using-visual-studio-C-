using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private System.Windows.Forms.PictureBox[] card = new System.Windows.Forms.PictureBox[64];
        int idex_old_pos; 
        int turn = 1;

        public Form1()
        {
            InitializeComponent();
        }

        //set ตาราง
        public void SetBK()
        {
            //แถวที่1
            for (int i = 0; i < 8; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.White;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.Black;
                }

                //this.card[i].ImageLocation = "D:/Code/Visual/Project/Pic/b" + (i + 1).ToString() + ".png";

            }
            //แถวที่2
            for (int i = 8; i < 16; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.Black;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.White;

                }

            }
            //แถวที่3
            for (int i = 16; i < 24; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.White;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.Black;

                }

                //this.card[i].ImageLocation = "D:/Code/Visual/Project/Pic/b0.png";

            }
            //แถวที่4
            for (int i = 24; i < 32; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.Black;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.White;

                }
            }
            //แถวที่5
            for (int i = 32; i < 40; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.White;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.Black;

                }
            }
            //แถวที่6
            for (int i = 40; i < 48; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.Black;



                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.White;


                }

                //this.card[i].ImageLocation = "D:/Code/Visual/Project/Pic/a0.png";
            }
            //แถวที่7
            for (int i = 48; i < 56; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.White;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.Black;

                }
            }
            //แถวที่8
            for (int i = 56; i < 64; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i].BackColor = Color.Black;

                }

                if (n > 0)
                {
                    this.card[i].BackColor = Color.White;

                }

                //this.card[i].ImageLocation = "D:/Code/Visual/Project/Pic/a" + (i - 55).ToString() + ".png";
            }
        }

        //สร้างราตาง
        private void button1_Click(object sender, EventArgs e)
        {
            //สร้างราตาง
            //แถวที่1
            for (int i = 0; i < 8; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/Code/Visual/Project/Pic/a0.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + (i * 80), 10);
                    this.card[i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + (i * 80), 10);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);
                }

                this.card[ i].ImageLocation = "D:/Code/Visual/Project/Pic/b" + (i + 1).ToString() + ".png";

            }
            //แถวที่2
            for (int i = 8; i < 16; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 8) * 80), 90);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 8) * 80), 90);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

            }
            //แถวที่3
            for (int i = 16; i < 24; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 16) * 80), 170);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 16) * 80), 170);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                this.card[ i].ImageLocation = "D:/Code/Visual/Project/Pic/b0.png";

            }
            //แถวที่4
            for (int i = 24; i < 32; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 24) * 80), 250);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 24) * 80), 250);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }
            }
            //แถวที่5
            for (int i = 32; i < 40; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 32) * 80), 330);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 32) * 80), 330);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }
            }
            //แถวที่6
            for (int i = 40; i < 48; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 40) * 80), 410);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                    

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 40) * 80), 410);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                    
                }

                this.card[ i].ImageLocation = "D:/Code/Visual/Project/Pic/a0.png";
            }
            //แถวที่7
            for (int i = 48; i < 56; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 48) * 80), 490);
                    this.card[i].Name = (i + 1).ToString();
                    this.card[i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[i].TabIndex = 0;
                    this.card[i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                if (n > 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    this.card[i].ImageLocation = "";
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 48) * 80), 490);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }
            }
            //แถวที่8
            for (int i = 56; i < 64; i++)
            {
                int n;
                n = i % 2;
                if (n == 0)
                {
                    this.card[ i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 56) * 80), 570);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.Black;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[i]);

                }

                if (n > 0)
                {
                    this.card[i] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(this.card[ i])).BeginInit();
                    /*this.card[i].ImageLocation = "D:/RG/card/00.png";*/
                    this.card[ i].Location = new System.Drawing.Point(350 + ((i - 56) * 80), 570);
                    this.card[ i].Name = (i + 1).ToString();
                    this.card[ i].BackColor = Color.White;
                    this.card[ i].Size = new System.Drawing.Size(80, 80);
                    this.card[ i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.card[ i].TabIndex = 0;
                    this.card[ i].TabStop = false;
                    this.Controls.Add(this.card[ i]);

                }

                this.card[ i].ImageLocation = "D:/Code/Visual/Project/Pic/a" + (i - 55).ToString() + ".png";
            }

            // Click action
            for (int i = 0; i < 64; i++)
            {
                this.card[i].Click += new System.EventHandler(this.pictureBox2_Click);
                this.Controls.Add(this.card[i]);
            }



        }

        //การเดิน & การกิน
        public void pictureBox2_Click(object sender, EventArgs e)
        {

            PictureBox A = (PictureBox)sender;
            int count = turn % 2;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if(count > 0)
            {
                //เบี้ย ดำ check
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a0.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);

                    SetBK();


                    if (this.card[idex_old_pos - 9].ImageLocation == "")
                    {
                        
                        int nrc = Convert.ToInt16(A.Name) - 9;
                        this.card[nrc].BackColor = ColorTranslator.FromHtml("#358320"); //เบี้ยดำ เดิน
                    }


                    //check การกิน ขวา
                    if (this.card[idex_old_pos - 8].ImageLocation != "")
                    {
                        for (int i = 0; i < 9; i++)
                        {

                            if (this.card[idex_old_pos - 8].ImageLocation == "D:/Code/Visual/Project/Pic/b" + i.ToString() + ".png")
                            {
                                int nrc2 = Convert.ToInt16(A.Name) - 8;
                                this.card[nrc2].BackColor = ColorTranslator.FromHtml("#358220"); //เบี้ยดำ กิน ขวา
                            }

                        }

                    }


                    //check การกิน ซ้าย
                    if (this.card[idex_old_pos - 10].ImageLocation != "")
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (idex_old_pos % 8 != 1)
                            {
                                if (this.card[idex_old_pos - 10].ImageLocation == "D:/Code/Visual/Project/Pic/b" + i.ToString() + ".png")
                                {
                                    int nrc3 = Convert.ToInt16(A.Name) - 10;
                                    this.card[nrc3].BackColor = ColorTranslator.FromHtml("#378323"); //เบี้ยดำ กิน ซ้าย
                                }
                            }
                        }

                    }


                }

                //เบี้ย ดำ เดิน
                if (A.BackColor == ColorTranslator.FromHtml("#358320"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a0.png";
                    int nrc = Convert.ToInt16(A.Name) + 7;
                    this.card[nrc].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //เบี้ย ดำ กิน ขวา
                if (A.BackColor == ColorTranslator.FromHtml("#358220"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a0.png";
                    int nrc2 = Convert.ToInt16(A.Name) + 6;
                    this.card[nrc2].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //เบี้ย ดำ กิน ซ้าย
                if (A.BackColor == ColorTranslator.FromHtml("#378323"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a0.png";
                    int nrc3 = Convert.ToInt16(A.Name) + 8;
                    this.card[nrc3].ImageLocation = "";


                    SetBK();

                    turn++;

                }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //เรือ a1 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a1.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a1 = Convert.ToInt16(A.Name);

                    SetBK();

                    //เรือ a1 ดำ check col
                    //เรือ a1 ดำ check col1
                    if (a1 > 0 && a1 < 8)
                    {

                        for (int i = 0; i < 8; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224"); //เรือ a1 ดำ เดิน กิน


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }

                        }
                    }
                    //เรือ a1 ดำ check col2
                    if (a1 > 8 && a1 < 16)
                    {
                        for (int i = 8; i < 16; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ a1 ดำ check col3
                    if (a1 > 16 && a1 < 24)
                    {
                        for (int i = 16; i < 24; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ a1 ดำ check col4
                    if (a1 > 24 && a1 < 32)
                    {
                        for (int i = 24; i < 32; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ a1 ดำ check col5
                    if (a1 > 32 && a1 < 40)
                    {
                        for (int i = 32; i < 40; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ a1 ดำ check col6
                    if (a1 > 40 && a1 < 48)
                    {
                        for (int i = 40; i < 48; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ a1 ดำ check col7
                    if (a1 > 48 && a1 < 56)
                    {
                        for (int i = 48; i < 56; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");


                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ a1 ดำ check col8
                    if (a1 > 56 && a1 < 64)
                    {
                        for (int i = 56; i < 64; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388224");

                            int n;
                            n = a1 % 2;
                            if (n == 0)
                            {
                                this.card[a1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a1 - 1].BackColor = Color.White;
                            }
                        }
                    }

                    //เรือ a1 ดำ check row up
                    for (int i = 9; i > 0; i += 8)
                    {

                        if (a1 - i < 64 && a1 - i >= 0)
                            this.card[a1 - i].BackColor = ColorTranslator.FromHtml("#388224");


                    }

                    //เรือ a1 ดำ check row down
                    for (int i = 7; i > 0; i += 8)
                    {

                        if (a1 + i < 64 && a1 + i >= 0)
                            this.card[a1 + i].BackColor = ColorTranslator.FromHtml("#388224");

                    }

                }

                //เรือ a1 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#388224"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a1.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //เรือ a8 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a8.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a8 = Convert.ToInt16(A.Name);

                    //เรือ a8 ดำ check col
                    //เรือ a8 ดำ check col1
                    if (a8 > 0 && a8 < 8)
                    {

                        for (int i = 0; i < 8; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424"); //เรือ a8 ดำ เดิน กิน


                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }

                        }
                    }
                    //เรือ a8 ดำ check col2
                    if (a8 > 8 && a8 < 16)
                    {
                        for (int i = 8; i < 16; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");


                            //int n;
                            //n = a8 % 2;
                            //if (n == 0)
                            //{
                            //    this.card[a8 - 1].BackColor = Color.Black;
                            //}

                            //if (n > 0)
                            //{
                            //    this.card[a8 - 1].BackColor = Color.White;
                            //}
                        }
                    }
                    //เรือ a8 ดำ check col3
                    if (a8 > 16 && a8 < 24)
                    {
                        for (int i = 16; i < 24; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");


                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ a8 ดำ check col4
                    if (a8 > 24 && a8 < 32)
                    {
                        for (int i = 24; i < 32; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");


                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ a8 ดำ check col5
                    if (a8 > 32 && a8 < 40)
                    {
                        for (int i = 32; i < 40; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");


                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ a8 ดำ check col6
                    if (a8 > 40 && a8 < 48)
                    {
                        for (int i = 40; i < 48; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");


                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ a8 ดำ check col7
                    if (a8 > 48 && a8 < 56)
                    {
                        for (int i = 48; i < 56; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");


                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ a8 ดำ check col8
                    if (a8 > 56 && a8 <= 64)
                    {
                        for (int i = 56; i < 64; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#388424");

                            int n;
                            n = a8 % 2;
                            if (n == 0)
                            {
                                this.card[a8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[a8 - 1].BackColor = Color.White;
                            }
                        }
                    }

                    //เรือ a8 ดำ check row up
                    for (int i = 9; i > 0; i += 8)
                    {
                        if ((a8 - i) > -8)
                        {
                            if (a8 - i < 64 && a8 - i >= 0)
                                this.card[a8 - i].BackColor = ColorTranslator.FromHtml("#388424");
                        }

                    }

                    //เรือ a8 ดำ check row down
                    for (int i = 7; i > 0; i += 8)
                    {

                        if (a8 + i < 64 && a8 + i >= 0)
                            this.card[a8 + i].BackColor = ColorTranslator.FromHtml("#388224");

                    }

                }

                //เรือ a8 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#388424"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a8.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //ม้า a2 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a2.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);

                    int a2_1 = Convert.ToInt16(A.Name) - 16; //0
                    int a2_2 = Convert.ToInt16(A.Name) - 18; //1     
                    int a2_3 = Convert.ToInt16(A.Name) - 7;  //7/0
                    int a2_4 = Convert.ToInt16(A.Name) + 9;  //7/0
                    int a2_5 = Convert.ToInt16(A.Name) + 16; //0
                    int a2_6 = Convert.ToInt16(A.Name) + 14; //1
                    int a2_7 = Convert.ToInt16(A.Name) + 5;  //1/2
                    int a2_8 = Convert.ToInt16(A.Name) - 11; //1/2

                    SetBK();




                    if (a2_1 >= 0 && a2_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a2_1].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                    }

                    if (a2_2 >= 0 && a2_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a2_2].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                    }

                    if (a2_3 >= 0 && a2_3 <= 64)
                    {                      
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[a2_3].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน                                                                                              
                    }

                    if (a2_4 >= 0 && a2_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[a2_4].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                    }

                    if (a2_5 >= 0 && a2_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a2_5].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                    }

                    if (a2_6 >= 0 && a2_6 <= 64)
                    {
                        if (idex_old_pos % 8 != 1)
                        this.card[a2_6].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                    }

                    if (a2_7 >= 0 && a2_7 <= 64)
                    {
                        if (idex_old_pos % 8 != 2 && idex_old_pos % 8 != 1)
                        {
                            this.card[a2_7].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                        }
                        
                    }

                    if (a2_8 >= 0 && a2_8 <= 64)
                    {
                        if(idex_old_pos % 8 != 2 && idex_old_pos % 8 != 1)
                        {
                            this.card[a2_8].BackColor = ColorTranslator.FromHtml("#378423"); //ม้า a2 ดำ เดิน
                        }
                        
                    }

                    




                }

                //ม้า a2 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#378423"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a2.png";

                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //ม้า a8 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a7.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a7_1 = Convert.ToInt16(A.Name) - 16; //0
                    int a7_2 = Convert.ToInt16(A.Name) - 18; //1
                    int a7_3 = Convert.ToInt16(A.Name) - 7; //7/0
                    int a7_4 = Convert.ToInt16(A.Name) + 9; //7/0
                    int a7_5 = Convert.ToInt16(A.Name) + 16; //0
                    int a7_6 = Convert.ToInt16(A.Name) + 14; //1
                    int a7_7 = Convert.ToInt16(A.Name) + 5; //1/2
                    int a7_8 = Convert.ToInt16(A.Name) - 11; //1/2

                    SetBK();

                    if (a7_1 >= 0 && a7_1 <= 64)
                    {
                        if (idex_old_pos % 8 != 0)
                        this.card[a7_1].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_2 >= 0 && a7_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a7_2].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_3 >= 0 && a7_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[a7_3].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_4 >= 0 && a7_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[a7_4].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_5 >= 0 && a7_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a7_5].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_6 >= 0 && a7_6 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a7_6].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_7 >= 0 && a7_7 <= 64)
                    {
                        if(idex_old_pos % 8 != 1 && idex_old_pos % 8 != 2)
                        this.card[a7_7].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }

                    if (a7_8 >= 0 && a7_8 <= 64)
                    {
                        if(idex_old_pos % 8 != 1 && idex_old_pos % 8 != 2)
                        this.card[a7_8].BackColor = ColorTranslator.FromHtml("#398325"); //ม้า a2 ดำ เดิน
                    }





                }

                //ม้า a8 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#398325"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a7.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //โคน a3 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a3.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a3_1 = Convert.ToInt16(A.Name) - 10;
                    int a3_2 = Convert.ToInt16(A.Name) - 9;
                    int a3_3 = Convert.ToInt16(A.Name) - 8;
                    int a3_4 = Convert.ToInt16(A.Name) + 6;
                    int a3_5 = Convert.ToInt16(A.Name) + 8;

                    SetBK();

                    if (a3_1 >= 0 && a3_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a3_1].BackColor = ColorTranslator.FromHtml("#398525"); //ม้า a2 ดำ เดิน
                    }

                    if (a3_2 >= 0 && a3_2 <= 64)
                    {
                        this.card[a3_2].BackColor = ColorTranslator.FromHtml("#398525"); //ม้า a2 ดำ เดิน
                    }

                    if (a3_3 >= 0 && a3_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a3_3].BackColor = ColorTranslator.FromHtml("#398525"); //ม้า a2 ดำ เดิน
                    }

                    if (a3_4 >= 0 && a3_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a3_4].BackColor = ColorTranslator.FromHtml("#398525"); //ม้า a2 ดำ เดิน
                    }

                    if (a3_5 >= 0 && a3_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a3_5].BackColor = ColorTranslator.FromHtml("#398525"); //ม้า a2 ดำ เดิน
                    }



                }

                //โคน a3 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#398525"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a3.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //โคน a6 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a6.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a6_1 = Convert.ToInt16(A.Name) - 10;
                    int a6_2 = Convert.ToInt16(A.Name) - 9;
                    int a6_3 = Convert.ToInt16(A.Name) - 8;
                    int a6_4 = Convert.ToInt16(A.Name) + 6;
                    int a6_5 = Convert.ToInt16(A.Name) + 8;

                    SetBK();

                    if (a6_1 >= 0 && a6_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a6_1].BackColor = ColorTranslator.FromHtml("#3A8427"); //ม้า a2 ดำ เดิน
                    }

                    if (a6_2 >= 0 && a6_2 <= 64)
                    {
                        this.card[a6_2].BackColor = ColorTranslator.FromHtml("#3A8427"); //ม้า a2 ดำ เดิน
                    }

                    if (a6_3 >= 0 && a6_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a6_3].BackColor = ColorTranslator.FromHtml("#3A8427"); //ม้า a2 ดำ เดิน
                    }

                    if (a6_4 >= 0 && a6_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a6_4].BackColor = ColorTranslator.FromHtml("#3A8427"); //ม้า a2 ดำ เดิน
                    }

                    if (a6_5 >= 0 && a6_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a6_5].BackColor = ColorTranslator.FromHtml("#3A8427"); //ม้า a2 ดำ เดิน
                    }



                }

                //โคน a6 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3A8427"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a6.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //เม็ด a5 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a5.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a5_1 = Convert.ToInt16(A.Name) - 10;
                    int a5_2 = Convert.ToInt16(A.Name) - 8;
                    int a5_3 = Convert.ToInt16(A.Name) + 6;
                    int a5_4 = Convert.ToInt16(A.Name) + 8;

                    SetBK();

                    if (a5_1 >= 0 && a5_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a5_1].BackColor = ColorTranslator.FromHtml("#3B8827"); //ม้า a2 ดำ เดิน
                    }

                    if (a5_2 >= 0 && a5_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a5_2].BackColor = ColorTranslator.FromHtml("#3B8827"); //ม้า a2 ดำ เดิน
                    }

                    if (a5_3 >= 0 && a5_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a5_3].BackColor = ColorTranslator.FromHtml("#3B8827"); //ม้า a2 ดำ เดิน
                    }

                    if (a5_4 >= 0 && a5_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a5_4].BackColor = ColorTranslator.FromHtml("#3B8827"); //ม้า a2 ดำ เดิน
                    }





                }

                //เม็ด a5 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3B8827"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a5.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //ขุน a4 ดำ เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/a4.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int a4_1 = Convert.ToInt16(A.Name) - 10;
                    int a4_2 = Convert.ToInt16(A.Name) - 9;
                    int a4_3 = Convert.ToInt16(A.Name) - 8;
                    int a4_4 = Convert.ToInt16(A.Name) + 0;
                    int a4_5 = Convert.ToInt16(A.Name) + 8;
                    int a4_6 = Convert.ToInt16(A.Name) + 7;
                    int a4_7 = Convert.ToInt16(A.Name) + 6;
                    int a4_8 = Convert.ToInt16(A.Name) - 2;

                    SetBK();

                    if (a4_1 >= 0 && a4_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a4_1].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_2 >= 0 && a4_2 <= 64)
                    {
                        this.card[a4_2].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_3 >= 0 && a4_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a4_3].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_4 >= 0 && a4_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a4_4].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_5 >= 0 && a4_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[a4_5].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_6 >= 0 && a4_6 <= 64)
                    {
                        this.card[a4_6].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_7 >= 0 && a4_7 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a4_7].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                    if (a4_8 >= 0 && a4_8 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[a4_8].BackColor = ColorTranslator.FromHtml("#378424");
                    }

                }

                //ขุน a4 ดำ เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#378424"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/a4.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }
            }


            

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if(count == 0)
            {
                //เบี้ย น้ำตาล check
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b0.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);

                    SetBK();
                    // เดิน
                    if (this.card[idex_old_pos + 7].ImageLocation == "")
                    {
                        int b0_1 = Convert.ToInt16(A.Name) + 7;
                        this.card[b0_1].BackColor = ColorTranslator.FromHtml("#3A8627"); //เบี้ยน้ำตาล เดิน
                    }
                    // กิน ซ้าย
                    if(this.card[idex_old_pos + 8].ImageLocation != "")
                    {
                        for(int i = 0; i < 9; i++)
                        {
                            if (idex_old_pos % 8 != 0)
                            {
                                if (this.card[idex_old_pos + 8].ImageLocation == "D:/Code/Visual/Project/Pic/a" + i.ToString() + ".png")
                                {
                                    int b0_2 = Convert.ToInt16(A.Name) + 8;
                                    this.card[b0_2].BackColor = ColorTranslator.FromHtml("#3E852C"); //เบี้ยน้ำตาล กิน ขวา
                                }
                            }
                        }
                    }
                    // กิน ขวา
                    if(this.card[idex_old_pos + 6].ImageLocation != "")
                    {
                        for(int i = 0; i < 9; i++)
                        {
                            if(this.card[idex_old_pos + 6].ImageLocation == "D:/Code/Visual/Project/Pic/a" + i.ToString() + ".png")
                            {
                                int b0_3 = Convert.ToInt16(A.Name) + 6;
                                this.card[b0_3].BackColor = ColorTranslator.FromHtml("#3B8229"); //เบี้ยน้ำตาล กิน ซ้าย
                            }
                        }
                    }

                }

                //เบี้ย น้ำตาล เดิน
                if (A.BackColor == ColorTranslator.FromHtml("#3A8627"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b0.png";
                    int b0_1 = Convert.ToInt16(A.Name) - 9;
                    this.card[b0_1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //เบี้ย น้ำตาล กิน ขวา
                if (A.BackColor == ColorTranslator.FromHtml("#3E852C"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b0.png";
                    int b0_2 = Convert.ToInt16(A.Name) - 10;
                    this.card[b0_2].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //เบี้ย น้ำตาล กิน ขวา
                if (A.BackColor == ColorTranslator.FromHtml("#3B8229"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b0.png";
                    int b0_3 = Convert.ToInt16(A.Name) - 8;
                    this.card[b0_3].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //เรือ b1 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b1.png")
                {
                    int b1 = Convert.ToInt16(A.Name);
                    idex_old_pos = Convert.ToInt16(A.Name);

                    SetBK();

                    //เรือ b1 ดำ check col
                    //เรือ b1 ดำ check col1
                    if (b1 > 0 && b1 < 8)
                    {

                        for (int i = 0; i < 8; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E"); //เรือ a1 ดำ เดิน กิน


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }

                        }
                    }
                    //เรือ b1 ดำ check col2
                    if (b1 > 8 && b1 < 16)
                    {
                        for (int i = 8; i < 16; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col3
                    if (b1 > 16 && b1 < 24)
                    {
                        for (int i = 16; i < 24; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col4
                    if (b1 > 24 && b1 < 32)
                    {
                        for (int i = 24; i < 32; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col5
                    if (b1 > 32 && b1 < 40)
                    {
                        for (int i = 32; i < 40; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col6
                    if (b1 > 40 && b1 < 48)
                    {
                        for (int i = 40; i < 48; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col7
                    if (b1 > 48 && b1 < 56)
                    {
                        for (int i = 48; i < 56; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col8
                    if (b1 > 56 && b1 < 64)
                    {
                        for (int i = 56; i < 64; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");

                            int n;
                            n = b1 % 2;
                            if (n == 0)
                            {
                                this.card[b1 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b1 - 1].BackColor = Color.White;
                            }
                        }
                    }

                    //เรือ b1 ดำ check row up
                    for (int i = 9; i > 0; i += 8)
                    {
                        if ((b1 - i) > -8)
                        {
                            if (b1 - i < 64 && b1 - i >= 0)
                                this.card[b1 - i].BackColor = ColorTranslator.FromHtml("#3F852E");
                        }

                    }

                    //เรือ b1 ดำ check row down
                    for (int i = 7; i > 0; i += 8)
                    {

                        if (b1 + i < 64 && b1 + i >= 0)
                            this.card[b1 + i].BackColor = ColorTranslator.FromHtml("#3F852E");

                    }

                }

                //เรือ b1 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3F852E"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b1.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //เรือ b8 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b8.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b8 = Convert.ToInt16(A.Name);

                    SetBK();

                    //เรือ b8 ดำ check col
                    //เรือ b8 ดำ check col1
                    if (b8 > 0 && b8 <= 8)
                    {

                        for (int i = 0; i < 8; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E"); //เรือ a1 ดำ เดิน กิน


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }

                        }
                    }
                    //เรือ b8 ดำ check col2
                    if (b8 > 8 && b8 <= 16)
                    {
                        for (int i = 8; i < 16; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col3
                    if (b8 > 16 && b8 <= 24)
                    {
                        for (int i = 16; i < 24; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col4
                    if (b8 > 24 && b8 <= 32)
                    {
                        for (int i = 24; i < 32; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col5
                    if (b8 > 32 && b8 <= 40)
                    {
                        for (int i = 32; i < 40; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col6
                    if (b8 > 40 && b8 <= 48)
                    {
                        for (int i = 40; i < 48; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col7
                    if (b8 > 48 && b8 <= 56)
                    {
                        for (int i = 48; i < 56; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");


                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }
                        }
                    }
                    //เรือ b1 ดำ check col8
                    if (b8 > 56 && b8 <= 64)
                    {
                        for (int i = 56; i < 64; i++)
                        {
                            this.card[i].BackColor = ColorTranslator.FromHtml("#3F852E");

                            int n;
                            n = b8 % 2;
                            if (n == 0)
                            {
                                this.card[b8 - 1].BackColor = Color.Black;
                            }

                            if (n > 0)
                            {
                                this.card[b8 - 1].BackColor = Color.White;
                            }
                        }
                    }

                    //เรือ b8 น้ำตาล check row up
                    for (int i = 9; i > 0; i += 8)
                    {
                        if ((b8 - i) > -8)
                        {
                            if (b8 - i < 64 && b8 - i >= 0)
                                this.card[b8 - i].BackColor = ColorTranslator.FromHtml("#3E812E");
                        }

                    }

                    //เรือ b8 น้ำตาล check row down
                    for (int i = 7; i > 0; i += 8)
                    {

                        if (b8 + i < 64 && b8 + i >= 0)
                            this.card[b8 + i].BackColor = ColorTranslator.FromHtml("#3E812E");

                    }

                }

                //เรือ b8 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3E812E"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b8.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //ม้า b2 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b2.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b2_1 = Convert.ToInt16(A.Name) - 16; //0
                    int b2_2 = Convert.ToInt16(A.Name) - 18; //1
                    int b2_3 = Convert.ToInt16(A.Name) - 7;  //7/0
                    int b2_4 = Convert.ToInt16(A.Name) + 9;  //7/0
                    int b2_5 = Convert.ToInt16(A.Name) + 16; //0
                    int b2_6 = Convert.ToInt16(A.Name) + 14; //1
                    int b2_7 = Convert.ToInt16(A.Name) + 5; //1/2
                    int b2_8 = Convert.ToInt16(A.Name) - 11; //1/2

                    SetBK();

                    if (b2_1 >= 0 && b2_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b2_1].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_2 >= 0 && b2_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b2_2].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_3 >= 0 && b2_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[b2_3].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_4 >= 0 && b2_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[b2_4].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_5 >= 0 && b2_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b2_5].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_6 >= 0 && b2_6 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b2_6].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_7 >= 0 && b2_7 <= 64)
                    {
                        if(idex_old_pos % 8 != 1 && idex_old_pos % 8 != 2)
                        this.card[b2_7].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }

                    if (b2_8 >= 0 && b2_8 <= 64)
                    {
                        if(idex_old_pos % 8 != 1 && idex_old_pos % 8 != 2)
                        this.card[b2_8].BackColor = ColorTranslator.FromHtml("#3E852D"); //ม้า b2 น้ำตาล เดิน
                    }





                }

                //ม้า b2 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3E852D"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b2.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //ม้า b7 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b7.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b7_1 = Convert.ToInt16(A.Name) - 16; //0
                    int b7_2 = Convert.ToInt16(A.Name) - 18; //1
                    int b7_3 = Convert.ToInt16(A.Name) - 7; //7/0
                    int b7_4 = Convert.ToInt16(A.Name) + 9; //7/0
                    int b7_5 = Convert.ToInt16(A.Name) + 16; //0
                    int b7_6 = Convert.ToInt16(A.Name) + 14; //1
                    int b7_7 = Convert.ToInt16(A.Name) + 5; //1/2
                    int b7_8 = Convert.ToInt16(A.Name) - 11; //1/2

                    SetBK();

                    if (b7_1 >= 0 && b7_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b7_1].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_2 >= 0 && b7_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b7_2].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_3 >= 0 && b7_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[b7_3].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_4 >= 0 && b7_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 7 && idex_old_pos % 8 != 0)
                        this.card[b7_4].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_5 >= 0 && b7_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b7_5].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_6 >= 0 && b7_6 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b7_6].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_7 >= 0 && b7_7 <= 64)
                    {
                        if(idex_old_pos % 8 != 1 && idex_old_pos % 8 != 2)
                        this.card[b7_7].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }

                    if (b7_8 >= 0 && b7_8 <= 64)
                    {
                        if(idex_old_pos % 8 != 1 && idex_old_pos % 8 != 2)
                        this.card[b7_8].BackColor = ColorTranslator.FromHtml("#428831"); //ม้า b7 น้ำตาล เดิน
                    }





                }

                //ม้า b7 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#428831"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b7.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //โคน b3 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b3.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b3_1 = Convert.ToInt16(A.Name) - 10; //1
                    int b3_2 = Convert.ToInt16(A.Name) - 8; //0
                    int b3_3 = Convert.ToInt16(A.Name) + 6; //1
                    int b3_4 = Convert.ToInt16(A.Name) + 8; //0
                    int b3_5 = Convert.ToInt16(A.Name) + 7;

                    SetBK();

                    if (b3_1 >= 0 && b3_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b3_1].BackColor = ColorTranslator.FromHtml("#3F822F"); //โคน b3 น้ำตาล เดิน กิน
                    }

                    if (b3_2 >= 0 && b3_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b3_2].BackColor = ColorTranslator.FromHtml("#3F822F"); //โคน b3 น้ำตาล เดิน กิน
                    }

                    if (b3_3 >= 0 && b3_3 <= 64)
                    {
                        if(idex_old_pos %8 != 1)
                        this.card[b3_3].BackColor = ColorTranslator.FromHtml("#3F822F"); //โคน b3 น้ำตาล เดิน กิน
                    }

                    if (b3_4 >= 0 && b3_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b3_4].BackColor = ColorTranslator.FromHtml("#3F822F"); //โคน b3 น้ำตาล เดิน กิน
                    }

                    if (b3_5 >= 0 && b3_5 <= 64)
                    {
                        this.card[b3_5].BackColor = ColorTranslator.FromHtml("#3F822F"); //โคน b3 น้ำตาล เดิน กิน
                    }



                }

                ///โคน b3 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3F822F"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b3.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

                //โคน b6 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b6.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b6_1 = Convert.ToInt16(A.Name) - 10; //1
                    int b6_2 = Convert.ToInt16(A.Name) - 8; //0
                    int b6_3 = Convert.ToInt16(A.Name) + 6; //1
                    int b6_4 = Convert.ToInt16(A.Name) + 8; //0
                    int b6_5 = Convert.ToInt16(A.Name) + 7;

                    SetBK();

                    if (b6_1 >= 0 && b6_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b6_1].BackColor = ColorTranslator.FromHtml("#3C7F2C"); //โคน b6 น้ำตาล เดิน กิน
                    }

                    if (b6_2 >= 0 && b6_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b6_2].BackColor = ColorTranslator.FromHtml("#3C7F2C"); //โคน b6 น้ำตาล เดิน กิน
                    }

                    if (b6_3 >= 0 && b6_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b6_3].BackColor = ColorTranslator.FromHtml("#3C7F2C"); //โคน b6 น้ำตาล เดิน กิน
                    }

                    if (b6_4 >= 0 && b6_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b6_4].BackColor = ColorTranslator.FromHtml("#3C7F2C"); //โคน b6 น้ำตาล เดิน กิน
                    }

                    if (b6_5 >= 0 && b6_5 <= 64)
                    {
                        this.card[b6_5].BackColor = ColorTranslator.FromHtml("#3C7F2C"); ///โคน b6 น้ำตาล เดิน กิน
                    }



                }

                //โคน b6 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3C7F2C"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b6.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //เม็ด b4 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b4.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b4_1 = Convert.ToInt16(A.Name) - 10; //1
                    int b4_2 = Convert.ToInt16(A.Name) - 8; //0
                    int b4_3 = Convert.ToInt16(A.Name) + 6; //1
                    int b4_4 = Convert.ToInt16(A.Name) + 8; //0

                    SetBK();


                    if (b4_1 >= 0 && b4_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b4_1].BackColor = ColorTranslator.FromHtml("#3E802E"); //เม็ด b4 น้ำตาล เดิน กิน
                    }

                    if (b4_2 >= 0 && b4_2 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b4_2].BackColor = ColorTranslator.FromHtml("#3E802E"); //เม็ด b4 น้ำตาล เดิน กิน
                    }

                    if (b4_3 >= 0 && b4_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b4_3].BackColor = ColorTranslator.FromHtml("#3E802E"); //เม็ด b4 น้ำตาล เดิน กิน
                    }

                    if (b4_4 >= 0 && b4_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b4_4].BackColor = ColorTranslator.FromHtml("#3E802E"); //เม็ด b4 น้ำตาล เดิน กิน
                    }





                }

                //เม็ด b4 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3E802E"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b4.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //ขุน b5 น้ำตาล เดิน กิน
                if (A.ImageLocation == "D:/Code/Visual/Project/Pic/b5.png")
                {
                    idex_old_pos = Convert.ToInt16(A.Name);
                    int b5_1 = Convert.ToInt16(A.Name) - 10; //1
                    int b5_2 = Convert.ToInt16(A.Name) - 9; 
                    int b5_3 = Convert.ToInt16(A.Name) - 8; //0
                    int b5_4 = Convert.ToInt16(A.Name) + 0; //0
                    int b5_5 = Convert.ToInt16(A.Name) + 8; //1
                    int b5_6 = Convert.ToInt16(A.Name) + 7; 
                    int b5_7 = Convert.ToInt16(A.Name) + 6; //0
                    int b5_8 = Convert.ToInt16(A.Name) - 2; //1

                    SetBK();

                    if (b5_1 >= 0 && b5_1 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b5_1].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_2 >= 0 && b5_2 <= 64)
                    {
                        this.card[b5_2].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_3 >= 0 && b5_3 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b5_3].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_4 >= 0 && b5_4 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b5_4].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_5 >= 0 && b5_5 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b5_5].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_6 >= 0 && b5_6 <= 64)
                    {
                        this.card[b5_6].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_7 >= 0 && b5_7 <= 64)
                    {
                        if(idex_old_pos % 8 != 0)
                        this.card[b5_7].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                    if (b5_8 >= 0 && b5_8 <= 64)
                    {
                        if(idex_old_pos % 8 != 1)
                        this.card[b5_8].BackColor = ColorTranslator.FromHtml("#3C802C");
                    }

                }

                //ขุน b5 น้ำตาล เดิน กิน
                if (A.BackColor == ColorTranslator.FromHtml("#3C802C"))
                {
                    A.ImageLocation = "D:/Code/Visual/Project/Pic/b5.png";
                    //int a1 = Convert.ToInt16(A.Name);
                    //this.card[a1].ImageLocation = "";
                    card[idex_old_pos - 1].ImageLocation = "";

                    SetBK();

                    turn++;

                }
            }
            

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            
            
             if(this.card[0].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
             {
                if (this.card[1].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                    if (this.card[2].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                        if (this.card[3].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                            if (this.card[4].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                if (this.card[5].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                    if (this.card[6].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                        if (this.card[7].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                            if (this.card[8].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                if (this.card[9].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                    if (this.card[10].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                        if (this.card[11].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                            if (this.card[12].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                if (this.card[13].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                    if (this.card[14].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                        if (this.card[15].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                            if (this.card[16].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                if (this.card[17].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                    if (this.card[18].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                        if (this.card[19].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                            if (this.card[20].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                if (this.card[21].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                    if (this.card[22].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                        if (this.card[23].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                            if (this.card[24].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                if (this.card[25].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                    if (this.card[26].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                        if (this.card[27].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                            if (this.card[28].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                if (this.card[29].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                    if (this.card[30].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                        if (this.card[31].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                            if (this.card[32].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                if (this.card[33].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                    if (this.card[34].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                        if (this.card[35].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                            if (this.card[36].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                if (this.card[37].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                    if (this.card[38].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                        if (this.card[39].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                            if (this.card[40].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                if (this.card[41].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                    if (this.card[42].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                        if (this.card[43].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                            if (this.card[44].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                if (this.card[45].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                    if (this.card[46].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                        if (this.card[47].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                            if (this.card[48].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                if (this.card[49].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                    if (this.card[50].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                        if (this.card[51].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                            if (this.card[52].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                if (this.card[53].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                    if (this.card[54].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                        if (this.card[55].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                            if (this.card[56].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                if (this.card[57].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                    if (this.card[58].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                        if (this.card[59].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                            if (this.card[60].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                                if (this.card[61].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                                    if (this.card[62].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                                        if (this.card[63].ImageLocation != "D:/Code/Visual/Project/Pic/a4.png")
                                                                                                                                                                                                                                                                           

                                                                                                                                                                                                                                                                                MessageBox.Show("Brown win");
             }

            if (this.card[0].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
            {
                if (this.card[1].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                    if (this.card[2].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                        if (this.card[3].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                            if (this.card[4].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                if (this.card[5].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                    if (this.card[6].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                        if (this.card[7].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                            if (this.card[8].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                if (this.card[9].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                    if (this.card[10].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                        if (this.card[11].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                            if (this.card[12].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                if (this.card[13].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                    if (this.card[14].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                        if (this.card[15].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                            if (this.card[16].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                if (this.card[17].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                    if (this.card[18].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                        if (this.card[19].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                            if (this.card[20].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                if (this.card[21].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                    if (this.card[22].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                        if (this.card[23].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                            if (this.card[24].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                if (this.card[25].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                    if (this.card[26].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                        if (this.card[27].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                            if (this.card[28].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                if (this.card[29].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                    if (this.card[30].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                        if (this.card[31].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                            if (this.card[32].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                if (this.card[33].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                    if (this.card[34].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                        if (this.card[35].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                            if (this.card[36].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                if (this.card[37].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                    if (this.card[38].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                        if (this.card[39].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                            if (this.card[40].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                if (this.card[41].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                    if (this.card[42].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                        if (this.card[43].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                            if (this.card[44].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                if (this.card[45].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                    if (this.card[46].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                        if (this.card[47].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                            if (this.card[48].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                if (this.card[49].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                    if (this.card[50].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                        if (this.card[51].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                            if (this.card[52].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                if (this.card[53].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                    if (this.card[54].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                        if (this.card[55].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                            if (this.card[56].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                if (this.card[57].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                    if (this.card[58].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                        if (this.card[59].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                            if (this.card[60].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                                if (this.card[61].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                                    if (this.card[62].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")
                                                                                                                                                                                                                                                                        if (this.card[63].ImageLocation != "D:/Code/Visual/Project/Pic/b5.png")


                                                                                                                                                                                                                                                                            MessageBox.Show("Black win");
            }
        }
    }
}
