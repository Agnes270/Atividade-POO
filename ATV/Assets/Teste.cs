using UnityEngine;
public class Teste : MonoBehaviour
{
    private Templario _templario = new Templario();
    void Start()
    {
GameObject go = new GameObject("Templario");
Templario templario = go.AddComponent<Templario>();

templario.AtribuirNome("Lancelot");
templario.AtribuirSaude(100);
templario.AtribuirDano(15);
templario.Atribuir_Ataque(25);
templario.AtribuirArma(Templario.ArmaDoTemplario.ESPADA);
templario.AtribuirArmadura(Templario.ArmaduraDoTemplario.CAPACETE);
        
Debug.Log("Nome do Templário: " + templario.Nome());
Debug.Log("Saúde: " + templario.Saude());
Debug.Log("Dano Base: " + templario.Dano());
Debug.Log("Ataque Base: " + templario.Ataque());
Debug.Log("Arma equipada: " + templario.Arma());
Debug.Log("Armadura equipada: " + templario.Armadura());
Debug.Log("Dano total calculado: " + templario.DanoDoTemplario());
}
    
public class TestePersonagem : MonoBehaviour
{
void Start()
{
            
GameObject go = new GameObject("Rayla");
Personagem personagem = go.AddComponent<Personagem>();

           
personagem.AtribuirNome("Rayla");
personagem.AtribuirSaude(120);
personagem.AtribuirDano(20);
personagem.Atribuir_Ataque(30);

           
Debug.Log("===== Teste da Personagem Rayla =====");
Debug.Log("Nome: " + personagem.Nome());
Debug.Log("Saúde: " + personagem.Saude());
Debug.Log("Dano: " + personagem.Dano());
Debug.Log("Ataque: " + personagem.Ataque());
}

}

    
    
    
    
    }
