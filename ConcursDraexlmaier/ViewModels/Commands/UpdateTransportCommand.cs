using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConcursDraexlmaier.ViewModels.Commands;

public class UpdateTransportCommand : ICommand
{
   
    private readonly TransportDTO TransportDTO;
    private readonly TransportService transportService;
    public event EventHandler? CanExecuteChanged;

    public UpdateTransportCommand(TransportDTO transportDTO)
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
        var test = this.transportService.Update(TransportDTO).Result;
    }
     
}
