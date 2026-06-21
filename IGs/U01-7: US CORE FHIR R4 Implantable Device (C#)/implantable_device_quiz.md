## Assignment U01-7: US CORE FHIR R4 Implantable Device (C#) - Part Quiz 1


### profile reference
https://www.hl7.org/fhir/us/core/StructureDefinition-us-core-implantable-device.html



Review the C# code and answer

a. Why does this code fail in searching the Implantable Devices for an athlete? 
The query fails because it is searching with a parameter of  subject instead of  patient
subject is not a search parameter but patient is.
the 'results' for page identation should be outside of the foreach loop


b. Which mandatory/must-support elements is the program not showing? [3 points]
mandatory - type
must support - distinctIdentifier (?), manufactureDate,  expirationDate, lotNumber, serialNumber
