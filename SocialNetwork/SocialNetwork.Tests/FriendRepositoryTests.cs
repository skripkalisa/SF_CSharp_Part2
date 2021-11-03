using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests
{
     [TestFixture]
    public class FriendRepositoryTests
    {
        [Test]
        public void CreateMustReturnZero()
        {
            var friendEntity0 = new FriendEntity
            {
                id = 0,
                user_id = 0,
                friend_id = 0
            };              
            var friendEntity100 = new FriendEntity
            {
                id = 100,
                user_id = 100,
                friend_id = 100
            };            


            Mock<IFriendRepository> mock = new Mock<IFriendRepository>();
            mock.Setup(v => v.Create(friendEntity0)).Returns(0);
            Assert.Zero(mock.Object.Create(friendEntity0));
            Assert.Zero(mock.Object.Create(friendEntity100));
        }
        [Test]
        public void DeleteMustReturnZero()
        {
            var friendEntity = new FriendEntity
            {
                id = 0,
                user_id = 0,
                friend_id = 0
            };   
            Mock<IFriendRepository> mock = new Mock<IFriendRepository>();
            mock.Setup(v => v.Delete(friendEntity.friend_id)).Returns(0);
            Assert.Zero(mock.Object.Delete(friendEntity.friend_id));
        }

        [Test]
        public void FindAllByUserIdMustReturnEnumerableFriendEntity()
        {
            var list = new List<FriendEntity>
            {
                new()
                {
                    id = 0,
                    user_id = 0,
                    friend_id = 0
                }
            };

            Mock<IFriendRepository> mock = new Mock<IFriendRepository>();
            mock.Setup(v => v.FindAllByUserId(0)).Returns(list);
            Assert.That(mock.Object.FindAllByUserId(0).Any(friend => friend.friend_id == 0));
        }
    }
}