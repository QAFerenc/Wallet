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
        public void Get_Balance()
        {

            // use Reflexion
             
            //idea 1. : idea 2. seems to be better below
            
            /*var type = typeof(OnlineWalletService);
            var myMethod = type.GetMethod("GetBalanceAsync");


            Type class1Type = typeof(OnlineWalletService);

            MemberInfo[] members = class1Type.GetMembers();

            MemberInfo[] field = class1Type.GetMember("GetBalanceAsync", BindingFlags.NonPublic | BindingFlags.Instance);           
            */

            //idea 2.
            
            // following command fails, as the class does not have constructor with zero parameter         
            var initiatedObject = Activator.CreateInstance<OnlineWalletService>();
            
            Console.WriteLine(myMethod.Invoke(initiatedObject,null));




        }
    }
    }