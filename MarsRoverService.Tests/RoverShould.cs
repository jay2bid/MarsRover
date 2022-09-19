namespace MarsRoverService.Tests;

public class RoverShould
{
    private Rover _rover;
    [SetUp]
    public void Setup()
    {
        _rover = new Rover();
    }

    [Test]
    public void RoverShouldSpinLet()
    {
        Assert.Pass();
    }
}