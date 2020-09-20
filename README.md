# LeadManagement
This is a sample application implemented usind React for front-end, .net Core for back-end, SqLite for database and Docker as container. To run this application, you need to follow the instructions below:
 
 - Check out the source code
 - Go to the root directory of the application
 - Run `docker-compose build`
 - Run `docker-compose up`

The Swagger for WebApi is configured on port 8090, so you can open it using http://localhost:8090/swagger. It includes two simple endpoints to get the jobs and update the status of a job. The react application is also accessible using http://localhost:3001. The data is sample data injected into the databse.
The project includes some unit tests for back-end part, but as the project is not a commercial projects, all possible scenarios are not considered and handled in the code and unit tests. To make the application robust, we can add more front-end and back-end tests to the applications.
