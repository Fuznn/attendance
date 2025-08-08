using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance
{
    internal class CreateFile
    {
        public static string? createFile(TextBox txtSave)
        {
            try 
            {
                using var saveFileDialog = new System.Windows.Forms.SaveFileDialog
                {
                    Title = "Create Attendance File",
                    //Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                    Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    FileName = "attendance.txt",
                    DefaultExt = "txt"
                };
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                { 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        // Write some initial content to the file
                        file.WriteLine("Attendance Record");
                        file.WriteLine("Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
                        file.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));
                        file.WriteLine("----------------------------");
                        txtSave.Text = saveFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the file: " + ex.Message);
            }
            return null;
        }
    }
}
