﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {

        IColorDal _colorDal;

        public ColorManager(IColorDal color)
        {
            _colorDal = color;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Yeni renk eklendi");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk silindi.");
        }

        public List<Color> GetAll()
        {
            
            return _colorDal.GetAll();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk güncellendi");
        }
    }
}