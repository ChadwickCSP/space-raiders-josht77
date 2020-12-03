# Space Raiders

## Overview

In this project, you will continue to hone the basics of Unity while creating a top down, 2D Shooter. Before you get started, take a look at one of my favorite NES games of all time [ZANAC](https://drive.google.com/file/d/16NXZVlsQTBM_uv4uEzwRvJXYIRuMd3M2/view). After downloading, open up the `Zanac.html` file in your web browser. The controls are listed at the bottom of the page. Your goal is to create a game similar to this.

* [Setup your repository](#setup-your-repository)
  * [Sign up for the project](#sign-up-for-project)
* [Milestones](#milestones)
  * [Milestone 1](#milestone-1)
  * [Milestone 2](#milestone-2)
  * [Milestone 3](#milestone-3)
* [Grading](#grading)
  * [Computational Thinking](#computational-thinking)
  * [Computing, Programming and Practice](#computing-programming-and-practice)
  * [Skills of a Student](#skills-of-a-student)
* [Getting Help](#getting-help)

## Setup your repository

### Sign up for Project

Sign up for the project repository here: [https://classroom.github.com/a/3raTMV5L](https://classroom.github.com/a/3raTMV5L)

After your repository has initialized it, clone it to your computer. I recommend
putting it in your `ap-csp` directory.

After you've cloned your repository, run the `setup.sh` script in the root of
that repository to initialize it's configuration.

Upon completion it should display a message similar to this one:

```
######################################################
# SETUP IS COMPLETE. YOU SHOULD NOW CREATE A         #
# `develop` BRANCH BY RUNNING THE FOLLOWING COMMAND: #
#                                                    #
# git checkout -b develop                            #
#                                                    #
# THEN PUSH THAT BRANCH TO GITHUB BY RUNNING THE     #
# FOLLOWING COMMAND:                                 #
#                                                    #
# git push -u origin develop                         #
#                                                    #
# AFTER PUSHING, OPEN A PULL REQUEST FROM YOUR       #
# `develop`  BRANCH TO THE `main` BRANCH BY VISITING #
# THIS REPO ON GITHUB, CLICKING `Pull Requests`      #
# THEN `New pull request`. THE BASE BRANCH SHOULD BE #
# `main` and THE COMPARE BRANCH SHOULD BE `develop`. #
#                                                    #
# FINALLY, ADD YOUR INSTRUCTOR AS A REVIEWER ON      #
# GITHUB. THIS IS HOW YOUR INSTRUCTOR WILL SEE YOUR  #
# WORK.                                              #
######################################################
```

Follow the directions to create a `develop` branch as well as pushing your
`develop` branch to Github.

Finally, create a pull request from your `develop` branch to the `main` branch
and assign `jcollard` as a reviewer.

![README/PullRequests.png](README/PullRequests.png)

![README/NewPullRequest.png](README/NewPullRequest.png)

![README/SetDevelop.png](README/SetDevelop.png)

![README/SetReviewer.png](README/SetReviewer.png)


## Milestones

### Milestone 1

Due Date: Thursday Dec. 3rd @ 8AM

An introduction to all of the basic mechanics to create a 2D Shooter in Unity is
available as part of the following videos. Note: The first video has you create
a new 2D Project using Unity Hub. You *should not* do this. Instead, you should
import the `SpaceRaiders` directory into Unity Hub. You *must* use Unity
2019.4.14. This can be downloaded here:
https://unity3d.com/get-unity/download/archive

1. [Part 1](https://drive.google.com/file/d/1VXH6Kb_X1xyXr3PVOYvDoVTteLoJ36Ln/view?usp=sharing) - Skip to 0:40
2. [Part 2](https://drive.google.com/file/d/1hj3pIKCXdit3SMwa6Jcmiv7mNaCTLcQT/view?usp=sharing)
3. [Part 3](https://drive.google.com/file/d/1XE4dWywKgKCsfxmRnJ2bHfctxjBMBZSI/view?usp=sharing)

The first Milestone is to complete all of the videos and challenges therein.

All code that you would like to count toward your evaluation should be part of a
`tag` on in your repository called `milestone-1`. This can be created by running
`git tag milestone-1`. Then push your tag to your repository by running `git
push -u origin milestone-1`. The date of this tag creation will be used to
determine when your work was submitted.

### Milestone 2

Due Date: Thursday Dec. 10th @ 8AM

You must complete 2 of the 3 challenges below:

* [Randomly Generated Background](https://docs.google.com/document/d/1iuqgwFVWErdtUFzfZtB03bBDS5XCoHwXB4GxPMKs1xM/edit)
* [Taking Damage](https://docs.google.com/document/d/1CJYxzm8Zhe7aeCGCQrrd_cazxCbc_TG1tNgPYw3vZT0/edit)
* [Enemy Lasers](https://docs.google.com/document/d/1UiuvScL_Grs7GPEc6sOY6ClcRjloUYvfmkvZbRcoXo0/edit)

All code that you would like to count toward your evaluation should be part of a
`tag` on in your repository called `milestone-2`. This can be created by running
`git tag milestone-2`. Then push your tag to your repository by running `git
push -u origin milestone-2`. The date of this tag creation will be used to
determine when your work was submitted.

### Milestone 3

Due Date: Monday Dec. 14th @ 8AM

Propose and implement at least 3 additional features. To get a score of
advanced, you must implement 5 additional features. Note, one of your features
may be the unimplemented feature for Milestone 2. You should propose your feature on Piazza for approval prior to implementing it.

Example Features:

* New Enemy Types
* A Boss Enemy
* Sounds / Music
* Power Up Items

All code that you would like to count toward your evaluation should be part of a
`tag` on in your repository called `milestone-3`. This can be created by running
`git tag milestone-3`. Then push your tag to your repository by running `git
push -u origin milestone-3`. The date of this tag creation will be used to
determine when your work was submitted.

## Grading

#### Computational Thinking
| Advanced                                                                         | Proficient                                                                  | Basic                                                                                                                      | Below Basic                                            |
|----------------------------------------------------------------------------------|-----------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------|
| Student creates 5 different enemy types                                          | Student creates the 3 basic enemies for Milestone 3                         | Student completes all of the Tutorial Video features                                                                       | Student does not complete all features in video series |
| Student creates a health variable to give the Tofu Character multiple hit points | Student utilizes most of the provided tile sprites to create a unique scene | The Tofu can Jump, Walk left and right, and is animated based on the direction of facing                                   |                                                        |
| Student proposes and implements a unique feature                                 | Student adds Spikes that cause the Tofu to respawn on touching              | Enemy animates the direction of facing and patrols on a platform, knocks back the Tofu, and is destroyed when jumped upon. |                                                        |
|                                                                                  | Student completes all non-bonus features listed in this README.md           |                                                                                                                            |                                                        |
### Computing, Programming and Practice

Demonstrate how you tested your assignment, write comments, and provide well
written commits.

| Advanced                                                                                                                                       | Proficient                                                                                       | Basic                                                                                                                   | Below Basic                                                                    |
|------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------|
| Student provides Screenshots / Videos of their final solutions and adds them to their README.md                                                | Student created README.md file stating how they tested their solutions and any known bugs.       | Student created a README.md for their solutions                                                                         | Student did not complete a README.md                                           |
| Student comments all methods describing all inputs and side effects as well as comments inside their methods describing tricky implementations | Student wrote comments inside their methods describing the tricky parts of their implementation. | Student wrote some comments                                                                                             | Student did not write comments                                                 |
| Student comments all member variables describing their use                                                                                     | Student comments most of their member variables                                                  | Student comments some of their member variables. Comments may not be particularly useful or contains grammatical errors | Student did not write comments                                                 |
| All of the students commits follow the commit message template.                                                                                | Most of the students commits follow the commit message template.                                 | Some of the students commits follow the commit message template                                                         | Few or none of the students commit messages follow the commit message template |

### Skills of a Student

Your skills of a student covers your StudentLog repository, your in class time
management, meeting deadlines, asking for help when needed, and helping others
when able.

| Advanced                                                                           | Proficient                   | Basic                                                    | Below Basic                                          |
|------------------------------------------------------------------------------------|------------------------------|----------------------------------------------------------|------------------------------------------------------|
| Manages time well in class, stays focused on work  at hand at all times            | Focuses on work in class     | Focuses at times, can get distracted                     | Uses class time poorly, is frequently distracted     |
| Meets all deadlines, on or ahead of schedule                                       | Meets deadlines              | Delivers close to deadline, may be late  by a day or two | Delivers work late or not at all                     |
| Advocates for self, seeks clarification when needed  and volunteers to help others | Seeks assistance when needed | Needs prompting to seek assistance                       | Does not seek assistance or ask for help when needed |

## Getting Help

All questions should be posted to the class Piazza board. You are also
encouraged to help other students who post on Piazza. When you post your
question, be sure to include as many details as possible for reproducing the
issue you're having.

Questions you should answer when asking a question include:

1. What are you trying to do?
2. What did you try?
3. What was the result?

Work hard to make sure the person trying to answer your question can reproduce
your error. Share your files so others can run exactly what you're running.

Also, include screenshot!

Formulating good questions is a good life long skill. You should try asking your
question on Piazza before seeking out synchronous time with Mx. Collard.
However, if you would like to meet to discuss synchronously, first, look at [Mx.
Collard's Calendar](http://tinyurl.com/mx-collard-calendar), then send them an
email with at least two proposed times you would like to meet.