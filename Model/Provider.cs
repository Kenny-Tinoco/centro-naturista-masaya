using System.Collections.Generic;

namespace CentroNaturistaMasaya.Model
{
    internal class Provider
    {
        private int idProvider;
        private string name;
        private string address;
        private string RUC;
        private List<string> telephones;
        private List<Supply> supplyRecord;
    }
}