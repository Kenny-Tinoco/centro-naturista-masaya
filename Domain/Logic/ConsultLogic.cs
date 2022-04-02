using DataAccess.DAO.DAOInterfaces;
using DataAccess.Model.DTO;
using System.Diagnostics.Contracts;

namespace Domain.Logic
{
    public class ConsultLogic
    {
        private ConsultDTO consult;
        private ConsultDAO<ConsultDTO> consultDAO;
        

        public ConsultLogic(ConsultDTO objectDTO, ConsultDAO<ConsultDTO> objectDAO )
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
