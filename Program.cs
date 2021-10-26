using System;

namespace CadAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            
            var indice = 0;
            var opcaoUsuario = "";
            
            while(opcaoUsuario.ToUpper() != "X") {
                Menu();   
                opcaoUsuario = Console.ReadLine().ToUpper();
                switch(opcaoUsuario) {
                    case "1":
                            Aluno aluno = new Aluno();
                            Console.WriteLine("Informe o nome do aluno: ");
                            aluno.Nome = Console.ReadLine();
                            Console.WriteLine("Informe a nota do aluno: ");
                            aluno.Nota = double.Parse(Console.ReadLine());
                            alunos[indice] = aluno;
                            indice++;
                        break;
                    case "2":
                        foreach (var a in alunos) {
                          if (!string.IsNullOrEmpty(a.Nome)) {
                              Console.WriteLine($"Nome: {a.Nome}, Nota: {a.Nota}");
                          }
                        }
                        break;
                    case "3":
                        double notaTotal = 0;
                        var numeroAlunos = 0;

                        for(var i = 0; i < alunos.Length; i++) {
                            notaTotal += alunos[i].Nota;
                            numeroAlunos++;
                        }

                        var mediaGeral = notaTotal / numeroAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral > 0 && mediaGeral < 3) {
                            conceitoGeral = Conceito.E;
                        }

                        else if(mediaGeral >= 3 && mediaGeral < 5) {
                            conceitoGeral = Conceito.D;
                        }

                        else if(mediaGeral >= 5 && mediaGeral < 7) {
                            conceitoGeral = Conceito.C;
                        }

                        else if(mediaGeral >= 7 && mediaGeral < 9) {
                            conceitoGeral = Conceito.B;
                        }

                        else {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Média geral de notas: {mediaGeral}, Conceito: {conceitoGeral}");

                        break;
                    case "X":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
            }
        }

        static void Menu(){
              Console.WriteLine("Informe a opção desejada: ");
              Console.WriteLine("1 - Inserir novo aluno.");
              Console.WriteLine("2 - Listar alunos.");
              Console.WriteLine("3 - Calcular média geral.");
              Console.WriteLine("x - Sair");
              Console.WriteLine("");
        }
    }
}
