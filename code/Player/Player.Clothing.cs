using Sandbox;
using System;
using System.Linq;

namespace PCT 
{
	public class ClothingEntity : ModelEntity 
	{
	}

	partial class PCTPlayer 
	{
		ModelEntity pants;
		ModelEntity jacket;
		ModelEntity shirt;
		ModelEntity shoes;
		ModelEntity hair;
		ModelEntity eyebrows;
		// ModelEntity hat;

		bool dressed = false;

		public void Dress() 
		{
			if (dressed) return;

			dressed = true;

			pants = new ClothingEntity();
			pants.SetModel("models/citizen_clothes/jacket/longsleeve/models/jeans.vmdl");
			pants.SetParent(this, true);
			SetBodyGroup(2, 1);

			jacket = new ClothingEntity();
			jacket.SetModel("models/citizen_clothes/jacket/brown_leather_jacket/models/brown_leather_jacket.vmdl");
			jacket.SetParent(this, true);

			shirt = new ClothingEntity();
			shirt.SetModel("models/citizen_clothes/shirt/flannel_shirt/models/flannel_shirt.vmdl");
			shirt.SetParent(this, true);

			shoes = new ClothingEntity();
			shoes.SetModel("models/citizen_clothes/shoes/sneakers/models/sneakers.vmdl");
			shoes.SetParent(this, true);
			SetBodyGroup(4, 1);	

			hair = new ClothingEntity();
			hair.SetModel("models/citizen_clothes/hair/hair_looseblonde/hair_looseblonde.vmdl");
			hair.SetParent(this, true);

			eyebrows = new ClothingEntity();
			eyebrows.SetModel("models/citizen_clothes/hair/eyebrows/models/eyebrows.vmdl");
			eyebrows.SetParent(this, true);

			// hat = new ClothingEntity();
		}
	}
}
