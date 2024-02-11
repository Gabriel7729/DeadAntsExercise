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
        if (string.IsNullOrEmpty(antsTrial))
            return 0;

        string replaceAnts = antsTrial.Replace("ant", string.Empty);

        int aCount = replaceAnts.Count(x => x == 'a');
        int nCount = replaceAnts.Count(x => x == 'n');
        int tCount = replaceAnts.Count(x => x == 't');

        return Math.Max(aCount, Math.Max(nCount, tCount));
    }
}