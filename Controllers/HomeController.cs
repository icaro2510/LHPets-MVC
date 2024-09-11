using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Miguel Gomes Salazar", "857.030.950-41", "miguelsalazar@gmail.com", "Wailler" );
        Cliente cliente2 = new Cliente(02, "William Henry Gates IV", "039.730.250-10", "willgtt@apple.com", "Sharp");
        Cliente cliente3 = new Cliente(03, "Daniel Ghost", "230.543.210-00", "ghosthacker@security.com", "Estói");
        Cliente cliente4 = new Cliente(04, "Alba Hanna Shevchenko", "800.777.920-50", "hannahsck@ibm.com", "Byron");
        Cliente cliente5 = new Cliente(05, "Mariah Sophi Rodrigues", "911.702.988-00", "sophi.mariah23@oracle.com", "Rot");

        //lista de clientes e atribuiu os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        //instancias do tipo fornecedor e atribuiu os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "SAVANA PET S/A", "14.185.102/001-80", "savana2002@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Avast Pets", "15.836.698/0001-57", "avastpets@avast.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "JCM Pet Shop ", "11.300.410/0001-58", "jcmps@sac.atendimento.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Cia do Pet Ltda", "87.945.350/0001-09", "companhiapet@ciapt.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Ctrl Alt Dog", "18.760.614/0001-37", "ctrl@alt.dog.br");

        //lista de fornecedor
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
