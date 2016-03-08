//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Studying
//{
//    public class ConveyorAnimalBox
//    {
//        public Animal SelectAnimalRandomly(ConveyorBelt conveyorbelt)
//        {
//            ArrayList box = new ArrayList();

//            foreach (var animal in conveyorbelt)
//            {
//                box.Add(animal);
//            }

//            Random r = new Random();
//            int randomAnimal = r.Next(box.Length());

//            return box[randomAnimal];

//        }
//    }
//}
