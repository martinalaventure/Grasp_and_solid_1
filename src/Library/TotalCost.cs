namespace Full_GRASP_And_SOLID.Library
{
    public class TotalCost
    {
        public double GetProductionCost(Recipe recipe)
        {
            double totalingredientcost = 0;
            double totalequipmentcost = 0;
            foreach (Step step in recipe.steps)
            {
                totalingredientcost += step.Input.UnitCost * step.Quantity;
                totalequipmentcost += step.Time/60.0 * step.Equipment.HourlyCost;
            }
            double totalCost = totalingredientcost+totalequipmentcost;
            return totalCost;
        }

    }
}