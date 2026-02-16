namespace LabPolymorphism;

public class Artifact
{
    private int id;

    public Artifact(int id)
    {
        this.id = id;
    }

    public void Identify()
    {
        Console.WriteLine($"[Artifact ID: {id}] Це невідомий стародавній предмет.");
    }
}