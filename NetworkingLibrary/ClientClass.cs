using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

//demonstrates sockets

namespace NetworkingLibrary
{

    public class ClientClass
    {
        //these variables are public static because they will be accessed outside of the class in the windows forms.
        public static string location;
        public static string serverResponse;
        public static string serverResponseText;

        public static void ExecuteClient(string[] args)
        {

            if (args.Length > 0)
            {
                //default values are set here
                string server = "whois.net.dcs.hull.ac.uk";
                int port = 43;
                int timeOut = 1000;
                string protocol = "-w"; //protocol are either: whois = w, http0.9 = h9, http1.0 = h0, http1.1 = h1
                bool debug = false;

                List<string> argsList = args.ToList(); //turns creates a list for arguments, this is so values can easily be removed without leaving empty indexes.

                //This for loop goes through the arguments list, to determine if any default program values should be changed.
                //It also removes the flags and their relevent data if they are contained in the list. The flag data is always after the flag specifier.
                //The end result is only the name and/or location.
                int i = 0;
                while (i < argsList.Count)
                {
                    switch (argsList[i])
                    {
                        case "-h":
                            server = argsList[i + 1];
                            argsList.RemoveAt(i);                    //basicly removes the flag and values shift down.
                            argsList.RemoveAt(i);                   //removes the address..
                            break;
                        case "-p":
                            port = int.Parse(argsList[i + 1]);
                            argsList.RemoveAt(i);
                            argsList.RemoveAt(i);
                            break;
                        case "-t":
                            timeOut = int.Parse(argsList[i + 1]);
                            argsList.RemoveAt(i);
                            argsList.RemoveAt(i);
                            break;
                        case "-h9":
                            protocol = "-h9";
                            argsList.RemoveAt(i);
                            break;
                        case "-h0":
                            protocol = "-h0";
                            argsList.RemoveAt(i);
                            break;
                        case "-h1":
                            protocol = "-h1";
                            argsList.RemoveAt(i);
                            break;
                        case "-w":
                            protocol = "-w";
                            argsList.RemoveAt(i);
                            break;
                        case "-d":
                            debug = true;
                            argsList.RemoveAt(i);
                            break;
                        default:
                            i++;                     //if an argument wasnt removed then then next index should be checked then its either a name or a location. 
                            break;                  //Therefore the next argument should be checked.
                    }

                }

                //If args list is less than 3 then, we have the right amount of arguments. More than this would mean either location or name have multiple words that arent inclosed in apostrophes.
                if (argsList.Count < 3)
                {
                    if (debug)
                    {
                        Console.WriteLine();
                        Console.WriteLine("=============== DEBUG ===============");
                        Console.WriteLine("Server: {}\nPort: {}\nTime Out: {}", server, port, timeOut);

                    }

                    //Creates a client and connects it to a port and creates the relevent streams to read and write to the network streams.
                    TcpClient client = new TcpClient();
                    client.Connect(server, port);
                    StreamWriter sw = new StreamWriter(client.GetStream());
                    StreamReader sr = new StreamReader(client.GetStream());
                    client.ReceiveTimeout = timeOut;
                    client.SendTimeout = timeOut;


                    if (protocol == "-w") //WHOIS protocol. The user requested for the server instruction to be made in a WHOIS protocol style.
                    {
                        if (debug)
                        {
                            Console.WriteLine("Protocol: WHOIS");
                        }

                        if (argsList.Count == 1)                                                       //If theres only one argument then it must be a server querry command for a username.
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Retrieve");
                                Console.WriteLine("Name: " + argsList[0]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine(argsList[0]);
                            sw.Flush();
                            Console.Write(argsList[0] + " is ");
                            location = sr.ReadToEnd();                                                   //The server will send a location
                            serverResponse = location;
                            Console.WriteLine(location);
                        }
                        else if (argsList.Count == 2)                                                    //This means the request is to update a user to a particular location.
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Update");
                                Console.WriteLine("Name: " + argsList[0]);
                                Console.WriteLine("Value: " + argsList[1]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine(argsList[0] + " " + argsList[1]);
                            sw.Flush();
                            serverResponseText = sr.ReadLine();                                           //Reading the server acknoledgement, otherwise server database doesnt update
                            Console.WriteLine(argsList[0] + " location changed to be " + argsList[1]);
                        }
                    }
                    else if (protocol == "-h9")
                    {
                        if (debug)
                        {
                            Console.WriteLine("Protocol: HTTP 0.9");
                        }

                        if (argsList.Count == 1)                                                         //Same as before 1 argument means its a querry command.
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Retrieve");
                                Console.WriteLine("Name: " + argsList[0]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine("GET /" + argsList[0]);
                            sw.Flush();

                            string serverResponse = sr.ReadLine();
                            serverResponseText = serverResponse + "\n";

                            if (serverResponse.Contains("OK"))
                            {
                                serverResponseText = serverResponseText + sr.ReadLine() + "\n" + sr.ReadLine() + "\n";     //Content-Type:<space>text/plain<CR><LF>
                                location = sr.ReadLine();                                                                 //<CR><LF>
                                serverResponse = serverResponse + location;                                              //Location
                                Console.WriteLine(argsList[0] + " is " + location);
                            }
                            else
                            {
                                Console.WriteLine("Name not found in database.");
                            }

                        }
                        else                                                                                            //2 arguments, meaning its an update command
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Update");
                                Console.WriteLine("Name: " + argsList[0]);
                                Console.WriteLine("Value: " + argsList[1]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine("PUT /" + argsList[0]);
                            sw.WriteLine();
                            sw.WriteLine(argsList[1]);
                            sw.Flush();

                            string serverResponse = sr.ReadLine();
                            serverResponseText = serverResponse + "\n";

                            if (serverResponse.Contains("OK"))
                            {
                                serverResponseText = serverResponseText + sr.ReadLine() + "\n" + sr.ReadLine();        //Reads the header, content type and empty string.
                                Console.WriteLine(argsList[0] + " location changed to be " + argsList[1]);
                            }
                            else
                            {
                                Console.WriteLine("Something went wrong.");
                            }

                        }
                    }
                    else if (protocol == "-h0")    //protocol http1.0
                    {
                        if (debug)
                        {
                            Console.WriteLine("Protocol: HTTP 1.0");
                        }

                        if (argsList.Count == 1)
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Retrieve");
                                Console.WriteLine("Container name: " + argsList[0]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine("GET /?" + argsList[0] + " HTTP/1.0");
                            sw.WriteLine();
                            sw.Flush();

                            string serverResponse = sr.ReadLine();
                            serverResponseText = serverResponse + "\n";

                            if (serverResponse.Contains("OK"))
                            {
                                serverResponseText = serverResponseText + sr.ReadLine() + "\n" + sr.ReadLine();
                                location = sr.ReadLine();
                                Console.WriteLine(argsList[0] + " is " + location);
                            }
                            else
                            {
                                Console.WriteLine("Name not found in database.");
                            }

                        }
                        else
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Update");
                                Console.WriteLine("Container name: " + argsList[0]);
                                Console.WriteLine("Container value: " + argsList[1]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }


                            sw.WriteLine("POST /" + argsList[0] + " HTTP/1.0");
                            sw.WriteLine("Content-Length: " + argsList[1].Length);
                            sw.WriteLine(); //end of optional header lines.
                            sw.WriteLine(argsList[1]);
                            sw.Flush();

                            string serverResponse = sr.ReadLine();
                            serverResponseText = serverResponse + "\n";

                            if (serverResponse.Contains("OK"))
                            {
                                serverResponseText = serverResponseText + sr.ReadLine() + "\n" + sr.ReadLine();
                                Console.WriteLine(argsList[0] + " location changed to be " + argsList[1]);
                            }
                            else
                            {
                                Console.WriteLine("something went wrong");
                            }


                        }
                    }
                    else if (protocol == "-h1")
                    {
                        if (debug)
                        {
                            Console.WriteLine("Protocol: HTTP 1.1");
                        }

                        if (argsList.Count == 1)
                        {

                            if (debug)
                            {
                                Console.WriteLine("Command: Retrieve");
                                Console.WriteLine("Container name: " + argsList[0]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine("GET /?name=" + argsList[0] + " HTTP/1.1");
                            sw.WriteLine("Host: " + server);
                            sw.WriteLine();
                            sw.Flush();


                            string serverResponse = sr.ReadLine();
                            serverResponseText = serverResponse + "\n";


                            if (serverResponse.Contains("OK"))
                            {
                                do //reads all the optional header lines
                                {
                                    serverResponse = sr.ReadLine();
                                    serverResponseText = serverResponseText + serverResponse + "\n";
                                }
                                while (serverResponse != "");

                                location = sr.ReadLine();
                                serverResponseText = serverResponseText + location + "\n";
                                Console.WriteLine(argsList[0] + " is " + location);
                            }
                            else
                            {
                                Console.WriteLine("Something went wrong.");
                            }

                        }
                        else
                        {
                            if (debug)
                            {
                                Console.WriteLine("Command: Update");
                                Console.WriteLine("Container name: " + argsList[0]);
                                Console.WriteLine("Container value: " + argsList[1]);
                                Console.WriteLine("=============== END DEBUG ===============");
                            }

                            sw.WriteLine("POST / HTTP/1.1");
                            sw.WriteLine("Host: " + server);
                            sw.WriteLine("Content-Length: " + args[1].Length);
                            sw.WriteLine();
                            sw.WriteLine("name=" + argsList[0] + "&location=" + argsList[1]);
                            sw.Flush();

                            string serverResponse = sr.ReadLine();
                            serverResponseText = serverResponse + "\n";

                            if (serverResponse.Contains("OK"))
                            {
                                do //reads all the optional header lines
                                {
                                    serverResponse = sr.ReadLine();
                                    serverResponseText = serverResponseText + serverResponse + "\n";
                                }
                                while (serverResponse != "");

                                Console.WriteLine(argsList[0] + " location changed to be " + argsList[1]);
                            }
                            else
                            {
                                Console.WriteLine("Something went wrong.");
                            }


                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("wrong number of args");
            }

        }

    }

}