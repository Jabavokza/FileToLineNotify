using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FileToLineNotify
{
    public partial class wMain : Form
    {
        public wMain()
        {
            InitializeComponent();
        }

        private void wMain_Load(object sender, EventArgs e)
        {

        }
        private void ocmOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog oOpenFileDialog = new OpenFileDialog()
                {
                    Multiselect = true,
                };
                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    otbPartFile.Text = oOpenFileDialog.FileName;
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmOpenFile_Click // " + oEx.Message);
            }
        }
        private void ocmSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (otbPartFile.Text.Equals(""))
                {
                    MessageBox.Show("Select File");
                }
                else
                {
                    ImageUploadResult oUploadResult = GEToUrl();
                    otbResult.Text = oUploadResult.Uri.OriginalString;
                    SETxPictureToLinNotify(otbResult.Text);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : ocmSend_Click // " + oEx.Message);
            }
        }
        private ImageUploadResult GEToUrl()
        {
            try
            {
                Cloudinary oCloudinary = new Cloudinary(new Account("jabavokza", "978885474333712", "tjSIxPOssmN7F5cqnCbW_b0n3Jk"));

                ImageUploadParams oUploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(otbPartFile.Text),
                };
                ImageUploadResult oUploadResult = oCloudinary.Upload(oUploadParams);
                return oUploadResult;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private void SETxPictureToLinNotify(string ptUrl)
        {
            try
            {
                string tMsg = "Code I have";// ข้อความแนบรูปภาพ  สามารถเปลี่ยนได้
                otbMsgRes.Text = POStToApiLine(tMsg, ptUrl);
            }
            catch (Exception oEx)
            {
                MessageBox.Show("wMain : SETxPictureToLinNotify // " + oEx.Message);
            }

        }
        private string POStToApiLine(string ptMsg, string ptPictureUrl)
        {
            try
            {
                string tToken = "rIZaHJMClZ2dAqJwO8v96WWjmAEEiEi1qHvwRZezodF";
                HttpWebRequest oRequest = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");

                string tPostData = string.Format("message={0}", ptMsg);
                if (ptPictureUrl != "")
                {
                    string tImageThumbnail = string.Format("imageThumbnail={0}", ptPictureUrl);
                    string tImageFullsize = string.Format("imageFullsize={0}", ptPictureUrl);
                    tPostData += "&" + tImageThumbnail.ToString() + "&" + tImageFullsize.ToString();
                }
                byte[] aData = Encoding.UTF8.GetBytes(tPostData);

                oRequest.Method = "POST";
                oRequest.ContentType = "application/x-www-form-urlencoded";
                oRequest.ContentLength = aData.Length;
                oRequest.Headers.Add("Authorization", "Bearer " + tToken);

                using (Stream oStream = oRequest.GetRequestStream())
                {
                    oStream.Write(aData, 0, aData.Length);
                }

                HttpWebResponse oResponse = (HttpWebResponse)oRequest.GetResponse();
                string tResponseString = new StreamReader(oResponse.GetResponseStream()).ReadToEnd();
                return tResponseString;
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

    }
}
