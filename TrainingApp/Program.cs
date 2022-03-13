// See https://aka.ms/new-console-template for more information

using TrainingApp.Training;

Exercise benchpress = new Exercise("Bench Press", 80, 7, 3, true);
Exercise inclinebenchpress = new Exercise("Incline Bench Press", 50, 10, 3, true);
Exercise dbflyes = new Exercise("DB Flyes", 20, 10, 3, false);
Exercise mchestpress = new Exercise("Machine Chest Press", 50, 12, 3, true);
Exercise cableflyes = new Exercise("Cable Flyes", 20, 15, 3, false);


List<Exercise> Monday = new List<Exercise>();
Monday.Add(benchpress);
Monday.Add(inclinebenchpress);
Monday.Add(dbflyes);
Monday.Add(mchestpress);
Monday.Add(cableflyes);

foreach (var exercise in Monday)
{
    exercise.CalNextReps();
    exercise.CalNextWeight();
    exercise.DisplayNextExerciseDetails();
}

Console.ReadLine();
