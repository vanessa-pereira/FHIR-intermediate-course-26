## U01-8: FHIR	Use	Case Proposal (Architecture)

### Question 1
VIGNETTE 1

- If the endpoint for the server is http://serverfhir.org/r4, enter the full url to obtain all the patient's allergies

Answer: 
http://serverfhir.org/r4/AllergyIntolerance

### Question 2
VIGNETTE 1

- If the endpoint for the FHIR server is http://pcpfhir.org/r4, enter the full url to query all the patient's information. 

Answer: 
http://pcpfhir.org/r4/Patient

### Question 3
VIGNETTE 2

- If the endpoint for the FHIR server is http://providersfhir.org/r4, enter the full url to query for providers. 

Answer: 
http://providersfhir.org/r4/Organization
recommended by autocorrect: http://providersfhir.org/r4/Practitioner

### Question 4
VIGNETTE 2

- If the endpoint for the FHIR server is http://providersfhir.org/r4, enter the full url to find a patient. 

Answer: 
http://providersfhir.org/r4/Patient?_name=Judy

### Question 5

- If the endpoint for the FHIR server is http://resultsfhir.org/r4, enter the full url to query for documents. 

Wrong attempt: http://resultsfhir.org/r4/Composition

Correct: http://resultsfhir.org/r4/DiagnosticReport



### Question 6

VIGNETTE 3

- If the endpoint for the FHIR server is http://medicarefhir.org/r4, enter the full url to query and retrieve the highest risk patients based on diabetes control levels, and reach out to those who should be screened for early signs of diabetic retinopathy.

Answer: 
http://medicarefhir.org/r4/Observation?code=http://loinc.org|4548-4&value-quantity=gt9|http://unitsofmeasure.org|%


### Question 7

VIGNETTE 3

- If the endpoint for the FHIR server is http://medicarefhir.org/r4, enter the full url to query and retrieve last known A1C. 

Answer: 
http://medicarefhir.org/r4/Observation?code=http://loinc.org|4548-4&_sort=-date&_count=1


### Question 8

VIGNETTE 3

- If the endpoint for the FHIR server is http://medicarefhir.org/r4, enter the full url to query the date of the last eye exam for the panel of patients identified per the quality measure specification


wrong attempt: http://medicarefhir.org/r4/Observation?patient=123&code=http://loinc.org|29271-4&_sort=-date&_count=1

correct: http://medicarefhir.org/r4/Procedure