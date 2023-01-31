namespace HW_2._5
{
    interface ILogger
    {
        void LogMessage(string message);
        void LogError(string error);

    }
    public class FileLogger : ILogger
    {
        private readonly string _filePath;
        private const int _maxFiles = 3;
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void LogError(string error)
        {
            var fileName = $"{DateTime.Now:yyyyMMdd_HHmmss}.log"; ;
            var fullFilePath = Path.Combine(_filePath, fileName);

            using (var streamWriter = new StreamWriter(fullFilePath, true))
            {
                streamWriter.WriteLine(error);
            }

            CleanupOldFiles();
        }

        public void LogMessage(string message)
        {
            var fileName = $"{DateTime.Now:yyyyMMdd_HHmmss}.log";
            var fullFilePath = Path.Combine(_filePath, fileName);

            using (var streamWriter = new StreamWriter(fullFilePath, true))
            {
                streamWriter.WriteLine(message);
            }

            CleanupOldFiles();
        }

        private void CleanupOldFiles()
        {
            var files = Directory.GetFiles(_filePath)
                .OrderBy(f => f)
                .ToList();

            var toDelete = files.Count - _maxFiles;
            if (toDelete <= 0)
            {
                return;
            }

            for (var i = 0; i < toDelete; i++)
            {
                var file = files[i];
                File.Delete(file);
            }
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"[ERROR] {error}");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }

    }
}
