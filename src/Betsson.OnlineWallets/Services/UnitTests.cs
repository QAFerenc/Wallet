using NUnit.Framework;
using Betsson.OnlineWallets.Services;
using Betsson.OnlineWallets.Models;
using RestSharp;
using Betsson.OnlineWallets.Data.Repositories;
using System;
using System.Reflection;


namespace Betsson.OnlineWallets.Tests
{
    public class UnitTests
    {
        
        OnlineWalletService? service;
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {


 Type class1Type = typeof(OnlineWalletService);

            MemberInfo[] members = class1Type.GetMembers();

            MemberInfo[] field = class1Type.GetMember("GetBalanceAsync", BindingFlags.NonPublic | BindingFlags.Instance);
            

         
         
         
            var initiatedObject = Activator.CreateInstance(class1Type);
             








/*

Type class1Type = typeof(OnlineWalletService);

            MemberInfo[] members = class1Type.GetMembers();

            MemberInfo[] field = class1Type.GetMember("GetBalanceAsync", BindingFlags.NonPublic | BindingFlags.Instance);
            

         
         
         
            var initiatedObject = (OnlineWalletService)Activator.CreateInstance(class1Type);
  */           
            Console.WriteLine("Hello World !");
          //  Console.WriteLine(myMethod.Invoke(initiatedObject,null));
    /*        Type class1Type = typeof(OnlineWalletService);
            var type = Type.GetType("Task<Balance>");


            MemberInfo[] members = class1Type.GetMembers();

            MemberInfo[] field = class1Type.GetMember("GetBalanceAsync", BindingFlags.NonPublic | BindingFlags.Instance);
            //var myMethod = class1Type.GetMethod("GetBalanceAsync");
            var myMethod = type.GetMethod("MyMethod");
            Console.WriteLine(myMethod);

      */      
            //var result = MemberInfo.Invoke(classInstance, parametersArray);

            //Betsson.OnlineWallets.Services
            

            
            //Console.WriteLine(balance);



            //  Console.WriteLine( await service.GetBalanceAsync());

            //Assert.Pass();
        }
    }
}