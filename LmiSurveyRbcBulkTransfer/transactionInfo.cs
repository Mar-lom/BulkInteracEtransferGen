using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace LmiSurveyRbcBulkTransfer
{
    public partial class transactionInfo : Form
    {

        List<string> answer = new List<string>();
        List<string> saltedValue = new List<string>();
        List<string> answerHashed = new List<string>();
        List<string> saltedPasswordAppendedPassword = new List<string>();

        public transactionInfo()
        {
            InitializeComponent();
        }

        private void createFile_Click(object sender, EventArgs e)
        {

            if (accountNumberTextBox.Text != string.Empty && accountIdTextBox.Text != string.Empty && questionTextBox.Text != string.Empty && answerTextBox.Text != string.Empty && moneyTextBox.Text != string.Empty)

            {

                string question = questionTextBox.Text;
                string answerRaw = answerTextBox.Text;


                float money = float.Parse(moneyTextBox.Text);
                float totalMoney = money * Global.userCount;

                //Account Number Entered
                string accountNumber = accountNumberTextBox.Text;
                string accountID = accountIdTextBox.Text;
                string salted = "";


                for (int i = 0; i < Global.userCount; i++)
                {

                    answer.Add(answerRaw);

                    //Trim the whitespace from the answer
                    string trimmed = String.Concat(answer[i].Where(c => !Char.IsWhiteSpace(c)));
                    string upperTrimmed = trimmed.ToUpper();

                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[32];
                    var random = new Random();

                    for (int o = 0; o < stringChars.Length; o++)
                    {
                        stringChars[o] = chars[random.Next(chars.Length)];
                    }
                    salted = new String(stringChars);

                    saltedValue.Add(salted);

                    saltedPasswordAppendedPassword.Add(upperTrimmed + saltedValue[i]);

                    answerHashed.Add(ComputeSha256Hash(saltedPasswordAppendedPassword[i]));

                    salted = "";

                    Thread.Sleep(10);


                }


                //Write XML Doc
                string testFileName = "ABCFile.xml";

                SaveFileDialog sf = new SaveFileDialog();

                // Feed the dummy name to the save dialog
                sf.FileName = testFileName;
                sf.Filter = "XML Files | *.xml";
                sf.DefaultExt = "xml"; //default extention 

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    // Now here's our save folder
                    string savePath = Path.GetDirectoryName(sf.FileName);
                   

                }

                XmlTextWriter w = new XmlTextWriter(sf.FileName, new UTF8Encoding(false));

                w.Formatting = Formatting.Indented; // if there is a formating issue remove this.


                int[] values = RandomReff.generateArray(Global.userCount);
                string abc = "http://www.abc.com/xmlns/ips/etf/2015-06-10-PROPOSAL/v1";
                string w3 = "http://www.w3.org/2001/XMLSchema-instance";

                if (questionTextBox.Text != string.Empty && answerTextBox.Text != string.Empty && moneyTextBox.Text != string.Empty)
                {
                    w.WriteRaw("$$XGZ0EFTXML[IPS[CLIENT[PROD$$");
                    w.WriteRaw(@"<?xml version=""1.0"" encoding=""UTF-8""?>");
                    w.WriteStartElement("etf:TransfersRequest");
                    w.WriteAttributeString("xmlns", "etf", null, abc); //change depending on the company
                    w.WriteAttributeString("xmlns", "xsi", null, w3);
                    w.WriteStartElement("etf:Header");
                    w.WriteStartElement("etf:BatchReferenceNumber");
                    w.WriteValue(RandomBatchReference());
                    w.WriteEndElement();// <BatchReferenceNumber>
                    w.WriteStartElement("etf:CreationDateTime");
                    w.WriteValue(TodaysDate());
                    w.WriteEndElement(); // <CreationDateTime>
                    w.WriteStartElement("etf:Client");
                    w.WriteStartElement("etf:Id");
                    w.WriteValue(accountID);
                    w.WriteEndElement(); //<Id>
                    w.WriteStartElement("etf:AccountHolderName");
                    w.WriteValue("Company Name");
                    w.WriteEndElement(); //<AccountHolder>
                    w.WriteStartElement("etf:AccountNumber");
                    w.WriteValue(accountNumber); //add format reminder
                    w.WriteEndElement(); // <AccountNumber>
                    w.WriteEndElement();//<client>
                    w.WriteStartElement("etf:Type");
                    w.WriteValue("SendTransfersRequest");
                    w.WriteEndElement(); // <Type>
                    w.WriteEndElement();// <Header>
                    w.WriteStartElement("etf:Data");
                    w.WriteStartElement("etf:Send");
                    w.WriteStartElement("etf:Sender");
                    w.WriteStartElement("etf:Name");
                    w.WriteValue("Company Name");
                    w.WriteEndElement();// <Name>
                    w.WriteEndElement();// <Sender>
                    w.WriteStartElement("etf:ProcessingOptions");
                    w.WriteStartElement("etf:Priority");
                    w.WriteValue("0");
                    w.WriteEndElement();// <Priority>
                    w.WriteStartElement("etf:ReminderMaxCount");
                    w.WriteValue("3");    /// 
                    w.WriteEndElement();// <ReminderMaxCount>
                    w.WriteStartElement("etf:TemplateId");
                    w.WriteValue("003_COMP_1"); //Company Template ID
                    w.WriteEndElement();//TemplateId
                    w.WriteEndElement();// <ProcessingOptions>
                    w.WriteStartElement("etf:Currency");
                    w.WriteValue("CAD");    /// CHANGE Maybe
                    w.WriteEndElement();// <currency>
                    w.WriteStartElement("etf:Transfers");
                    // Each Recipient

                    for (int i = 0; i < Global.userCount; i++)

                    {
                        w.WriteStartElement("etf:Trf");
                        w.WriteStartElement("etf:Sender");
                        w.WriteStartElement("etf:Name");
                        w.WriteValue("ABC company"); //header
                        w.WriteEndElement();//</name>
                        w.WriteEndElement();// </sender>
                        w.WriteStartElement("etf:Recipient");
                        w.WriteStartElement("etf:Name");
                        w.WriteValue(Global.firstNamesNew[i] + " " + Global.lastNameNew[i]);
                        w.WriteEndElement();// <Name>
                        w.WriteStartElement("etf:Email");
                        w.WriteValue(Global.emailNew[i]);
                        w.WriteEndElement();// <Email>
                        w.WriteStartElement("etf:Language");
                        w.WriteValue("en");
                        w.WriteEndElement();// <Language>
                        w.WriteEndElement();// <Recipient>
                        w.WriteStartElement("etf:Authentication");
                        w.WriteStartElement("etf:Question");
                        w.WriteValue(question);
                        w.WriteEndElement();// <Autherntication>
                        w.WriteStartElement("etf:Answer");
                        w.WriteValue(answerHashed[i]);
                        w.WriteEndElement();// <Answer>
                        w.WriteStartElement("etf:HashType");
                        w.WriteValue("SHA2");
                        w.WriteEndElement();// <Answer>
                        w.WriteStartElement("etf:HashSalt");
                        w.WriteValue(saltedValue[i]);
                        w.WriteEndElement();// <HashSalt>
                                            // change to real authentication
                        w.WriteEndElement();// <authentication>
                        w.WriteStartElement("etf:Amount");
                        w.WriteValue(money.ToString("0.00")); //add value box
                        w.WriteEndElement();// <Amount> 
                        w.WriteStartElement("etf:Memo");
                        w.WriteValue("Thank you for participating in the ABC Company survey"); //thank you message on the e-transfer request
                        w.WriteEndElement();// <Language> 
                        w.WriteStartElement("etf:ReferenceNumber");
                        w.WriteValue(values[i]); // change value to random a- ####
                        w.WriteEndElement(); // <Reference Number> 
                        w.WriteEndElement();// <TRF>
                    }
                    w.WriteEndElement();// <Transfer>
                    w.WriteEndElement();// <send>
                    w.WriteEndElement();// <Data>
                    w.WriteStartElement("etf:Trailer");
                    w.WriteStartElement("etf:TotalTransfers");
                    w.WriteValue(Global.userCount); //add value box  $$$$
                    w.WriteEndElement();// <Amount> 
                    w.WriteStartElement("etf:TotalAmount");
                    w.WriteValue(totalMoney.ToString("0.00")); //add value box  $$$$
                    w.WriteEndElement();// <Amount>
                    w.WriteEndElement();// <trailer>
                    w.WriteEndElement(); // <TransferRequest>
                    w.Close();

                    MessageBox.Show($"{Global.userCount} User(s) Added! File Created!");


                    Application.Exit(); // closes application 
                }

            }

            else
            {
                MessageBox.Show("Please Fill in all Information");
            }



        }

        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                return Convert.ToBase64String(bytes);
            }
        }

        private void transactionInfo_Load(object sender, EventArgs e)
        {
            accountNumberTextBox.Text = "000-00000-0000000";
            accountIdTextBox.Text = "000000000";
        }

        public static class RandomReff
        {
            public static int[] generateArray(int count)
            {
                Random random = new Random();
                int[] values = new int[count];
                for (int i = 0; i < count; ++i)
                {
                    values[i] = random.Next();
                }
                return values;
            }
        }

        public string TodaysDate()
        {
            //Todays Creation Date. 
            DateTime td = DateTime.Now;
            string currentTime = String.Format("{0:s}", td);
            currentTime += ".100Z";

            return currentTime;

        }

        public long RandomBatchReference()
        {
            //Generates batchNumber ID reference by adding 3 random numbers to the date
            DateTime dateToInt = DateTime.Now;
            Random random = new Random();
            long randomBatchID = long.Parse(dateToInt.ToString("yyyyMMdd") + random.Next(100, 999));

            return randomBatchID;
        }

        private void transactionInfo_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult closing = MessageBox.Show("Are you sure you want to exit the Program? NOTE: Closing the program will delete all previously entered information", "Close Program", MessageBoxButtons.YesNo);

                if (closing == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void moneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            {
                if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }


        }
    }







}