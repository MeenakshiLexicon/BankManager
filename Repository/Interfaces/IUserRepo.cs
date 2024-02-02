﻿using System.Security.Claims;
using System.Transactions;
using WebApplication_Inlamning_P_3.Models.Entities;
using static WebApplication_Inlamning_P_3.Models.Entities.Users;

namespace WebApplication_Inlamning_P_3.Repository.Interfaces
{
    public interface IUserRepo
    {
        List<Users> GetAllUser();
        Account AddUser(Users user, Customer customer, Account account);
        Task<Users> GetUserByUsernameAndPassword(string username, string password);
        List <UserAccount> GetUserDetails(string username);
        List <AccountTransactions> GetTransactionsOfUser(string username, int accountId);
        Account CreateUserAccounts(string username,string accountType, string frequency, decimal balance);
        string TransferMoney(string username, int sourceAccountId, int destinationAccountId,  decimal amount,  string symbol, string bank);


    }
}
