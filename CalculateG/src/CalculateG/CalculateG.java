package CalculateG;
public class CalculateG {
    public static double multiply(double x, double y){
        //method for multiplication
        return x * y;

    }
    public static double summation(double x, double y){
        // add 2 more methods for powering to square and summation (similar to multiplication)
        return x + y;
    }

    public static double poweringtosqure(double x){
        // add 2 more methods for powering to square and summation (similar to multiplication)
        return Math.pow(x,2);
    }
    public static void outline(String message, double result){
        // method for printing out a result
        System.out.println(message + result);
    }

    public static void main(String[] args){
        // compute the position and velocity of an object with defined methods and print out the result
        double gravity =-9.81; // Earth's gravity in m/s^2
        double fallingTime = 30;
        double initialVelocity = 0.0;
        double initialPosition = 0.0;
        //double finalVelocity = ?;
        //double finalPosition = ?;
        // Add the formulas for position and velocity

        double finalPosition = summation(multiply(0.5, gravity), multiply(poweringtosqure(fallingTime),gravity));
        finalPosition = summation(multiply(initialVelocity, fallingTime),summation(initialPosition, finalPosition));
        String positionMessage = "The object's final position: " + fallingTime + "second is: ";
        outline(positionMessage, finalPosition);

// Add output line for velocity (similar to position)
        double finalVelocity = multiply(gravity, fallingTime) + initialVelocity;
        String velocityMessage = "The object's final velocity: " + fallingTime + "second is: ";
        outline(velocityMessage, finalVelocity);

    }
}