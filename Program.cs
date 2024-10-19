// See https://aka.ms/new-console-template for more information

           MyNamespace.MyStruct myStruct = new  MyNamespace.MyStruct { Id = 1, Name = "MyStructExample" };
            myStruct.Print();  // Output: ID: 1, Name: MyStructExample

            // Using the delegate
             MyNamespace.MyClass myClass = new  MyNamespace.MyClass();
             MyNamespace.MyDelegate del = new  MyNamespace.MyDelegate(myClass.DisplayMessage);
            del("Hello from the delegate!");  // Output: Hello from the delegate!
