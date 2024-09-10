# .NET Microservices for Azure Developers
This is the repository for the LinkedIn Learning course `.NET Microservices for Azure Developers`. The full course is available from [LinkedIn Learning][lil-course-url].

![lil-thumbnail-url] 

It's no longer only architects who need to understand the benefits and challenges of cloud-native architectures, such as microservices. By leveraging this popular architectural pattern, developers and other key application stakeholders can enhance the availability, reliability, and scalability of their software solutions. In this course, instructor Rodrigo Díaz Concha provides an overview of microservices, as well as how to use .NET to create microservices that can be deployed in Azure. Rodrigo covers key topics such as microservices pros and cons, writing unit tests, microservices containerization with Docker, microservices deployment on top of an orchestrator, and synchronous communication between microservices.

_See the readme file in the main branch for updated instructions and information._
## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"

## Instructor

Rodrigo Díaz Concha

Solutions Architect, Microsoft Regional Director, and Microsoft MVP

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/rodrigo-diaz-concha?u=104).

[0]: # (Replace these placeholder URLs with actual course URLs)

[lil-course-url]: https://www.linkedin.com/learning/dot-net-microservices-for-azure-developers
[lil-thumbnail-url]: https://media.licdn.com/dms/image/v2/D4E0DAQEt0Nhsuy5q1Q/learning-public-crop_675_1200/learning-public-crop_675_1200/0/1724438751225?e=2147483647&v=beta&t=dKn6GS8arOQzRJPeJD-LorVRjNT_w-rMlD4k1TxYQDQ

