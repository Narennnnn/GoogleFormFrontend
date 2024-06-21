# Google Form Submission Frontend

This repository contains the frontend application for a Google Form-like submission system. The frontend is built using Windows Forms in Visual Basic and interacts with a backend server running on port 3000.

## Prerequisites

- Visual Studio (with support for Visual Basic)
- .NET Framework
- Backend server (instructions to run it are provided below)
- Newtonsoft.Json plugin for Visual Studio

## Getting Started

### Step 1: Clone the Repository

Clone this repository to your local machine using the following command:

```bash
git clone https://github.com/Narennnnn/GoogleFormFrontend.git
```
### Step 2: Install Dependencies
#### Install Newtonsoft.Json Plugin
1. Open frontend code in Visual Studio.
2. Go to Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution.
3. Search for Newtonsoft.Json.
4. Install the latest version of Newtonsoft.Json

### Step 3: Run the Backend Server

Make sure the backend server is up and running on port 3000. \
Follow the instructions mentioned here: 
```bash 
https://github.com/Narennnnn/GoogleFormBackend/blob/main/README.md
```

### Step 4: Run the Frontend Application
1. Open the solution in Visual Studio.
3. Click on the Run button or press F5 ``(GoogleFormSubmissionFrontend)`` to start the application.

### Testing Features
Once the frontend application is running, you can test the following features:

#### 1. View Submissions:
Click on the VIEW SUBMISSIONS```(CTRL + V)``` button to view existing submissions.

#### 2. Create New Submission:

1. Click on the CREATE NEW SUBMISSION `(CTRL + N)` button to open the submission form.
2. Fill out the form with Name, Email, Phone Number, and GitHub Link.
3. Use the Start/Stop Stopwatch button to measure time taken for the submission.`(CTRL+T)`
4. Click Submit to send your submission to the backend server.`(CTRL+S)`

### Demo 
```bash
https://drive.google.com/file/d/1rwT2r2qTowQBP7DHvat05yzsJROodEuw/view?usp=sharing
```