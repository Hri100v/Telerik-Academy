using System;

public class SimpleMathExam : Exam
{
    private int problemSolved;
    public int ProblemsSolved 
    {
        get { return this.problemSolved; } 
        private set
        {
            if (value < 0 || 2 < value)
                throw new ArgumentOutOfRangeException("ProblemsSolved" + " must be in the range [0, 2]");

            this.problemSolved = value;
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0:
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            case 1:
                return new ExamResult(4, 2, 6, "Average result: Half done.");
            case 2:
                return new ExamResult(6, 2, 6, "Excellent result: Everything done.");
            default:
                throw new ArgumentOutOfRangeException("ProblemsSolved" + " must be in the range [0, 2]");
        }
    }
}
