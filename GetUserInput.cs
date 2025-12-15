public class GetUserInput {

    public int GetIntInput(string prompt) {
        int value;
        while (true) {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value > 0) {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    public double GetDoubleInput(string prompt) {
        double value;
        while (true) {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value > 0) {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    public (int, int) GetItemRangeInput(string promptMin, string promptMax) {
        int minItems, maxItems;
        while (true) {
            minItems = GetIntInput(promptMin);
            maxItems = GetIntInput(promptMax);
            if (minItems <= maxItems) {
                return (minItems, maxItems);
            }
            Console.WriteLine("Invalid range. Minimum items must be less than or equal to maximum items.");
        }
    }
}