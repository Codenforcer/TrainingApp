// See https://aka.ms/new-console-template for more information


namespace TrainingApp.Training
{
    public class Exercise : IExerciseBase
    {
        private string exerciseName;
        private int weightUsed;
        private int repsDone;
        private int setsDone;
        private bool isCompound;

        private int nextWeight;
        private int nextReps;

        #region
        public string ExerciseName { get { return exerciseName; } set { exerciseName = value; } }
        public int WeightUsed { get { return weightUsed; } set { weightUsed = value; } }
        public int RepsDone { get { return repsDone; } set { repsDone = value; } }
        public int SetsDone { get { return setsDone; } set { setsDone = value; } }
        public int NextWeight { get { return nextWeight; } set { nextWeight = value; } }
        public int NextReps { get { return nextReps; } set { nextReps = value; } }
        public bool IsCompound { get { return isCompound; } set { isCompound = value; } }

        #endregion

        public Exercise(string exerc, int weightuse, int repcount, int setscount, bool iscompound)
        {
            this.exerciseName = exerc;
            this.weightUsed = weightuse;
            this.repsDone = repcount;
            this.setsDone = setscount;
            this.isCompound = iscompound;
        }

        // Method to workout how many reps user should do next time.
        public int CalNextReps()
        {
            if (RepsDone >= 10)
                NextReps = 6;
            else if (RepsDone == 8)
                NextReps = 10;
            else
                NextReps = RepsDone += 2;

            return NextReps;

        }

        // Method to determine what weight user should use for next time base on lift(compound) and reps done.
        public int CalNextWeight()
        {
            if (RepsDone >= 10)
            {
                if (IsCompound == true)
                {
                    NextWeight = WeightUsed + 10;
                }
                else
                {
                    NextWeight = WeightUsed + 5;
                }

            }
            else
            {
                NextWeight = WeightUsed;
            }

            return NextWeight;
        }

        // Display details what user should be doing for next exercise.
        public void DisplayNextExerciseDetails()
        {
            Console.WriteLine($"{ExerciseName}: \nSets: {SetsDone} \nReps: {NextReps} \nWeight: {NextWeight}Kg");
        }

    }
}
