namespace LabPolymorphism;

public class MagicScroll : Artifact
{
    public MagicScroll(int id) : base(id)
    {
    }

    public new void Identify()
    {
        Console.WriteLine("[Magic Scroll] Це сувій з закляттям вогню.");
    }
}