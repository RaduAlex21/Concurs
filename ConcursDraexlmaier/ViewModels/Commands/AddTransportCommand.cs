using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Utils.Enums;

namespace ConcursDraexlmaier.ViewModels.Commands;

public class AddTransportCommand : ICommand
{
    private readonly TransportDTO TransportDTO;
    private readonly TransportService transportService;
    public event EventHandler? CanExecuteChanged;

    public AddTransportCommand(TransportDTO transportDTO)
    {
        this.TransportDTO = TransportDTO;
        this.transportService = new TransportService();
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        /* this.accountService.Insert(accountDTO);*/
        var test = this.transportService.Insert(TransportDTO).Result;
    }
}
