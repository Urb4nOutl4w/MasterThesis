using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using alps.net.api;
using alps.net.api.ALPS;
using alps.net.api.parsing;
using alps.net.api.StandardPASS;

namespace TestAppXml
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program test = new Program();
            test.ReadXML();
            test.WriteOWL();
            
            
            Console.WriteLine("test");
        }


        public void WriteOWL()
        {
            // import
            IPASSReaderWriter io = PASSReaderWriter.getInstance();

            // Prepare the paths to the structure-defining owl files
            IList<string> paths = new List<string>
            {
                "C:/Users/Tim/OneDrive/Documents/PASS/standard_PASS_ont_v_1.1.0.owl",
                "C:/Users/Tim/OneDrive/Documents/PASS/abstract-layered-pass-ont.owl",
            };
            // Load these files once (no future calls neded)
            io.loadOWLParsingStructure(paths);

            IList<IPASSProcessModel> models = io.loadModels(new List<string> { "C:/Users/Tim/Dropbox/FH Joanneum/MAB/Visio/Drawing1.owl" });

            //var test2 = models[0]"test";

            // ################################################### export ####################################################################

            // Create Model
            IPASSProcessModel model = new PASSProcessModel("http://subjective-me.jimdo.com/s-bpm/processmodels/2022-05-18/tim/", "Drawing2");
            //model.createUniqueModelComponentID();
            //model.setModelComponentID("1234");

            // Create SID
            IModelLayer layer = new ModelLayer(model, "SID_1");
            //layer.createUniqueModelComponentID();

            // The layer is already registered in the model (because the model was passed in the constructor),
            // but the layer is currently not the base layer
            model.setBaseLayer(layer);

            // Create Subject with Base Behavior

            ISubjectBaseBehavior beTim = new SubjectBaseBehavior(layer, "Tim_Behavior");
            IFullySpecifiedSubject tim = new FullySpecifiedSubject(layer, "Tim", null, beTim);

            ISubjectBaseBehavior beLukas = new SubjectBaseBehavior(layer, "Lukas_Behavior");
            IFullySpecifiedSubject lukas = new FullySpecifiedSubject(layer, "Lukas", null, beLukas);

            // Create Message Exchange

            IMessageExchangeList timToLukas = new MessageExchangeList(layer, "TimToLukas");
            IMessageSpecification message1 = new MessageSpecification(layer, "Gemma essen");
            IMessageExchange messageEx1 = new MessageExchange(layer, "Gemma Essen von Tim an Lukas", message1, tim, lukas);
            timToLukas.addContainsMessageExchange(messageEx1);

            IMessageExchangeList lukasToTim = new MessageExchangeList(layer, "LukasToTim");
            IMessageSpecification message2 = new MessageSpecification(layer, "Jo");
            IMessageExchange messageEx2 = new MessageExchange(layer, "Jo von Lukas an Tim", message2, lukas, tim);
            lukasToTim.addContainsMessageExchange(messageEx2);

            IMessageSpecification message3 = new MessageSpecification(layer, "Na");
            IMessageExchange messageEx3 = new MessageExchange(layer, "Na von Lukas an Tim", message3, lukas, tim);
            lukasToTim.addContainsMessageExchange(messageEx3);

            // Create Behavior

            IDoState doState1 = new DoState(beTim, "essen");
            //doState1.setIsStateType(IState.StateType.InitialStateOfBehavior);
            ISendState sendState1 = new SendState(beTim, "senden");
            IReceiveState receiveState1 = new ReceiveState(beTim, "empfangen");
            IDoState doState2 = new DoState(beTim, "essen2");
            IDoState doState3 = new DoState(beTim, "essen3");

            beTim.setInitialState(doState1);
            ISet<IState> endStates = new HashSet<IState>();
            endStates.Add(doState2);
            endStates.Add(doState3);
            beTim.setEndStates(endStates);


            IDoTransition doTransition1 = new DoTransition(doState1, sendState1, "essen zu senden");

            ISendTransition sendTran1 = new SendTransition(sendState1, receiveState1, "senden zu empfangen");
            ISendTransitionCondition sendTranCon1 = new SendTransitionCondition(sendTran1, "Send Transition Condition", null, messageEx1, 0, 0, null, messageEx1.getReceiver(), messageEx1.getMessageType());
            sendTran1.setTransitionCondition(sendTranCon1);
            

            IReceiveTransition recTran1 = new ReceiveTransition(receiveState1, doState2, "von empfangen zu essen2");
            IReceiveTransitionCondition recTranCon1 = new ReceiveTransitionCondition(recTran1, "Receive Transition Vondition", null, messageEx2, 0, 0, null, messageEx2.getSender(), messageEx2.getMessageType());
            recTran1.setTransitionCondition(recTranCon1);

            IReceiveTransition recTran2 = new ReceiveTransition(receiveState1, doState3, "von empfangen zu essen3");
            IReceiveTransitionCondition recTranCon2 = new ReceiveTransitionCondition(recTran2, "Receive Transition Vondition", null, messageEx3, 0, 0, null, messageEx3.getSender(), messageEx3.getMessageType());
            recTran2.setTransitionCondition(recTranCon2);



            Console.WriteLine(io.exportModel(model, "C:/Users/Tim/Dropbox/FH Joanneum/MAB/Visio/Drawing2.owl"));

        }


        public String RemoveTags(string text, string startTag, string endTag)
        {
            if (text.Contains(startTag))
            {
                // Find the position of the start and the end tag
                int foundS1 = text.IndexOf(startTag);
                int foundS2 = text.IndexOf(endTag);

                //RemoveTags everything between start and end tag
                text = text.Remove(foundS1, foundS2 + endTag.Length - foundS1);
                
                // call the function again (recursion)
                return RemoveTags(text, startTag, endTag);
            }
            else
            {
                //end of recursion
                return text;
            }
        }

        

        public void ReadXML()
        {
            /*
            // First write something so that there is something to read ...  
            var b = new Book { title = "Serialization Overview" };
            var serializer = new XmlSerializer(typeof(Book));
            var wfile = new System.IO.StreamWriter(@"C:\Users\Tim\Dropbox\FH Joanneum\MAB\Visio\test.xml");
            serializer.Serialize(wfile, b);
            wfile.Close();

            */

            string rawFile = File.ReadAllText(@"C:\Users\Tim\Dropbox\FH Joanneum\MAB\BPMN\Alle Prozesselemente.bpmn");

            string cleanFile = RemoveTags(rawFile, "<extensionElements>", "</extensionElements>");
            cleanFile = cleanFile.Replace("<extensionElements/>", "");

            XDocument xdoc = XDocument.Parse(cleanFile);

            xdoc.Save(@"C:\Users\Tim\Dropbox\FH Joanneum\MAB\BPMN\Alle Prozesselemente_clean.bpmn");


            XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Xml2CSharp.Definitions));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"C:\Users\Tim\Dropbox\FH Joanneum\MAB\BPMN\Testprozess Lanes_clean.bpmn");
            Xml2CSharp.Definitions overview = (Xml2CSharp.Definitions)reader.Deserialize(file);
            file.Close();

            foreach (Xml2CSharp.Participant p in overview.Collaboration.Participant)
            {
                Console.WriteLine(p.Name);
            }

            //Console.WriteLine(overview);

        }

    }
}
