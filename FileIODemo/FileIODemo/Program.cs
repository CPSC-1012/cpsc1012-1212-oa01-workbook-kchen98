using System;
using System.IO; // file class
namespace FileIODemo
{
    internal class Program
    {
        static string DataFilePath = "../../../points.txt";
        static string OutputDataFilePath = "../../../output-file.txt";

        static void WriteToFileUsingStreamWriter(string[] nameArray, int[] pointArray, int studentCount)
        {
            try
            {
                // Overwrite the file
                StreamWriter writer = new StreamWriter(OutputDataFilePath);
                //To append to the file instead you cause
                //StreamWriter writer = new StreamWriter(DataFilePath, true);
                for (int index = 0; index < studentCount; index++)
                {
                    writer.Write(nameArray[index]);
                    writer.Write(',');
                    writer.Write(pointArray[index]);
                    writer.WriteLine();
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file with exception {ex.Message}");
            }
        }
        static int ReadFromFileUsingStreamReader(string[] nameArray, int[] pointArray)
        {
            int recordCount = 0;
            // Check if the data file exists
            if (!File.Exists(DataFilePath))
            {
                Console.WriteLine($"The file ${DataFilePath} does not exists.");
            }
            else
            {
                try
                {
                    StreamReader reader = new StreamReader(DataFilePath);
                    int index = 0;
                    while (!reader.EndOfStream && recordCount < nameArray.Length)
                    {
                        string currentLine = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(currentLine))
                        {
                            // Return an array where each value is separated by a comma
                            string[] tokens = currentLine.Split(',');
                            nameArray[index] = tokens[0];
                            pointArray[index] = int.Parse(tokens[1]);
                            index++;
                            recordCount++;
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading from file with exception {ex.Message}");
                }
            }
                return recordCount;
        }
        static int ReadFromFileUsingReadAllLines(string[] nameArray, int[] pointArray)
        {
            int recordCount = 0; // number of records read from file

            // Check if the data file exists
            if (!File.Exists(DataFilePath))
            {
                Console.WriteLine($"The file ${DataFilePath} does not exists.");
            }
            else
            {
                try
                {
                    // Read all the lines from the text file and return an array of lines
                    string[] allLines = File.ReadAllLines(DataFilePath);
                    const char Delimiter = ',';
                    for (int index = 0; index < allLines.Length && index < nameArray.Length; index++)
                    {
                        string currentLine = allLines[index];
                        string[] tokens = currentLine.Split(Delimiter);
                        nameArray[index] = tokens[0];
                        pointArray[index] = int.Parse(tokens[1]);
                        recordCount++;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write($"Error reading from file with exception {ex.Message}");
                }
            }
            return recordCount;
        }
        static void Main(string[] args)
        {
            // Declare and create two parallel arrays for student names and student points
            const int MaxStudents = 25;
            int currentStudentCount = 0;
            string[] nameArray = new string[MaxStudents];
            int[] pointArray = new int[MaxStudents];

            //currentStudentCount = ReadFromFileUsingReadAllLines(nameArray, pointArray);
            currentStudentCount = ReadFromFileUsingStreamReader(nameArray, pointArray);

            // Call the WriteToFileUsingStreamWriter method
            WriteToFileUsingStreamWriter(nameArray, pointArray, currentStudentCount);  
            
            DisplayStudents(nameArray, pointArray, currentStudentCount);
        }

        static void DisplayStudents(string[] nameArray, int[] pointArray, int studentCount)
        {
            for (int index = 0; index < studentCount; index++)
            {
                Console.WriteLine($"{nameArray[index],-20} {pointArray[index],6}");
            }
        }
    }
}
