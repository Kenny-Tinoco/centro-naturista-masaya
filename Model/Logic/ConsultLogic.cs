using MasayaNaturistCenter.Model.DAO;
using MasayaNaturistCenter.Model.DTO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.Model
{
    public class ConsultLogic
    {
        private ConsultDTO consult;
        private IConsultDAO consultDAO;
        

        public ConsultLogic(ConsultDTO objectDTO, IConsultDAO objectDAO)
        {
            Contract.Requires(objectDTO != null && objectDTO != null);
            consult = objectDTO;
            consultDAO = objectDAO;
        }


        public void addPrescriptionProduct(ProductDTO product)
        {
            Contract.Requires(product != null);
            consult.prescriptionProducts.Add(product);
        }

        public void deletePrescriptionProduct(ProductDTO product)
        {
            Contract.Requires(product != null);
            consult.prescriptionProducts.Remove(product);
        }

        public void addSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
        }

        public void deleteSymptom(string symptom)
        {
            Contract.Requires(symptom != null);
        }

    }
}
