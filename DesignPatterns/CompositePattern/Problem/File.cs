namespace CodingInterviewSolutions.DesignPatterns.CompositePattern.Problem
{
    internal class File
    {
        public string FileName { get; }

        public File(string fileName)
        {
            FileName = fileName;
        }

        public void LinuxLsCommand()
        {
            Console.WriteLine($"The filename is: {FileName}");
        }
    }
}
