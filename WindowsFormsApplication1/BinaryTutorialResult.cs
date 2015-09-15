namespace BinaryTutorial
{
    public class BinaryTutorialResult
    {
        private int value = 0;

        internal void subtract(int value)
        {
            this.value -= value;
        }

        internal void add(int value)
        {
            this.value += value;
        }

        internal string toString()
        {
            return "" + value;
        }

        internal void clear()
        {
            value = 0;
        }
    }


}
