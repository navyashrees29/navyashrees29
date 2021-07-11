using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PatientDataReaderLib
{
    public class PatientDataReaderType
    {
        public List<ModelsLib.PatientDataInfo> GetAllPatientsDetails(string path)
        {
            List<string> lines = GetAllLines(path);
            List<ModelsLib.PatientDataInfo> patientList = new List<ModelsLib.PatientDataInfo>();
            for (int i = 0; i < lines.Count; i++)
            {
                ModelsLib.PatientDataInfo patientDataInfo = MapLineItemPatientObject(lines[i]);
                patientList.Add(patientDataInfo);
            }
            return patientList;
        }

        private List<string> GetAllLines(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> lines = new List<string>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                lines.Add(line);
            }
            reader.Close();
            return lines;
        }

        private ModelsLib.PatientDataInfo MapLineItemPatientObject(string lineItem)
        {
            string[] lineItems = lineItem.Split(',');
            ModelsLib.PatientDataInfo patientData = new ModelsLib.PatientDataInfo();
            patientData.Name = lineItems[0];
            patientData.Height = float.Parse(lineItems[1]);
            patientData.Weight = float.Parse(lineItems[2]);
            return patientData;
        }

    }
}

