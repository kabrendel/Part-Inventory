using System.ComponentModel;

namespace C968_Task_1
{
    public class Inventory : Product
    {
        //  Properties
        public BindingList<Product> Products;
        public BindingList<Part> AllParts;
        //  partIndex to operate as a partID incrementer.
        private int partIndex = 0;
        public int PartIndex
        {
            get { return partIndex; }
        }
        //  productIndex to operate as productID incrementer.
        private int productIndex = 0;
        public int ProductIndex
        {
            get { return productIndex; }
        }
        //  Methods from UML:
        //  Part methods:
        public void AddPart(Part part)
        {
            AllParts.Add(part);
            partIndex++;
        }
        public bool DeletePart(Part part)
        {
            //  Remove part and return true or false.
            //  true if removed
            //  false if not removed or not found
            return AllParts.Remove(part);
        }
        public Part LookupPart(int identifier)
        {
            //  Iterate list, return matching Part object where PartId matches identifier
            //  Return null if fail to match.
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == identifier)
                {
                    return AllParts[i];
                }
            }
            return null;
        }
        public void UpdatePart(int identifier, Part part)
        {
            AllParts[identifier] = part;
        }
        //  Product methods from UML:
        public void AddProduct(Product product)
        {
            Products.Add(product);
            productIndex++;
        }
        public bool RemoveProduct(int identifier)
        {
            //  Remove product from Products Bindinglist<Product>
            //  Iterate through Products and match ProductID to identifier
            for (int i = 0; i < Products.Count; i++)
            { 
                if (Products[i].ProductID == identifier)
                {
                    //  Can return true or false.
                    //  True if removed, false if not removed or not found.
                    return Products.Remove(Products[i]);
                }
            }
            return false;   //  Return false if no match found for identifier.
        }
        public Product LookupProduct(int identifier)
        {
            //  Iterate list, return matching Product object where ProductId matches identifier
            //  Return null if fail to match.
            for (var i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == identifier)
                {
                    return Products[i];
                }
            }
            return null;
        }
        public void UpdateProduct(int identifier, Product product)
        {
            Products[identifier] = product;
        }
    }
}