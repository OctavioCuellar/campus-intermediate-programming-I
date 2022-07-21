using System;

namespace campus_intermediate_programming_I
{
    public abstract class Pair
    {
        public abstract string Key { get; set; }
        public abstract dynamic Value { get; set; }

        public class AddPair : Pair
        {
            public AddPair(string key, dynamic value)
            {
                Key = key;
                Value = value;
            }

            public override string Key { get; set; }
            public override dynamic Value { get; set; }
        }

	}
}
