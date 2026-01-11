using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using PrimePhysique.Contracts;

public class TrainingPlanFunction
{
    [FunctionName("training-plan")]
    public IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "training-plan")]
        HttpRequest req)
    {
        var plan = new TrainingPlanDto
        {
            Title = "Upper Body Strength",
            Description = "Chest, Back, Shoulders",
            Exercises =
            {
                new ExerciseDto { Name = "Bench Press", Sets = 4, Reps = 8 },
                new ExerciseDto { Name = "Pull Ups", Sets = 3, Reps = 10 },
                new ExerciseDto { Name = "Shoulder Press", Sets = 3, Reps = 8 }
            }
        };

        return new OkObjectResult(plan);
    }
}
