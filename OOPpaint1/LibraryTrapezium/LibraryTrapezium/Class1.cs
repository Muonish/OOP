using System;

namespace LibraryTrapezium
{
    public interface IApplicationFunc
    {
        void Go();
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class InfoAttribute : System.Attribute
    {
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
    }
}
