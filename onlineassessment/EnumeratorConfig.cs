﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringEnumerator.Tests
{


    // Your implementation of CustomStringEnumerator should take into account all the properties of EnumeratorConfig
    public class EnumeratorConfig
    {
        // Specifies the minimal length of strings that should be returned by a custom enumerator.
        // If it is set to negative value then this option is ignored.
        public int MinLength { get; set; } = -1;

        // Specifies the maximum length of strings that should be returned by a custom enumerator.
        // If it is set to negative value then this option is ignored.
        public int MaxLength { get; set; } = -1;

        // Specifies that only strings that start with a capital letter should be returned by a custom enumerator.
        // Please note that empty or null strings do not meet this condition.
        public bool StartWithCapitalLetter { get; set; }

        // Specifies that only strings that start with a digit should be returned by a custom enumerator.
        // Please note that empty or null strings do not meet this condition.
        public bool StartWithDigit { get; set; }
    }
}
