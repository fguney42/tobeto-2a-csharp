using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class FuelBusinessRules
    {
        private readonly IFuelDal _fuelDal;

        public FuelBusinessRules(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        public void CheckIfFuelNameNotExists(string fuelName)
        {
            bool isExists = false;
            var fuelList = _fuelDal.GetList();
            foreach (var fuel in fuelList)
            {
                if (fuel.Name == fuelName)
                {
                    throw new Exception("Fuel Already Exists");
                }
            }
        }
        public void IsNullOrWhiteSpace(string transmissionName)
        {
            foreach (var transmissionDalString in _fuelDal.GetList())
            {
                if (string.IsNullOrWhiteSpace(transmissionDalString.ToString()))
                {
                    throw new Exception("String is Null or string have whitespace character");
                }
            }
        }


    }
}