using InvoicePro.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace InvoicePro.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IBudgetService _budgetService;
        private readonly IInvoiceService _invoiceService;

        public HomeController(
            IClientService clientService,
            IBudgetService budgetService,
            IInvoiceService invoiceService)
        {
            _clientService = clientService;
            _budgetService = budgetService;
            _invoiceService = invoiceService;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity!.IsAuthenticated)
                return View();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var clients = await _clientService.GetClientsAsync(userId);
            var budgets = await _budgetService.GetBudgetsAsync(userId);
            var invoices = await _invoiceService.GetInvoicesAsync(userId);

            ViewBag.TotalClients = clients.Count();
            ViewBag.TotalBudgets = budgets.Count();
            ViewBag.TotalInvoices = invoices.Count();
            ViewBag.PendingInvoices = invoices.Count(i => i.Status == "Pending" || i.Status == "Overdue");
            ViewBag.TotalReceivable = invoices.Where(i => i.Status != "Paid" && i.Status != "Cancelled").Sum(i => i.Total);
            ViewBag.TotalReceived = invoices.Where(i => i.Status == "Paid").Sum(i => i.Total);
            ViewBag.RecentInvoices = invoices.OrderByDescending(i => i.IssueDate).Take(5);
            ViewBag.RecentBudgets = budgets.OrderByDescending(b => b.IssueDate).Take(5);

            return View();
        }
    }
}