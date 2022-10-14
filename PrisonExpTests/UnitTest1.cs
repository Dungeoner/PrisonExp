namespace PrisonExpTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetFilledCollectionNoDuplicatesTest()
        {
            var arrayBuilder = new ArrayBuilder();
            var actual = arrayBuilder.GetFilledCollection(100, 100);
            var containsDuplicates = actual.Any(x => actual.Count(c => c == x) > 1);
            Assert.False(containsDuplicates);
        }
    }
}