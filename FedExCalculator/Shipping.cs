namespace FedExCalculator;
public class Shipping
{
  public decimal ComputeCost(decimal weightInPounds)
  {
    if (weightInPounds <= 0) return 0;
    if (weightInPounds <= 5) return 6;
    if (weightInPounds <= 10) return 15;
    return 20;
  }
}
