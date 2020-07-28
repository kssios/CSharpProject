using System.Collections.Generic;

namespace Hoplon.Collections
{
    // <summary>
    // O proposito desta interface é definir uma API para abstrair os detalhes técnicos de uma 
    // colecao para adicionar, remover e procurar um elemento, 
    // </summary>
    public interface IHoplonCollection
    {
        // <summary>
        // Adiciona um elemento na respectiva coleção representada pela chave. 
        // </summary>
        // <param name="key">a chave que mapeia o item</param>
        // <param name="value"></param>
        // <returns>Retorna true se o elemento foi adicionado, caso o elemento está presente 
        // na lista retorna false e autaliza a posição de acordo com a ordem 
        // crescente</returns>
        bool Add(string key, string value);

        // <summary>
        // Retorna uma lista com os valores que a chave esta armazenando de acordo com os
        // limites de inicio e fim. 
        // A lista retornada esta ordenada em ordem crescente.
        // O parâmetro start e end são indices no formato zero-base, onde o primeiro elemento
        // é representado pelo indice 0, o segundo elemento com 
        // indice 1 e assim por diante.
        // O parâmetro start e end representam um range inclusivo, ou seja, se for requisitado
        // start=1 e end=3, será retornado uma lista com três 
        // elementos, com o segundo elemento, terceiro e quarto elemento da coleção
        // solicitada.
        // O parâmetro end pode ter valores negativos, neste caso ele funciona como um offset
        // considerando o útimo elemento. Exemplo: 
        //    "-1" significa que o filtro deve retornar até o último elemento. Se o start é "0" e o
        // end é "-1" significa q todos os elementos do chave serão retornados.
        //    "-2" significa que o filtro deve retornar até o penúltimo elemento.
        // Caso o parâmetro start seja menor que zero, deve ser considerado como se fosse o
        // primeiro elemento.
        // Caso o parâmetro end seja maior que o numero de elementos, deve ser considerado
        // como se fosse o último elemento.
        // </summary>
        // <param name="key"></param>
        // <param name="start"></param>
        // <param name="end"></param>
        // <returns></returns>
        IList<string> Get(string key, int start, int end);

        // <summary>
        // Remove a chave com seus respectivos valores da coleção.
        // </summary>
        // <param name="key"></param>
        // <returns>Retorna true se a chave foi removida, false caso a chave nao 
        // exista</returns>
        bool Remove(string key);


        // <summary>
        // Retorna o indice que o elemento (value) esta posicionado.
        // Este indice inicia com 0 e vai até tamanho da respectiva coleção considerando a
        // chave.
        // </summary>
        // <param name="key"></param>
        // <param name="value"></param>
        // <returns>Retorna -1 se a chave ou valor não existem</returns>
        long IndexOf(string key, string value);
    }
}


