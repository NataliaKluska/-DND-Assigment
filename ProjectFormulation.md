## Project Formulation & Initial Requirements: Travel Blog for Sharing Stories

### Project Description (Domain)

The DND course project is a **Travel Blog** platform that allows users to share their travel experiences and stories from different countries. Users can register, log in, and submit blog posts that describe their adventures, providing details about their travels. Other users, both registered and unregistered, can browse and read these stories. 

#### Why This Project?

Travel blogs are an exciting way for people to document and share their travel experiences, while also offering inspiration to others looking for new destinations or travel tips. Technically, this project covers essential software development concepts like authentication and CRUD operations, while also focusing on development practices such as RESTful APIs and using Blazor for an engaging frontend experience.

My aim for implementing a travel blog is to create a platform that is practical, user-driven, and scalable. The project also allows me to deal with real-world challenges like managing user-generated content and securing user data.

---

### Requirements (User Stories)

1. **User Registration & Login**  
    _As a new user, I want to create an account, so I can submit my travel stories._  
    _As an existing user, I want to log in securely using my username and password, so I can access my profile and submit or manage my stories._

2. **Submit Travel Stories**  
   _As a logged-in user, I want to create a new blog post where I can share my travel story, including details like title, content, and the country I visited._  
   _As a user, I want to edit or delete my previous travel stories, so I can manage and update my content._

3. **View Travel Stories**  
   _As a visitor or logged-in user, I want to view a list of all travel stories submitted by other users, so I can read their experiences._  
   _As a visitor, I want to browse travel stories by country, so I can easily find stories related to specific destinations._

4. **Story Viewing for Guests**  
   _As a visitor (without logging in), I want to browse and view travel stories, so I can read about travel experiences even if I haven't created an account._
5. **Role-Based Access (Admin vs Regular User)**

_As an admin, I want to moderate all submitted stories, so I can ensure inappropriate or irrelevant content is removed._
 _As an admin, I want to delete or edit any user's story, so I can maintain the quality of the blog._

6. **User Authentication & Security**  
   _As a user, I want my account to be protected with a secure password hashing mechanism, so my credentials are safe._

7. **Story Pagination**  
   _As a user, I want to view the stories in a paginated format, so I can easily browse through multiple stories without overwhelming the interface._

---

### Delimitations

While the project concept includes a broad range of features and user stories, it's important to note that due to time constraints, resource limitations, and the complexity of some features, plus working solo, I may not be able to implement all the desired functionalities within the given project timeline.

The core focus of the project will be on the following required functionalities:
- User registration and login
- The ability to submit, view, edit, and delete travel stories
- Communication between the Blazor frontend and the ASP.NET Core Web API

#### Potential Features Not Prioritized in the Initial Version:

##### Main Improvement: Role-Based Access (Admin vs Regular User)
- Admins should be present and able to moderate all submitted stories, so they can ensure inappropriate or irrelevant content is removed.

##### Secondary Improvements:
- Advanced search and filtering of stories based on keywords or regions.
- Profile management features beyond basic login and password change.
- Full mobile-responsive design or extensive UI/UX improvements.
- Uploading images or media within blog posts (which could be considered as future enhancements).
- Extensive admin controls for moderating content beyond basic CRUD operations.

These additional features represent future extensions of the platform and would be considered if time and resources allow. However, for the initial phase, I will focus on meeting the primary technical requirements and delivering a working, secure, and user-friendly blog system.
