# AIM - GraphQL Reference Architecture in C#

#### Summary

The purpose of this reference architecture is to provide a basic demonstration of the foundational components of GraphQL using the HotChocolate implementation i.e. queries, mutations, and subscriptions. Testing, auth, unions? to come. 

#### Getting Started

Mac Suggested Setup

- [VS code](https://code.visualstudio.com/download) (C# Dev kit extension, need to be logged in for it to work)
- [Download .NET 7.0](https://dotnet.microsoft.com/en-us/download)


#### Running the App 

After cloning the app, cd into the root
- Run `dotnet run --project GraphQL`   
- You can view the [IDE](https://chillicream.com/docs/bananacakepop/v2) at "http://localhost:5166/graphql/" (your port may be different)
- You can find example operations in the postman collection within the repo

#### Running Operations

Either within Banana Cake Pop or postman you can start interacting with the schema. 

To test out the subscription you'll first need to run the subscription operation and then run the addBook operation. Once the addBook operation is run, you'll see a response for the subscription.
