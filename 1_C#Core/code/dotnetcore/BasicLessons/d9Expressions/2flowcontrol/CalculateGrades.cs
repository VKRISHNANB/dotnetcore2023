using System;
/**
 * Maps points of a written exam to  grades
 * (1.0 (best), 1.3, 1.7, 2.0, ..., 4.0, 4.7, 5.0).  
 * 
 * @author pape
 */
public class CalculateGrades {

    /**
     * Prints for all points from 0 to 120 in steps of 0.5
     * all corresponding grades.
     */
    public static void main(String[] args) {
        for (double points = 0.0; points < 120.0; points += 0.5) {
            Console.WriteLine(points + " -> " + CalculateGrades.getGrade(points));
        }
    }

    /**
     * Returns the grade for the given points.
     */
    public static double getGrade(double points) {
        double grade = 5.0;
       
        if (50.0 >= points && points < 59.9) {
            grade = 4.7;
        } else if (60.0 >= points && points < 64.9) {
            grade = 4.0;
        } else if (65.0 >= points && points < 69.9) {
            grade = 3.7;
        } else if (70.0 >= points && points < 75.9) {
            grade = 3.3;
        } else if (75.0 >= points && points < 79.9) {
            grade = 3.0;
        } else if (80 >= points && points < 84.9) {
            grade = 2.7;
        } else if (85 >= points && points < 89.9) {
            grade = 2.3;
        } else if (90 >= points && points < 94.9) {
            grade = 2.0;
        } else if (95 >= points && points < 99.9) {
            grade = 1.7;
        } else if (100 >= points && points < 104.9) {
            grade = 1.3;
        } else if (105 >= points && points < 120.4) {
            grade = 1.0;
        }
        
        
        return grade;
    }
}
