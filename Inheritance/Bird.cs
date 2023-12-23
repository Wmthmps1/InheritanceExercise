using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		public bool CanTalk { get; set; }
		public bool CanFly { get; set; }
		public string TypeOfBird { get; set; }
		public bool HasNest { get; set; }
		public string TalkString {
			get
			{
				if (CanTalk == true)
				{
					return "can talk";
				} else
				{
					return "can't talk";
				}
			}
			set
			{
			}
		}
        public string FlyString
        {
            get
            {
                if (CanFly == true)
                {
                    return "can fly";
                }
                else
                {
                    return "can't fly";
                }
            }

            set
            {
            }
        }
        public string NestString
        {
            get
            {
                if (HasNest == true)
                {
                    return "has a nest";
                }
                else
                {
                    return "doesn't have a nest";
                }
            }

            set
            {
            }
        }

    }
}

// Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class