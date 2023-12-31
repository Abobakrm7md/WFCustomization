using System.Collections.Generic;

namespace WFCustomization.Shared.Logging.Settings
{
    public class LoggerSettings
    {
        public string Level { get; set; }
        public ConsoleSettings Console { get; set; }
        public FileSettings File { get; set; }
        public IDictionary<string, string> Overrides { get; set; }
        public IEnumerable<string> ExcludePaths { get; set; }
        public IEnumerable<string> ExcludeProperties { get; set; }
        public IDictionary<string, object> Tags { get; set; }
    }
}
