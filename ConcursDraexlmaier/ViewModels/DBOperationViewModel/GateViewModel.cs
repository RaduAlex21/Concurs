using ConcursDraexlmaier.ViewModels.Commands;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConcursDraexlmaier.ViewModels.DBOperationViewModel;

public class GateViewModel
{
   /* private readonly GateDTO gateDTO;
    private readonly bool isToBeUpdated = false;

    public GateViewModel()
    {
        this.gateDTO = new GateDTO();
    } 

    public int IdGate 
    {
        get
        {
            return this.gateDTO.IdGate;
        }
        set
        {
            this.gateDTO.IdGate = value;
            this.FirePropertyChanged(nameof(IdGate));
        }
    }

    public int Id_Location
    {
        get
        {
            return this.gateDTO.Id_Location;
        }
        set
        {
            this.gateDTO.Id_Location = value;
            this.FirePropertyChanged(nameof(Id_Location));
        }
    }

    public List<string> StatusGate
    {
        get
        {
            return new List<string>() { "Open", "Ocupaid" };
        }
    }
    public string Status
    {
        get
        {
            return this.gateDTO.Status.ToString();
        }
        set
        {
            if (value == "Open")
            {
                this.gateDTO.Status = Utils.Enums.GateStatus.Open;
            }
            if (value == "Ocupaid")
            {
                this.gateDTO.Status = Utils.Enums.GateStatus.Ocupaid;
            }
        }
    }

    public string? Available_Time
    {
        get
        {
            return this.gateDTO.Available_Time;
        }
        set
        {
            this.gateDTO.Available_Time = value;
            this.FirePropertyChanged(nameof(Available_Time));
        }
    }

    public string? TimeOfUnpacking
    {
        get
        {
            return this.gateDTO.TimeOfUnpacking;
        }
        set
        {
            this.gateDTO.TimeOfUnpacking = value;
            this.FirePropertyChanged(nameof(TimeOfUnpacking));
        }
    }


    *//* public ICommand AddAccount
     {
         get
         {
             if (isToBeUpdated)
             {
                 return new UpdateAccountCommand(this.accountDTO);
             }
             return new AddAccountCommand(this.accountDTO);
         }
     }
 *//*
    public event PropertyChangedEventHandler? PropertyChanged;*/
}
