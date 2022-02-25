using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class Patient
    {
        private PersonalInformation personalInformation;
        private List<String> symptoms;
        private List<Consult> recordMedicalConsultation;


        public Patient()
        {
            
        }

        public Patient(PersonalInformation personalInformation) 
        {
            Contract.Requires(personalInformation != null);

            this.personalInformation = personalInformation;
            symptoms = new List<String>();
        }


        public void addSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
            symptoms.Add(symptom);
        }

        public void deleteSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
            symptoms.Remove(symptom);
        }

    }
}
