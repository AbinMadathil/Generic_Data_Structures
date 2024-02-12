using Generic_stack;

// var Mystack= new GenericStack<int>(2);
// Mystack.Push();
// Console.WriteLine(Mystack.Peek());
// Mystack.Push(10);
// Console.WriteLine(Mystack.Peek());
// Mystack.Push(2);


var MyQueue= new GenericQueue<ChatMessages>(1);

MyQueue.Enqueue(new ChatMessages(1,"Sample Data",DateTime.Now,123));
var data=MyQueue.FirstElement();
if(data!=null){
Console.WriteLine(data.Content);
}
MyQueue.Enqueue(new ChatMessages(1,"Sample Data Message ",DateTime.Now,1234));

