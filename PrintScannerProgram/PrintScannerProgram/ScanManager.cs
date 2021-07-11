using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    public class ScanManager 
    {
        
      public void ScanDocument(IScanner scanner)
        {
            scanner.Scan();
        }
    }
}
