import requests
#Patient id
id= 'X12984'
#Now Searching the vitals for the patient
urlEndpoint='http://fhirserver.hl7fundamentals.org/fhir'
urlObservations =urlEndpoint+'/Observation?patient='+id +"&_sort=code,date"
print('Now Searching for Observations...@'+urlObservations)
observation_response = requests.get(urlObservations).json()
while urlObservations != None:
  observation_response = requests.get(urlObservations).json()
  key='entry'
  EntryArray=observation_response[key]
  print (observation_response)
  content=''
  print ('Observation(s) found for the patient')
  for entry in EntryArray:
    observation=entry['resource']
    ISODate=observation['effectiveDateTime']
    content = content + f"{observation['status']}|{observation['code']['text']}|{ISODate}|{observation['valueQuantity']['value']:.2f} {observation['valueQuantity']['unit']}\r\n"
  print (content)
  urlObservations=next((link['url'] for link in observation_response['link']
                        if link['relation']=='next'), 
                       #similar to sql select URL from link in obs response where link relation = next
                        None)