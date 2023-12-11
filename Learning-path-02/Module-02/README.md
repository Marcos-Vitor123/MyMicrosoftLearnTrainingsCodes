# Chamar métodos da Biblioteca de Classes do .NET usando C#

## Conceitos 

- `WriteLine()` é um ***método*** 
- `Console` é uma ***classe***
- `.` ***Operador*** de acesso de membro
- `()` ***Operador*** de chamada do método
- ***Argumentos*** são passados dentro dos parênteses do ***operador*** de chamada do método

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
- > **IMPORTANTE!** Alguns **Métodos** exigem que seja criada uma **Instância** de uma **classe** enqunato outros não

