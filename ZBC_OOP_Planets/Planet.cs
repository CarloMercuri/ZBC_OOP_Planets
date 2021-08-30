using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_OOP_Planets
{
    public class Planet
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private float _mass;

        public float Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        private int _diameter;

        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        private int _density;

        public int Density
        {
            get { return _density; }
            set { _density = value; }
        }

        private float _gravity;

        public float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }

        private float _rotationPeriod;

        public float RotationPeriod
        {
            get { return _rotationPeriod; }
            set { _rotationPeriod = value; }
        }

        private float _lenghtOfDay;

        public float LenghtOfDay
        {
            get { return _lenghtOfDay; }
            set { _lenghtOfDay = value; }
        }

        private float _distanceFromSun;

        public float DistanceFromSun
        {
            get { return _distanceFromSun; }
            set { _distanceFromSun = value; }
        }

        private float _orbitalPeriod;

        public float OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            set { _orbitalPeriod = value; }
        }

        private float _orbitalVelocity;

        public float OrbitalVelocity
        {
            get { return _orbitalVelocity; }
            set { _orbitalVelocity = value; }
        }

        private int _meanTemperature;

        public int MeanTemperature
        {
            get { return _meanTemperature; }
            set { _meanTemperature = value; }
        }

        private int _numberOfMoons;

        public int NumberOfMoons
        {
            get { return _numberOfMoons; }
            set { _numberOfMoons = value; }
        }

        private bool _hasRingSystem;

        public bool HasRingSystem
        {
            get { return _hasRingSystem; }
            set { _hasRingSystem = value; }
        }

        public Planet(string _name, float _mass, int _diameter, int _density, float _gravity, float _rotationPeriod, float _lenghtOfDay, float _distanceFromSun, float _orbitalPeriod, float _orbitalVelocity, int _meanTemperature, int _numberOfMoons, bool _hasRingSystem)
        {
            Name = _name;
            Mass = _mass;
            Diameter = _diameter;
            Density = _density;
            Gravity = _gravity;
            RotationPeriod = _rotationPeriod;
            LenghtOfDay = _lenghtOfDay;
            DistanceFromSun = _distanceFromSun;
            OrbitalPeriod = _orbitalPeriod;
            OrbitalVelocity = _orbitalVelocity;
            MeanTemperature = _meanTemperature;
            NumberOfMoons = _numberOfMoons;
            HasRingSystem = _hasRingSystem;
        }

       
    }
}
