using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pz_26
{
    internal class FileWork
    {
        public static void CreateFile(string path)
        {
            try
            {
                File.Create(path);
            }
            catch
            {
                MessageBox.Show("File creation error", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           
        }
        public static async void SaveFile(string path, string text)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Append))
                {
                    byte[] buffer = Encoding.Default.GetBytes(text);
                    await fileStream.WriteAsync(buffer, 0, buffer.Length);
                }
            }
            catch
            {
                MessageBox.Show("File save error", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        public static async void OpenFile(string path)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream, System.Text.Encoding.Default))
                    {
                        string text = await streamReader.ReadToEndAsync();
                    }
                }
            }
            catch
            {
                MessageBox.Show("File opening error", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        public static void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch
            {
                MessageBox.Show("File delition error", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
