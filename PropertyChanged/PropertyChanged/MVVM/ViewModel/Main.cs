using PropertyChanged.MVVM.Model;

namespace PropertyChanged.MVVM.ViewModel {
    public class Main : BaseViewModel {

        private int countChanges = 0;
        public int CountChanges { get { return countChanges++; } }

        public Person Person { get; set; }

        private string log;
        public string Log { 
            get { 
                return log; 
            } set { 
                log = value;
                OnPropertyChanged(nameof(Log));
            } 
        }

        public Main () {

            Title = "Main";
            Log = "Not have logs.";
            Person = new Person(GuidId.NextId, "160.170.736-30", "Diego Menezes Soares", new System.DateTime(2002, 03, 26));

            Person.PropertyChanged += (s,e) => {

                var person = s as Person;

                switch(e.PropertyName) {

                    case nameof(Person.CPF):
                        Log = CountChanges + " - Changed CPF to " + person.CPF;
                        break;
                    case nameof(Person.Name):
                        Log = CountChanges + " - Changed Name to " + person.Name;
                        break;
                }            
            };
        }
    }
}
