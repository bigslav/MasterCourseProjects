namespace InheritanceMiniProject.Interfaces;

public interface IRentable
{
    public bool IsRented { get; set; }
    public void Rent();
    public void Return();
}
