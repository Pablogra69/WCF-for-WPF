using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        String IService1.Add(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2)
        {
            return GetDataUsingDataContract(valueReal1, valueImaginary1, valueReal2, valueImaginary2, 1).ToString();
        }

        String IService1.Divide(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2)
        {
            return GetDataUsingDataContract(valueReal1, valueImaginary1, valueReal2, valueImaginary2, 2).ToString();
        }

        String IService1.Multiply(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2)
        {
            return GetDataUsingDataContract(valueReal1, valueImaginary1, valueReal2, valueImaginary2, 3).ToString();
        }

        String IService1.Subtract(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2)
        {
            return GetDataUsingDataContract(valueReal1, valueImaginary1, valueReal2, valueImaginary2, 4).ToString();
        }
       



      ///////  https://www.codeproject.com/Articles/18282/Complex-Calculator

       

        public String GetDataUsingDataContract(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2, int operation)
        {

            Complex complex1 = new Complex(valueReal1, valueImaginary1);
            Complex complex2 = new Complex(valueReal2, valueImaginary2);

            Complex count =0;
            if (operation == 1) count = (complex1 + complex2);
            else if (operation == 2) count = (complex1 * complex2);
            else if (operation == 3) count = (complex1 - complex2);
            else if (operation == 4) count = (complex1 / complex2);


            return count.ToString();


        }

       
    }
}
