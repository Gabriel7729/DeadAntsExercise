public static class AntsProgram
{
    public static void Main(string[] args)
    {
        string antsTrial = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

        int deadAnts = CountDeadAnts(antsTrial);
        Console.WriteLine("Dead ants: " + deadAnts);
    }

    public static int CountDeadAnts(string? antsTrial)
    {
        //Validate if the ants is null or empty
        if (string.IsNullOrEmpty(antsTrial))
            return 0;

        //Replace the ants alive
        string replaceAnts = antsTrial.Replace("ant", string.Empty);

        //Count all the ants that are dead
        int aCount = replaceAnts.Count(x => x == 'a');
        int nCount = replaceAnts.Count(x => x == 'n');
        int tCount = replaceAnts.Count(x => x == 't');

        //Calculate the amount of dead ants
        return Math.Max(aCount, Math.Max(nCount, tCount));
    }
}