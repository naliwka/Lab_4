using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_4
{
    internal class ApplicationLicense
    {
        private string key = "";
        private string keyPro = "34G5JBK245J3BMFS";
        private string keyTrial = "6KEJL";
        private License control = new License();
        private enum License
        {
            Common,
            Pro,
            Trial
        }
        public string Control
        {
            get 
            { 
                return control.ToString(); 
            }
        }
        public void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
            control = License.Trial;
        }
        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }
        public void AllowPro()
        {
            Console.WriteLine("Платна версія");
            control = License.Pro;
        }
        
        public ApplicationLicense(string key)
        {
            if (key == keyPro)
            {
                this.key = keyPro;
                AllowPro();
                Console.WriteLine(control);
            }
            else if (key == keyTrial)
            {
                this.key = keyTrial;
                AllowTrial();
                Console.WriteLine(control);
            }
            else
            {
                AllowCommon();
                Console.WriteLine(control);
            }
        }
    }
}
