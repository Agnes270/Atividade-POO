using UnityEngine;
public class Teste : MonoBehaviour
{
    private Templario _templario = new Templario();
    
    private Personagem = new Personagem();
    
    void Start()
    {
        _templario.AtribuirNome("lencelot");
        _templario.AtribuirDano(20);
        _templario.AtribuirSaude(100);
        _templario.AtribuirAtaque(10);
        Debug.Log("O "+ templario.NomeDoPersonagem (lencelot) +" da "+ templario.DanoDoTemplario(20) + " tem " + templario.SaudeDoTemplario(100)+
                  " tem "+templario.Ataque(10));
        
        Personagem.AtribuirNome("Rayla");
        Personagem.AtribuirDano(15);
        Personagem.AtribuirSaude(80);
        Personagem.AtribuirAtaque(8);
        Debug.Log("O "+ personagem.NomeDoCarro(Rayla));

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o carro " + gol.NomeDoCarro());
        }

        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumero_de_rodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("Caminhão do Falstão");
        
        //fusca.AtribuirTipoDeCarroceria("Larga");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o " + caminhao.NomeDoCarro());
        }

        
        //============================================
        
        joao.AtribuirNome("João Roberto II");
        joao.AtribuirEnergia(10);
        joao.AtribuirForca_Ataque(12);
        joao.AtribuirForca_do_pulo(6);
        joao.AtribuirVelocidade(8);
        joao.AtribuitNumero_de_pes(2);
        joao.AtribuitNumero_de_maos(2);
        
        ork.AtribuirNome("Ork Gob");
        ork.AtribuirEnergia(23);
        ork.AtribuirForca_Ataque(15);
        ork.AtribuirForca_do_pulo(8);
        ork.AtribuirVelocidade(6);
        ork.AtribuitNumero_de_pes(2);
        ork.AtribuitNumero_de_maos(4);
        ork.AtribuirArma(Inimigo.ArmaDoInimigo.MACHADO);
        ork.AtribuirArmadura(Inimigo.ArmaduraDoInimigo.COURO);

        if (ork.DanoDoInimigo() >= joao.Energia())
        {
            Debug.Log("O " + joao.Nome() + " ficou sem energia");
        }
        else
        {
            Debug.Log("O " + joao.Nome() + " aonda tem "+ joao.Energia() + "energia");
        }

    }
    void Update()
    {
        
    }
}