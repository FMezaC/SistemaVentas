using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FuntionalLayer
{
    public class TiketFuntion
    {
        // agregar linear de ticket
        StringBuilder Linea = new StringBuilder();

        // Variable que almacena
        int maxCar = 40, cortar;

        // metodo para crear leieas en guion
        public string LienasGuion()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";
            }
            return Linea.AppendLine(lineasGuion).ToString();
        }

        // metodo para crear linear en asterico
        public string LineasAsterisco()
        {
            string LienaAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                LienaAsterisco += "*";
            }
            return Linea.AppendLine(LienaAsterisco).ToString();
        }

        //Encabezado de tiket's
        public void EncabezadoVenta()
        {
            Linea.AppendLine("PRODUCTO             CANT.  PREC.  IMPT.");
        }

        // metodo para poner texto a la izquierda
        public void Textoizquierda(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterAct = 0;
                for (int LongituTexto = texto.Length; LongituTexto < maxCar; --maxCar)
                {
                    Linea.AppendLine(texto.Substring(caracterAct, maxCar));
                    caracterAct += maxCar;
                }
                Linea.AppendLine(texto.Substring(caracterAct, texto.Length - caracterAct));
            }
            else
            {
                Linea.AppendLine(texto);
            }
        }

        // metodo para poner texto a la derecha
        public void TextoDerecha(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterAct = 0;
                for (int LongituTexto = texto.Length; LongituTexto < maxCar; --maxCar)
                {
                    Linea.AppendLine(texto.Substring(caracterAct, maxCar));
                    caracterAct += maxCar;
                }
                Linea.AppendLine(texto.Substring(caracterAct, texto.Length - caracterAct));

                string espacios = "";
                for (int i = 0; i < (maxCar - texto.Substring(caracterAct, texto.Length - caracterAct).Length); i++)
                {
                    espacios += " ";
                }
                Linea.AppendLine(espacios + texto.Substring(caracterAct, texto.Length - caracterAct));
            }
            else
            {
                string espacios = "";
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";
                }
                Linea.AppendLine(texto);
            }
        }

        // metodo para definir el centro de los extremos
        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterAct = 0;
                for (int LongituTexto = texto.Length; LongituTexto < maxCar; --maxCar)
                {
                    Linea.AppendLine(texto.Substring(caracterAct, maxCar));
                    caracterAct += maxCar;
                }
                Linea.AppendLine(texto.Substring(caracterAct, texto.Length - caracterAct));

                string espacios = "";
                int centrar = (maxCar - texto.Substring(caracterAct, texto.Length - caracterAct).Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }
                Linea.AppendLine(espacios + texto.Substring(caracterAct, texto.Length - caracterAct));
            }
            else
            {
                string espacios = "";
                int centrar = (maxCar - texto.Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }
                Linea.AppendLine(espacios + texto);
            }
        }

        // metodo para agregar exto extremo
        public void textoExtremo(string textoIzquierda, string textoDerecho)
        {
            string textIzq, textDere, textCompleto = "", espacios = "";
            if (textoIzquierda.Length > 18)
            {
                cortar = textoIzquierda.Length - 18;
                textIzq = textoIzquierda.Remove(18, cortar);
            }
            else
            {
                textIzq = textoIzquierda;
            }
            textCompleto = textIzq;
            if (textoDerecho.Length > 20)
            {
                cortar = textoDerecho.Length - 20;
                textDere = textoDerecho.Remove(20, cortar);
            }
            else
            {
                textDere = textoDerecho;
            }


            int nroespacio = maxCar - (textIzq.Length + textDere.Length);
            for (int i = 0; i < nroespacio; i++)
            {
                espacios += " ";
            }
            textCompleto += espacios + textDere;
            Linea.AppendLine(textCompleto);
        }

        // metodo para agregar subtotales
        public void Agregartotales(string texto, decimal total)
        {
            string resumen, Valor, TextoCompleto, espacios = "";
            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            {
                resumen = texto;
            }
            TextoCompleto = resumen;
            Valor = total.ToString("#,#.00");

            int nrEspacio = maxCar - (resumen.Length + Valor.Length);
            for (int i = 0; i < nrEspacio; i++)
            {
                espacios += " ";
            }
            TextoCompleto += espacios + Valor;
            Linea.AppendLine(TextoCompleto);
        }

        // metodo para agregar articulo
        public void AgregarArticulo(string articulo, int cantidad, decimal precio, decimal Importe)
        {
            //string resumen, Valor, TextoCompleto, espacios = "";
            if (cantidad.ToString().Length <= 5 && precio.ToString().Length <= 7 && Importe.ToString().Length <= 8)
            {
                string elemento = "", espacio = "";
                Boolean bandera = false;
                int norEspacio = 0;
                if (articulo.Length > 20)
                {
                    norEspacio = (4 - cantidad.ToString().Length);
                    espacio = " ";
                    for (int i = 0; i < norEspacio; i++)
                    {
                        espacio += " ";
                    }
                    elemento += espacio + cantidad.ToString(); // bandera

                    norEspacio = (6 - precio.ToString().Length);
                    espacio = " ";

                    for (int i = 0; i < norEspacio; i++)
                    {
                        espacio += " ";
                    }
                    elemento += espacio + precio.ToString();

                    norEspacio = (8 - Importe.ToString().Length);
                    espacio = "";
                    for (int i = 0; i < norEspacio; i++)
                    {
                        espacio += " ";
                    }
                    elemento += espacio + Importe.ToString();

                    int CaracterActual = 0;
                    for (int longituTexto = articulo.Length; longituTexto > 20; longituTexto -= 20)
                    {
                        if (bandera == false)
                        {
                            Linea.AppendLine(articulo.Substring(CaracterActual, 20) + elemento);
                            bandera = true;
                        }
                        else
                        {
                            Linea.AppendLine(articulo.Substring(CaracterActual, 20));
                            CaracterActual += 20;
                        }
                    }
                    // Imprimir Detalle Completo
                    //Linea.AppendLine(articulo.Substring(CaracterActual, articulo.Length - CaracterActual));
                }
                else
                {
                    for (int i = 0; i < 20 - articulo.Length; i++)
                    {
                        espacio += " ";
                    }
                    elemento = articulo + espacio;

                    norEspacio = (5 - cantidad.ToString().Length);
                    espacio = "";
                    for (int i = 0; i < norEspacio; i++)
                    {
                        espacio += " ";
                    }
                    elemento += espacio + cantidad.ToString();

                    norEspacio = (7 - cantidad.ToString().Length);
                    espacio = "";
                    for (int i = 0; i < norEspacio; i++)
                    {
                        espacio += " ";
                    }
                    elemento += espacio + precio.ToString();

                    norEspacio = (8 - Importe.ToString().Length);
                    espacio = "";
                    for (int i = 0; i < norEspacio; i++)
                    {
                        espacio += " ";
                    }
                    elemento += espacio + Importe.ToString();
                    Linea.AppendLine(elemento);
                }
            }
            else
            {
                Linea.AppendLine("Los valores ingresados para esta fila");
                Linea.AppendLine("Superan las columnas soportadas por este");
                throw new Exception("los valores Ingresados para algunos ticket's\nSuperan las Columnas");
            }
        }


        public void cortarTicket()
        {
            Linea.AppendLine("\x18" + "m");
            Linea.AppendLine("\x18" + "d" + "\x09");
        }

        public void AbreCajon()
        {
            Linea.AppendLine("\x18" + "p" + "\x00" + "\x0F" + "\x96");
        }

        public void imprimirTicket(string Impresora)
        {
            RawPrinterHelper.SendStringToPrinter(Impresora, Linea.ToString());
            Linea.Clear();
        }

    }




    // Clase mandar a imprimri a la Impresora

    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de venta ";
            // Win7
            di.pDataType = "RAW";

            // Win8+
            // di.pDataType = "XPS_PASS";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            fs.Close();
            fs.Dispose();
            fs = null;
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
