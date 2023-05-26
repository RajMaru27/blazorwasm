using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMPractice.Shared
{
    public class BankList
    {
        public string SearchTerm { get; set; } = string.Empty;
        public List<Bank> Banklist { get; set; } = new List<Bank>();
    }
}
