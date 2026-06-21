using System;
using Hl7.Fhir.Model;
namespace fic_patient_goals
{
    class Program
    {
        static void Main(string[] args)
        {
            string PatientId = "X12984";
            string GoalsList = GetPatientGoals(PatientId);
            Console.WriteLine(GoalsList);
        }

        public static string GetPatientGoals(string PatientId)

        {
            string FHIR_EndPoint = "http://fhirserver.hl7fundamentals.org/fhir";

            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);
            var p = new Hl7.Fhir.Rest.SearchParams();
            p.Add("patient", PatientId);
            var results = client.Search<Goal>(p);
            string output = "";

            while (results != null)
            {
                if (results.Total == 0) output = "No patient goals found";

                foreach (var entry in results.Entry)
                {
                    var PatientGoal = (Goal)entry.Resource;

                    string lifecycle_status = " Lifecycle status: " + PatientGoal.LifecycleStatus + " ";

                    string description = "";

                    if (PatientGoal.Description != null)
                    {
                        if (PatientGoal.Description.Coding.Count > 0)
                        {
                            description =
                                PatientGoal.Description.Coding[0].Display
                                + " ("
                                + PatientGoal.Description.Coding[0].Code
                                + ")";
                        }
                        else
                        {
                            description = "| Description: " + PatientGoal.Description.Text;
                        }
                    }

                    output = output + lifecycle_status + description + "\r\n";
                }
                // get the next page of results
                results = client.Continue(results);
            }
            return output;
        }
    }
}

