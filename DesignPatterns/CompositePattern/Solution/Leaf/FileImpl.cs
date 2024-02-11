using CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Component;

namespace CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Leaf
{
    internal class FileImpl : IFileSystem
    {
        public string FileName { get; }

        public FileImpl(string fileName)
        {
            FileName = fileName;
        }

        public void LinuxLsCommand()
        {
            Console.WriteLine($"The filename is: {FileName}");
        }
    }
}
