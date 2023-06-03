using System;
using System.Globalization;

namespace Arquivo{
    class Program{
        static void Main(){
            TesteHeranca[] TH = new TesteHeranca[20];
            int op, i = 0;

            do{
                menu();
                op = Convert.ToInt16(Console.ReadLine());
                switch(op){
                    case 1:
                        if(i > 0){
                            Console.Write($"Informe o numero do paciente que deseja ver [1-{i}]");
                            int pos = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine(TH[pos-1]);
                        }else{
                            Console.WriteLine("Não há pessoas cadastradas!");
                        }
                        break;
                    case 2:
                        if(i<20){

                            Console.Write("Informe o nome do usuario: ");
                            string nome = Console.ReadLine();
                            Console.Write("Informe a idade do usuario: ");
                            int idade = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Informe o email do usuario: ");
                            string email = Console.ReadLine();
                            Console.Write("Informe o cpf do usuario: ");
                            string cpf = Console.ReadLine();
                            TesteHeranca pessoa = new TesteHeranca(nome, idade, email, cpf);
                            TH[i] = pessoa;
                            i++;
                        }else{
                            Console.Write("Numero de pessoas cadastradas atingiu o limite!");
                        }
                        break;
                    case 3:
                        for(int j = 0; j < i; j++){
                            Console.WriteLine("--------------Dados pessoais--------------");
                            Console.WriteLine(TH[j]);
                            Console.WriteLine("\n------------------------------------------");
                        }
                        break;
                    case 4:
                            Console.WriteLine("Vai se foder");
                        break;
                }
            }while(op != 4);


        }

        static void menu(){
            Console.WriteLine("1- Mostrar informações\n2- Inserir informações\n3- Mostrar todas as pessoas cadastradas\n4- Sair");
        }
    }

    class Classe1{
        public string Nome;
        public int Idade;
        
        public Classe1(){
            this.Nome = "Não informado";
        }

        public Classe1(string Nome, int idade){
            this.Nome = Nome;
            this.Idade = idade;
        }

        public void setNome(string Nome){
            this.Nome = Nome;
        }

        public void setIdade(int Idade){
            this.Idade = Idade;
        }
    }

    class TesteHeranca:Classe1{

        private double _saldo;
        public string Email;
        public string Cpf;

        public TesteHeranca(){
            _saldo = 0;
            Email = "Não informado";
            Cpf = "Não informado";
        }


        public TesteHeranca(string Email, string Cpf) : this(){
            _saldo = 0;
            this.Email = Email;
            this.Cpf = Cpf;
        }

        public TesteHeranca(string nome, int idade, string Email, string Cpf) : this(){
            _saldo = 0;
            this.Email = Email;
            this.Cpf = Cpf;
            this.Idade = idade;
            this.Nome = nome;
        }

        public void adicionarSaldo(double valor){
            this._saldo += valor;
        }

        public void setEmail(string email){
            this.Email = email;
        }

        public void setCpf(string cpf){
            this.Cpf = cpf;
        }

        public override string ToString(){
            return $"Nome: {Nome};\nIdade: {Idade};\nEmail: {Email};\nCPF: {Cpf}";
        }
    }
}