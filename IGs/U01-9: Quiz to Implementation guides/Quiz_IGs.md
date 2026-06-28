## IG Quiz

### Question 1
- Why do we state that FHIR is a “platform specification”?

a. Because it requires adaptation to suit particular context of use

### Question 2

- What is the primary goal of the Argonaut Data Query/US Core IGs?

b. Allow physicians/patients to safely access demographic/clinical information


### Question 3

- Which spec is the basis for Argonaut Smart-On-FHIR authentication? 

c. oAuth


### Question 4

- Which guide we discussed allows the specific FHIR version to be stated in the ex-changed resources? 

d. CDS-Hooks

### Question 5
- What is the meaning of that red letter S in the tabular versions of profiles in an implementation guide  

a. ‘Must-Support’: as a server, if you have this information in your system, you are mandated to send it. As a client, you are supposed to process this information, display it to your users, or, at least not fail when receiving them.

### Question 6
- Which are the mandatory elements for a conformant FHIR US-Core Patient re-source instance?

a. Name, gender, identifier

note: i dont think this is correct as only name and gender are mandatory on https://build.fhir.org/ig/HL7/US-Core/StructureDefinition-us-core-patient.html and gender does not exist but only sex as extension

### Question 7

- Which extensions are defined for the FHIR US-Core Patient profile?


c. For Race, Ethnicity,  Birth Sex and Gender Identity

note: I dont think this is correct as only Race, Ethnicity, Tribial Affiliation, sex and interpreter required are extension in US patient profile. sex =/= gender

### Question 8

- Which resources are constrained by the Provider Directory IG? Select the most complete list.

d. Practitioner, PractitionerRole, Location, Organization, Endpoint