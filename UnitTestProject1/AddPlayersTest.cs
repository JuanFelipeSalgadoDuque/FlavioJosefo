using System;
using System.Collections.Generic;
using FlavioJosefo.Controllers;
using FlavioJosefo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AddPlayersTest
    {
        [TestMethod]
        //MethodName_Parameters_ReturnSuccesOrError
        public void ArrayString_Empty_Returns_Null()
        {

            //init
            string[] emptyPlayers = new string[0];
            Game game = new Game();
            //act
            
            var result = game.AddPlayersAtCircle(emptyPlayers);
            
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void OKArray_Returns_LinkedListPlayers()
        {
            //init
            string[] players = new string[] { "pedro", "Juan", "Carlos", "Pepito" };
            Game game = new Game();
            //act

            var result = game.AddPlayersAtCircle(players);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(LinkedList<Player>));

        }

        [TestMethod]
        //MethodName_Parameters_ReturnSuccesOrError
        public void Invalid_List_and_Id_Returns_Null()
        {

            //init
            int id = 0;
            LinkedList<Player> players = new LinkedList<Player>();
            Game game = new Game();

            //act

            var result = game.PlayGame(players, id);

            //Assert
            Assert.IsNull(result);

        }

        [TestMethod]
        //MethodName_Parameters_ReturnSuccesOrError
        public void OKLinkedList_and_OKId_Returns_Player()
        {

            //init
            string[] list = new string[] { "pedro", "Juan", "Carlos", "Pepito" };
            Game game = new Game();
            LinkedList<Player> players = game.AddPlayersAtCircle(list);
            int id = 3;

            //act
            var result = game.PlayGame(players, id);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Player));

        }


    }
}
