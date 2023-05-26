using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id), Messages.ColorsListedGetById);
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new Result(true, Messages.ColorAdded);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, Messages.ColorUpdated);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, Messages.ColorDeleted);
        }
    }
}
