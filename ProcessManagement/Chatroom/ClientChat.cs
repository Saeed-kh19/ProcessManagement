using EasyFileTransfer;
using ProcessManagement.Chatroom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Sample.Client
{
    public partial class ClientChat
    {

        private void SnedButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                EasyFileTransfer.Model.Response rsp = EftClient.Send(openFileDialog1.FileName, textBox2.Text, Convert.ToInt32(textBox1.Text));
                if (rsp.status == 1)
                {
                    MessageBox.Show("send successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
