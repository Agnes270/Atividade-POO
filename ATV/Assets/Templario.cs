using UnityEngine;

public class Templario : Personagem
{
    public enum ArmaDoTemplario
    {
        ESCUDO,ESPADA
    }
    public enum ArmaduraDoTemplario
    {
        CAPACETE, CAPA
    }

    [ SerializeField ]
    private ArmaduraDoTemplario armadura;
    [ SerializeField ]
    private ArmaDoTemplario arma;

    public void AtribuirArmadura(ArmaduraDoTemplario armadura)
    {
        this.armadura = armadura;
    }

    public ArmaduraDoTemplario Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(ArmaDoTemplario arma)
    {
        this.arma = arma;
    }

    public ArmaDoTemplario Arma()
    {
        return this.arma;
    }


    public float DanoDoTemplario()
    {
        float dano = 0;

        switch (arma)
        {
            case ArmaDoTemplario.ESCUDO:
                dano = Ataque() + 10;
                break;
            case ArmaDoTemplario.ESPADA:
                dano = Ataque() + 20;
                break;
        }
        
        
        return dano;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
