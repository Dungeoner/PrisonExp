using PrisonExp;

internal class Program
{
    static void Main(string[] args)
    {
        var boxQuantity = 100;
        var attemptsAmount = 50;
        var randomStrategy = new RandomStrategy();
        var smartStrategy = new SmartStrategy();
        var randomStrategySuccessCouner = 0;
        var smartStrategySuccessCouner = 0;
        for (int i = 0; i < 100000; i++)
        {
            var newExperiment = new Experiment(new ArrayFiller(), boxQuantity);
            var randomStrategyResult = newExperiment.DoExperiment(attemptsAmount, randomStrategy);
            if (randomStrategyResult)
            {
                randomStrategySuccessCouner++;
            }
            var smartStrategyResult = newExperiment.DoExperiment(attemptsAmount, smartStrategy);
            if (smartStrategyResult)
            {
                smartStrategySuccessCouner++;
            }
        }
    }
    private static bool CheckBoxes(int[] boxes)
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            if (boxes.Count(x => x == i + 1) < 1)
            {
                return false;
            }
        }
        return true;
    }
}