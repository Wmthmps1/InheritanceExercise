using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public string TypeOfReptile { get; set; }
		public bool MovesOnBelly { get; set; }
		public bool CanCamoflauge { get; set; }
		public bool LivesInWater { get; set; }

        public string MovesOnBellyString
        {
            get
            {
                if (MovesOnBelly == true)
                {
                    return "does move on its belly";
                }
                else
                {
                    return "walks";
                }
            }

            set
            {
            }
        }

        public string CamoflaugeString
        {
            get
            {
                if (CanCamoflauge == true)
                {
                    return "can camoflauge";
                }
                else
                {
                    return "cannot camoflauge";
                }
            }

            set
            {
            }
        }

        public string LivesInWaterString
        {
            get
            {
                if (LivesInWater == true)
                {
                    return "lives in water";
                }
                else
                {
                    return "does not live in water";
                }
            }

            set
            {
            }
        }

    }
}
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
