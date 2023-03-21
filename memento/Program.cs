using memento;

var originator = new Originator();
var caretaker = new Caretaker(originator);

caretaker.Save();
originator.SetState("Test_State_1");
originator.ShowState();

caretaker.Save();
originator.SetState("Test_State_2");
originator.ShowState();

Console.WriteLine("Undo state");
caretaker.Undo();
originator.ShowState();

Console.WriteLine("Redo state");
caretaker.Redo();
originator.ShowState();

caretaker.Save();
originator.SetState("Test_State_3");
originator.ShowState();

Console.WriteLine("Undo state");
caretaker.Undo();
originator.ShowState();
Console.WriteLine("Undo state");
caretaker.Undo();
originator.ShowState();

Console.WriteLine("Redo state");
caretaker.Redo();
originator.ShowState();
Console.WriteLine("Redo state");
caretaker.Redo();
originator.ShowState();
