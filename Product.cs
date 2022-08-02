using System.ComponentModel;

namespace C968_Task_1
{
    public class Product : Part
    {
        //  Properties
        public BindingList<Part> AssociatedParts;
        public int ProductID { get; set; }
        //  Properties inherited from abstract class Part
        public override int PartID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override int InStock { get; set; }
        public override int Min { get; set; }
        public override int Max { get; set; }
        //  Methods
        public void AddAssociatedPart(Part part)
        {
            //  Add part object to AssociatedParts bindinglist associated with calling object.
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int identifier)
        {
            //  Remove part from AssociatedParts BindingList<Part>.
            //  Iterate through AssociatedParts and match PartID to identifier.
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == identifier)
                    //  Returns true if found and removed.
                    //  Returns false if not found or not removed.
                    return AssociatedParts.Remove(AssociatedParts[i]);
            }
            return false;
        }
        public Part LookupAssociated(int identifier)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == identifier)
                    return AssociatedParts[i];
            }
            return null;
        }
    }
}
