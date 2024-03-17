using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_ManjulaRajan
{
    public class Mathoperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

       
        // Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }

        public double Subtract(double a, double b, double c)
        {
            return a - b - c;
        }

        // Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        // Division
        public int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }



        //Write an explanation of method overloading in C#

        //Answetr;Method overloading in C# allows you to define multiple methods with the same name within the same class or in a derived class. These methods have different parameter lists, which means they can accept different types or numbers of parameters. Method overloading enables you to create several methods with the same name but with different behaviors based on the parameters they accept.




        //Describe how method overloading works with different parameter types and counts
        //Answer;Method overloading in C# works by allowing you to define multiple methods with the same name within the same class or in derived classes, but with different parameter types or counts. When you call an overloaded method, the C# compiler determines which method to invoke based on the number and types of arguments passed to it


        //Explain the benefits of using method overloading in a software application.
        //•	It gives us the flexibility to use a different implementation calling the same method name
        //•	When properly implemented, it makes our code maintainable
        //•	It increases the readability of our code
        //•	We can use it on constructors to create new objects given different types of data

        //What is the reason for using method overloading.
        //Answer; Overloading can be used  Where a class can accept multiple methods with the same name, distinguished by the number and type of arguments passed in the method.


        //How different methods with the same name are resolved.
        //Method overloading. In a class, there can be several methods with the same name. However they must have a different signature. The signature of a method is comprised of its name, its parameter types and the order of its parameters.


        //Examples of scenarios where method overloading is beneficial.
        //Answer; a class can Discuss the importance of optimization in method overloading for better performancehave more than one method with the same name, but different parameters. For instance, consider an arithmetic class. This class could have several methods named "add", but these methods perform addition for different types and numbers of parameters.

        //Discuss the role of these overloads in making the code more flexible and maintainable.
        //Answer;Overloaded methods facilitate code maintenance by centralizing related functionalities within a single method name. When changes or updates are required, developers only need to modify the overloaded method(s) rather than locating and updating multiple methods scattered throughout the codebase. This consolidation simplifies maintenance tasks, reduces the likelihood of introducing bugs, and promotes consistency across the codebase.
        //Method overloading allows developers to define multiple versions of a method with different parameter lists. This flexibility enables users of the code to invoke the method with various argument combinations, providing adaptability to different use cases without the need for creating separate methods for each scenario.

        //Optimize the method overloads to handle edge cases or specific data patterns.
        //Answer;Parameter Type Variations, Parameter Count Variations, Default Parameter Values:,Parameter Order VariationsHandling Null Values, Specialized Handling for Edge Cases, 


        //Explain how this optimization improves the usability and reliability of the methods.
        //Answer;Clearer Interface, Reduced Cognitive Load, Improved Discoverability, Reduced Error Prone Code,Explicit Handling of Edge Cases, Improved Robustness, Modular Design, Facilitated Updates and Improved Documentation.


        //Discuss the importance of optimization in method overloading for better performance
        //Answer;optimization in method overloading is crucial for achieving better performance in software systems by reducing overhead, optimizing resource utilization, avoiding redundant computations, minimizing branching and conditional logic, enhancing compiler optimization, optimizing data access patterns, and facilitating performance profiling and tuning. By carefully designing and optimizing overloaded methods, developers can significantly improve the overall performance and efficiency of their software applications.





    }//class



}//namespace,
