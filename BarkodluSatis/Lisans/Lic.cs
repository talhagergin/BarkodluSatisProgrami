using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;


namespace Lisans
{
    public class Lic
    {
        public string CpuNo()
        {
            string islemciid = "";
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
           foreach (ManagementObject mo in mbsList)
            {
               islemciid = mo["ProcessorID"].ToString();
            }
            return islemciid;
        }

    }
}
