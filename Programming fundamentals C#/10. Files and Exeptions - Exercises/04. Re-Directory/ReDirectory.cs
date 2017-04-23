﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

/*You have been tasked to distribute a directory (folder) of files with various extensions to different folders. The files should be 
distributed by their file extension. You need to group all the files, which have the same extension into a folder named: “{extension} + s”
In other words: all “.txt” files must be put in a folder called “txts”.
The resulting folders should be put in a folder “output”.*/
namespace _04.Re_Directory
{
    class ReDirectory
    {
        
        static void Main(string[] args)
        {
            var inputFiles = Directory.GetFiles("input");

            Directory.CreateDirectory("output");
            Directory.CreateDirectory("output/txts");
            Directory.CreateDirectory("output/pngs");
            Directory.CreateDirectory("output/tests");

            var txtFiles = new List<string>();
            var pngFiles = new List<string>();
            var testFiles = new List<string>();

            foreach (var file in inputFiles)
            {
                var fileInfo = new FileInfo(file);
                var extension = fileInfo.Extension;

                switch (extension)
                {
                    case ".txt":
                        txtFiles.Add(file);
                        break;
                    case ".png":
                        pngFiles.Add(file);
                        break;
                    case ".test":
                        testFiles.Add(file);
                        break;
                }
            }

            MovingTheFilesFiles(txtFiles, pngFiles, testFiles);
        }

        private static void MovingTheFilesFiles(List<string> txtFiles, List<string> pngFiles, List<string> testFiles)
        {
            foreach (var txtFile in txtFiles)
            {
                var currentFile = new FileInfo(txtFile);
                var txtFileAsString = currentFile.Name;

                File.Move(txtFile, "output/txts/" + txtFileAsString);
            }

            foreach (var pngFile in pngFiles)
            {
                var currentFile = new FileInfo(pngFile);
                var pngFileAsString = currentFile.Name;

                File.Move(pngFile, "output/pngs/" + pngFileAsString);
            }

            foreach (var testFile in testFiles)
            {
                var currentFile = new FileInfo(testFile);
                var testFileAsString = currentFile.Name;

                File.Move(testFile, "output/tests/" + testFileAsString);

            }
        }
    }
}
