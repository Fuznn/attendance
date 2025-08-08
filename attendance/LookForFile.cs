using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices.Marshalling;

namespace attendance
{
    internal class LookForFile
    {
        /*This class is used to look for a section file that
       integrated the names to be used to check attendance.*/
        public static void lookForFile(TextBox txtLoad)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = "Select or Create Section File",
                Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"File selected: {openFileDialog.FileName}");
                    txtLoad.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured while opening the file: {ex.Message}");
            }
            //gegegge 
        }
    }
}
