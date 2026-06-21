using System;
using Hl7.Fhir.Model;
namespace fic_device
{
    class Program
    {
        static void Main(string[] args)
        {
            string PatientId = "X12984";
            string DeviceList = GetPatientDevices(PatientId);
            Console.WriteLine(DeviceList);
        }

        public static string GetPatientDevices(string PatientId)

        {
            string FHIR_EndPoint = "http://fhirserver.hl7fundamentals.org/fhir";

            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);
            var p = new Hl7.Fhir.Rest.SearchParams();
            p.Add("patient", PatientId);
            var results = client.Search<Device>(p);
            string output = "";
            while (results != null)
            {
                if (results.Total == 0) output = "No devices found";

                foreach (var entry in results.Entry)
                {
                    var Device = (Device)entry.Resource;
                    string Content = "";

                        if (Device.UdiCarrier.Count > 0)
                        {
                            Content =  "UDI Human Readable Barcode: " 	+ Device.UdiCarrier[0].CarrierHRF+"|"
                                    + " Device Identifier: " + Device.UdiCarrier[0].DeviceIdentifier + "|";
                                     
                        }
                        if (Device.Status.HasValue)
						{
						Content = Content + " Device Status: " + Device.Status 
							+ "| Expir Date: " + Device.ExpirationDate 
							+ "| Type: " + Device.Type.Coding[0].Display ;
                        
                        output = output + Content + "\r\n";   
                }
            }
				// get the next page of results
				results = client.Continue(results);
				if (results == null)
    			break;
        }
		return output;
    }
	}
}

