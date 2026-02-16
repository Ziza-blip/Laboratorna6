namespace LabPolymorphism;

public class AncientSword : Artifact
{
    public AncientSword(int id) : base(id)
    {
    }

    public new void Identify()
    {
        Console.WriteLine("[Ancient Sword] Це заіржавілий меч короля.");
    }
}