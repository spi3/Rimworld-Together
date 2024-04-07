﻿using System;
using System.Collections.Generic;

namespace Shared
{
    [Serializable]
    public class PlayerFactionData
    {
        public string manifestMode;

        public string manifestDetails;

        public List<string> manifestComplexDetails = new List<string>();

        public List<string> manifestSecondaryComplexDetails = new List<string>();
    }
}
