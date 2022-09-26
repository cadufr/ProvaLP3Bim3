namespace ProvaLP3.ViewModels;

public class LojaViewModel
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Andar { get; set; }
    public string? Descricao { get; set; }
    public string? LojaDoCadu { get; set; }
    public string? Email { get; set; }

    public LojaViewModel(int id, string nome, string andar, string descricao, string lojaCadu, string email)
    {
        Id = id;
        Nome = nome;
        Andar = andar;
        Descricao = descricao;
        LojaDoCadu = lojaCadu;
        Email = email;
    }

    public LojaViewModel()
    {
        
    }

}