namespace PrimePhysique.Contracts;

public class TrainingPlanDto
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = "Push Day";
    public string Description { get; set; } = "Chest, Shoulders, Triceps";
    public List<ExerciseDto> Exercises { get; set; } = new();
}

public class ExerciseDto
{
    public string Name { get; set; } = "";
    public int Sets { get; set; }
    public int Reps { get; set; }
}
