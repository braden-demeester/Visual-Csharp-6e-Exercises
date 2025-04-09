namespace IsEqualToTest
{
    public class GenericEquality
    {
        public static bool IsEqualTo<T>(T first, T second)
        {
            return first?.Equals(second) ?? false;
        }

        public static string GetEqualityMessage<T>(T first, T second)
        {
            return $"{first} is {(IsEqualTo(first, second) ? "" : "not ")}equal to {second}";
        }
    }
}
