using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _meesageDal;

        public MessageManager(IMessageDal meesageDal)
        {
            _meesageDal = meesageDal;
        }

        public Message GetByID(int id)
        {
            return _meesageDal.Get(x => x.MessageID == id);
          
        }

        public List<Message> GetList()
        {
      return  _meesageDal.List(x => x.ReceiverMail == "admin@gmial.com");
        }

        public void MessageAdd(Message message)
        {
           _meesageDal.Add(message);
        }

        public void MessageDelete(Message message)
        {
            _meesageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _meesageDal.Update(message);
        }
    }
}
