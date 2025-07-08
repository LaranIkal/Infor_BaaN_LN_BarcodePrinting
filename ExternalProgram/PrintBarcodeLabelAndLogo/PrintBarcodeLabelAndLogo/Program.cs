using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PrintBarCodeLabelWithLogo
  {
  class Program
  {
    static void Main(string[] args)
    {
      String LogofileName = "";
      String SpoolFile = "";

      if (args == null)
      {

      }
      else
      {
        LogofileName = args[0];
        SpoolFile = args[1];
        string SpoolToPrint = args[2];

        string LogoFile = File.ReadAllText(LogofileName, ASCIIEncoding.Default);

        string SpoolFileToPrint = File.ReadAllText(SpoolFile, ASCIIEncoding.Default);
        string DataWithLogo = SpoolFileToPrint.Replace("***COMPANYLOGO***", LogoFile);
        File.WriteAllText(SpoolFile, DataWithLogo, ASCIIEncoding.Default);
        File.Copy(SpoolFile, SpoolToPrint);
      }
    }
  }
}
