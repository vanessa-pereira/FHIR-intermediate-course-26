using System;
using Hl7.Fhir.Model;
namespace fic_allergy
{
    class Program
    {
        static void Main(string[] args)
        {
            string PatientId = "11649";
            string AllergyList = GetPatientAllergies(PatientId);
            Console.WriteLine(AllergyList);
        }

        public static string GetPatientAllergies(string PatientId)

        {
            string FHIR_EndPoint = "http://fhirserver.hl7fundamentals.org/fhir";

            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);
            var p = new Hl7.Fhir.Rest.SearchParams();
            p.Add("patient", PatientId);
            var results = client.Search<AllergyIntolerance>(p);
            string output = "";
            while (results != null)
            {
                if (results.Total == 0) output = "No allergies found";

                foreach (var entry in results.Entry)
                {
                    var Alrgy = (AllergyIntolerance)entry.Resource;
                    string Content = Alrgy.Code.Coding[0].Display
                        + " / " + Alrgy.VerificationStatus.Coding[0].Code
                        + " (" + Alrgy.ClinicalStatus.Coding[0].Code + ")";
                    output = output + Content + "\r\n";   
                }
                 // get the next page of results
                results = client.Continue(results);
            }
            return output;
        }
    }
}

