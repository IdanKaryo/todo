using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    public class ListEntity
    {
        public string Name { get; set; }
        public List<string> List { get; set; }
    }
}