using System;

//Edited by: Stephen Britt
//     Date: 3/10/2022

class MathQuestion {
    // private member variables
    private static int m_leftOperand = 0;
    private static int m_rightOperand = 0;
    private static MathOperation m_operation;

    // MathOperation enum
    private enum MathOperation {
        Addition = 0,
        Subtraction = 1,
        Multiplication = 2,
        Modulus = 3
    } // end enum

    private static MathOperation GetOperator() {
        Random rnd = new Random();

        return (MathOperation)rnd.Next(0, 4);
    } // end method

    private static int GetOperand() {
        Random rnd = new Random();

        return rnd.Next(0, 10);
    } // end method

    public static string GetProblem() {
        m_leftOperand = GetOperand();
        m_rightOperand = GetOperand();
        m_operation = GetOperator();

        if (m_operation == MathOperation.Modulus) {
            while (m_rightOperand == 0) {
                m_rightOperand = GetOperand();
            } // end while
        } // end if

        string problemOutputString = "";

        if (m_operation == MathOperation.Addition) {
            problemOutputString += m_leftOperand + " + " + m_rightOperand + " = ";
        } else if (m_operation == MathOperation.Subtraction) {
            problemOutputString += m_leftOperand + " - " + m_rightOperand + " = ";
        } else if (m_operation == MathOperation.Multiplication) {
            problemOutputString += m_leftOperand + " X " + m_rightOperand + " = ";
        } else if (m_operation == MathOperation.Modulus) {
            problemOutputString += m_leftOperand + " % " + m_rightOperand + " = ";
        } // end if
        
        return problemOutputString;        
    } // end method

    public static int GetAnswer() {
        int resultOfOperation = 0;

        if (m_operation == MathOperation.Addition) {
            resultOfOperation = m_leftOperand + m_rightOperand;
        } else if (m_operation == MathOperation.Subtraction) {
            resultOfOperation = m_leftOperand - m_rightOperand;
        } else if (m_operation == MathOperation.Multiplication) {
            resultOfOperation = m_leftOperand * m_rightOperand;
        } else if (m_operation == MathOperation.Modulus) {
            resultOfOperation = m_leftOperand % m_rightOperand;
        } // end if

        return resultOfOperation;
    } // end method
}// end class