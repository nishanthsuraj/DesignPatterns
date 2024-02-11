using CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Component;

namespace CodingInterviewSolutions.DesignPatterns.CompositePattern.Solution.Composite
{
    internal class DirectoryImpl : IFileSystem
    {
        public string DirectoryName { get; set; }
        public IList<IFileSystem> Files { get; set; }


        public DirectoryImpl(string directoryName)
        {
            DirectoryName = directoryName;
            Files = new List<IFileSystem>();
        }

        public void LinuxLsCommand()
        {
            Console.WriteLine($"The Directory name: {DirectoryName}");

            foreach (IFileSystem file in Files)
            {
                file.LinuxLsCommand();
            }
        }

        public void Add(IFileSystem fileSystem)
        {
            Files.Add(fileSystem);
        }
    }
}
