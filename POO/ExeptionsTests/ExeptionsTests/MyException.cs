﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsTests {
  class MyException: Exception {

    public override string ToString() {
      return "Mohamed exception";
    }

  }
}
