using ConcursDraexlmaier.ViewModels.Commands;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Utils.Enums;

namespace ConcursDraexlmaier.ViewModels.DBOperationViewModel;

public class AccountAddViewModel : NotifyPropertyChangedBase
{
    private readonly AccountDTO accountDTO;
    private readonly bool isToBeUpdated = false;
     
    public AccountAddViewModel()
    {
        this.accountDTO = new AccountDTO();
    }
    
    public AccountAddViewModel(AccountDTO accountDTO, bool isToBeUpdated = false)
    {
        this.accountDTO = accountDTO;
        this.isToBeUpdated = isToBeUpdated;
    }

    public string? Username 
    {
        get
        {
            return this.accountDTO.Username;
        }
        set 
        {
            this.accountDTO.Username = value;
            this.FirePropertyChanged(nameof(Username));
        }
    }

    public string? Password
    {
        get
        {
            return this.accountDTO.Password;
        }
        set
        {
            this.accountDTO.Password = value;
            this.FirePropertyChanged(nameof(Password));
        }
    }

    public string? Nickname
    {
        get
        {
            return this.accountDTO.Nickname;
        }
        set
        {
            this.accountDTO.Nickname = value;
            this.FirePropertyChanged(nameof(Nickname));
        }
    }

    public string? Email
    {
        get
        {
            return this.accountDTO.Email;
        }
        set
        {
            this.accountDTO.Email = value;
            this.FirePropertyChanged(nameof(Email));
        }
    }

    public string? PhoneNumber
    {
        get
        {
            return this.accountDTO.PhoneNumber;
        }
        set
        {
            this.accountDTO.PhoneNumber = value;
            this.FirePropertyChanged(nameof(PhoneNumber));
        }
    }

    public List<string> Roles
    {
        get
        {
            return new List<string>() {"Admin", "Driver"};
        }
    }
    public string Role
    {
        get
        {
            return this.accountDTO.Role.ToString();
        }
        set
        { 
            if(value == "Admin")
            {
                this.accountDTO.Role = Utils.Enums.Role.Admin;
            }
            if(value == "Driver")
            {
                this.accountDTO.Role = Utils.Enums.Role.Driver;
            }
        }
    } 

    public ICommand AddAccount
    {
        get
        {
            if(isToBeUpdated)
            {
                return new UpdateAccountCommand(this.accountDTO);
            }
            return new AddAccountCommand(this.accountDTO);
        }
    } 

    public event PropertyChangedEventHandler? PropertyChanged;
}
