using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.DTO;
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
