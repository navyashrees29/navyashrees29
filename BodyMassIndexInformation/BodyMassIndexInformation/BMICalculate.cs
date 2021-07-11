using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class BMICalculate
    {
        private float height;
        private float weight;
        private float bmiValue;

        public BMICalculate(float height, float weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public float BmiCalculation()
        {
            return this.bmiValue = this.weight / this.height;
        }

    }
}
