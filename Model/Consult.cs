using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CentroNaturistaMasaya.Model
{
    internal class Consult
    {
        private int idConsult;
        private Time time;
        private Date date;
        private Patient patient;
        private List<Product> prescriptionProducts;


        public Consult()
        {

        }

        public Consult(Patient patient) : this(0, new Time().actualTime(), new Date().getToday(), patient)
        {
        }

        public Consult(int idConsult, Time time, Date date, Patient patient)
        {
            Contract.Requires(idConsult >= 0 && time != null && date != null && patient != null);

            this.idConsult = idConsult;
            this.time = time;
            this.date = date;
            this.patient = patient;
        }


        public void addPrescriptionProduct(Product product)
        {
            Contract.Requires(product != null);
            prescriptionProducts.Add(product);
        }

        public void deletePrescriptionProduct(Product product)
        {
            Contract.Requires(product != null);
            prescriptionProducts.Remove(product);
        }

        public void addSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
            patient.addSymptom(symptom);
        }

        public void deleteSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
            patient.deleteSymptom(symptom);
        }

    }
}
