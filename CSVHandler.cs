using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Wfa
{
    class Indicators
    {

    }

    class CSVHandler
    {
        public static string FileExtension = ".csv";
        public static char FileDelimiter = ';';



        CSVHandler() { }

        public static void handler(string sourcePath, string destinationPath)
        {
            string[] files = Directory.GetFiles(sourcePath, "*" + FileExtension);
            Array.Sort(files);
            if (files.Length != 0)
            {
                string fileName = files.Last();

                var temp = File.ReadAllText(fileName).Split('\n');

                string[] names = fileName.Split('.');
                fileName = names[0];

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(destinationPath, fileName + ".txt")))
                {
                    outputFile.WriteLine("((//++");
                    int lineCounter = 1;
                    string[] tempArray = null;


                    for (int i = 11; i < temp.Length; i++)
                    {

                        if (i != 14 && temp[i] != "")
                        {
                            outputFile.Write("(" + lineCounter + ")");
                            tempArray = temp[i].Split(FileDelimiter);
                            for (int j = 1; j < tempArray.Length && tempArray[j] != "\r"; j++)
                            {
                                outputFile.Write(":" + tempArray[j]);
                            }
                            outputFile.Write("::\n");
                            lineCounter += 1;
                        }
                    }


                    outputFile.WriteLine("==))");

                   
                }
                Process.Start(destinationPath);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Відсутній файл для конвертації");
            }
        }

        public static int linesCounter()
        {
            return 0;
            /*
            string[] files = Directory.GetFiles(sourcePath, "*" + FileExtension);
            Array.Sort(files);
            string fileName = files.Last();
            System.IO.StreamReader src = new System.IO.StreamReader(fileName);

            int counter = 0;
            string line;

            while ((line = src.ReadLine()) != null)
            {
                counter += 1;
            }

            src.Close();

            return counter;*/
        }
    }
}
