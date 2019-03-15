using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace App2_TarefaNew.Modelos
{
    public class GerenciadorTarefa
    {
        private List<Tarefa> Lista { get; set; }
        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem(); // carrega a lista para nao ficar nula
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);

        }

        public void Remover(int index)
        {
            Lista = Listagem(); // carrega a lista para nao ficar nula
            Lista.RemoveAt(index);
            SalvarNoProperties(Lista);
        }

        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista = Listagem(); // carrega a lista para nao ficar nula
            Lista.RemoveAt(index);

            tarefa.DataFinalizacao = DateTime.Now;
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);

        }
       
        public List<Tarefa> Listagem()
        {
            return ListagemProperties();
        }

        private void SalvarNoProperties(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
                App.Current.Properties.Remove("Tarefas");


            string JsonVal = JsonConvert.SerializeObject(Lista);
            App.Current.Properties.Add("Tarefas", JsonVal );
        }

        private List<Tarefa> ListagemProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                String JsonVal = (String)App.Current.Properties["Tarefas"];
                List<Tarefa> lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);
               
                return lista;
                //return (List<Tarefa>)App.Current.Properties["Tarefas"];
            }
            else return new List<Tarefa>();
        }

    }
}
