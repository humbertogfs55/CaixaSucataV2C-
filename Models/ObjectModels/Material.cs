namespace CaixaSucata.Models.ObjectModels
{
    public class Material
    {
        public Material()
        {
            
        }
        public int Id { get; set; }
        public int Ind { get; set; }
        public string Name { get; set; }
        public decimal Stock { get; set; }
        public decimal StandartPrice { get; set; }
        public decimal ModifiedPrice1 { get; set; }
        public decimal ModifiedPrice2 { get; set; }

        public string DisplayStandart 
        {
            get { return Name + ": R$ " + StandartPrice.ToString("0.00"); }
        }
        public string DisplayMod1
        {
            get { return Name + ": R$ " + ModifiedPrice1.ToString("0.00"); }
        }
        public string DisplayMod2
        {
            get { return Name + ": R$ " + ModifiedPrice2.ToString("0.00"); }
        }
        public string DisplayConfiguration
        {
            get { return Ind + " " + Name + ": R$ " + StandartPrice.ToString("0.00") + " | " + ModifiedPrice1.ToString("0.00") + " | " + ModifiedPrice2.ToString("0.00"); }
        }
        public string DisplayStock
        {
            get { return Name + "  KG " + Stock.ToString("0.00"); }
        }

        #region overiden methods
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Material otherMaterial = (Material)obj;
            return Ind == otherMaterial.Ind;
        }

        public override int GetHashCode()
        {
            return Ind.GetHashCode();
        }
        #endregion
    }
}
