# Chamar métodos da Biblioteca de Classes do .NET usando C#

## Conceitos 

- `WriteLine()` é um ***método*** 
- `Console` é uma ***classe***
- `.` ***Operador*** de acesso de membro
- `()` ***Operador*** de chamada do método
    > Exemplo: `Classe.Metodo();`
- ***Argumentos*** são passados dentro dos parênteses do ***operador*** de chamada do método
- Estrutura `nomeClasse.NomeMetodo()`

    ```cs
        Console.WriteLine("argumentos aqui");
    ```

## Métodos com Estados ou *Métodos de Instância*

- Depende de valores armazenados em memória **(estado atual)** ou alteram esses valores a cada linha quando requerido.
    - Valores de variáveis

## Métodos sem Estados ou *Métodos Estáticos*

- Não depende de nenhum valor armazenados em memória **(estado atual)**. São independente.
    - `Console.WriteLine()`

## Criando Instâncias
- Uma única classe pode ter **Métodos de Instâncias** e **Métodos Estáticos**
- **Objeto** é uma **Instância** de uma **classe**
- **Operador** `new` usado para criá-la
- Ao criar uma **Instância** é preciso acessar o **Método** no **Objeto**
- > **IMPORTANTE!** Alguns **Métodos** exigem que seja criada uma **Instância** de uma **classe** enqunato outros não.
- > **Simplificando!** 
    ```cs
    using System;

    namespace Practices
    {
        internal class Program
        {
            private static void Main(string[] args)
            {
                Random dice = new(); // dice é o "Objeto" criado do tipo "Random" criado pelo operador "new"
                int result = dice.Next(); // "result" recebe o endereço de memória armazenado na linha anterior no "Objeto" "dice" e altera ou adciona valores através do "Método" "Next"
                Console.WriteLine(result);
            }
        }
    }

    ```
## Valores retornados
- **Métodos nulos** não retornan valor quando finalizados
## Parâmetros de entrada
- Informação consumida pelo **método**
- **Parâmetros** variáveis usada no método
- **Argumetos** valor transmitido quando o método é chamado
- **Assinatura de método** define a quantidade e o tipo de dados de cada **parâmetro**
## Métodos sobrecarregados
- Permite métodos com ou sem parâmetros
## Maneiras de encontrar informações sobre **classes** e **métodos**
- Pesquise por **C# Random.Next()** por exemplo
    - Sua pesquisa deve incluir o nome da classe e o nome do método
- [Documentação Oficial da biblioteca de classes do .NET](https://learn.microsoft.com) ou [https://learn.microsoft.com](https://learn.microsoft.com)


