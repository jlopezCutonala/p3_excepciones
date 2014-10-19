using System;

namespace excepciones
{
	class Principal
	{
		public void lanzaExcepcion(){
			try{
				int numero = -45 ;
				if(numero < 1){
					throw new ZeroException("El numero es 0.", numero);
				}
			}catch(ZeroException ex ){
				Console.WriteLine(ex.mensajeDeLaExcepcion());
			}
		}
		
		public int ejemploSinManejoDeExcepcion(){
			int numero1 = 10;
			int numero2 = 0;
			Console.WriteLine("Sin manejo de excepciones.");
			return (numero1 / numero2);
		}
		
		public int ejemploConManejoDeExcepcion(int numero1, int numero2){
			try
		    {
				Console.WriteLine("Con manejo de excepciones.");
				return (numero1 / numero2);
		    }
		    catch (System.DivideByZeroException dbz)
		    {
		        System.Console.WriteLine("Se intento una división entre 0." + dbz.Message);
		        return 0;
		    }
			finally
			{
				Console.WriteLine("Entro al bloque finally.");
			}
		}
		
		public static void Main (string[] args)
		{
			Principal programa = new Principal();
			//programa.ejemploConManejoDeExcepcion(10,0);
			//Console.WriteLine();
			//programa.ejemploConManejoDeExcepcion(100,10);
			//Console.WriteLine();
			//programa.ejemploSinManejoDeExcepcion();
			//Console.WriteLine();
			programa.lanzaExcepcion();
		}
	}
}

