
namespace IsEqualToTest
{
    public class IsEqualToTest
    {
        static int testIntIntEqualValue1 = 2;
        static int testIntIntEqualValue2 = 2;

        static int testIntIntUnequalValue1 = 2;
        static int testIntIntUnequalValue2 = -3512;

        static int testIntDoubleEqualValue1 = 65;
        static double testIntDoubleEqualValue2 = 65;

        static int testIntDoubleUnequalValue1 = 65;
        static double testIntDoubleUnequalValue2 = 65.2;

        static object testObjectObjectValue1 = "hi";
        static object testObjectObjectValue2 = -5;

        static float testFloatObjectEqualValue1 = -5;
        static object testFloatObjectEqualValue2 = -5;

        static float testFloatObjectUnequalValue1 = -5;
        static object testFloatObjectUnequalValue2 = "negative five";

        static void Main(string[] args)
        {

            Console.WriteLine($"int and int: {GenericEquality.GetEqualityMessage(
                testIntIntEqualValue1, testIntIntEqualValue2)}");
            Console.WriteLine($"int and int: {GenericEquality.GetEqualityMessage(
                            testIntIntUnequalValue1, testIntIntUnequalValue2)}");

            Console.WriteLine($"int and double: {GenericEquality.GetEqualityMessage(
                testIntDoubleEqualValue1, testIntDoubleEqualValue2)}");
            Console.WriteLine($"int and double: {GenericEquality.GetEqualityMessage(
                testIntDoubleUnequalValue1, testIntDoubleUnequalValue2)}");

            Console.WriteLine($"object and object: {GenericEquality.GetEqualityMessage(
                testObjectObjectValue1, testObjectObjectValue2)}");

            Console.WriteLine($"float and object: {GenericEquality.GetEqualityMessage(
                testFloatObjectEqualValue1, testFloatObjectEqualValue2)}");
            Console.WriteLine($"float and object: {GenericEquality.GetEqualityMessage(
                testFloatObjectUnequalValue1, testFloatObjectUnequalValue2)}");

        }
    }
}
