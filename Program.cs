﻿using System;
using ZooLab.Classes;

namespace ZooLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat MeshMesh = new Cat()
            {
                PetName = "MeshMesh",
                FavFood = "Fish",
                CanSwim = true
            };
            
            Console.WriteLine(MeshMesh.AnimalName);
            Console.WriteLine(MeshMesh.PetName);
            Console.WriteLine(MeshMesh.Type);
            MeshMesh.Sound();

            Bird Twetty = new Bird();

        }
    }
}
