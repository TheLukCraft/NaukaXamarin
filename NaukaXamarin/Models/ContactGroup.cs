using System;
using System.Collections.Generic;
using System.Text;

namespace NaukaXamarin.Models
{
    class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
    }
}
