# Argonaut Profile Mapping

### List of Profiles

#### Vitals:

*   US Core Vital Signs Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-vital-signs.html
    *   US Core Pediatric BMI for Age Observation Profile - https://hl7.org/fhir/us/core/StructureDefinition-pediatric-bmi-for-age.html
    *   US Core Pediatric Weight for Height Observation Profile - https://hl7.org/fhir/us/core/StructureDefinition-pediatric-weight-for-height.html
    *   US Core Blood Pressure Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-blood-pressure.html
    *   US Core BMI Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-bmi.html
    *   US Core Body Height Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-body-height.html
    *   US Core Body Temperature Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-body-temperature.html
    *   US Core Body Weight Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-body-weight.html
    *   US Core Head Circumference Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-head-circumference.html
    *   US Core Heart Rate Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-heart-rate.html
    *   US Core Pulse Oximetry Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-pulse-oximetry.html
    *   US Core Respiratory Rate Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-respiratory-rate.html
    *   US Core Pediatric Head Occipital Frontal Circumference Percentile Profile - https://hl7.org/fhir/us/core/StructureDefinition-head-occipital-frontal-circumference-percentile.html
*   US Core Average Bloood Pressure Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-average-blood-pressure.html

#### Immunization:

*   US Core Immunizaion Profile - https://hl7.org/fhir/us/core/StructureDefinition-us-core-immunization.html



----

## Q1 - Which Argonaut profiles will you use for each category (lab, vitals, immunization)?

| Category | Argonaut Profile | 
|---|---|
| Lab | US Core Laboratory Result Observation Profile | 
| Vital signs | US Core Vital Sign Profile |  
| Immunization | US Core Immunization Profile | 

## Q2 - Which Argonaut profiles codes and codesystem will you use for each category (lab, vitals, immunization)?

| Category | Description | Terminology codes from profile | Code system| 
|---|---|---|---|
| Imunization | Measles, mumps and rubella (combination vaccine) | [03] | [http://hl7.org/fhir/sid/cvx] |
| Imunization |influenza virus vaccine | [16] | [http://hl7.org/fhir/sid/cvx] |
| Imunization | typhoid vaccine| [91] | [http://hl7.org/fhir/sid/cvx] |
| Imunization | Hepatitis A and B, in a combination vaccine  | [104] | [http://hl7.org/fhir/sid/cvx] |
| Imunization | yellow fever vaccine  |[37] | [http://hl7.org/fhir/sid/cvx] |
| Vitals | Blood Pressure |  Systolic: [8480-6], Diastolic: [8462-4] | [http://loinc.org]|
| Vitals | Heart Rate | [8867-4] | [http://loinc.org]|
| Vitals | Anthropometry |  Body Height: [8302-2], Body Weight: [29463-7], BMI: [39156-5] | [http://loinc.org]|
| Labs | Urinalysis Routine | [24356-8] | [http://loinc.org]|
| Labs | Blood (Basic Metabolic Panel) | [51990-0] | [http://loinc.org]|
| Labs | CBC| [58410-2] | [http://loinc.org]|