using System;
/**
 * Implements a simple calculator with a recursive descendant parser.
 * The synax of the expression in EBNF is:
 * <pre>
 * expression = term, [ "+" | "-" , term ] ;
 * term = "(",  term, ")" | "0" | "1" | ... | "9" ;
 * </pre>
 * 
 * @author pape
 *
 */
public class Calculator {

    private char[] expression;

    private char currentCharacter;
    
    private int indexOfCurrentCharacter = 0;
    
    /**
     * Creates a new Calculator with the given expression.
     */
    public Calculator(String expression) {
        this.expression = expression.ToCharArray();
        readNextCharacter();
    }
    
    /**
     * Reads in the next character to be parsed.
     * If no character exists anymore, then the 0 is used
     * as the next character.
     * White spaces are ignored.
     */
    private void readNextCharacter() {
        while ( indexOfCurrentCharacter < expression.Length
                && Char.IsWhiteSpace(expression[indexOfCurrentCharacter]) ) {
            indexOfCurrentCharacter++;
        }
        
        if ( indexOfCurrentCharacter < expression.Length) {
            currentCharacter = expression[indexOfCurrentCharacter++];
        } else {
            currentCharacter =(char) 0;
        }
    }
    
    /**
     * Returns the value of the expression.
     */
    public int evaluateExpression() {
        int valueOfExpression = evaluiereTerm();
        
        while ( currentCharacter == '+' || currentCharacter == '-') {
            char operators = currentCharacter;
            readNextCharacter();
            int term = evaluiereTerm();
            switch (operators) {
            case '+': valueOfExpression += term;
                      break;
            case '-': valueOfExpression -= term;
                      break;
            }
        }
         
        return valueOfExpression;
    }

    /**
     * Reads in a term, evalutes it and returns the result.
     */
    private int evaluiereTerm() {
        int resultOfTerm = 0;
        
        if (currentCharacter == '(') {
            readNextCharacter();
            resultOfTerm = evaluateExpression();
            if (currentCharacter != ')') {
                Console.WriteLine("Closing parenthesis expected");
            } else {
                readNextCharacter();
            }
        } else if ( Char.IsDigit(currentCharacter)) {
            resultOfTerm = currentCharacter - '0';
            readNextCharacter();
        }
        
        return resultOfTerm;
    }
}
