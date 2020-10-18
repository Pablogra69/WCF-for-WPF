using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]

        String Add(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        //string AddData(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        [OperationContract]
        String Divide(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        // string MinusData(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        [OperationContract]
        String Multiply(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        //string MultipleData(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        [OperationContract]
        String Subtract(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);
        //string DeviceData(double valueReal1, double valueImaginary1, double valueReal2, double valueImaginary2);

        

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
    //}
}
