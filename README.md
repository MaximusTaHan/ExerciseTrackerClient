# ExerciseTracker
Application for learning and implementing the Repository design pattern.

Web API that implements a Repository abstraction layer ontop of EF, using a SQL server for a Database.
And an application for consuming the API

## Requirements
- [x] This is an application where you should record exercise data.
- [x] You should choose one type of exercise only. We want to keep the app simple so you focus on the subject you're learning and not on the business complexities.
- [x] You can choose raw SQL or Entity Framework for your data-persistence.
- [x] The model for your exercise class should have at least the following properties: {Id INT, DateStart DateTime, DateEnd DateTime, Duration TimeSpan, Comments string}
- [x] You can choose between SQLite or SQLServer.
- [x] Your application should have the following classes: UserInput, ExerciseController, ExerciseService (where business logic will be handled) and ExerciseRepository.

## Features
### ExcerciseTracker
- Repository Abstraction layer.
  - This is a layer that separates the direct DB access logic from the rest of the application, making your controllers more testable and exchangeable.
- Workout Repository that is easily extendable or replaced
- Workout model that alows you to track your exercise hours
- Basic CRUD functionality with a SQLServer connection

### ExerciseTrackerClient

- Simple Console application for consuming the ExerciseTracker
- Easy to use Menu with options for all controller operations

![MainMenu](https://user-images.githubusercontent.com/91058022/164718425-8faa352d-2d49-498e-8f67-b4f8f508c37b.png)
- Service class for Validation of user input
- Service class for easily Posting your Workouts


![Create](https://user-images.githubusercontent.com/91058022/164718844-5eb2b384-6ce3-49c4-88ad-d44aa3b7f5b9.png)

![GetById](https://user-images.githubusercontent.com/91058022/164718854-8a88b311-5b29-47a3-ae39-3765b0d8ed57.png)

## Challenges

- I changed the Duration variable to a long, this is done since you cannot directly save a TimeSpan in a SQL server. There are plenty of options around this with different benefits. One, that i considered, was to not store the duration in the DB and just calculate it into a DTO in the client, i chose not to do this for the simple reason i have done so before. 
- Struggeling with grasping the purpose and usefulness of Repository pattern, the concept predates Entity Framework so there is a lot of contentious information about the topic. A lot of discussion about if its useful or not, whether you should use it with EF or not. There seems to be merit in both sides. What i learned however is that the Repository patterns can be useful in decoupling and structuring backend data flow.
- What constitutes a service? One of the questions came up in relation to the "ExerciseService" class in the requirements. Service is a widely used word in programming and doesnt have one solid definition. What it essentially boils down to is that a service can be any class that fills some logic or functionality. 

## What i learned

- How to apply the repository pattern infront of a controller. 
- The benefits of decoupling your data acces layers and business layers.
- Researching design patterns and filtering between quality information and less-quality information.
- Different ways to handle time in SQL



### I would like to thank Pablo and the great community, The C# Academy, he is building over on Discord and the well crafted Projects he provides through his website
Website: https://www.thecsharpacademy.com/

### Resources and links
Topics and links used for this project:
- Project page https://www.thecsharpacademy.com/exercise-tracker/
- Discussion on Repository pattern https://stackoverflow.com/questions/14110890/not-using-repository-pattern-use-the-orm-as-is-ef
- Handling TimeSpan to DB https://stackoverflow.com/questions/8503825/what-is-the-correct-sql-type-to-store-a-net-timespan-with-values-240000
Additional reading:
- Unit of Work discussion https://softwareengineering.stackexchange.com/questions/406729/is-unit-of-work-pattern-really-needed-with-repository-pattern
- https://dotnettutorials.net/lesson/repository-design-pattern-csharp/
