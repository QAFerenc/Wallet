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


            var type = typeof(OnlineWalletService);
            var myMethod = type.GetMethod("GetBalanceAsync");


            Type class1Type = typeof(OnlineWalletService);

            MemberInfo[] members = class1Type.GetMembers();

            MemberInfo[] field = class1Type.GetMember("GetBalanceAsync", BindingFlags.NonPublic | BindingFlags.Instance);
            

         
            var initiatedObject = Activator.CreateInstance<OnlineWalletService>();
            
         
            Console.WriteLine("Hello World !");
            Console.WriteLine(myMethod.Invoke(initiatedObject,null));




        }
    }
    }