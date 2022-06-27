using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyChanged.MVVM.Model {
    public static class GuidId {

        private static int nextId = 1;
        public static int NextId {
            get {
                return nextId++;
            }
        }
    }
}
