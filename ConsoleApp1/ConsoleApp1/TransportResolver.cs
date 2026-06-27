namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string input)
    {

        return input.ToLower() switch
        {
            "car" => new Car(),
            "plane" => new Airplane(),
            "boat" => new Boat(),
            "helicopter" => new Helicopter(),
            _ => null
        };
    }
}