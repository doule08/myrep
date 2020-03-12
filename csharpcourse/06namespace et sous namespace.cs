	// vim: syntax=php

using namespace ConsoleApp1.Models; 	//inclue le dossier Models compris dans le même projet

//principe de masquage de Class => selectionne l'objet le plus "proche"

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Models.Blop p = new Models.Blop();		//crée un objet de type Blop venant du namespace ConsoleApp1.Models
      