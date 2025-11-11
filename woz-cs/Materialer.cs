class Materialer
{
    int træ;
    int metal;
    int mad;

    public Materialer()
    {
        træ = 0;
        metal = 0;
        mad = 0;
    }
    public int GetTræ()
    {
        return træ;
    }
    public int GetMetal()
    {
        return metal;
    }
    public int GetMad()
    {
        return mad;
    }
    public void AddTræ(int found_træ)
    {
        træ = træ + found_træ;
    }
    public void AddMetal(int found_metal)
    {
        metal = metal + found_metal;
    }
    public void AddMad(int found_mad)
    {
        mad = mad + found_mad;
    }
    public void RemoveTræ(int used_træ)
    {
        træ = træ - used_træ;
    }
    public void RemoveMetal(int used_metal)
    {
        metal = metal - used_metal;
    }
    public void RemoveMad(int used_mad)
    {
        mad = mad - used_mad;
    }
}
