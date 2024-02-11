namespace DeadAnts.Test
{
    public class DeadAntsTest
    {
        [Fact]
        public void ShouldTestDeadAnts()
        {
            Assert.Equal(0, AntsProgram.CountDeadAnts("ant ant ant ant"));
            Assert.Equal(2, AntsProgram.CountDeadAnts("ant anantt aantnt"));
            Assert.Equal(1, AntsProgram.CountDeadAnts("ant ant .... a nt"));
        }

        [Fact]
        public void ShouldTestIfAntsTrialIsCero()
        {
            Assert.Equal(0, AntsProgram.CountDeadAnts(null));
        }
    }
}