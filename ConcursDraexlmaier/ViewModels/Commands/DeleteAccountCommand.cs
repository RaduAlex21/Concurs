using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursDraexlmaier.ViewModels.Commands;

public class DeleteAccountCommand
{
    private readonly AccountDTO accountDTO;
    private readonly AccountService accountService;
    public event EventHandler? CanExecuteChanged;

    public DeleteAccountCommand(AccountDTO accountDTO)
    {
        this.accountDTO = accountDTO;
        this.accountService = new AccountService();
    }

    public bool CanExecute(int id)
    {
        return true;
    }

    public void Execute(int id)
    {
        /* this.accountService.Insert(accountDTO);*/
        var test = this.accountService.Delete(id).Result;
    }
}
