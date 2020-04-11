# AimlBot ChatBot
## Demo https://chatbot20200410174704.azurewebsites.net/

## Demo Angular 8 https://chatbotcore2020.azurewebsites.net/

### Based on the project https://sourceforge.net/projects/aimlbot/files/ by Nicholas Tollervey

* Nicholas H.Tollervey http://ntoll.org/

#### Original Description

AIMLBot (Program#) is a small, fast, standards-compliant yet easily customizable implementation of an AIML (Artificial Intelligence Markup Language) based chatter bot in C#. AIMLBot has been tested on both Microsoft's runtime environment and Mono. Put simply, it will allow you to chat (by entering text) with your computer using natural language.

This is the second version of the library and it has been re-written from scratch. It now boasts:

* Better cross-platform compatibility. updated to work with .NET core 3.1
* A completely new modular architecture to make it easier for developers to extend and add functionality.
* A simpler and more logical API.
* Standards compliant AIML support with the option for custom tags.
* Very small size (currently only 56k).
* Very fast (over 30,000 categories processed in under a second).
* Some simple Console code Sample examples for developers to get started (simple windows and console based applications as well as a sample ASP.NET web Application).

#### Acknowledgments
First, thanks to Dr.Richard S.Wallace the inventor of AIML.

Thanks also to the many free software developers who have already implemented an AIML bot. The liberty to study how it was done is much appreciated.

#### Project description
The AIML specification was used as the vade mecum for this project. Read it to understand how this project and AIML works. For a less formal introduction, read on…

“AIML: Artificial Intelligence Markup Language

AIML (Artificial Intelligence Markup Language) is an XML-compliant language that’s easy to learn, and makes it possible for you to begin customizing an Alicebot or creating one from scratch within minutes.

The most important units of AIML are:

`<aiml>` : the tag that begins and ends an AIML document
`<category>` : the tag that marks a “unit of knowledge” in an Alicebot’s knowledge base
`<pattern>` : used to contain a simple pattern that matches what a user may say or type to an Alicebot
`<template>` : contains the response to a user input
There are also 20 or so additional more tags often found in AIML files, and it’s possible to create your own so-called “custom predicates”. Right now, a beginner’s guide to AIML can be found in the AIML Primer.

The free A.L.I.C.E. AIML includes a knowledge base of approximately 41,000 categories. Here’s an example of one of them:

`<category>
    <pattern>WHAT ARE YOU</pattern>
        <template>
            <think><set name="topic">Me</set></think>
            I am the latest result in artificial intelligence,
            which can reproduce the capabilities of the human brain
            with greater speed and accuracy.
    </template>
</category>'
(The opening and closing <aiml> tags are not shown here, because this is an excerpt from the middle of a document.)

Everything between `<category>` and `</category>` is—you guessed it—a category. A category can have one pattern and one template. (It can also contain a <that> tag, but we won’t get into that here.)

The pattern shown will match only the exact phrase “what are you” (capitalization is ignored).

But it’s possible that this category may be invoked by another category, using the `<srai>` tag (not shown) and the principle of reductionism.

In any case, if this category is called, it will produce the response “I am the latest result in artificial intelligence…” shown above. In addition, it will do something else interesting. Using the <think> tag, which causes Alicebot to perform whatever it contains but hide the result from the user, the Alicebot engine will set the “topic” in its memory to “Me”. This allows any categories elsewhere with an explicit “topic” value of “ME” to match better than categories with the same patterns that are not given an explicit topic. This illustrates one mechanism whereby a botmaster can exercise precise control over a conversational flow.”

The above text is Copyright© A.L.I.C.E. AI Foundation, Inc.

http://www.alicebot.org
