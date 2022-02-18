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

        public Consult(Patient patient)
        {
            Contract.Requires(patient != null);
            this.patient = patient;
            time = new Time();
            date = new Date();
            prescriptionProducts = new List<Product>();
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
