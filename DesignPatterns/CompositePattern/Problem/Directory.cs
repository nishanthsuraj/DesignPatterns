namespace CodingInterviewSolutions.DesignPatterns.CompositePattern.Problem
{
    internal class Directory
    {
        public string DirectoryName { get; set; }
        public IList<object> Files { get; set; }


        public Directory(string directoryName)
        {
            DirectoryName = directoryName;
            Files = new List<object>();
        }

        public void LinuxLsCommand()
        {
            Console.WriteLine($"The Directory name: {DirectoryName}");

            foreach (object file in Files)
            {
                if (file.GetType() == typeof(File))
                {
                    ((File)file).LinuxLsCommand();
                }
                else if (file.GetType() == typeof(Directory))
                {
                    ((Directory)file).LinuxLsCommand();
                }
            }
        }

        public void Add(object obj)
        {
            Files.Add(obj);
        }
    }
}
