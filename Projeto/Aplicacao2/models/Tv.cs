class Tv
{
    public int Channel;

    public Tv(int channel)
    {
        Channel = channel;
    }

    public override string ToString()
    {
        return $"Tv on channel {Channel}";
    }
}