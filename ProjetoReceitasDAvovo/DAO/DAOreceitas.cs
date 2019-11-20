using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoReceitasDAvovo.Entidades;
using ReceitasEntidade;


namespace ReceitasDAO
{
    class DAOreceitas
    {
        private List<Ingredientes> receitas;
        private List<Receitas> listaReceitas;
        public DAOreceitas()
        {
            this.receitas = new List<Ingredientes>()
            {
                new Ingredientes
                {
                    NomeDaReceita = "Pão de Queijo",
                    ingredientes = "4 copos (americanos) de polvilho doce (500 g) " +"\n1 colher(sopa) tempero ou sal a gosto"+ "\n2 copos(americano) de leite(300 ml)" + "\n1 copo(americano) de óleo(150 ml)" +
                    "\n2 ovos grandes ou 3 pequenos" + "\n4 copos(americano) de queijo minas meia cura ralado" + "\nóleo para untar",
                    ModoDePreparo = "Coloque sal a gosto numa quantidade de  polvilho e somente umedeça com um pouco de água.\nCuidado para não passar do ponto e a massa ficar líquida, a água é só para umdecer a mistura.\nAqueça uma frigideira e  vá passando a massa em uma peneira até cobrir o fundo.\nVire a tapioca com uma espátula quando a massa ficar sequinha, mas sem queimar de um lado e repita o processo do outro até o ponto desejado, daí é só colocar o recheio do seu gosto ou passar manteiga.",
                    Imagem = "paoDeQueijo.jpg",
                },
                 new Ingredientes
                {
                     NomeDaReceita = "Bolo de Fubá",
                    ingredientes = "4 ovos \n2 xícaras de chá de açúcar \n2 xícaras de chá de trigo \n1 xícara de chá de fubá \n3 colheres de sopa de margarina \n1 xícara de chá de leite \n4 colheres de chá de fermento",
                    ModoDePreparo = "Bater as claras em neve, acrescentar o açúcar, continuar batendo.\nAcrescente aos poucos as gemas, a margarina, o leite, a farinha de trigo, o fubá e continue batendo.\nColoque por último o fermento, bata por mais 1 minuto. Coloque a massa numa forma untada e deixe assar em forno médio pré aquecido por aproximadamente 30 minutos.",
                    Imagem = "boloDeFuba.jpg",
                },
                  new Ingredientes
                {
                    NomeDaReceita = "Canjica",
                    ingredientes = "2 xícaras de canjica \n1 caixinha de leite condensado \n1 xícara de açúcar \n2 xícaras de canjica \n50g de coco ralado",
                    ModoDePreparo = "Um dia antes, coloque a canjica em um pote e deixe de molho por aproximadamente 12h.\nColoque a canjica em uma panela de pressão, e coloque água até que fique três dedos acima da quantidade de canjica."+
               "\nDeixe cozinhar e quando a panela pegar pressão, conte 40 minutos. Transfira a canjica cozida para uma panela e, em fogo médio,  acrescente os outros ingredientes, mexendo até que misture bem e levante fervura, o que pode levar até 30 minutos.\nQuando o caldo estiver mais grosso, está pronto.",
                    Imagem = "canjicaDoce.jpg",
                },
            };
        }
        public List<Ingredientes> Lista()
        {
            return this.receitas;
        }
        public List<Receitas> NovaReceitas(int index)
        {
            List<Receitas> Lista = new List<Receitas>();
            Receitas NovaListaReceita = new Receitas();
            if (index == 1)
            {
                Ingredientes PaoDeQueijo = receitas.Find(x => x.NomeDaReceita.Equals("Pão de Queijo"));
                NovaListaReceita.receita = PaoDeQueijo;
                Lista.Add(NovaListaReceita);
            }
            if (index == 2)
            {
                Ingredientes PaoDeQueijo = receitas.Find(x => x.NomeDaReceita.Equals("Bolo de Fubá"));
                NovaListaReceita.receita = PaoDeQueijo;
                Lista.Add(NovaListaReceita);
            }
            if (index == 3)
            {
                Ingredientes PaoDeQueijo = receitas.Find(x => x.NomeDaReceita.Equals("Canjica"));
                NovaListaReceita.receita = PaoDeQueijo;
                Lista.Add(NovaListaReceita);
            }
            else
            {
                index = 0;
            }
            return Lista;
        }
        public List<Receitas> listaReceita(int index)
        {
            return listaReceitas = NovaReceitas(index);
        }
    }
}
