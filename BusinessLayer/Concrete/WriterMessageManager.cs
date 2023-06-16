﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }
        public void TAdd(WriterMessage entity)
        {
            _writerMessageDal.Insert(entity);
        }

        public void TDelete(WriterMessage entity)
        {
            _writerMessageDal.Delete(entity);
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage entity)
        {
            _writerMessageDal.Update(entity);
        }

        public List<WriterMessage> WriterMessageGetByFilter(string mail)
        {
            return _writerMessageDal.GetByFilter(x=>x.Receiver == mail);
        }
    }
}