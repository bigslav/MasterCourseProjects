namespace InheritanceMiniProject.Interfaces;

public interface IRentable
{
    public bool IsRented { get; set; }
    public bool Rent();
    public bool Return();
}
