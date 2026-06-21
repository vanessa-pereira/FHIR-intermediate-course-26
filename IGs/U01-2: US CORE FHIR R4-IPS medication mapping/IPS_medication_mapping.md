## FHIRPath Queries

| Question | FHIRPath Query | Label |
|---|---|---|
| IPS - FHIRPath for get the Medication Code | `MedicationStatement.medicationCodeableConcept.coding.code` | Medication Code |  
| IPS - FHIRPath for get the Medication Date | `MedicationStatement.effectiveDateTime` | Medication Date |  
| IPS - FHIRPath for get the Medication Name | `MedicationStatement.medicationCodeableConcept.coding.display` | Medication Name |  
| IPS - FHIRPath for get the Medication Prescriber | `MedicationStatement.informationSource.display` | Medication Prescriber |  
| IPS - FHIRPath for get the Medication Statement Status | `MedicationStatement.status` | Medication Status |  
| US CORE - FHIRPath for get the Medication Code | `MedicationRequest.medicationCodeableConcept.coding.code` | Medication Code |  
| US CORE - FHIRPath for get the Medication Date | `MedicationRequest.authoredOn` | Medication Date |  
| US CORE - FHIRPath for get the Medication Name | `MedicationRequest.medicationCodeableConcept.coding.display` | Medication Name |  
| US CORE - FHIRPath for get the Prescriber name | `MedicationRequest.requester.display` | Prescriber Name |  
| US CORE - FHIRPath for get the Medication Status | `MedicationRequest.status` | Medication Status |  
