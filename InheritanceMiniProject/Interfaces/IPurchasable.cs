namespace InheritanceMiniProject.Interfaces;

public interface IPurchasable
{
    public bool IsPurchased { get; set; }
    public void Purchase();
}