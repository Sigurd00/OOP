﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Miniproject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu(" fancymenu ");
            menu.Add(
                new MenuItem(
                    " Punkt1 ",
                    " Indhold af punkt 1... det er indtil videre bare tekst "));
            menu.Add(
                new MenuItem(
                    " Punkt2 ",
                    " Indhold af punkt 2... det er indtil videre også bare tekst "));
            menu.Add(
                new MenuItem(
                    " Et lidt længere menupunkt ",
                    " Indhold af punkt 3... det er indtil videre også bare tekst "));
            menu.Start();
        }
    }
}