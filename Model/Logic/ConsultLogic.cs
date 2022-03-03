using MasayaNaturistCenter.Model.Utilities;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class ConsultLogic
    {
        private ConsultDTO consult;
        private ConsultDAO consultDAO;
        

        public ConsultLogic(ConsultDTO objectDTO, ConsultDAO objectDAO)
        {
            Contract.Requires(objectDTO != null && objectDTO != null);
            consult = objectDTO;
            consultDAO = objectDAO;
        }


        public void addPrescriptionProduct(Product product)
        {
            Contract.Requires(product != null);
            consult.prescriptionProducts.Add(product);
        }

        public void deletePrescriptionProduct(Product product)
        {
            Contract.Requires(product != null);
            consult.prescriptionProducts.Remove(product);
        }

        public void addSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
            consult.patient.addSymptom(symptom);
        }

        public void deleteSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
            consult.patient.deleteSymptom(symptom);
        }

    }
}
