using System;
namespace excepciones
{
	public class ZeroException: System.Exception
	{
		private int numero;
		
		public ZeroException (string message, int numero): base(message){
			this.numero = numero;
		}
		
		public String mensajeDeLaExcepcion(){
			return "El numero especificado es menor a 1 y es el número " + this.numero;
		}
	}
}

