using System;
//using Agenda.NomeCompleto;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean menu = true;
            //String nome;
            //String sobrenome;
            String ano;
            String mes;
            String dia;
            String niverString = $"{ano}/{mes}/{dia}";
            Contato[] agenda = new Contato[100];        //criando a agenda com espaço para 100 contatos
            
            do          //Menu
            {
                Console.WriteLine("O que você deseja fazre? Escolha a opção no Menu:");
                Console.WriteLine("Menu: " +
                    "1. Inserir novo contato: " +
                    "2. Buscar contato pelo primeiro nome: " +
                    "3. Buscar por nome completo: " +
                    "4. Buscar pelo tipo de contato: " +
                    "5. Buscar pela cidade: " +
                    "6. Remover contato");
                String numberS = Console.ReadLine();
                int number = Int32.Parse(numberS);
                switch(number)
                {
                    case 1:

                        break;
                    case 2:
                        Console.WriteLine(NomeCompleto.getNome);
                        break;

                }
            } while (menu);
        }

        public struct NomeCompleto
        {
            public String nome;
            public String sobrenome;
            public NomeCompleto(String nome, String sobrenome)
            {
                this.nome = nome;
                this.sobrenome = sobrenome;
            }
            public static String getNome { get; }
            public static String getSobrenome { get; }
            public override string ToString() => $"{nome} {sobrenome}";
        }

        public enum Tipo
        {
            Celular,
            Trabalho,
            Casa,
            Principal,
            Pager,
            Fax_Trabalho,
            Fax_Casa
        }

        public struct Telefone
        {
            public int ddd;
            public int telefone;
            public Telefone(int ddd, int tel)
            {
                this.ddd = ddd;
                this.telefone = tel;
            }
            public static int getDdd { get; }
            public static int getTel { get; }

            public override string ToString() => $"({ddd}) {telefone}";
        }

        public struct Email
        {
            public String email;
            public Email(String email)
            {
                this.email = email;
            }
            public static String getEmail { get; }

            public override string ToString() => $"{email}";
        }

        public struct Endereco
        {
            public String rua;
            public String bairro;
            public String cidade;
            public String estado;
            public Endereco(String rua, String bairro, String cidade, String estado)
            {
                this.rua = rua;
                this.bairro = bairro;
                this.cidade = cidade;
                this.estado = estado;
            }
            public static String getBairro { get; }
            public static String getCidade { get; }
            public static String getEstado { get; }
            public static String getRua { get; }
            public override string ToString() => $"Endereço: {rua}. {bairro}, {cidade}-{estado}";
        }

        public struct Aniversario
        {
            public Aniversario(String data)
            {
                DateTime date1 = DateTime.Parse(data, System.Globalization.CultureInfo.InvariantCulture);
            }
            public static String getData { get; }
        }
        public struct Contato
        {
            public NomeCompleto nome;
            public Aniversario aniversario;
            public Tipo tipo;
            public Telefone telefone;
            public Email email;
            public Endereco endereco;
            public String? observacoes;
            public Contato(NomeCompleto nome, Aniversario aniversario, Tipo tipo, Telefone telefone, Email email, Endereco endereco){
                this.nome = nome;
                this.aniversario = aniversario;
                this.tipo = tipo;
                this.telefone = telefone;
                this.email = email;
                this.endereco = endereco;
                this.observacoes = null;
            }
            /*public override string ToString()
            {
                contatoString = Console.WriteLine(nome);
            }*/
            public static void removeContato()
            {
                //NomeCompleto = default;
            }
        }
    }
    }
}
    