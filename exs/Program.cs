﻿/*
 * Created by SharpDevelop.
 * User: home
 * Date: 04/01/2019
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using exs.classes;
using mthds;
namespace exs
{
	class Program
	{
		public static void Main(string[] args)
		{
			pessoa p = new pessoa{
			nome="pokemon",
			};
			
			pessoa p1 = new pessoa();
			p1.Nome="Brunna pedroza";
			produto pr = new produto();
			pr.Nome="shampoo";
			pr.Tipo="cosmetico";
			
			
			
			Console.WriteLine("Welcome to world map "+p1.Nome);
			email.Inst.De="alan@gmail.com";
			email.Inst.SendEmail();
			Console.WriteLine(email.Inst.VerifyingIns());
			float x=233f;
		Console.WriteLine(string.Format("%2f",x));
			
				UserControl1 mt = new UserControl1();			
			mt.ass();
		Console.WriteLine(email.Inst);
			email.Inst.SendEmail();
			//Console.WriteLine("Welcome to world map "+p1.GetType());
			//Console.WriteLine("Welcome to world map "+typeof(pessoa));
			//Console.WriteLine("vc esta comprando "+pr.Nome+" do tipo:"+pr.Tipo);
			//p1.gravar();
			//p.gravar();
			//pr.gravar();
			Console.ReadKey(true);
		}
		
		
	}//fim classe
}//fim namespace