using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConcursDraexlmaier.ViewModels.Commands;

public class UpdateAccountCommand : ICommand
{
    private readonly AccountDTO accountDTO;
    private readonly AccountService accountService;
    public event EventHandler? CanExecuteChanged;

    public UpdateAccountCommand(AccountDTO accountDTO)
    {
        this.accountDTO = accountDTO;
        this.accountService = new AccountService();
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        /* this.accountService.Insert(accountDTO);*/
        var test = this.accountService.Update(accountDTO).Result;
    }
}
