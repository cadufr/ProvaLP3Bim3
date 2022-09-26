using Microsoft.AspNetCore.Mvc;
using ProvaLP3.ViewModels;

namespace ProvaLP3.Controllers;

public class LojaController : Controller
{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>(); 

    public IActionResult Index()
    {
        return View(lojas);
    }

    public IActionResult Gerenciamento()
    {
        return View(lojas);
    }

    public IActionResult Show(int id)
    {
      
        foreach(var loja in lojas)
        {
            if(loja.Id == id)
            {
                return View(loja);
            }
        }

       
        return View(lojas[0]);
    }

    public IActionResult CadastrarLoja()
    {
        return View();
    }

    public IActionResult Adicionar(LojaViewModel viewModel)
    {
        foreach(var loja in lojas)
        {
           
            if(loja.Nome == viewModel.Nome || loja.Id == viewModel.Id)
            {
                return RedirectToAction("Gerenciamento");
            }
        }

        lojas.Add(viewModel);
        return RedirectToAction("Gerenciamento");
    }

    public IActionResult Excluir(int id)
    {
        foreach(var loja in lojas.ToList())
        {
            if(loja.Id == id)
            {
                lojas.Remove(loja);
            }
        }
        return RedirectToAction("Gerenciamento");
    }
}