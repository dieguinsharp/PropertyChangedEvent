using PropertyChanged.MVVM.ViewModel;
using System;

namespace PropertyChanged.MVVM.Model {
    public class Person : BaseViewModel {

        private string cpf;
        private string name;


        public Person (int id, string cpf, string name, DateTime birth) {
            Id = id;
            CPF = cpf;
            Name = name;
            Birth = birth;
        }

        public int Id { get; set; }
        public string CPF { get { return cpf; } set { cpf = value; OnPropertyChanged(nameof(CPF)); } }
        public string Name { get { return name; } set { name = value; OnPropertyChanged(nameof(Name)); } }
        public DateTime Birth { get; set; }

    }
}
