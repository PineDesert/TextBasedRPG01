using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG01
{
    internal class Page
    {
        public int PageNumber { get; private set; }
        
        public string Content { get; private set; }

        public Page(int pageNumber, string content)
        {
            PageNumber = pageNumber;
            Content = content;
        }
    }
}
