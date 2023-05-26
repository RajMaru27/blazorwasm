using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMPractice.Shared
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public int AccountType { get; set; } 
        public string Branch { get; set; } = string.Empty;
        public string IfscCode { get; set; } = string.Empty;
       
    }
}
