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

public class TransportAddViewModel : NotifyPropertyChangedBase
{
    private readonly TransportDTO transportDTO;

    public TransportAddViewModel()
    {
        this.transportDTO = new TransportDTO();
    }

    public int Id_Account
    {
        get
        {
            return this.transportDTO.Id_Account;
        }
        set
        {
            this.transportDTO.Id_Account = value;
            this.FirePropertyChanged(nameof(Id_Account));
        }
    }

    public int Id_Location
    {
        get
        {
            return this.transportDTO.Id_Location;
        }
        set
        {
            this.transportDTO.Id_Location = value;
            this.FirePropertyChanged(nameof(Id_Location));
        }
    }

    public string? StartLocation
    {
        get
        {
            return this.transportDTO.StartLocation;
        }
        set
        {
            this.transportDTO.StartLocation = value;
            this.FirePropertyChanged(nameof(StartLocation));
        }
    }

    public string? Amount
    {
        get
        {
            return this.transportDTO.Amount;
        }
        set
        {
            this.transportDTO.Amount = value;
            this.FirePropertyChanged(nameof(Amount));
        }
    }

    public string? DispatchDate
    {
        get
        {
            return this.transportDTO.DispatchDate;
        }
        set
        {
            this.transportDTO.DispatchDate = value;
            this.FirePropertyChanged(nameof(DispatchDate));
        }
    }

    public string? DeliveryDate
    {
        get
        {
            return this.transportDTO.DeliveryDate;
        }
        set
        {
            this.transportDTO.DeliveryDate = value;
            this.FirePropertyChanged(nameof(DeliveryDate));
        }
    }

    public string? EstimateDelivery
    {
        get
        {
            return this.transportDTO.EstimateDelivery;
        }
        set
        {
            this.transportDTO.EstimateDelivery = value;
            this.FirePropertyChanged(nameof(EstimateDelivery));
        }
    }
  
    public List<string> TransportStatus
    {
        get
        {
            return new List<string>() { "Delivered", "InTransit", "New" };
        }
    }
    public string Status
    {
        get
        {
            return this.transportDTO.Status.ToString();
        }
        set
        {
            if (value == "Delivered")
            {
                this.transportDTO.Status = Utils.Enums.TransportStatus.Delivered;
            }
            if (value == "InTransit")
            {
                this.transportDTO.Status = Utils.Enums.TransportStatus.InTransit;
            }
            if (value == "New")
            {
                this.transportDTO.Status = Utils.Enums.TransportStatus.New;
            }
        }
    }

    public ICommand AddTransport
    {
        get
        {
            return new AddTransportCommand(this.transportDTO);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
