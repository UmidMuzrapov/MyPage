using System.Collections.Generic;

namespace UmidMuzrapov.Shared
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string Icon { get; set;}
        public List<MenuItem> Items { get; set; }
    }
}
